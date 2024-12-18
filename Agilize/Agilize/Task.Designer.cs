namespace Agilize
{
    partial class Task
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
            this.TaskLBL = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.dateCreationLBL = new System.Windows.Forms.Label();
            this.deadLineLBL = new System.Windows.Forms.Label();
            this.currentStateLBL = new System.Windows.Forms.Label();
            this.SprintLBL = new System.Windows.Forms.Label();
            this.estimatedTimeTxtBox = new System.Windows.Forms.TextBox();
            this.estimatedTimeLBL = new System.Windows.Forms.Label();
            this.memebersLBL = new System.Windows.Forms.Label();
            this.deadLineTPicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreationTPicker = new System.Windows.Forms.DateTimePicker();
            this.MembersListBox = new System.Windows.Forms.ListBox();
            this.addMemberBTN = new System.Windows.Forms.Button();
            this.ListedMembersListBox = new System.Windows.Forms.ListBox();
            this.currentSateCBox = new System.Windows.Forms.ComboBox();
            this.sprintNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteMemberBtn = new System.Windows.Forms.Button();
            this.retunBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sprintNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskLBL
            // 
            this.TaskLBL.AutoSize = true;
            this.TaskLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.TaskLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskLBL.ForeColor = System.Drawing.Color.White;
            this.TaskLBL.Location = new System.Drawing.Point(12, 9);
            this.TaskLBL.Name = "TaskLBL";
            this.TaskLBL.Size = new System.Drawing.Size(116, 51);
            this.TaskLBL.TabIndex = 0;
            this.TaskLBL.Text = "Task";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.White;
            this.descriptionLbl.Location = new System.Drawing.Point(12, 73);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(165, 36);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.descriptionTxtBox.Location = new System.Drawing.Point(12, 112);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(490, 640);
            this.descriptionTxtBox.TabIndex = 3;
            this.descriptionTxtBox.Text = "Add a description";
            this.descriptionTxtBox.TextChanged += new System.EventHandler(this.descriptionTxtBox_TextChanged);
            this.descriptionTxtBox.Enter += new System.EventHandler(this.descriptionTxtBox_Enter);
            this.descriptionTxtBox.Leave += new System.EventHandler(this.descriptionTxtBox_Leave);
            // 
            // dateCreationLBL
            // 
            this.dateCreationLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.dateCreationLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreationLBL.Location = new System.Drawing.Point(508, 112);
            this.dateCreationLBL.Name = "dateCreationLBL";
            this.dateCreationLBL.Size = new System.Drawing.Size(146, 30);
            this.dateCreationLBL.TabIndex = 6;
            this.dateCreationLBL.Text = "Date Creation";
            this.dateCreationLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deadLineLBL
            // 
            this.deadLineLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.deadLineLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadLineLBL.Location = new System.Drawing.Point(508, 165);
            this.deadLineLBL.Name = "deadLineLBL";
            this.deadLineLBL.Size = new System.Drawing.Size(146, 30);
            this.deadLineLBL.TabIndex = 8;
            this.deadLineLBL.Text = "Dead Line";
            this.deadLineLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentStateLBL
            // 
            this.currentStateLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.currentStateLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStateLBL.Location = new System.Drawing.Point(508, 222);
            this.currentStateLBL.Name = "currentStateLBL";
            this.currentStateLBL.Size = new System.Drawing.Size(146, 30);
            this.currentStateLBL.TabIndex = 10;
            this.currentStateLBL.Text = "Current Sate";
            this.currentStateLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SprintLBL
            // 
            this.SprintLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.SprintLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SprintLBL.Location = new System.Drawing.Point(508, 282);
            this.SprintLBL.Name = "SprintLBL";
            this.SprintLBL.Size = new System.Drawing.Size(146, 30);
            this.SprintLBL.TabIndex = 12;
            this.SprintLBL.Text = "Sprint";
            this.SprintLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estimatedTimeTxtBox
            // 
            this.estimatedTimeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.estimatedTimeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estimatedTimeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedTimeTxtBox.Location = new System.Drawing.Point(654, 334);
            this.estimatedTimeTxtBox.Name = "estimatedTimeTxtBox";
            this.estimatedTimeTxtBox.Size = new System.Drawing.Size(168, 29);
            this.estimatedTimeTxtBox.TabIndex = 15;
            this.estimatedTimeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estimatedTimeTxtBox.TextChanged += new System.EventHandler(this.estimatedTimeTxtBox_TextChanged);
            // 
            // estimatedTimeLBL
            // 
            this.estimatedTimeLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.estimatedTimeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedTimeLBL.Location = new System.Drawing.Point(508, 334);
            this.estimatedTimeLBL.Name = "estimatedTimeLBL";
            this.estimatedTimeLBL.Size = new System.Drawing.Size(146, 30);
            this.estimatedTimeLBL.TabIndex = 14;
            this.estimatedTimeLBL.Text = "Estimated Time";
            this.estimatedTimeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memebersLBL
            // 
            this.memebersLBL.AutoSize = true;
            this.memebersLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.memebersLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memebersLBL.ForeColor = System.Drawing.Color.White;
            this.memebersLBL.Location = new System.Drawing.Point(508, 384);
            this.memebersLBL.Name = "memebersLBL";
            this.memebersLBL.Size = new System.Drawing.Size(209, 36);
            this.memebersLBL.TabIndex = 16;
            this.memebersLBL.Text = "Task Members";
            // 
            // deadLineTPicker
            // 
            this.deadLineTPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deadLineTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deadLineTPicker.Location = new System.Drawing.Point(654, 165);
            this.deadLineTPicker.MinDate = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            this.deadLineTPicker.MinimumSize = new System.Drawing.Size(4, 30);
            this.deadLineTPicker.Name = "deadLineTPicker";
            this.deadLineTPicker.Size = new System.Drawing.Size(168, 30);
            this.deadLineTPicker.TabIndex = 19;
            this.deadLineTPicker.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.deadLineTPicker.ValueChanged += new System.EventHandler(this.deadLineTPicker_ValueChanged);
            // 
            // dateCreationTPicker
            // 
            this.dateCreationTPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateCreationTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreationTPicker.Location = new System.Drawing.Point(654, 112);
            this.dateCreationTPicker.MinDate = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            this.dateCreationTPicker.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateCreationTPicker.Name = "dateCreationTPicker";
            this.dateCreationTPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateCreationTPicker.Size = new System.Drawing.Size(168, 30);
            this.dateCreationTPicker.TabIndex = 20;
            this.dateCreationTPicker.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            this.dateCreationTPicker.ValueChanged += new System.EventHandler(this.dateCreationTPicker_ValueChanged);
            // 
            // MembersListBox
            // 
            this.MembersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.MembersListBox.FormattingEnabled = true;
            this.MembersListBox.Location = new System.Drawing.Point(508, 602);
            this.MembersListBox.Name = "MembersListBox";
            this.MembersListBox.Size = new System.Drawing.Size(314, 121);
            this.MembersListBox.TabIndex = 21;
            // 
            // addMemberBTN
            // 
            this.addMemberBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.addMemberBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBTN.FlatAppearance.BorderSize = 0;
            this.addMemberBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBTN.ForeColor = System.Drawing.Color.White;
            this.addMemberBTN.Location = new System.Drawing.Point(508, 729);
            this.addMemberBTN.Name = "addMemberBTN";
            this.addMemberBTN.Size = new System.Drawing.Size(314, 23);
            this.addMemberBTN.TabIndex = 22;
            this.addMemberBTN.Text = "Add Member";
            this.addMemberBTN.UseVisualStyleBackColor = false;
            this.addMemberBTN.Click += new System.EventHandler(this.addMemberBTN_Click);
            // 
            // ListedMembersListBox
            // 
            this.ListedMembersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(159)))));
            this.ListedMembersListBox.FormattingEnabled = true;
            this.ListedMembersListBox.Location = new System.Drawing.Point(508, 423);
            this.ListedMembersListBox.Name = "ListedMembersListBox";
            this.ListedMembersListBox.Size = new System.Drawing.Size(314, 134);
            this.ListedMembersListBox.TabIndex = 23;
            // 
            // currentSateCBox
            // 
            this.currentSateCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.currentSateCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentSateCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSateCBox.FormattingEnabled = true;
            this.currentSateCBox.Location = new System.Drawing.Point(654, 221);
            this.currentSateCBox.Name = "currentSateCBox";
            this.currentSateCBox.Size = new System.Drawing.Size(168, 32);
            this.currentSateCBox.TabIndex = 24;
            this.currentSateCBox.SelectedIndexChanged += new System.EventHandler(this.currentSateCBox_SelectedIndexChanged);
            // 
            // sprintNumUpDown
            // 
            this.sprintNumUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.sprintNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprintNumUpDown.Location = new System.Drawing.Point(654, 283);
            this.sprintNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sprintNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sprintNumUpDown.Name = "sprintNumUpDown";
            this.sprintNumUpDown.Size = new System.Drawing.Size(168, 29);
            this.sprintNumUpDown.TabIndex = 25;
            this.sprintNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sprintNumUpDown.ValueChanged += new System.EventHandler(this.sprintNumUpDown_ValueChanged);
            // 
            // deleteMemberBtn
            // 
            this.deleteMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.deleteMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberBtn.FlatAppearance.BorderSize = 0;
            this.deleteMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberBtn.ForeColor = System.Drawing.Color.White;
            this.deleteMemberBtn.Location = new System.Drawing.Point(508, 563);
            this.deleteMemberBtn.Name = "deleteMemberBtn";
            this.deleteMemberBtn.Size = new System.Drawing.Size(314, 23);
            this.deleteMemberBtn.TabIndex = 26;
            this.deleteMemberBtn.Text = "Delete Member";
            this.deleteMemberBtn.UseVisualStyleBackColor = false;
            this.deleteMemberBtn.Click += new System.EventHandler(this.deleteMemberBtn_Click);
            // 
            // retunBTN
            // 
            this.retunBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.retunBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retunBTN.FlatAppearance.BorderSize = 0;
            this.retunBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retunBTN.Image = global::Agilize.Properties.Resources.returnIMG;
            this.retunBTN.Location = new System.Drawing.Point(714, 9);
            this.retunBTN.Name = "retunBTN";
            this.retunBTN.Size = new System.Drawing.Size(90, 60);
            this.retunBTN.TabIndex = 5;
            this.retunBTN.UseVisualStyleBackColor = false;
            this.retunBTN.Click += new System.EventHandler(this.retunBTN_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.deleteMemberBtn);
            this.Controls.Add(this.sprintNumUpDown);
            this.Controls.Add(this.currentSateCBox);
            this.Controls.Add(this.ListedMembersListBox);
            this.Controls.Add(this.addMemberBTN);
            this.Controls.Add(this.MembersListBox);
            this.Controls.Add(this.dateCreationTPicker);
            this.Controls.Add(this.deadLineLBL);
            this.Controls.Add(this.deadLineTPicker);
            this.Controls.Add(this.dateCreationLBL);
            this.Controls.Add(this.currentStateLBL);
            this.Controls.Add(this.SprintLBL);
            this.Controls.Add(this.estimatedTimeLBL);
            this.Controls.Add(this.memebersLBL);
            this.Controls.Add(this.estimatedTimeTxtBox);
            this.Controls.Add(this.retunBTN);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.TaskLBL);
            this.Name = "Task";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.sprintNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskLBL;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.RichTextBox descriptionTxtBox;
        private System.Windows.Forms.Button retunBTN;
        private System.Windows.Forms.Label dateCreationLBL;
        private System.Windows.Forms.Label deadLineLBL;
        private System.Windows.Forms.Label currentStateLBL;
        private System.Windows.Forms.Label SprintLBL;
        private System.Windows.Forms.TextBox estimatedTimeTxtBox;
        private System.Windows.Forms.Label estimatedTimeLBL;
        private System.Windows.Forms.Label memebersLBL;
        private System.Windows.Forms.DateTimePicker deadLineTPicker;
        private System.Windows.Forms.DateTimePicker dateCreationTPicker;
        private System.Windows.Forms.ListBox MembersListBox;
        private System.Windows.Forms.Button addMemberBTN;
        private System.Windows.Forms.ListBox ListedMembersListBox;
        private System.Windows.Forms.ComboBox currentSateCBox;
        private System.Windows.Forms.NumericUpDown sprintNumUpDown;
        private System.Windows.Forms.Button deleteMemberBtn;
    }
}