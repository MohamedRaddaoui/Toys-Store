
namespace SignUpDemo
{
    partial class listevente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listevente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.id_Commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_Commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p4 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.DateTimePicker();
            this.p3 = new System.Windows.Forms.DateTimePicker();
            this.p1 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.visualiser = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imprimer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.ForeColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 107);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste des ventes ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(746, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Commande,
            this.id_client,
            this.date_Commande,
            this.Montant});
            this.table.Location = new System.Drawing.Point(78, 369);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(643, 192);
            this.table.TabIndex = 62;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // id_Commande
            // 
            this.id_Commande.HeaderText = "N° facture";
            this.id_Commande.Name = "id_Commande";
            this.id_Commande.Width = 150;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "Client";
            this.id_client.Name = "id_client";
            this.id_client.Width = 150;
            // 
            // date_Commande
            // 
            this.date_Commande.HeaderText = "Date";
            this.date_Commande.Name = "date_Commande";
            this.date_Commande.Width = 150;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.Width = 150;
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.Location = new System.Drawing.Point(468, 271);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(16, 18);
            this.p4.TabIndex = 61;
            this.p4.Text = "à";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(259, 271);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(27, 18);
            this.p2.TabIndex = 60;
            this.p2.Text = "De";
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(501, 269);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(161, 20);
            this.p5.TabIndex = 59;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(292, 269);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(161, 20);
            this.p3.TabIndex = 58;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(129, 271);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(124, 18);
            this.p1.TabIndex = 57;
            this.p1.Text = "Choisir période :";
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(236, 239);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(200, 20);
            this.d2.TabIndex = 56;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 576);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 30);
            this.button3.TabIndex = 54;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // visualiser
            // 
            this.visualiser.BackColor = System.Drawing.Color.Green;
            this.visualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualiser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualiser.ForeColor = System.Drawing.Color.White;
            this.visualiser.Location = new System.Drawing.Point(606, 330);
            this.visualiser.Name = "visualiser";
            this.visualiser.Size = new System.Drawing.Size(97, 33);
            this.visualiser.TabIndex = 52;
            this.visualiser.Text = "Visualiser ";
            this.visualiser.UseVisualStyleBackColor = false;
            this.visualiser.Click += new System.EventHandler(this.visualiser_Click);
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(129, 241);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(101, 18);
            this.d1.TabIndex = 55;
            this.d1.Text = "Choisir date :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(236, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 59);
            this.button2.TabIndex = 63;
            this.button2.Text = "Visualiser avec une date";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(446, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 59);
            this.button4.TabIndex = 64;
            this.button4.Text = "Visualiser avec une periode";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imprimer
            // 
            this.imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer.ForeColor = System.Drawing.Color.White;
            this.imprimer.Location = new System.Drawing.Point(624, 576);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(97, 33);
            this.imprimer.TabIndex = 65;
            this.imprimer.Text = "Imprimer";
            this.imprimer.UseVisualStyleBackColor = false;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // listevente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(783, 631);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.visualiser);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "listevente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Form";
            this.Load += new System.EventHandler(this.listevente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.DateTimePicker p5;
        private System.Windows.Forms.DateTimePicker p3;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button visualiser;
        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button imprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_Commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
    }
}