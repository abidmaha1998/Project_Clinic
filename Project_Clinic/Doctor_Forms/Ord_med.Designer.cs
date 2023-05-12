namespace Project_Clinic.Doctor_Forms
{
    partial class Ord_med
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ord_med));
            this.txt_nom_medic = new System.Windows.Forms.TextBox();
            this.cb_Ord = new System.Windows.Forms.ComboBox();
            this.txt_nb_jour = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_qte = new System.Windows.Forms.NumericUpDown();
            this.cb_docteur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_ord_med = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idordmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrJrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommedicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordonnanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordonnanceMedicamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordonnanceMedicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_jour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ord_med)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnanceMedicamentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnanceMedicamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom_medic
            // 
            this.txt_nom_medic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nom_medic.Location = new System.Drawing.Point(323, 298);
            this.txt_nom_medic.Multiline = true;
            this.txt_nom_medic.Name = "txt_nom_medic";
            this.txt_nom_medic.Size = new System.Drawing.Size(200, 35);
            this.txt_nom_medic.TabIndex = 244;
            // 
            // cb_Ord
            // 
            this.cb_Ord.FormattingEnabled = true;
            this.cb_Ord.Location = new System.Drawing.Point(323, 249);
            this.cb_Ord.Name = "cb_Ord";
            this.cb_Ord.Size = new System.Drawing.Size(200, 21);
            this.cb_Ord.TabIndex = 237;
            // 
            // txt_nb_jour
            // 
            this.txt_nb_jour.Location = new System.Drawing.Point(323, 190);
            this.txt_nb_jour.Name = "txt_nb_jour";
            this.txt_nb_jour.Size = new System.Drawing.Size(200, 21);
            this.txt_nb_jour.TabIndex = 243;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 236;
            this.label2.Text = "Quantité:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 235;
            this.label1.Text = "Ord num:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 19);
            this.label10.TabIndex = 234;
            this.label10.Text = "Nombre de jour:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(157, 45);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 35);
            this.textBox6.TabIndex = 231;
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(323, 140);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(200, 21);
            this.txt_qte.TabIndex = 245;
            // 
            // cb_docteur
            // 
            this.cb_docteur.Enabled = false;
            this.cb_docteur.FormattingEnabled = true;
            this.cb_docteur.Location = new System.Drawing.Point(323, 359);
            this.cb_docteur.Name = "cb_docteur";
            this.cb_docteur.Size = new System.Drawing.Size(200, 21);
            this.cb_docteur.TabIndex = 246;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 247;
            this.label3.Text = "Nom Medicament:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 248;
            this.label4.Text = "Docteur:";
            // 
            // dg_ord_med
            // 
            this.dg_ord_med.AutoGenerateColumns = false;
            this.dg_ord_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ord_med.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idordmedDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.nbrJrDataGridViewTextBoxColumn,
            this.nommedicDataGridViewTextBoxColumn,
            this.ordNumDataGridViewTextBoxColumn,
            this.idDocDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.ordonnanceDataGridViewTextBoxColumn});
            this.dg_ord_med.DataSource = this.ordonnanceMedicamentBindingSource1;
            this.dg_ord_med.Location = new System.Drawing.Point(114, 479);
            this.dg_ord_med.Name = "dg_ord_med";
            this.dg_ord_med.Size = new System.Drawing.Size(643, 150);
            this.dg_ord_med.TabIndex = 249;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::Project_Clinic.Properties.Resources.system_update__1_;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(587, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(153, 47);
            this.button9.TabIndex = 239;
            this.button9.Text = "Modifier";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Project_Clinic.Properties.Resources.reload;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(653, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 32);
            this.button3.TabIndex = 242;
            this.button3.Text = "Refrech";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Project_Clinic.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(587, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 241;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Project_Clinic.Properties.Resources.delet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(587, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 240;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Project_Clinic.Properties.Resources.add1;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(587, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 47);
            this.button11.TabIndex = 238;
            this.button11.Text = "Ajouter";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::Project_Clinic.Properties.Resources.background;
            this.pictureBox7.Location = new System.Drawing.Point(114, 86);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(703, 387);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 233;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(123, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 232;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Clinic.Properties.Resources.printer;
            this.pictureBox1.Location = new System.Drawing.Point(763, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 250;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idordmedDataGridViewTextBoxColumn
            // 
            this.idordmedDataGridViewTextBoxColumn.DataPropertyName = "id_ord_med";
            this.idordmedDataGridViewTextBoxColumn.HeaderText = "id_ord_med";
            this.idordmedDataGridViewTextBoxColumn.Name = "idordmedDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // nbrJrDataGridViewTextBoxColumn
            // 
            this.nbrJrDataGridViewTextBoxColumn.DataPropertyName = "NbrJr";
            this.nbrJrDataGridViewTextBoxColumn.HeaderText = "NbrJr";
            this.nbrJrDataGridViewTextBoxColumn.Name = "nbrJrDataGridViewTextBoxColumn";
            // 
            // nommedicDataGridViewTextBoxColumn
            // 
            this.nommedicDataGridViewTextBoxColumn.DataPropertyName = "Nom_medic";
            this.nommedicDataGridViewTextBoxColumn.HeaderText = "Nom_medic";
            this.nommedicDataGridViewTextBoxColumn.Name = "nommedicDataGridViewTextBoxColumn";
            // 
            // ordNumDataGridViewTextBoxColumn
            // 
            this.ordNumDataGridViewTextBoxColumn.DataPropertyName = "Ord_Num";
            this.ordNumDataGridViewTextBoxColumn.HeaderText = "Ord_Num";
            this.ordNumDataGridViewTextBoxColumn.Name = "ordNumDataGridViewTextBoxColumn";
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            // 
            // ordonnanceDataGridViewTextBoxColumn
            // 
            this.ordonnanceDataGridViewTextBoxColumn.DataPropertyName = "Ordonnance";
            this.ordonnanceDataGridViewTextBoxColumn.HeaderText = "Ordonnance";
            this.ordonnanceDataGridViewTextBoxColumn.Name = "ordonnanceDataGridViewTextBoxColumn";
            // 
            // ordonnanceMedicamentBindingSource1
            // 
            this.ordonnanceMedicamentBindingSource1.DataSource = typeof(Project_Clinic.Ordonnance_Medicament);
            // 
            // ordonnanceMedicamentBindingSource
            // 
            this.ordonnanceMedicamentBindingSource.DataSource = typeof(Project_Clinic.Ordonnance_Medicament);
            // 
            // Ord_med
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dg_ord_med);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_docteur);
            this.Controls.Add(this.txt_qte);
            this.Controls.Add(this.txt_nom_medic);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cb_Ord);
            this.Controls.Add(this.txt_nb_jour);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.textBox6);
            this.Name = "Ord_med";
            this.Text = "Ord_med";
            this.Load += new System.EventHandler(this.Ord_med_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_jour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ord_med)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnanceMedicamentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnanceMedicamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom_medic;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox cb_Ord;
        private System.Windows.Forms.NumericUpDown txt_nb_jour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown txt_qte;
        private System.Windows.Forms.ComboBox cb_docteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_ord_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn idordmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrJrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommedicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordonnanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordonnanceMedicamentBindingSource;
        private System.Windows.Forms.BindingSource ordonnanceMedicamentBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}