using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace QuanLyCuaHangTienLoi.View
{
    public partial class frmCam_QR : Form
    {
        public string id = "";
        //Xem số cam đang kết nối
        private FilterInfoCollection cameras;
        //Cam cụ thể
        private VideoCaptureDevice cam;

        public frmCam_QR()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmCam_QR_Load(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
                comboBox1.SelectedIndex = 0;
            }
            
        }

        public void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader red = new BarcodeReader();
            var res = red.Decode(bitmap);
            if (res != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = res.ToString();
                    id = res.ToString();
                }));
            }
            pictureBox1.Image = bitmap;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                    textBox1.Clear();
                }
            }
        }    
  
        private void frmCam_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
        }
    }
}
