
using System;

namespace SignUpDemo
{
    partial class gestion_jouets
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
            this.pho = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.TextBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jouetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boutiqueDataSet = new SignUpDemo.boutiqueDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agemin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.agemax = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.prix = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.idfour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.id1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.recherche = new System.Windows.Forms.Button();
            this.jouetTableAdapter = new SignUpDemo.boutiqueDataSetTableAdapters.jouetTableAdapter();
            this.name2 = new System.Windows.Forms.ComboBox();
            this.type = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jouetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pho
            // 
            this.pho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pho.Location = new System.Drawing.Point(299, 310);
            this.pho.Name = "pho";
            this.pho.Size = new System.Drawing.Size(134, 28);
            this.pho.TabIndex = 43;
            this.pho.Text = "inserer une photo";
            this.pho.UseVisualStyleBackColor = true;
            this.pho.Visible = false;
            this.pho.Click += new System.EventHandler(this.pho_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(1037, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 30);
            this.label9.TabIndex = 45;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(299, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(478, 70);
            this.label10.TabIndex = 46;
            this.label10.Text = "Gestion des jouets";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Crimson;
            this.panelLeft.Controls.Add(this.button8);
            this.panelLeft.Controls.Add(this.button7);
            this.panelLeft.Controls.Add(this.button6);
            this.panelLeft.Controls.Add(this.button5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(151, 697);
            this.panelLeft.TabIndex = 47;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(31, 655);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 30);
            this.button8.TabIndex = 76;
            this.button8.Text = "Home";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 427);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 57);
            this.button7.TabIndex = 75;
            this.button7.Text = "Modifier un jouet";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 60);
            this.button6.TabIndex = 74;
            this.button6.Text = "Ajouter un jouet";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 58);
            this.button5.TabIndex = 73;
            this.button5.Text = "Supprimer un jouet";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(645, 351);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(132, 20);
            this.image.TabIndex = 44;
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(194, 220);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(192, 84);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 42;
            this.photo.TabStop = false;
            this.photo.Visible = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom1,
            this.col1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data.Location = new System.Drawing.Point(505, 197);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 140;
            this.data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data.Size = new System.Drawing.Size(557, 428);
            this.data.TabIndex = 48;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // nom1
            // 
            this.nom1.HeaderText = "nom";
            this.nom1.Name = "nom1";
            // 
            // col1
            // 
            this.col1.HeaderText = "photo";
            this.col1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col1.Name = "col1";
            this.col1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col1.Width = 140;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prix";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id_fournisseur";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "stock";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "type";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jouetBindingSource
            // 
            this.jouetBindingSource.DataMember = "jouet";
            this.jouetBindingSource.DataSource = this.boutiqueDataSet;
            // 
            // boutiqueDataSet
            // 
            this.boutiqueDataSet.DataSetName = "boutiqueDataSet";
            this.boutiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(190, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 19);
            this.label11.TabIndex = 63;
            this.label11.Text = "Type";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label12.Location = new System.Drawing.Point(189, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 61;
            this.label12.Text = "Age min";
            this.label12.Visible = false;
            // 
            // agemin
            // 
            this.agemin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.agemin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.agemin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agemin.HintForeColor = System.Drawing.Color.Empty;
            this.agemin.HintText = "";
            this.agemin.isPassword = false;
            this.agemin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemin.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemin.LineThickness = 3;
            this.agemin.Location = new System.Drawing.Point(311, 416);
            this.agemin.Margin = new System.Windows.Forms.Padding(4);
            this.agemin.Name = "agemin";
            this.agemin.Size = new System.Drawing.Size(122, 29);
            this.agemin.TabIndex = 60;
            this.agemin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.agemin.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label13.Location = new System.Drawing.Point(189, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 59;
            this.label13.Text = "Age max";
            this.label13.Visible = false;
            // 
            // agemax
            // 
            this.agemax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.agemax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.agemax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agemax.HintForeColor = System.Drawing.Color.Empty;
            this.agemax.HintText = "";
            this.agemax.isPassword = false;
            this.agemax.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemax.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemax.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.agemax.LineThickness = 3;
            this.agemax.Location = new System.Drawing.Point(311, 455);
            this.agemax.Margin = new System.Windows.Forms.Padding(4);
            this.agemax.Name = "agemax";
            this.agemax.Size = new System.Drawing.Size(122, 29);
            this.agemax.TabIndex = 58;
            this.agemax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.agemax.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label14.Location = new System.Drawing.Point(189, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 19);
            this.label14.TabIndex = 57;
            this.label14.Text = "Id Fournisseur";
            this.label14.Visible = false;
            // 
            // prix
            // 
            this.prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prix.HintForeColor = System.Drawing.Color.Empty;
            this.prix.HintText = "";
            this.prix.isPassword = false;
            this.prix.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.prix.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.prix.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.prix.LineThickness = 3;
            this.prix.Location = new System.Drawing.Point(311, 488);
            this.prix.Margin = new System.Windows.Forms.Padding(4);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(122, 29);
            this.prix.TabIndex = 56;
            this.prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prix.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label15.Location = new System.Drawing.Point(190, 492);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 19);
            this.label15.TabIndex = 55;
            this.label15.Text = "Prix";
            this.label15.Visible = false;
            // 
            // idfour
            // 
            this.idfour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idfour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idfour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idfour.HintForeColor = System.Drawing.Color.Empty;
            this.idfour.HintText = "";
            this.idfour.isPassword = false;
            this.idfour.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idfour.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idfour.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idfour.LineThickness = 3;
            this.idfour.Location = new System.Drawing.Point(311, 525);
            this.idfour.Margin = new System.Windows.Forms.Padding(4);
            this.idfour.Name = "idfour";
            this.idfour.Size = new System.Drawing.Size(122, 29);
            this.idfour.TabIndex = 54;
            this.idfour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idfour.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label16.Location = new System.Drawing.Point(189, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 19);
            this.label16.TabIndex = 53;
            this.label16.Text = "Nom";
            this.label16.Visible = false;
            // 
            // nom
            // 
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nom.HintForeColor = System.Drawing.Color.Empty;
            this.nom.HintText = "";
            this.nom.isPassword = false;
            this.nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nom.LineThickness = 3;
            this.nom.Location = new System.Drawing.Point(311, 342);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(122, 29);
            this.nom.TabIndex = 52;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nom.Visible = false;
            // 
            // stock
            // 
            this.stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stock.HintForeColor = System.Drawing.Color.Empty;
            this.stock.HintText = "";
            this.stock.isPassword = false;
            this.stock.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.stock.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.stock.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.stock.LineThickness = 3;
            this.stock.Location = new System.Drawing.Point(311, 561);
            this.stock.Margin = new System.Windows.Forms.Padding(4);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(122, 29);
            this.stock.TabIndex = 64;
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stock.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label17.Location = new System.Drawing.Point(189, 571);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 19);
            this.label17.TabIndex = 65;
            this.label17.Text = "Stock";
            this.label17.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(842, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 41);
            this.button2.TabIndex = 67;
            this.button2.Text = "visualizer les jouets";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 68;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(378, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 41);
            this.button3.TabIndex = 69;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(378, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 41);
            this.button4.TabIndex = 70;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id1
            // 
            this.id1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id1.HintForeColor = System.Drawing.Color.Empty;
            this.id1.HintText = "";
            this.id1.isPassword = false;
            this.id1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.id1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.id1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.id1.LineThickness = 3;
            this.id1.Location = new System.Drawing.Point(260, 147);
            this.id1.Margin = new System.Windows.Forms.Padding(4);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(147, 29);
            this.id1.TabIndex = 71;
            this.id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(229, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.Color.Crimson;
            this.recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recherche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.ForeColor = System.Drawing.Color.White;
            this.recherche.Location = new System.Drawing.Point(440, 157);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(139, 34);
            this.recherche.TabIndex = 74;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = false;
            this.recherche.Visible = false;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // jouetTableAdapter
            // 
            this.jouetTableAdapter.ClearBeforeFill = true;
            // 
            // name2
            // 
            this.name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.FormattingEnabled = true;
            this.name2.Location = new System.Drawing.Point(311, 395);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(139, 24);
            this.name2.TabIndex = 76;
            // 
            // type
            // 
            this.type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type.HintForeColor = System.Drawing.Color.Empty;
            this.type.HintText = "";
            this.type.isPassword = false;
            this.type.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.type.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.type.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.type.LineThickness = 3;
            this.type.Location = new System.Drawing.Point(582, 550);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(122, 29);
            this.type.TabIndex = 62;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.type.Visible = false;
            // 
            // gestion_jouets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1074, 697);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.agemin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.agemax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.idfour);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.image);
            this.Controls.Add(this.pho);
            this.Controls.Add(this.photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_jouets";
            this.Text = "gestion_jouets";
            this.Load += new System.EventHandler(this.gestion_jouets_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jouetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boutiqueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private System.Windows.Forms.Button pho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox agemin;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox agemax;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prix;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idfour;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom1;
        private System.Windows.Forms.DataGridViewImageColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button recherche;
        private boutiqueDataSet boutiqueDataSet;
        private System.Windows.Forms.BindingSource jouetBindingSource;
        private boutiqueDataSetTableAdapters.jouetTableAdapter jouetTableAdapter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox name2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox type;
    }
}