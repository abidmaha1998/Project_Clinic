using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Project_Clinic.Admin_Forms.Report
{
    public partial class DoctorDetails : DevExpress.XtraReports.UI.XtraReport
    {
        private Doctor objetDansContexte;
        private int i;

        public DoctorDetails()
        {
            InitializeComponent();
        }

        public DoctorDetails(Doctor objetDansContexte)
        {
            this.objetDansContexte = objetDansContexte;
        }

        public DoctorDetails(int i)
        {
            this.i = i;
        }
    }
}
