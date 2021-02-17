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
    public partial class MRViewPage : Form
    {
        public MRViewPage()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }
        string id;
       
        //Resize Form
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        //Resize Form Finish

        private void Hasta_MouseLeave(object sender, EventArgs e)
        {
            Hasta.BackColor = Color.FromArgb(0, 117, 213);
            Hasta.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Hasta_MouseEnter(object sender, EventArgs e)
        {
            
            Hasta.ForeColor = Color.FromArgb(255, 255, 255);
           
        }

       

        private void Rapor_MouseEnter(object sender, EventArgs e)
        {
            
            Rapor.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void Rapor_MouseLeave(object sender, EventArgs e)
        {
            Rapor.BackColor = Color.FromArgb(0, 117, 213);
            Rapor.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = Color.DarkRed;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_MouseEnter(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(30, 137, 233);
        }

        private void Maximize_MouseLeave(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Style.Maximize(this);
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(30, 137, 233);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            Style.Minimize(this);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = Style.formState;
            oturumuKapatToolStripMenuItem.Text =UserInformation.UserName;
            string query = "SELECT id AS 'ID',TC AS 'TC',imgloc AS 'MR',tumorloc AS 'Tumor MR',date AS 'Kayıt Tarihi',result AS 'MR Sonucu',cinsiyet AS 'Cinsiyeti',birthdate AS 'Doğum Tarihi' from tumor WHERE ban='0' AND doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
            imgBox.Image = Image.FromFile("img/img.jpg");
            tumorBox.Image = Image.FromFile("img/tumor.jpg");

        }

        private void title_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void menuStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void panel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

     
        private void oturumuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.Show();
            this.Close();
        }

        private void Hasta_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            this.Close();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void Search_MouseEnter(object sender, EventArgs e)
        {
            Search.BackColor = Color.FromArgb(30, 137, 233);
        }


        private void Search_MouseLeave(object sender, EventArgs e)
        {
            Search.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void label4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataView.CurrentRow.Cells[0].Value.ToString();
            TC.Text = DataView.CurrentRow.Cells[1].Value.ToString();
            Result.Text = DataView.CurrentRow.Cells[5].Value.ToString();
           
            Sql.PatientInfo(DataView.CurrentRow.Cells[1].Value.ToString());
            Cinsiyeti.Text = PatientsInformation.cinsiyet;
            NameT.Text = PatientsInformation.name + " " + PatientsInformation.surname;
            MRInformation.date= DataView.CurrentRow.Cells[4].Value.ToString();
            MRInformation.imgLoc=ServerInformation.myHostName+"static/"+ DataView.CurrentRow.Cells[2].Value.ToString();
           
            MRInformation.tumorLoc= ServerInformation.myHostName + "static/" + DataView.CurrentRow.Cells[3].Value.ToString();
            MRInformation.result= DataView.CurrentRow.Cells[5].Value.ToString();
            imgBox.ImageLocation = MRInformation.imgLoc;
            tumorBox.ImageLocation = MRInformation.tumorLoc;

        }

        private void TCSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',imgloc AS 'MR',tumorloc AS 'Tumor MR',date AS 'Kayıt Tarihi',result AS 'MR Sonucu',cinsiyet AS 'Cinsiyeti',birthdate AS 'Doğum Tarihi' from tumor WHERE TC LIKE '%" + TCSearch.Text + "%' AND doctor = '" + UserInformation.UserKey + "'";
            
            Sql.Select(query, DataView);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',imgloc AS 'MR',tumorloc AS 'Tumor MR',date AS 'Kayıt Tarihi',result AS 'MR Sonucu',cinsiyet AS 'Cinsiyeti',birthdate AS 'Doğum Tarihi' from tumor WHERE ban='0' AND TC LIKE '%" + TCSearch.Text + "%' AND doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try { 
            string rslt;
            if (Result.Text == "Tümör Bulundu")
                rslt = "Pozitif";
            else
                rslt = "Negatif";
            Sql.UpdateMR("UPDATE tumor SET   id='" + id + "' AND result='" + rslt+"' WHERE ban='0' AND TC='"+TC.Text+"' AND doctor='"+UserInformation.UserKey+"' ");
                Style.Message("MR Başarıyla Kaydedildi");
                TC.Text = "";
                Result.Text = "";
            }
            catch
            {
                Style.Error("MR Kaydedilemedi");
            }
         }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void Print_MouseEnter(object sender, EventArgs e)
        {

            Print.BackColor = Color.FromArgb(30, 137, 233);
        }


        private void Print_MouseLeave(object sender, EventArgs e)
        {
            Print.BackColor = Color.FromArgb(0, 117, 213);

        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.BackColor = Color.DarkRed;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',imgloc AS 'MR',tumorloc AS 'Tumor MR',date AS 'Kayıt Tarihi',result AS 'MR Sonucu',cinsiyet AS 'Cinsiyeti',birthdate AS 'Doğum Tarihi' from tumor WHERE doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
            NameT.Text = "";
            Result.Text = "";
            TCSearch.Text = "";
            TC.Text = "";

            imgBox.Image = Image.FromFile("img/img.jpg");
            tumorBox.Image = Image.FromFile("img/tumor.jpg");
            Cinsiyeti.Text = "";
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string rslt;
                if (Result.Text == "Tümör Bulundu")
                    rslt = "Pozitif";
                else
                    rslt = "Negatif";
                Sql.UpdateMR("UPDATE tumor SET  ban='1' WHERE id='"+id+"' AND TC='" + TC.Text + "' AND doctor='" + UserInformation.UserKey + "' ");
                Style.Message("MR Başarıyla Kaydedildi");
                TC.Text = "";
                Result.Text = "";
            }
            catch
            {
                Style.Error("MR Kaydedilemedi");
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.Show();
        }
    }
}
