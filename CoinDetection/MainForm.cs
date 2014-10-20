//----------------------------------------------------------------------------
//  Video processing robot
//  v0.1
//  detect coin(x,y,type)       
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
using System.Threading;
using Emgu.CV.CvEnum;
using System.IO.Ports;
using System.Timers;

namespace ShapeDetection
{
   public partial class MainForm : Form
   {
      private Capture _capture;                //video capture object
      private CircleF gTrackingPos;            //global
      public static Mutex mutex = new Mutex(); //mutex
      private bool gCancelLoop = false;
      private int gFrameCnt = 0;

      private float offset_x = 10.0f;
      private float offset_y = -5.0f;

      private List<CircleF> listCircle = new List<CircleF>();
      private float gCircleR_Sum = 0;

      System.Timers.Timer gCtrlTimer;          //control timer

      const int FIVE_JIAO = 1;                 //fifty cents
      const int ONE_YUAN = 2;                  //one rmb
      const int ONE_JIAO = 3;                  //one jiao

      /// <summary>
      /// for sort circle array
      /// </summary>
      public class CircleComparer : IComparer<CircleF>
      {
          int IComparer<CircleF>.Compare(CircleF x, CircleF y)
          {
              return (int)(x.Center.X - y.Center.X);
          }
      }

      public MainForm()
      {
         InitializeComponent();

         fileNameTextBox.Text = "pic3.png";
         InitRobotCtrlDevice();
         InitTimer();
         this.FormClosed += DisposeMainWindow;
      }

      #region Control
      /// <summary>
      /// Init Timer
      /// </summary>
      private void InitTimer()
      {
          gCtrlTimer = new System.Timers.Timer(10000);
          gCtrlTimer.Elapsed += new ElapsedEventHandler(gCtrlTimer_Elapsed);
          gCtrlTimer.AutoReset = true;
          gCtrlTimer.Enabled = true;
          gCtrlTimer.Stop();
          //gCtrlTimer.Start();
      }

      /// <summary>
      /// Timer task
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      void gCtrlTimer_Elapsed(object sender, ElapsedEventArgs e)
      {           
          //wait the mutex
          mutex.WaitOne();
          CircleF trackPosition = gTrackingPos;      //read the value
          mutex.ReleaseMutex();

          Point StartPos = new Point(-387, 0);
          Point TargetPos = new Point((int)(114.0 - 0.22 * trackPosition.Center.X), (int)(40.0 * trackPosition.Center.Y / 183.0 - 390.55));
          
          Point OneYuanPos = new Point(-180, -200);
          Point FiveJiaoPos = new Point(-280, -200);
          Point OneJiaoPos = new Point(-280, -100);

          Point test = new Point(0, -386);

          if (trackPosition.Radius == 0)
          {
              return;
          }

          RobotArm_Go2Pos(TargetPos);
          Thread.Sleep(4000);
          //RobotArm_GrabThing();
          //one yuan R > 60
          if (trackPosition.Radius > 40)
          {
              RobotArm_Go2Pos(OneYuanPos);
          }
          Thread.Sleep(4000);          
          RobotArm_DropThing();
      }

      /// <summary>
      /// send a command
      /// </summary>
      /// <param name="strCmd"></param>
      private void Commands(string strCmd)
      {
          if (this.serialPort.IsOpen)
          {
              this.serialPort.WriteLine(strCmd);
          }
      }
      /// <summary>
      /// Go to position
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      private void RobotArm_Go2Pos(Point point)
      {
          string strCmd = "G1 " + "X" + point.X.ToString() + " " + "Y" + point.Y.ToString();
          Commands(strCmd);
      }
      /// <summary>
      /// Grab things
      /// </summary>
      private void RobotArm_GrabThing()
      {
          string strDownCmd = "M1 10";
          string strUpCmd = "M1 50";
          Commands(strDownCmd);
          Thread.Sleep(500);
          Commands(strUpCmd);
          Thread.Sleep(500);
      }

      /// <summary>
      /// Robot Arm Drop Things
      /// </summary>
      private void RobotArm_DropThing()
      {
          string strCmd = "M2";
          Commands(strCmd);
      }
      #endregion

      private void InitRobotCtrlDevice()
      {
          this.serialPort.PortName = "NULL";
          this.serialPort.Close();
          this.comboBox_Device.Items.Clear();
          foreach (string s in SerialPort.GetPortNames())
          {
              this.comboBox_Device.Items.Add(s);
          }

      }
     
      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         //PerformShapeDetection();
      }

      private void loadImageButton_Click(object sender, EventArgs e)
      {
         DialogResult result = openFileDialog1.ShowDialog();
         if (result == DialogResult.OK || result == DialogResult.Yes)
         {
            fileNameTextBox.Text = openFileDialog1.FileName;
         }
      }
      #region capture button
      /// <summary>
      /// Start capture
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btn_capture_Click(object sender, EventArgs e)
      {
          try
          {
              //try to create the capture
              if (_capture == null)
              {
                  try
                  {
                      _capture = new Capture();
                  }
                  catch (NullReferenceException excpt)
                  {   //show errors if there is any
                      MessageBox.Show(excpt.Message);
                  }
              }

              if (_capture != null) //if camera capture has been successfully created
              {
                  _capture.ImageGrabbed += ProcessFrame;
                  Thread.Sleep(1000);    //wait other task finish
                  _capture.Start();
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message.ToString());
          }

      }
      #endregion

      /// <summary>
      /// find the noise circles
      /// </summary>
      /// <param name="circle"></param>
      /// <param name="rect"></param>
      /// <returns></returns>
      private bool IsNoiseCircle(CircleF circle, Rectangle rect)
      {         
          if (circle.Center.X > rect.X + rect.Width
              || circle.Center.X < rect.X
              || circle.Center.Y > rect.Y + rect.Height
              || circle.Center.Y < rect.Y
              || circle.Radius > 63)
          {
              return true;
          }
          else
          {
              return false;
          }
      }

      #region Processing image
      private void ProcessFrame(object sender, EventArgs e) 
      {
          try
          {
              using (MemStorage storage = new MemStorage()) //create storage for motion components
              {
                  Image<Bgr, Byte> image = _capture.RetrieveBgrFrame();    /* get a frame */
                 
                  //Load the image from file and resize it for display
                  Image<Bgr, Byte> img = image.Resize(960, 540, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, true);

                  //Convert the image to grayscale and filter out the noise
                  Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

                  double cannyThreshold = 180.0;
                  double circleAccumulatorThreshold = 120;

                  CircleF[] circles = gray.HoughCircles(
                      new Gray(cannyThreshold),
                      new Gray(circleAccumulatorThreshold),
                      2.0,     //Resolution of the accumulator used to detect centers of the circles
                      20.0,    //min distance 
                      5,       //min radius
                      0        //max radius
                      )[0];    //Get the circles from the first channel

                  //rect filter noise                  
                  Rectangle cRect = new Rectangle();
                  cRect.Width = 700;
                  cRect.Height = 200;
                  cRect.X = 10;
                  cRect.Y = 170;

                  //remove noise circle
                  List<CircleF> pureCircles = new List<CircleF>();       //pure circles without noise
                  foreach (CircleF c in circles)
                  {
                      if (!IsNoiseCircle(c, cRect))
                      {
                          pureCircles.Add(c);
                      }
                  }

                  //sort and find the first tracking circle
                  pureCircles.Sort(new CircleComparer());
                   
                  //copy to display circle
                  Image<Bgr, Byte> circleImage = img.CopyBlank();

                  MCvFont font_r = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5, 0.5);
                  foreach (CircleF circle in pureCircles)
                  {
                      circleImage.Draw(circle, new Bgr(Color.Brown), 2);
                      string strR = "R: " + circle.Radius.ToString();
                      circleImage.Draw(strR, ref font_r, new Point((int)circle.Center.X, (int)circle.Center.Y), new Bgr(Color.Red));
                      img.Draw(circle, new Bgr(Color.Brown), 2);
                  }

                  //tracking the first circle and tell robot where to grab it                  
                  MCvFont f_cam = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1.0, 1.0);
                  MCvFont f_time = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX_SMALL, 1.0, 1.0);
                  string strFirstCirclePos = "";
                  if (pureCircles.Count > 0)
                  {
                      strFirstCirclePos = "X: " + pureCircles[0].Center.X.ToString() + "," 
                          + "Y: " + pureCircles[0].Center.Y.ToString() + ","
                          + "R: " + pureCircles[0].Radius.ToString();
                      img.Draw(pureCircles[0], new Bgr(Color.Red), 3);    //re-draw the first tracking one
                      img.Draw(strFirstCirclePos, ref f_cam, new Point((int)pureCircles[0].Center.X, (int)pureCircles[0].Center.Y), new Bgr(Color.Green));

                      gCircleR_Sum += pureCircles[0].Radius;
                      if (++gFrameCnt >= 5)
                      {
                          gFrameCnt = 0;
                          gCircleR_Sum /= 5;
                          //syn to gTrackPos
                          mutex.WaitOne();
                          gTrackingPos = pureCircles[0];
                          gTrackingPos.Radius = gCircleR_Sum;
                          mutex.ReleaseMutex();
                          gCircleR_Sum = 0;
                      }


                  }
                  else
                  {
                      mutex.WaitOne();
                      gTrackingPos = new CircleF();    //if there is no circle detected, reset the value
                      mutex.ReleaseMutex();
                  }
                                    
                  img.Draw(cRect, new Bgr(Color.Green), 2);                            //Draw a rect for calibrating camera
                                    
                  string now = DateTime.Now.ToString();                                //get date time
                  string strTotal = "Detect: " + pureCircles.Count;                    //get how many coins we detect

                  img.Draw("CAM1", ref f_cam, new Point(10, 40), new Bgr(Color.DarkBlue));
                  img.Draw(now, ref f_time, new Point(10, 70), new Bgr(10, 80, 10));
                  
                  circleImage.Draw(strTotal, ref f_cam, new Point(10, 40), new Bgr(Color.Green));
                                    
                  //resize to imageBox size and display it for debug
                  Image<Bgr, Byte> displayImg = img.Resize(547, 311, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, true);
                  triangleRectangleImageBox.Image = displayImg;
                  circleImageBox.Image = circleImage;
                  //Thread.Sleep(10);                             //wait a moment, because we do not need high speed
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message.ToString());
          }                   
      }

      /// <summary>
      /// Stop capture
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btn_stop_Click(object sender, EventArgs e)
      {
          _capture.Stop();
      }
       #endregion

      #region Identify Coin
      private int IdentifyCoin()
      {

          return 0;
      }
      #endregion

      private void btn_OpenPort_Click(object sender, EventArgs e)
      {
          try
          {
              /* Verify if user have selected the parameters of serial port */
              if (null == this.comboBox_Device.SelectedItem)
              {
                  MessageBox.Show("Please select robot device!");
                  return;
              }

              /* If this port has already been opened, ignore it */
              if (this.serialPort.IsOpen)
              {
                  if (comboBox_Device.SelectedItem.ToString() == this.serialPort.PortName)
                  {
                      MessageBox.Show("Already Initialized");
                      return;
                  }
              }

              /* Set parameter */
              this.serialPort.PortName = comboBox_Device.SelectedItem.ToString();
              this.serialPort.BaudRate = 115200;                       //Baudrate: user select
              this.serialPort.Parity = Parity.None;                    //Parity: none
              this.serialPort.DataBits = 8;                            //Data bits: 8
              this.serialPort.StopBits = StopBits.One;                 //Stop bits: 1
              this.serialPort.Handshake = Handshake.None;              //Flow control: none
              this.serialPort.ReadTimeout = 2000;                      //Read timeout: 5000ms
              this.serialPort.WriteTimeout = 2000;                     //Write timeout: 500ms
              this.serialPort.ReadBufferSize = 65536;
              //this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);    // we do not need ACK from robot

              this.serialPort.Open();    //open serial port
          }
          catch(Exception ex)
          {
              MessageBox.Show(ex.Message.ToString());
          }
      }

      private void btnGo2Pos_Click(object sender, EventArgs e)
      {
          string pos_x = this.tbPosX.Text;
          string pos_y = this.tbPosY.Text;

          string strCmd = "G1 " + "X" + pos_x + " " + "Y" + pos_y;  
          this.serialPort.WriteLine(strCmd);
      }
      /// <summary>
      /// Close serial port before we close the MainWindow
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      void DisposeMainWindow(object sender, FormClosedEventArgs e)
      {
          if (this.serialPort.IsOpen)
          {
              this.serialPort.Close();
          }          
      }

      private void btn_Pull_Click(object sender, EventArgs e)
      {
          RobotArm_GrabThing();
      }

      private void btnDrop_Click(object sender, EventArgs e)
      {
          RobotArm_DropThing();
      }

      private void btnRobotArmOn_Click(object sender, EventArgs e)
      {
          //gCtrlTimer.Start();
          gCancelLoop = false;
          Thread thread = new Thread(new ThreadStart(RobotTask));
          thread.Start();
      }

      void RobotTask()
      {
          while (true)
          {
              if (gCancelLoop)
              {
                  continue;
              }
              //wait the mutex
              mutex.WaitOne();
              CircleF trackPosition = gTrackingPos;      //read the value
              mutex.ReleaseMutex();

              Point StartPos = new Point(-386, 0);
              float offsetX = 10.0f;
              float offsetY = -5.0f;
              Point TargetPos = new Point((int)(114.0 - 0.22 * trackPosition.Center.X + offsetX), (int)(40.0 * trackPosition.Center.Y / 183.0 - 390.55 + offsetY));

              Point OneYuanPos = new Point(-180, -180);
              Point FiveJiaoPos = new Point(-280, -180);
              Point OneJiaoPos = new Point(-280, -100);

              Point test = new Point(0, -386);

              if (trackPosition.Radius == 0)
              {
                  continue;
              }


              //one yuan R > 60
              if (trackPosition.Radius > 58 && trackPosition.Radius < 60)
              {
                  RobotArm_Go2Pos(TargetPos);
                  Thread.Sleep(1500);
                  RobotArm_GrabThing();
                  RobotArm_Go2Pos(OneYuanPos);

                  Thread.Sleep(1500);
                  RobotArm_DropThing();
              }
              else if (trackPosition.Radius > 43 && trackPosition.Radius < 46)
              {
                  RobotArm_Go2Pos(TargetPos);
                  Thread.Sleep(1500);
                  RobotArm_GrabThing();
                  RobotArm_Go2Pos(OneJiaoPos);

                  Thread.Sleep(1500);
                  RobotArm_DropThing();
              }
              else if(trackPosition.Radius > 48 && trackPosition.Radius < 50)
              {
                  RobotArm_Go2Pos(TargetPos);
                  Thread.Sleep(1500);
                  RobotArm_GrabThing();
                  RobotArm_Go2Pos(FiveJiaoPos);

                  Thread.Sleep(1500);
                  RobotArm_DropThing();
              }
             
          }
      }

      private void btnRobotArmOff_Click(object sender, EventArgs e)
      {
          //gCtrlTimer.Stop();
          gCancelLoop = true;
      }

      private void btn_Back2StartPos_Click(object sender, EventArgs e)
      {
          string strCmd = "M1 50";
          Commands(strCmd);

          strCmd = "G1 X-386 Y0";
          Commands(strCmd);
      }

      private void btn_xplus_Click(object sender, EventArgs e)
      {
          offset_x += 0.5f;
          this.lblOffsets.Text = "X: " + offset_x.ToString() + "Y: " + offset_y.ToString(); 
      }

      private void btn_xsub_Click(object sender, EventArgs e)
      {
          offset_x -= 0.5f;
          this.lblOffsets.Text = "X: " + offset_x.ToString() + "Y: " + offset_y.ToString(); 
      }

      private void btn_yplus_Click(object sender, EventArgs e)
      {
          offset_y += 0.5f;
          this.lblOffsets.Text = "X: " + offset_x.ToString() + "Y: " + offset_y.ToString(); 
      }

      private void btn_ysub_Click(object sender, EventArgs e)
      {
          offset_y -= 0.5f;
          this.lblOffsets.Text = "X: " + offset_x.ToString() + "Y: " + offset_y.ToString(); 
      }
   }
}
