namespace Project_Clinic
{
    partial class Docteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docteur));
            this.txt_recherche_admin_Doc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_specialite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.dg_admin_doc = new System.Windows.Forms.DataGridView();
            this.txt_experience = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bt_aj_img = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docspecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docexperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docaddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_experience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_recherche_admin_Doc
            // 
            this.txt_recherche_admin_Doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recherche_admin_Doc.Location = new System.Drawing.Point(56, 12);
            this.txt_recherche_admin_Doc.Multiline = true;
            this.txt_recherche_admin_Doc.Name = "txt_recherche_admin_Doc";
            this.txt_recherche_admin_Doc.Size = new System.Drawing.Size(164, 39);
            this.txt_recherche_admin_Doc.TabIndex = 1;
            this.txt_recherche_admin_Doc.TextChanged += new System.EventHandler(this.txt_recherche_admin_Doc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txt_nom
            // 
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nom.Location = new System.Drawing.Point(208, 192);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(164, 29);
            this.txt_nom.TabIndex = 5;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txt_prenom
            // 
            this.txt_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prenom.Location = new System.Drawing.Point(208, 255);
            this.txt_prenom.Multiline = true;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(164, 29);
            this.txt_prenom.TabIndex = 7;
            this.txt_prenom.TextChanged += new System.EventHandler(this.txt_prenom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date de naissance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_adress
            // 
            this.txt_adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adress.Location = new System.Drawing.Point(208, 390);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(164, 29);
            this.txt_adress.TabIndex = 13;
            this.txt_adress.TextChanged += new System.EventHandler(this.txt_adress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresse:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tele
            // 
            this.txt_tele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tele.Location = new System.Drawing.Point(208, 343);
            this.txt_tele.Multiline = true;
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(164, 29);
            this.txt_tele.TabIndex = 11;
            this.txt_tele.TextChanged += new System.EventHandler(this.txt_tele_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Téléphone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(208, 312);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 21);
            this.txt_date.TabIndex = 14;
            this.txt_date.ValueChanged += new System.EventHandler(this.txt_date_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Experience:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(208, 425);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(164, 29);
            this.txt_pass.TabIndex = 16;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_specialite
            // 
            this.txt_specialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_specialite.Location = new System.Drawing.Point(208, 509);
            this.txt_specialite.Multiline = true;
            this.txt_specialite.Name = "txt_specialite";
            this.txt_specialite.Size = new System.Drawing.Size(164, 29);
            this.txt_specialite.TabIndex = 20;
            this.txt_specialite.TextChanged += new System.EventHandler(this.txt_specialite_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Spécialité:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(554, 28);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(71, 13);
            this.lb_total.TabIndex = 24;
            this.lb_total.Text = "Total docteur";
            this.lb_total.Click += new System.EventHandler(this.lb_total_Click);
            // 
            // dg_admin_doc
            // 
            this.dg_admin_doc.AutoGenerateColumns = false;
            this.dg_admin_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_admin_doc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDataGridViewTextBoxColumn,
            this.nomDocDataGridViewTextBoxColumn,
            this.prenomDocDataGridViewTextBoxColumn,
            this.dateNaissanceDocDataGridViewTextBoxColumn,
            this.docspecialiteDataGridViewTextBoxColumn,
            this.docexperienceDataGridViewTextBoxColumn,
            this.docphoneDataGridViewTextBoxColumn,
            this.docaddrDataGridViewTextBoxColumn,
            this.docpassDataGridViewTextBoxColumn,
            this.docImageDataGridViewImageColumn});
            this.dg_admin_doc.DataSource = this.doctorBindingSource;
            this.dg_admin_doc.Location = new System.Drawing.Point(12, 591);
            this.dg_admin_doc.Name = "dg_admin_doc";
            this.dg_admin_doc.Size = new System.Drawing.Size(701, 117);
            this.dg_admin_doc.TabIndex = 25;
            this.dg_admin_doc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_admin_doc_CellContentClick);
            this.dg_admin_doc.Click += new System.EventHandler(this.dg_admin_doc_Click);
            this.dg_admin_doc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_admin_doc_KeyDown);
            // 
            // txt_experience
            // 
            this.txt_experience.Location = new System.Drawing.Point(208, 468);
            this.txt_experience.Name = "txt_experience";
            this.txt_experience.Size = new System.Drawing.Size(164, 21);
            this.txt_experience.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(842, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Imprimmer la listes des Docteur";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_Clinic.Properties.Resources.printer;
            this.pictureBox3.Location = new System.Drawing.Point(748, 626);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 152;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(26, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 151;
            this.pictureBox6.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Project_Clinic.Properties.Resources.delete_user;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(459, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 123;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Project_Clinic.Properties.Resources.canceluder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(459, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 115;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::Project_Clinic.Properties.Resources.profilew__1_;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(459, 299);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(153, 47);
            this.button9.TabIndex = 114;
            this.button9.Text = "Modifier";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(86)))));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Project_Clinic.Properties.Resources.add_user;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(459, 251);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 47);
            this.button11.TabIndex = 113;
            this.button11.Text = "Ajouter";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Project_Clinic.Properties.Resources.reload;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(469, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 30;
            this.button4.Text = "Refrech";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(40, 84);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(152, 88);
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // bt_aj_img
            // 
            this.bt_aj_img.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_aj_img.ForeColor = System.Drawing.Color.White;
            this.bt_aj_img.Image = global::Project_Clinic.Properties.Resources.pic2;
            this.bt_aj_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aj_img.Location = new System.Drawing.Point(249, 95);
            this.bt_aj_img.Name = "bt_aj_img";
            this.bt_aj_img.Size = new System.Drawing.Size(159, 39);
            this.bt_aj_img.TabIndex = 3;
            this.bt_aj_img.Text = "Ajouter image";
            this.bt_aj_img.UseVisualStyleBackColor = false;
            this.bt_aj_img.Click += new System.EventHandler(this.bt_aj_img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "Id_Doc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            // 
            // nomDocDataGridViewTextBoxColumn
            // 
            this.nomDocDataGridViewTextBoxColumn.DataPropertyName = "Nom_Doc";
            this.nomDocDataGridViewTextBoxColumn.HeaderText = "Nom_Doc";
            this.nomDocDataGridViewTextBoxColumn.Name = "nomDocDataGridViewTextBoxColumn";
            // 
            // prenomDocDataGridViewTextBoxColumn
            // 
            this.prenomDocDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Doc";
            this.prenomDocDataGridViewTextBoxColumn.HeaderText = "Prenom_Doc";
            this.prenomDocDataGridViewTextBoxColumn.Name = "prenomDocDataGridViewTextBoxColumn";
            // 
            // dateNaissanceDocDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDocDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance_Doc";
            this.dateNaissanceDocDataGridViewTextBoxColumn.HeaderText = "DateNaissance_Doc";
            this.dateNaissanceDocDataGridViewTextBoxColumn.Name = "dateNaissanceDocDataGridViewTextBoxColumn";
            // 
            // docspecialiteDataGridViewTextBoxColumn
            // 
            this.docspecialiteDataGridViewTextBoxColumn.DataPropertyName = "Doc_specialite";
            this.docspecialiteDataGridViewTextBoxColumn.HeaderText = "Doc_specialite";
            this.docspecialiteDataGridViewTextBoxColumn.Name = "docspecialiteDataGridViewTextBoxColumn";
            // 
            // docexperienceDataGridViewTextBoxColumn
            // 
            this.docexperienceDataGridViewTextBoxColumn.DataPropertyName = "Doc_experience";
            this.docexperienceDataGridViewTextBoxColumn.HeaderText = "Doc_experience";
            this.docexperienceDataGridViewTextBoxColumn.Name = "docexperienceDataGridViewTextBoxColumn";
            // 
            // docphoneDataGridViewTextBoxColumn
            // 
            this.docphoneDataGridViewTextBoxColumn.DataPropertyName = "Doc_phone";
            this.docphoneDataGridViewTextBoxColumn.HeaderText = "Doc_phone";
            this.docphoneDataGridViewTextBoxColumn.Name = "docphoneDataGridViewTextBoxColumn";
            // 
            // docaddrDataGridViewTextBoxColumn
            // 
            this.docaddrDataGridViewTextBoxColumn.DataPropertyName = "Doc_addr";
            this.docaddrDataGridViewTextBoxColumn.HeaderText = "Doc_addr";
            this.docaddrDataGridViewTextBoxColumn.Name = "docaddrDataGridViewTextBoxColumn";
            // 
            // docpassDataGridViewTextBoxColumn
            // 
            this.docpassDataGridViewTextBoxColumn.DataPropertyName = "Doc_pass";
            this.docpassDataGridViewTextBoxColumn.HeaderText = "Doc_pass";
            this.docpassDataGridViewTextBoxColumn.Name = "docpassDataGridViewTextBoxColumn";
            // 
            // docImageDataGridViewImageColumn
            // 
            this.docImageDataGridViewImageColumn.DataPropertyName = "Doc_Image";
            this.docImageDataGridViewImageColumn.HeaderText = "Doc_Image";
            this.docImageDataGridViewImageColumn.Name = "docImageDataGridViewImageColumn";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project_Clinic.Doctor);
            this.doctorBindingSource.CurrentChanged += new System.EventHandler(this.doctorBindingSource_CurrentChanged);
            // 
            // Docteur
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1086, 756);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txt_experience);
            this.Controls.Add(this.dg_admin_doc);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txt_specialite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_aj_img);
            this.Controls.Add(this.txt_recherche_admin_Doc);
            this.Controls.Add(this.pictureBox1);
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "Docteur";
            this.Text = "Docteur";
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_experience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_recherche_admin_Doc;
        private System.Windows.Forms.Button bt_aj_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_specialite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.DataGridView dg_admin_doc;
        private System.Windows.Forms.NumericUpDown txt_experience;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docspecialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docexperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docaddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn docImageDataGridViewImageColumn;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
    }
}