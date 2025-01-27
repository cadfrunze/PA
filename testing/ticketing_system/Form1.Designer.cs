using ticketing_system.services;

namespace ticketing_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab1Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tab1LbCantitate = new System.Windows.Forms.Label();
            this.tab1LbPretBuc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab1ComboTickets = new System.Windows.Forms.ComboBox();
            this.tab1LbCredential = new System.Windows.Forms.Label();
            this.tab1TbTelefon = new System.Windows.Forms.TextBox();
            this.tab1TbEmail = new System.Windows.Forms.TextBox();
            this.tab1TbCnp = new System.Windows.Forms.TextBox();
            this.tab1TbPrenume = new System.Windows.Forms.TextBox();
            this.tab1TbNume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(331, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powered by Cadfrunze";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab1);
            this.tab.Controls.Add(this.tab2);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(8, 46);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(989, 499);
            this.tab.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label11);
            this.tab1.Controls.Add(this.label10);
            this.tab1.Controls.Add(this.label9);
            this.tab1.Controls.Add(this.label8);
            this.tab1.Controls.Add(this.tab1Panel);
            this.tab1.Controls.Add(this.tab1LbCredential);
            this.tab1.Controls.Add(this.tab1TbTelefon);
            this.tab1.Controls.Add(this.tab1TbEmail);
            this.tab1.Controls.Add(this.tab1TbCnp);
            this.tab1.Controls.Add(this.tab1TbPrenume);
            this.tab1.Controls.Add(this.tab1TbNume);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(4, 38);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(981, 457);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Buy Ticket";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab1Panel
            // 
            this.tab1Panel.Controls.Add(this.button1);
            this.tab1Panel.Controls.Add(this.tab1LbCantitate);
            this.tab1Panel.Controls.Add(this.tab1LbPretBuc);
            this.tab1Panel.Controls.Add(this.label7);
            this.tab1Panel.Controls.Add(this.tab1ComboTickets);
            this.tab1Panel.Location = new System.Drawing.Point(490, 6);
            this.tab1Panel.Name = "tab1Panel";
            this.tab1Panel.Size = new System.Drawing.Size(485, 445);
            this.tab1Panel.TabIndex = 11;
            this.tab1Panel.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(125, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Plateste: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tab1LbCantitate
            // 
            this.tab1LbCantitate.AutoSize = true;
            this.tab1LbCantitate.Location = new System.Drawing.Point(263, 178);
            this.tab1LbCantitate.Name = "tab1LbCantitate";
            this.tab1LbCantitate.Size = new System.Drawing.Size(130, 29);
            this.tab1LbCantitate.TabIndex = 3;
            this.tab1LbCantitate.Text = "Cantitate: ";
            // 
            // tab1LbPretBuc
            // 
            this.tab1LbPretBuc.AutoSize = true;
            this.tab1LbPretBuc.Location = new System.Drawing.Point(37, 178);
            this.tab1LbPretBuc.Name = "tab1LbPretBuc";
            this.tab1LbPretBuc.Size = new System.Drawing.Size(127, 29);
            this.tab1LbPretBuc.TabIndex = 2;
            this.tab1LbPretBuc.Text = "Pret/bilet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Selecteaza tip Ticket";
            // 
            // tab1ComboTickets
            // 
            this.tab1ComboTickets.FormattingEnabled = true;
            this.tab1ComboTickets.Location = new System.Drawing.Point(162, 56);
            this.tab1ComboTickets.Name = "tab1ComboTickets";
            this.tab1ComboTickets.Size = new System.Drawing.Size(216, 37);
            this.tab1ComboTickets.TabIndex = 0;
            // 
            // tab1LbCredential
            // 
            this.tab1LbCredential.AutoSize = true;
            this.tab1LbCredential.ForeColor = System.Drawing.Color.Red;
            this.tab1LbCredential.Location = new System.Drawing.Point(29, 283);
            this.tab1LbCredential.Name = "tab1LbCredential";
            this.tab1LbCredential.Size = new System.Drawing.Size(0, 29);
            this.tab1LbCredential.TabIndex = 10;
            // 
            // tab1TbTelefon
            // 
            this.tab1TbTelefon.Location = new System.Drawing.Point(159, 216);
            this.tab1TbTelefon.Name = "tab1TbTelefon";
            this.tab1TbTelefon.Size = new System.Drawing.Size(223, 34);
            this.tab1TbTelefon.TabIndex = 9;
            // 
            // tab1TbEmail
            // 
            this.tab1TbEmail.Location = new System.Drawing.Point(159, 168);
            this.tab1TbEmail.Name = "tab1TbEmail";
            this.tab1TbEmail.Size = new System.Drawing.Size(223, 34);
            this.tab1TbEmail.TabIndex = 8;
            this.tab1TbEmail.TextChanged += new System.EventHandler(this.tab1TbEmail_TextChanged);
            // 
            // tab1TbCnp
            // 
            this.tab1TbCnp.Location = new System.Drawing.Point(159, 128);
            this.tab1TbCnp.Name = "tab1TbCnp";
            this.tab1TbCnp.Size = new System.Drawing.Size(223, 34);
            this.tab1TbCnp.TabIndex = 7;
            this.tab1TbCnp.TextChanged += new System.EventHandler(this.tab1TbCnp_TextChanged);
            // 
            // tab1TbPrenume
            // 
            this.tab1TbPrenume.Location = new System.Drawing.Point(159, 78);
            this.tab1TbPrenume.Name = "tab1TbPrenume";
            this.tab1TbPrenume.Size = new System.Drawing.Size(223, 34);
            this.tab1TbPrenume.TabIndex = 6;
            this.tab1TbPrenume.TextChanged += new System.EventHandler(this.tab1TbPrenume_TextChanged);
            // 
            // tab1TbNume
            // 
            this.tab1TbNume.Location = new System.Drawing.Point(159, 30);
            this.tab1TbNume.Name = "tab1TbNume";
            this.tab1TbNume.Size = new System.Drawing.Size(223, 34);
            this.tab1TbNume.TabIndex = 5;
            this.tab1TbNume.TextChanged += new System.EventHandler(this.tab1TbNume_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume";
            // 
            // tab2
            // 
            this.tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Location = new System.Drawing.Point(4, 38);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(981, 457);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Activate!";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(397, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(397, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(397, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(397, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 557);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab1Panel.ResumeLayout(false);
            this.tab1Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tab1TbNume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tab1TbTelefon;
        private System.Windows.Forms.TextBox tab1TbEmail;
        private System.Windows.Forms.TextBox tab1TbCnp;
        private System.Windows.Forms.TextBox tab1TbPrenume;
        private System.Windows.Forms.Panel tab1Panel;
        private System.Windows.Forms.Label tab1LbCredential;
        private System.Windows.Forms.ComboBox tab1ComboTickets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tab1LbPretBuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tab1LbCantitate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

