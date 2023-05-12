using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Doc_Test : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        public int S { get; }
        public Doc_Test(int s)
        {
            InitializeComponent();
            //Initialiser dataGrid
            var req = from v in ctx.Test.Where(d => d.Id_Doc == s) select v;
            testBindingSource.DataSource = req.ToList();
            dg_test.DataSource = testBindingSource;
            //Initialiser cb_docteur
            var doctors = ctx.Doctor.ToList();
            foreach (Doctor d in doctors)
                cb_docteur.Items.Add(d.Id_Doc==s);
            cb_docteur.SelectedIndex = 0;
            S = s;
        }

        private void dg_ord_med_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Ajouter Test
        private void button11_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            int prix = int.Parse(txt_prix.Value.ToString());
            int doctor = int.Parse(cb_docteur.SelectedItem.ToString());
            Test t = new Test(1, nom, prix,doctor);
            ctx.Test.Add(t);
            ctx.SaveChanges();
            MessageBox.Show("bien ajouté");
            RefreshData(S);
        }
        public void RefreshData(int S)
        {
            var req = from v in ctx.Test.Where(d => d.Id_Doc == S) select v;
 
             
            testBindingSource.DataSource = req.ToList();
            dg_test.DataSource = testBindingSource;
        }
        
        //Refrech Data
       private void button3_Click(object sender, EventArgs e)
        {
            RefreshData(S);
        }

        //Modifier test
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Voulez vous vraiment modifier cet Test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToModify = (Test)testBindingSource.Current as Test;

                 
                objectToModify.Nom_test = textBox1.Text;
                objectToModify.Prix_test = int.Parse(txt_prix.Value.ToString());
                objectToModify.Id_Doc = int.Parse(cb_docteur.SelectedItem.ToString());

                ctx.Test.AddOrUpdate(objectToModify);

                ctx.SaveChanges();

            }
        }
        //Supprimer Test
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToDelete = (Test)testBindingSource.Current as Test;
                ctx.Test.Remove(objectToDelete);
                ctx.SaveChanges();
                RefreshData(S);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}