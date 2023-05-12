using DevExpress.XtraReports.UI;
using Project_Clinic.Doctor_Forms.Report;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Ord_med : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();

        public int S { get; }

        public Ord_med(int s)
        {
            InitializeComponent();

            var req = from v in ctx.Ordonnance_Medicament.Where(d => d.Id_Doc == s) select v;
            
            ordonnanceMedicamentBindingSource.DataSource = req.ToList();
            dg_ord_med.DataSource = ordonnanceMedicamentBindingSource;

            var doctors = from v in ctx.Doctor.Where(d => d.Id_Doc == s) select v;
           
            foreach (Doctor d in doctors)
                cb_docteur.Items.Add(d.Id_Doc);
            cb_docteur.SelectedIndex = 0;

            var ordonances = ctx.Ordonnance.ToList();
            foreach (Ordonnance o in ordonances)
                cb_Ord.Items.Add(o.Ord_Num);
            cb_Ord.SelectedIndex = 0;
            S = s;
        }
        public bool VerifierChamps()
        {
            if (txt_nb_jour.Value == 0 || txt_nom_medic.Text == string.Empty || txt_qte.Value == 0 || cb_docteur.SelectedIndex == -1 || cb_Ord.SelectedIndex == -1)
                return false;
            return true;
        }
        //ViderChamps
        public void ViderChamps()
        {
            txt_nb_jour.Value = 0;
            txt_nom_medic.Text = "";
            txt_qte.Value = 0;
            cb_docteur.SelectedIndex = -1;
            cb_Ord.SelectedIndex = -1;

        }
        public void RefreshData(int S)
        {

            
            var req = from v in ctx.Ordonnance_Medicament.Where(d => d.Id_Doc == S) select v;
            ordonnanceMedicamentBindingSource.DataSource = req.ToList();
            dg_ord_med.DataSource = ordonnanceMedicamentBindingSource;

        }
        private void Ord_med_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int qte = int.Parse(txt_qte.Value.ToString());
            int nbrjour = int.Parse(txt_nb_jour.Value.ToString());
            string medicament = txt_nom_medic.Text.ToString();
            int doctor = S;
            int maladie = int.Parse(cb_Ord.SelectedItem.ToString());
            Ordonnance_Medicament m = new Ordonnance_Medicament(1,qte, nbrjour, medicament, maladie, doctor);
            ctx.Ordonnance_Medicament.Add(m);
            ctx.SaveChanges();
            MessageBox.Show("bien ajouté");
            RefreshData(S);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToModify = (Ordonnance_Medicament)ordonnanceMedicamentBindingSource.Current as Ordonnance_Medicament;



                objectToModify.Quantite = int.Parse(txt_qte.Text);
                objectToModify.NbrJr = int.Parse(txt_nb_jour.Text);
                objectToModify.Nom_medic = txt_nom_medic.Text;
                objectToModify.Id_Doc = int.Parse(cb_docteur.SelectedItem.ToString());
                objectToModify.Ord_Num = int.Parse(cb_Ord.SelectedItem.ToString());



                ctx.Ordonnance_Medicament.AddOrUpdate(objectToModify);


                 ctx.SaveChanges();
 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshData(S);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete  
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToDelete = (Ordonnance_Medicament)ordonnanceMedicamentBindingSource.Current as Ordonnance_Medicament;
                ctx.Ordonnance_Medicament.Remove(objectToDelete);
                ctx.SaveChanges();
                RefreshData(S);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var objectToPrint = (Ordonnance_Medicament)ordonnanceMedicamentBindingSource.Current as Ordonnance_Medicament;
            var ord = new Ordonnance_Medicament { id_ord_med = objectToPrint.id_ord_med };
            int i = ord.id_ord_med;

            AllOrdMed report = new AllOrdMed();
            report.Parameters["id_ord"].Value = i;
            report.CreateDocument();
            report.ShowPreview();
        }
    }
    }