using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Doctor_Dashbord : DevExpress.XtraEditors.XtraForm
    {
        Form activeForm;
        public Doctor_Dashbord()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.layoutControl1.Controls.Add(childForm);
            this.layoutControl1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void sidePanel2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Test(), sender);
        }

        private void sidePanel3_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Test(), sender);
        }

        private void sidePanel4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doc_RendezVous(), sender);
        }

        private void sidePanel4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Doc_Test(), sender);
        }

        private void sidePanel8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doc_Patient(), sender);
        }

        private void sidePanel5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ord_med(), sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }
    }
}