namespace WindowsFormsApplication1.GUI
{
    partial class FormLogIn
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmployeeId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(44, 152);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(92, 35);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please provide the following information to log in:";
            // 
            // maskedTextBoxEmployeeId
            // 
            this.maskedTextBoxEmployeeId.Location = new System.Drawing.Point(118, 52);
            this.maskedTextBoxEmployeeId.Mask = "0000000";
            this.maskedTextBoxEmployeeId.Name = "maskedTextBoxEmployeeId";
            this.maskedTextBoxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxEmployeeId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password: ";
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(118, 89);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeePassword.TabIndex = 6;
            this.textBoxEmployeePassword.TextChanged += new System.EventHandler(this.textBoxEmployeePassword_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(175, 152);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 35);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(112, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forgot your password?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxEmployeeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogIn);
            this.Name = "FormLogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
    }
}