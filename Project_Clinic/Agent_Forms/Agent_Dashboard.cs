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

namespace Project_Clinic.Agent_Forms
{
    public partial class Agent_Dashboard : DevExpress.XtraEditors.XtraForm
    {
        Form activeForm;
        public Agent_Dashboard()
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
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sidePanel6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RendezVousForm(), sender);
        }

        private void sidePanel8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agent_Patient(), sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }
    }
}