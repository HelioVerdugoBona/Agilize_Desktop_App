namespace Agilize
{
    partial class ManageMembers
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
            this.createMembersBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaswordTxtBox = new System.Windows.Forms.TextBox();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.mailTxtBox = new System.Windows.Forms.TextBox();
            this.NicknameTxtBox = new System.Windows.Forms.TextBox();
            this.manageMembersLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.membersofAgilize = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.projectMembers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteMemberbtn = new System.Windows.Forms.Button();
            this.retunBTN = new System.Windows.Forms.Button();
            this.createMembersBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createMembersBox
            // 
            this.createMembersBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.createMembersBox.Controls.Add(this.label1);
            this.createMembersBox.Controls.Add(this.PaswordTxtBox);
            this.createMembersBox.Controls.Add(this.createMemberBtn);
            this.createMembersBox.Controls.Add(this.mailTxtBox);
            this.createMembersBox.Controls.Add(this.NicknameTxtBox);
            this.createMembersBox.Location = new System.Drawing.Point(30, 111);
            this.createMembersBox.Name = "createMembersBox";
            this.createMembersBox.Size = new System.Drawing.Size(351, 313);
            this.createMembersBox.TabIndex = 0;
            this.createMembersBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Create and add a member";
            // 
            // PaswordTxtBox
            // 
            this.PaswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.PaswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswordTxtBox.Location = new System.Drawing.Point(24, 174);
            this.PaswordTxtBox.Name = "PaswordTxtBox";
            this.PaswordTxtBox.ShortcutsEnabled = false;
            this.PaswordTxtBox.Size = new System.Drawing.Size(300, 32);
            this.PaswordTxtBox.TabIndex = 12;
            this.PaswordTxtBox.Text = "Password";
            this.PaswordTxtBox.UseSystemPasswordChar = true;
            this.PaswordTxtBox.Enter += new System.EventHandler(this.PaswordTxtBox_Enter);
            this.PaswordTxtBox.Leave += new System.EventHandler(this.PaswordTxtBox_Leave);
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.createMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createMemberBtn.FlatAppearance.BorderSize = 0;
            this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createMemberBtn.Location = new System.Drawing.Point(24, 254);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(300, 41);
            this.createMemberBtn.TabIndex = 9;
            this.createMemberBtn.Text = "Create and Add";
            this.createMemberBtn.UseVisualStyleBackColor = false;
            this.createMemberBtn.Click += new System.EventHandler(this.createMemberBtn_Click);
            // 
            // mailTxtBox
            // 
            this.mailTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.mailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxtBox.Location = new System.Drawing.Point(24, 64);
            this.mailTxtBox.Name = "mailTxtBox";
            this.mailTxtBox.Size = new System.Drawing.Size(300, 32);
            this.mailTxtBox.TabIndex = 10;
            this.mailTxtBox.Text = "Email";
            this.mailTxtBox.Enter += new System.EventHandler(this.mailTxtBox_Enter);
            this.mailTxtBox.Leave += new System.EventHandler(this.mailTxtBox_Leave);
            // 
            // NicknameTxtBox
            // 
            this.NicknameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.NicknameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameTxtBox.Location = new System.Drawing.Point(24, 116);
            this.NicknameTxtBox.Name = "NicknameTxtBox";
            this.NicknameTxtBox.Size = new System.Drawing.Size(300, 32);
            this.NicknameTxtBox.TabIndex = 11;
            this.NicknameTxtBox.Text = "Nickname";
            this.NicknameTxtBox.Enter += new System.EventHandler(this.NicknameTxtBox_Enter);
            this.NicknameTxtBox.Leave += new System.EventHandler(this.NicknameTxtBox_Leave);
            // 
            // manageMembersLbl
            // 
            this.manageMembersLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.manageMembersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMembersLbl.ForeColor = System.Drawing.Color.White;
            this.manageMembersLbl.Location = new System.Drawing.Point(12, 9);
            this.manageMembersLbl.Name = "manageMembersLbl";
            this.manageMembersLbl.Size = new System.Drawing.Size(369, 55);
            this.manageMembersLbl.TabIndex = 13;
            this.manageMembersLbl.Text = "Manage Members";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.groupBox1.Controls.Add(this.membersofAgilize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addMemberBtn);
            this.groupBox1.Location = new System.Drawing.Point(418, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 313);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // membersofAgilize
            // 
            this.membersofAgilize.FormattingEnabled = true;
            this.membersofAgilize.Location = new System.Drawing.Point(34, 64);
            this.membersofAgilize.Name = "membersofAgilize";
            this.membersofAgilize.Size = new System.Drawing.Size(300, 147);
            this.membersofAgilize.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add a member from Agilize";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.addMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBtn.FlatAppearance.BorderSize = 0;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMemberBtn.Location = new System.Drawing.Point(34, 254);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(300, 41);
            this.addMemberBtn.TabIndex = 9;
            this.addMemberBtn.Text = "Add";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.groupBox2.Controls.Add(this.projectMembers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.deleteMemberbtn);
            this.groupBox2.Location = new System.Drawing.Point(821, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 313);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // projectMembers
            // 
            this.projectMembers.FormattingEnabled = true;
            this.projectMembers.Location = new System.Drawing.Point(30, 64);
            this.projectMembers.Name = "projectMembers";
            this.projectMembers.Size = new System.Drawing.Size(271, 147);
            this.projectMembers.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Delete a project member";
            // 
            // deleteMemberbtn
            // 
            this.deleteMemberbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.deleteMemberbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberbtn.FlatAppearance.BorderSize = 0;
            this.deleteMemberbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemberbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteMemberbtn.Location = new System.Drawing.Point(30, 254);
            this.deleteMemberbtn.Name = "deleteMemberbtn";
            this.deleteMemberbtn.Size = new System.Drawing.Size(271, 41);
            this.deleteMemberbtn.TabIndex = 9;
            this.deleteMemberbtn.Text = "Delete";
            this.deleteMemberbtn.UseVisualStyleBackColor = false;
            this.deleteMemberbtn.Click += new System.EventHandler(this.deleteMemberbtn_Click);
            // 
            // retunBTN
            // 
            this.retunBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.retunBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retunBTN.FlatAppearance.BorderSize = 0;
            this.retunBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retunBTN.Image = global::Agilize.Properties.Resources.returnIMG;
            this.retunBTN.Location = new System.Drawing.Point(1064, 9);
            this.retunBTN.Name = "retunBTN";
            this.retunBTN.Size = new System.Drawing.Size(90, 60);
            this.retunBTN.TabIndex = 18;
            this.retunBTN.UseVisualStyleBackColor = false;
            this.retunBTN.Click += new System.EventHandler(this.retunBTN_Click);
            // 
            // ManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.retunBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manageMembersLbl);
            this.Controls.Add(this.createMembersBox);
            this.Name = "ManageMembers";
            this.Text = "ManageMembers";
            this.createMembersBox.ResumeLayout(false);
            this.createMembersBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createMembersBox;
        private System.Windows.Forms.TextBox PaswordTxtBox;
        private System.Windows.Forms.TextBox NicknameTxtBox;
        private System.Windows.Forms.TextBox mailTxtBox;
        private System.Windows.Forms.Button createMemberBtn;
        private System.Windows.Forms.Label manageMembersLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteMemberbtn;
        private System.Windows.Forms.ListBox membersofAgilize;
        private System.Windows.Forms.ListBox projectMembers;
        private System.Windows.Forms.Button retunBTN;
    }
}