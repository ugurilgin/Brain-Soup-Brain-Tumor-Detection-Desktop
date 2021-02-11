using BrainSoup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }
        Point lastLocation;
        bool mouseDown;
        int sayac = 0;
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(215, 24, 24);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(0, 117, 213);
        }


     
        private void okBtn_MouseEnter(object sender, EventArgs e)
        {
            okBtn.BackColor = Color.FromArgb(0, 117, 213);
            okBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void okBtn_MouseLeave(object sender, EventArgs e)
        {
            okBtn.BackColor = Color.FromArgb(255, 255, 255);
            okBtn.ForeColor = Color.FromArgb(0, 117, 213);
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
            errorLbl.Text=ErrorInformation.Message;
            titleLbl.Text = ErrorInformation.Title;
           errorPB.Image= Image.FromFile(ErrorInformation.Image);
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
    }
}
