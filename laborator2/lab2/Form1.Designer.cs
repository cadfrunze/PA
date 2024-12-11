namespace lab2
{
    partial class Form1
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
            this.apasaBtn = new System.Windows.Forms.Button();
            this.labelTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apasaBtn
            // 
            this.apasaBtn.BackColor = System.Drawing.Color.Red;
            this.apasaBtn.Location = new System.Drawing.Point(209, 107);
            this.apasaBtn.Name = "apasaBtn";
            this.apasaBtn.Size = new System.Drawing.Size(205, 44);
            this.apasaBtn.TabIndex = 0;
            this.apasaBtn.Text = "Apasa-ma!";
            this.apasaBtn.UseVisualStyleBackColor = false;
            this.apasaBtn.Click += new System.EventHandler(this.btnClick);

            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Location = new System.Drawing.Point(206, 187);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(89, 16);
            this.labelTxt.TabIndex = 1;
            this.labelTxt.Text = "Ai apasat de: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.apasaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apasaBtn;
        private System.Windows.Forms.Label labelTxt;
    }
}

