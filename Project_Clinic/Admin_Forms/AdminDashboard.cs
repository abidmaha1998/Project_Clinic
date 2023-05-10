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

namespace Project_Clinic.Admin_Forms
{
    
    public partial class AdminDashboard : DevExpress.XtraEditors.XtraForm
    {
        Form activeForm;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            this.layoutControl2.Controls.Add(childForm);
            this.layoutControl2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void sidePanel2_Click(object sender, EventArgs e)
        {
           
        }

        private void sidePanel3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agent(), sender);
        }

        private void Admin_Forms_Load(object sender, EventArgs e)
        {

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Docteur(), sender);

        }

        private void sidePanel7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agent(), sender);
        }

        private void sidePanel8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_Patient(), sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }
    }
}