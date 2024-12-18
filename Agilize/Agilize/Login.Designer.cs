namespace Agilize
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.agilizeLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.singUpLbl = new System.Windows.Forms.LinkLabel();
            this.DonAcount = new System.Windows.Forms.Label();
            this.paswordTxTBox = new System.Windows.Forms.TextBox();
            this.usernameTxTBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.LoginBox.Controls.Add(this.agilizeLbl);
            this.LoginBox.Controls.Add(this.pictureBox2);
            this.LoginBox.Controls.Add(this.singUpLbl);
            this.LoginBox.Controls.Add(this.DonAcount);
            this.LoginBox.Controls.Add(this.paswordTxTBox);
            this.LoginBox.Controls.Add(this.usernameTxTBox);
            this.LoginBox.Controls.Add(this.LoginBtn);
            this.LoginBox.Location = new System.Drawing.Point(621, 0);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(643, 765);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.TabStop = false;
            // 
            // agilizeLbl
            // 
            this.agilizeLbl.AutoSize = true;
            this.agilizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agilizeLbl.Location = new System.Drawing.Point(306, 732);
            this.agilizeLbl.Name = "agilizeLbl";
            this.agilizeLbl.Size = new System.Drawing.Size(55, 20);
            this.agilizeLbl.TabIndex = 8;
            this.agilizeLbl.Text = "Agilize";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 103);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // singUpLbl
            // 
            this.singUpLbl.AutoSize = true;
            this.singUpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singUpLbl.LinkColor = System.Drawing.Color.Black;
            this.singUpLbl.Location = new System.Drawing.Point(385, 663);
            this.singUpLbl.Name = "singUpLbl";
            this.singUpLbl.Size = new System.Drawing.Size(138, 37);
            this.singUpLbl.TabIndex = 4;
            this.singUpLbl.TabStop = true;
            this.singUpLbl.Text = "Sign Up";
            this.singUpLbl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.singUpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SingUpLbl_LinkClicked);
            // 
            // DonAcount
            // 
            this.DonAcount.AutoSize = true;
            this.DonAcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonAcount.Location = new System.Drawing.Point(102, 663);
            this.DonAcount.Name = "DonAcount";
            this.DonAcount.Size = new System.Drawing.Size(292, 37);
            this.DonAcount.TabIndex = 3;
            this.DonAcount.Text = "Don\'t have acount?";
            // 
            // paswordTxTBox
            // 
            this.paswordTxTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.paswordTxTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paswordTxTBox.Location = new System.Drawing.Point(21, 369);
            this.paswordTxTBox.Name = "paswordTxTBox";
            this.paswordTxTBox.Size = new System.Drawing.Size(611, 51);
            this.paswordTxTBox.TabIndex = 2;
            this.paswordTxTBox.Text = "Password";
            this.paswordTxTBox.UseSystemPasswordChar = true;
            this.paswordTxTBox.Enter += new System.EventHandler(this.paswordTxTBox_Enter);
            this.paswordTxTBox.Leave += new System.EventHandler(this.paswordTxTBox_Leave);
            // 
            // usernameTxTBox
            // 
            this.usernameTxTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.usernameTxTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxTBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTxTBox.Location = new System.Drawing.Point(21, 274);
            this.usernameTxTBox.Name = "usernameTxTBox";
            this.usernameTxTBox.Size = new System.Drawing.Size(611, 51);
            this.usernameTxTBox.TabIndex = 1;
            this.usernameTxTBox.Text = "Nickname";
            this.usernameTxTBox.Enter += new System.EventHandler(this.usernameTxTBox_Enter);
            this.usernameTxTBox.Leave += new System.EventHandler(this.usernameTxTBox_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Location = new System.Drawing.Point(231, 548);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(192, 58);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 765);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.LinkLabel singUpLbl;
        private System.Windows.Forms.Label DonAcount;
        private System.Windows.Forms.TextBox paswordTxTBox;
        private System.Windows.Forms.TextBox usernameTxTBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label agilizeLbl;
    }
}

