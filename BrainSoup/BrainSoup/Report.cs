using BrainSoup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
      
       

        //Rest of the code
        Bitmap MemoryImage;
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(215, 24, 24);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(0, 117, 213);
        }


     
        
        private void Error_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

        private void Error_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void Error_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            TC.Text = "Hastanın TC Kimlik No: " + PatientsInformation.TC;
            FullName.Text = "Hastanın Adı ve Soyadı: "+PatientsInformation.name + "  "+PatientsInformation.surname;
            BirthDate.Text = "Hastanın Doğum Tarihi: "+PatientsInformation.birthdate;
            Email.Text = "Hastanın Mail Adresi " + PatientsInformation.email;
            Cinsiyet.Text = "Hastanın Cinsiyeti: " + PatientsInformation.cinsiyet;
            Date.Text = "MR Kayıt Tarihi: " + MRInformation.date;
            Result.Text = "MR Sonucu: " + MRInformation.result;
            imgBox.ImageLocation = MRInformation.imgLoc;
            tumorBox.ImageLocation = MRInformation.tumorLoc;



        }

        private void titleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void titleLbl_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void titleLbl_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void errorLbl_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void errorLbl_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void errorLbl_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void errorPB_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void errorPB_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void errorPB_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void Print_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(20, 137, 233);
        }

        private void Print_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(0, 117, 213);
        }
     
     
        private void Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender,PrintPageEventArgs e)
        {
          
            Bitmap bmp = new Bitmap(panel3.Width,1020, panel3.CreateGraphics());
            panel3.DrawToBitmap(bmp, new Rectangle(0, 0, panel3.Width, 930));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }
    }
}
