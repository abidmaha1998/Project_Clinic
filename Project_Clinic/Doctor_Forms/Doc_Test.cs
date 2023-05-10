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
        public Doc_Test()
        {
            InitializeComponent();
            var req = from v in ctx.Test select v;
            testBindingSource.DataSource = req.ToList();
            dg_test.DataSource = testBindingSource;

            var doctors = ctx.Doctor.ToList();
            foreach (Doctor d in doctors)
                cb_docteur.Items.Add(d.Id_Doc);
            cb_docteur.SelectedIndex = 0;
        }

        private void dg_ord_med_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            int prix = int.Parse(txt_prix.Value.ToString());
            int doctor = int.Parse(cb_docteur.SelectedItem.ToString());
            Test t = new Test(1, nom, prix,doctor);
            ctx.Test.Add(t);
            ctx.SaveChanges();
            MessageBox.Show("bien ajouté");
            RefreshData();
        }
        public void RefreshData()
        {
            var req = from v in ctx.Test select v;
            testBindingSource.DataSource = req.ToList();
            dg_test.DataSource = testBindingSource;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var req = from v in ctx.Test select v;
            testBindingSource.DataSource = req.ToList();
            dg_test.DataSource = testBindingSource;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Voulez vous vraiment modifier cet Test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToModify = (Test)testBindingSource.Current as Test;

                 
                //var objetDansContexte = new Ordonnance_Medicament { id_ord_med = objectToModify.id_ord_med };

                objectToModify.Nom_test = textBox1.Text;
                objectToModify.Prix_test = int.Parse(txt_prix.Value.ToString());
                objectToModify.Id_Doc = int.Parse(cb_docteur.SelectedItem.ToString());



                ctx.Test.AddOrUpdate(objectToModify);


                //ctx.Entry(objetDansContexte).CurrentValues.SetValues(objectToModify);
                ctx.SaveChanges();
                //ctx.Entry(objetDansContexte).State = EntityState.Detached;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete data from binding source, then save to sql database
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToDelete = (Test)testBindingSource.Current as Test;
                ctx.Test.Remove(objectToDelete);
                ctx.SaveChanges();
                RefreshData();

            }
        }
    }
}