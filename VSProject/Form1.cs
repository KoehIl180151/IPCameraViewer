using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.IO;
using AForge.Imaging.Filters;

namespace IPCameraViever1._0
{
    public partial class Form1 : Form
    {
        MJPEGStream stream;
        bool mouseDown;
        private Point offset;

        public Form1()
        {
            InitializeComponent();

            //save IP Adress to IPCameraSaves.txt
            if (File.Exists("IPCameraSaves.txt"))
            {
                //sets the IP Adress field to the IP that was saved in the .txt file
                txtIPInput.Text = File.ReadAllText("IPCameraSaves.txt");
                //deletes file so no problems occur with it
                File.Delete("IPCameraSaves.txt");
            }

            //sets form border style to none so that i cam implement coustom controls
            FormBorderStyle = FormBorderStyle.None;
        }

    private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            int x, y;

            //gets the current size of the output image so the stream can be resized correctly
            x = imgOutput.Size.Width;
            y = imgOutput.Size.Height;

            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();

            //resizing Image
            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(x, y);
            Bitmap resizedImage = filter.Apply(bmp);

            //sets the output image to the before rezized image
            imgOutput.Image = resizedImage;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            //sets the IP Adress to the value entered in the text field 
            string IPAdress = txtIPInput.Text;

            stream = new MJPEGStream("http://" + IPAdress + "/");
            stream.NewFrame += Stream_NewFrame;
            stream.Start();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            //stops stream (very complicated task:-))
            stream.Stop();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            string IPAdress;

            IPAdress = txtIPInput.Text;

            //saves the IP Adress that was entered in the text field to the text file
            File.WriteAllText("IPCameraSaves.txt", IPAdress);

            Close();
        }

        //coustom controls
        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmdMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void cmdWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void mouseDOwn_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
