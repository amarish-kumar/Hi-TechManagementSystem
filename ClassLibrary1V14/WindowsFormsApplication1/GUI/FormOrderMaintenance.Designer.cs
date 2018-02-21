namespace WindowsFormsApplication1.GUI
{
    partial class FormOrderMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderMaintenance));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrderBook = new System.Windows.Forms.Button();
            this.buttonOrderSoftware = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create an order for:";
            // 
            // buttonOrderBook
            // 
            this.buttonOrderBook.Location = new System.Drawing.Point(25, 112);
            this.buttonOrderBook.Name = "buttonOrderBook";
            this.buttonOrderBook.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderBook.TabIndex = 1;
            this.buttonOrderBook.Text = "Book";
            this.buttonOrderBook.UseVisualStyleBackColor = true;
            this.buttonOrderBook.Click += new System.EventHandler(this.buttonOrderBook_Click);
            // 
            // buttonOrderSoftware
            // 
            this.buttonOrderSoftware.Location = new System.Drawing.Point(122, 112);
            this.buttonOrderSoftware.Name = "buttonOrderSoftware";
            this.buttonOrderSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderSoftware.TabIndex = 2;
            this.buttonOrderSoftware.Text = "Software";
            this.buttonOrderSoftware.UseVisualStyleBackColor = true;
            this.buttonOrderSoftware.Click += new System.EventHandler(this.buttonOrderSoftware_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(122, 153);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormOrderMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 191);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOrderSoftware);
            this.Controls.Add(this.buttonOrderBook);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderMaintenance";
            this.Text = "FormOrderMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrderBook;
        private System.Windows.Forms.Button buttonOrderSoftware;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonExit;
    }
}