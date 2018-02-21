namespace WindowsFormsApplication1.GUI
{
    partial class FormPasswordChange
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmployeeId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(238, 115);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 35);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(114, 75);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeePassword.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password: ";
            // 
            // maskedTextBoxEmployeeId
            // 
            this.maskedTextBoxEmployeeId.Location = new System.Drawing.Point(114, 38);
            this.maskedTextBoxEmployeeId.Mask = "0000000";
            this.maskedTextBoxEmployeeId.Name = "maskedTextBoxEmployeeId";
            this.maskedTextBoxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxEmployeeId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Id: ";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(14, 115);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(92, 35);
            this.buttonLogIn.TabIndex = 8;
            this.buttonLogIn.Text = "Save";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please provide the following information to change your password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Return to Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogIn);
            this.Name = "FormPasswordChange";
            this.Text = "Form Change Password ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}