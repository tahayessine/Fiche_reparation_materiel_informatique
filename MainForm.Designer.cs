namespace Proojet
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Costumer_btn = new System.Windows.Forms.Button();
            this.HOME_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search_equipement = new System.Windows.Forms.Button();
            this.Btn_delete_equipement = new System.Windows.Forms.Button();
            this.Btn_update_equipement = new System.Windows.Forms.Button();
            this.Btn_add_equipement = new System.Windows.Forms.Button();
            this.equipementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeetDataSet = new Proojet.ProjeetDataSet();
            this.equipementsTableAdapter = new Proojet.ProjeetDataSetTableAdapters.EquipementsTableAdapter();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVEquipement = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipement)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer Equipment Repair System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Repair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(63, 722);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sign Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "PIECE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Costumer_btn
            // 
            this.Costumer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Costumer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Costumer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Costumer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Costumer_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costumer_btn.ForeColor = System.Drawing.Color.White;
            this.Costumer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Costumer_btn.Location = new System.Drawing.Point(16, 379);
            this.Costumer_btn.Name = "Costumer_btn";
            this.Costumer_btn.Size = new System.Drawing.Size(245, 50);
            this.Costumer_btn.TabIndex = 3;
            this.Costumer_btn.Text = "COSTUMER";
            this.Costumer_btn.UseVisualStyleBackColor = false;
            this.Costumer_btn.Click += new System.EventHandler(this.Costumer_btn_Click);
            // 
            // HOME_btn
            // 
            this.HOME_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.HOME_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.HOME_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.HOME_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btn.ForeColor = System.Drawing.Color.White;
            this.HOME_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btn.Location = new System.Drawing.Point(16, 308);
            this.HOME_btn.Name = "HOME_btn";
            this.HOME_btn.Size = new System.Drawing.Size(245, 49);
            this.HOME_btn.TabIndex = 2;
            this.HOME_btn.Text = "EQUIPEMENT";
            this.HOME_btn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome User";
            // 
            // Exitbtn
            // 
            this.Exitbtn.AutoSize = true;
            this.Exitbtn.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Location = new System.Drawing.Point(974, 9);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(20, 22);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "X";
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.Exitbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(283, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 49);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Costumer_btn);
            this.panel2.Controls.Add(this.HOME_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 785);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Proojet.Properties.Resources.mechanic;
            this.pictureBox6.Location = new System.Drawing.Point(16, 512);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proojet.Properties.Resources.repair_tools;
            this.pictureBox5.Location = new System.Drawing.Point(16, 445);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proojet.Properties.Resources.pc;
            this.pictureBox4.Location = new System.Drawing.Point(12, 307);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proojet.Properties.Resources.shutdown;
            this.pictureBox3.Location = new System.Drawing.Point(16, 722);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proojet.Properties.Resources.customer;
            this.pictureBox2.Location = new System.Drawing.Point(16, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proojet.Properties.Resources.repair;
            this.pictureBox1.Location = new System.Drawing.Point(90, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 39);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 231);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 38);
            this.textBox2.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(322, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 18);
            this.label.TabIndex = 15;
            this.label.Text = "Num_Serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Brand";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID_Client";
            // 
            // btn_search_equipement
            // 
            this.btn_search_equipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btn_search_equipement.FlatAppearance.BorderSize = 0;
            this.btn_search_equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_equipement.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_equipement.ForeColor = System.Drawing.Color.White;
            this.btn_search_equipement.Location = new System.Drawing.Point(704, 637);
            this.btn_search_equipement.Name = "btn_search_equipement";
            this.btn_search_equipement.Size = new System.Drawing.Size(91, 46);
            this.btn_search_equipement.TabIndex = 90;
            this.btn_search_equipement.Text = "Search";
            this.btn_search_equipement.UseVisualStyleBackColor = false;
            this.btn_search_equipement.Click += new System.EventHandler(this.btn_search_costumer_Click);
            // 
            // Btn_delete_equipement
            // 
            this.Btn_delete_equipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Btn_delete_equipement.FlatAppearance.BorderSize = 0;
            this.Btn_delete_equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_delete_equipement.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete_equipement.ForeColor = System.Drawing.Color.White;
            this.Btn_delete_equipement.Location = new System.Drawing.Point(523, 637);
            this.Btn_delete_equipement.Name = "Btn_delete_equipement";
            this.Btn_delete_equipement.Size = new System.Drawing.Size(86, 46);
            this.Btn_delete_equipement.TabIndex = 89;
            this.Btn_delete_equipement.Text = "Delete";
            this.Btn_delete_equipement.UseVisualStyleBackColor = false;
            this.Btn_delete_equipement.Click += new System.EventHandler(this.Btn_delete_equipement_Click);
            // 
            // Btn_update_equipement
            // 
            this.Btn_update_equipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Btn_update_equipement.FlatAppearance.BorderSize = 0;
            this.Btn_update_equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update_equipement.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update_equipement.ForeColor = System.Drawing.Color.White;
            this.Btn_update_equipement.Location = new System.Drawing.Point(416, 637);
            this.Btn_update_equipement.Name = "Btn_update_equipement";
            this.Btn_update_equipement.Size = new System.Drawing.Size(87, 46);
            this.Btn_update_equipement.TabIndex = 88;
            this.Btn_update_equipement.Text = "Update";
            this.Btn_update_equipement.UseVisualStyleBackColor = false;
            this.Btn_update_equipement.Click += new System.EventHandler(this.Btn_update_equipement_Click);
            // 
            // Btn_add_equipement
            // 
            this.Btn_add_equipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Btn_add_equipement.FlatAppearance.BorderSize = 0;
            this.Btn_add_equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_add_equipement.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_add_equipement.ForeColor = System.Drawing.Color.White;
            this.Btn_add_equipement.Location = new System.Drawing.Point(316, 637);
            this.Btn_add_equipement.Name = "Btn_add_equipement";
            this.Btn_add_equipement.Size = new System.Drawing.Size(85, 46);
            this.Btn_add_equipement.TabIndex = 87;
            this.Btn_add_equipement.Text = "ADD";
            this.Btn_add_equipement.UseVisualStyleBackColor = false;
            this.Btn_add_equipement.Click += new System.EventHandler(this.Btn_add_equipement_Click);
            // 
            // equipementsBindingSource
            // 
            this.equipementsBindingSource.DataMember = "Equipements";
            this.equipementsBindingSource.DataSource = this.projeetDataSet;
            // 
            // projeetDataSet
            // 
            this.projeetDataSet.DataSetName = "ProjeetDataSet";
            this.projeetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipementsTableAdapter
            // 
            this.equipementsTableAdapter.ClearBeforeFill = true;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // Num_Ser
            // 
            this.Num_Ser.DataPropertyName = "Num_Ser";
            this.Num_Ser.HeaderText = "Num_Ser";
            this.Num_Ser.MinimumWidth = 6;
            this.Num_Ser.Name = "Num_Ser";
            this.Num_Ser.Width = 125;
            // 
            // DGVEquipement
            // 
            this.DGVEquipement.AutoGenerateColumns = false;
            this.DGVEquipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEquipement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Ser,
            this.brandDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn});
            this.DGVEquipement.DataSource = this.equipementsBindingSource;
            this.DGVEquipement.Location = new System.Drawing.Point(613, 104);
            this.DGVEquipement.Name = "DGVEquipement";
            this.DGVEquipement.RowHeadersWidth = 51;
            this.DGVEquipement.RowTemplate.Height = 24;
            this.DGVEquipement.Size = new System.Drawing.Size(553, 458);
            this.DGVEquipement.TabIndex = 91;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(848, 637);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(318, 46);
            this.textBox3.TabIndex = 92;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 785);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DGVEquipement);
            this.Controls.Add(this.btn_search_equipement);
            this.Controls.Add(this.Btn_delete_equipement);
            this.Controls.Add(this.Btn_update_equipement);
            this.Controls.Add(this.Btn_add_equipement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Costumer_btn;
        private System.Windows.Forms.Button HOME_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search_equipement;
        private System.Windows.Forms.Button Btn_delete_equipement;
        private System.Windows.Forms.Button Btn_update_equipement;
        private System.Windows.Forms.Button Btn_add_equipement;
        private ProjeetDataSet projeetDataSet;
        private System.Windows.Forms.BindingSource equipementsBindingSource;
        private ProjeetDataSetTableAdapters.EquipementsTableAdapter equipementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Ser;
        private System.Windows.Forms.DataGridView DGVEquipement;
        private System.Windows.Forms.TextBox textBox3;
    }
}