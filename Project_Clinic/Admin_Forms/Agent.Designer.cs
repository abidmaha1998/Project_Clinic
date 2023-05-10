namespace Project_Clinic.Admin_Forms
{
    partial class Agent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agent));
            this.dg_admin_doc = new System.Windows.Forms.DataGridView();
            this.lb_total = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_recherche_admin_Doc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bt_aj_img = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageagDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_admin_doc
            // 
            this.dg_admin_doc.AutoGenerateColumns = false;
            this.dg_admin_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_admin_doc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagDataGridViewTextBoxColumn,
            this.nomagDataGridViewTextBoxColumn,
            this.prenomagDataGridViewTextBoxColumn,
            this.phoneagDataGridViewTextBoxColumn,
            this.dateNaissanceagDataGridViewTextBoxColumn,
            this.adresseagDataGridViewTextBoxColumn,
            this.passwordagDataGridViewTextBoxColumn,
            this.imageagDataGridViewImageColumn});
            this.dg_admin_doc.DataSource = this.agentBindingSource;
            this.dg_admin_doc.Location = new System.Drawing.Point(34, 612);
            this.dg_admin_doc.Name = "dg_admin_doc";
            this.dg_admin_doc.Size = new System.Drawing.Size(701, 117);
            this.dg_admin_doc.TabIndex = 172;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(576, 49);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(62, 13);
            this.lb_total.TabIndex = 171;
            this.lb_total.Text = "Total agent";
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(230, 446);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(164, 29);
            this.txt_pass.TabIndex = 166;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 165;
            this.label7.Text = "Password";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(230, 333);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 21);
            this.txt_date.TabIndex = 164;
            // 
            // txt_adress
            // 
            this.txt_adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adress.Location = new System.Drawing.Point(230, 411);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(164, 29);
            this.txt_adress.TabIndex = 163;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 162;
            this.label4.Text = "Adresse:";
            // 
            // txt_tele
            // 
            this.txt_tele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tele.Location = new System.Drawing.Point(230, 364);
            this.txt_tele.Multiline = true;
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(164, 29);
            this.txt_tele.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 160;
            this.label5.Text = "Téléphone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 159;
            this.label3.Text = "Date de naissance";
            // 
            // txt_prenom
            // 
            this.txt_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prenom.Location = new System.Drawing.Point(230, 276);
            this.txt_prenom.Multiline = true;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(164, 29);
            this.txt_prenom.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 157;
            this.label2.Text = "Prénom";
            // 
            // txt_nom
            // 
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nom.Location = new System.Drawing.Point(230, 213);
            this.txt_nom.Multiline = true;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(164, 29);
            this.txt_nom.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 155;
            this.label1.Text = "Nom:";
            // 
            // txt_recherche_admin_Doc
            // 
            this.txt_recherche_admin_Doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recherche_admin_Doc.Location = new System.Drawing.Point(90, 33);
            this.txt_recherche_admin_Doc.Multiline = true;
            this.txt_recherche_admin_Doc.Name = "txt_recherche_admin_Doc";
            this.txt_recherche_admin_Doc.Size = new System.Drawing.Size(164, 29);
            this.txt_recherche_admin_Doc.TabIndex = 153;
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
            this.button2.Location = new System.Drawing.Point(481, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 179;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(481, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 178;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
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
            this.button9.Location = new System.Drawing.Point(481, 320);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(153, 47);
            this.button9.TabIndex = 177;
            this.button9.Text = "Modifier";
            this.button9.UseVisualStyleBackColor = false;
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
            this.button11.Location = new System.Drawing.Point(481, 272);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 47);
            this.button11.TabIndex = 176;
            this.button11.Text = "Ajouter";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Clinic.Properties.Resources.printer;
            this.pictureBox2.Location = new System.Drawing.Point(757, 612);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 175;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Project_Clinic.Properties.Resources.reload;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(491, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 174;
            this.button4.Text = "Refrech";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(Project_Clinic.Doctor);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(62, 105);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(152, 88);
            this.pictureBox.TabIndex = 170;
            this.pictureBox.TabStop = false;
            // 
            // bt_aj_img
            // 
            this.bt_aj_img.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_aj_img.ForeColor = System.Drawing.Color.White;
            this.bt_aj_img.Image = global::Project_Clinic.Properties.Resources.pic2;
            this.bt_aj_img.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aj_img.Location = new System.Drawing.Point(271, 116);
            this.bt_aj_img.Name = "bt_aj_img";
            this.bt_aj_img.Size = new System.Drawing.Size(159, 39);
            this.bt_aj_img.TabIndex = 154;
            this.bt_aj_img.Text = "Ajouter image";
            this.bt_aj_img.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(34, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 180;
            this.pictureBox6.TabStop = false;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(Project_Clinic.Agent);
            // 
            // idagDataGridViewTextBoxColumn
            // 
            this.idagDataGridViewTextBoxColumn.DataPropertyName = "Id_ag";
            this.idagDataGridViewTextBoxColumn.HeaderText = "Id_ag";
            this.idagDataGridViewTextBoxColumn.Name = "idagDataGridViewTextBoxColumn";
            // 
            // nomagDataGridViewTextBoxColumn
            // 
            this.nomagDataGridViewTextBoxColumn.DataPropertyName = "Nom_ag";
            this.nomagDataGridViewTextBoxColumn.HeaderText = "Nom_ag";
            this.nomagDataGridViewTextBoxColumn.Name = "nomagDataGridViewTextBoxColumn";
            // 
            // prenomagDataGridViewTextBoxColumn
            // 
            this.prenomagDataGridViewTextBoxColumn.DataPropertyName = "Prenom_ag";
            this.prenomagDataGridViewTextBoxColumn.HeaderText = "Prenom_ag";
            this.prenomagDataGridViewTextBoxColumn.Name = "prenomagDataGridViewTextBoxColumn";
            // 
            // phoneagDataGridViewTextBoxColumn
            // 
            this.phoneagDataGridViewTextBoxColumn.DataPropertyName = "Phone_ag";
            this.phoneagDataGridViewTextBoxColumn.HeaderText = "Phone_ag";
            this.phoneagDataGridViewTextBoxColumn.Name = "phoneagDataGridViewTextBoxColumn";
            // 
            // dateNaissanceagDataGridViewTextBoxColumn
            // 
            this.dateNaissanceagDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance_ag";
            this.dateNaissanceagDataGridViewTextBoxColumn.HeaderText = "DateNaissance_ag";
            this.dateNaissanceagDataGridViewTextBoxColumn.Name = "dateNaissanceagDataGridViewTextBoxColumn";
            // 
            // adresseagDataGridViewTextBoxColumn
            // 
            this.adresseagDataGridViewTextBoxColumn.DataPropertyName = "Adresse_ag";
            this.adresseagDataGridViewTextBoxColumn.HeaderText = "Adresse_ag";
            this.adresseagDataGridViewTextBoxColumn.Name = "adresseagDataGridViewTextBoxColumn";
            // 
            // passwordagDataGridViewTextBoxColumn
            // 
            this.passwordagDataGridViewTextBoxColumn.DataPropertyName = "Password_ag";
            this.passwordagDataGridViewTextBoxColumn.HeaderText = "Password_ag";
            this.passwordagDataGridViewTextBoxColumn.Name = "passwordagDataGridViewTextBoxColumn";
            // 
            // imageagDataGridViewImageColumn
            // 
            this.imageagDataGridViewImageColumn.DataPropertyName = "Image_ag";
            this.imageagDataGridViewImageColumn.HeaderText = "Image_ag";
            this.imageagDataGridViewImageColumn.Name = "imageagDataGridViewImageColumn";
            // 
            // Agent
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dg_admin_doc);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.pictureBox);
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
            this.Name = "Agent";
            this.Text = "Agent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dg_admin_doc;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_aj_img;
        private System.Windows.Forms.TextBox txt_recherche_admin_Doc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageagDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource agentBindingSource;
    }
}