
namespace SignUpDemo
{
    partial class abonnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abonnement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.abonner = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(147, 348);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(194, 29);
            this.email.TabIndex = 61;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label17.Location = new System.Drawing.Point(44, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 19);
            this.label17.TabIndex = 66;
            this.label17.Text = "Email :";
            // 
            // abonner
            // 
            this.abonner.BackColor = System.Drawing.Color.White;
            this.abonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abonner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.abonner.Location = new System.Drawing.Point(287, 470);
            this.abonner.Name = "abonner";
            this.abonner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.abonner.Size = new System.Drawing.Size(115, 46);
            this.abonner.TabIndex = 67;
            this.abonner.Text = "s\'abonner";
            this.abonner.UseVisualStyleBackColor = false;
            this.abonner.Click += new System.EventHandler(this.abonner_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.White;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.annuler.Location = new System.Drawing.Point(23, 470);
            this.annuler.Name = "annuler";
            this.annuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.annuler.Size = new System.Drawing.Size(115, 46);
            this.annuler.TabIndex = 68;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 72);
            this.label1.TabIndex = 69;
            this.label1.Text = "Entrez votre adresse Mail pour recevoir \r\nla liste de nos dernies jouets et être " +
    "\r\nparmi les premiers à les achetés ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(377, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 70;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(414, 528);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.abonner);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "abonnement";
            this.Text = "abonnement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button abonner;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}