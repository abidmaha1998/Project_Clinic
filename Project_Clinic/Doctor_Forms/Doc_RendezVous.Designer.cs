namespace Project_Clinic.Doctor_Forms
{
    partial class Doc_RendezVous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc_RendezVous));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rendezVousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg = new System.Windows.Forms.DataGridView();
            this.idrdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daterdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurerdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinpatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 205;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 19);
            this.label1.TabIndex = 206;
            this.label1.Text = "Rechercher par Date Rendez-Vous:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 19);
            this.label11.TabIndex = 207;
            this.label11.Text = "Rechercher par CIN patient: ";
            // 
            // txt_cin
            // 
            this.txt_cin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cin.Location = new System.Drawing.Point(322, 43);
            this.txt_cin.Multiline = true;
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(143, 35);
            this.txt_cin.TabIndex = 208;
            this.txt_cin.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(292, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 209;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::Project_Clinic.Properties.Resources.background;
            this.pictureBox7.Location = new System.Drawing.Point(12, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(567, 167);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 204;
            this.pictureBox7.TabStop = false;
            // 
            // rendezVousBindingSource
            // 
            this.rendezVousBindingSource.DataSource = typeof(Project_Clinic.RendezVous);
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrdvDataGridViewTextBoxColumn,
            this.daterdvDataGridViewTextBoxColumn,
            this.heurerdvDataGridViewTextBoxColumn,
            this.idDocDataGridViewTextBoxColumn,
            this.cinpatDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn});
            this.dg.DataSource = this.rendezVousBindingSource;
            this.dg.Location = new System.Drawing.Point(12, 185);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(542, 150);
            this.dg.TabIndex = 210;
            // 
            // idrdvDataGridViewTextBoxColumn
            // 
            this.idrdvDataGridViewTextBoxColumn.DataPropertyName = "Id_rdv";
            this.idrdvDataGridViewTextBoxColumn.HeaderText = "Id_rdv";
            this.idrdvDataGridViewTextBoxColumn.Name = "idrdvDataGridViewTextBoxColumn";
            // 
            // daterdvDataGridViewTextBoxColumn
            // 
            this.daterdvDataGridViewTextBoxColumn.DataPropertyName = "Date_rdv";
            this.daterdvDataGridViewTextBoxColumn.HeaderText = "Date_rdv";
            this.daterdvDataGridViewTextBoxColumn.Name = "daterdvDataGridViewTextBoxColumn";
            // 
            // heurerdvDataGridViewTextBoxColumn
            // 
            this.heurerdvDataGridViewTextBoxColumn.DataPropertyName = "Heure_rdv";
            this.heurerdvDataGridViewTextBoxColumn.HeaderText = "Heure_rdv";
            this.heurerdvDataGridViewTextBoxColumn.Name = "heurerdvDataGridViewTextBoxColumn";
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            // 
            // cinpatDataGridViewTextBoxColumn
            // 
            this.cinpatDataGridViewTextBoxColumn.DataPropertyName = "Cin_pat";
            this.cinpatDataGridViewTextBoxColumn.HeaderText = "Cin_pat";
            this.cinpatDataGridViewTextBoxColumn.Name = "cinpatDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            // 
            // Doc_RendezVous
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txt_cin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Doc_RendezVous";
            this.Text = "Doc_RendezVous";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.BindingSource rendezVousBindingSource;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daterdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurerdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinpatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
    }
}