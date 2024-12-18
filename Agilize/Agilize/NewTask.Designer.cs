namespace Agilize
{
    partial class NewTask
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
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.projectNameTxTBox = new System.Windows.Forms.TextBox();
            this.newTaskLbls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptBtn
            // 
            this.acceptBtn.AutoSize = true;
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.ForeColor = System.Drawing.Color.White;
            this.acceptBtn.Location = new System.Drawing.Point(370, 212);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(94, 38);
            this.acceptBtn.TabIndex = 18;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(477, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 38);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // projectNameTxTBox
            // 
            this.projectNameTxTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameTxTBox.Location = new System.Drawing.Point(22, 112);
            this.projectNameTxTBox.Name = "projectNameTxTBox";
            this.projectNameTxTBox.Size = new System.Drawing.Size(533, 38);
            this.projectNameTxTBox.TabIndex = 16;
            this.projectNameTxTBox.TextChanged += new System.EventHandler(this.projectNameTxTBox_TextChanged);
            // 
            // newTaskLbls
            // 
            this.newTaskLbls.AutoSize = true;
            this.newTaskLbls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.newTaskLbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTaskLbls.ForeColor = System.Drawing.Color.White;
            this.newTaskLbls.Location = new System.Drawing.Point(13, 11);
            this.newTaskLbls.Name = "newTaskLbls";
            this.newTaskLbls.Size = new System.Drawing.Size(213, 51);
            this.newTaskLbls.TabIndex = 15;
            this.newTaskLbls.Text = "New Task";
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.projectNameTxTBox);
            this.Controls.Add(this.newTaskLbls);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox projectNameTxTBox;
        private System.Windows.Forms.Label newTaskLbls;
    }
}