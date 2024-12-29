﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ticketing_project
{
    public partial class Form1 : Form
    {
        private User user = new User();
        private List<StocBilete> stocBiletes;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private string ChangeText
        {
            get;
            set;
        }

        private void clickNext(object sender, EventArgs e)
        {
            user.Name = numeTfn.Text.ToLower().Trim();
            user.Prenom = prenumeTfn.Text.ToLower().Trim();
            user.Cnp = cnpTfn.Text.ToString().Trim();
            user.Email = emailTfn.Text.ToLower().Trim();
            user.Telefon = telefonTfn.Text.ToString().Trim();

            if (user.Name.Length > 2 && user.Prenom.Length > 2 && user.Cnp.Length > 2 && user.CkeckCnp() is false && user.Email.Length > 2)
            {
                numeTfn.Enabled = false;
                prenumeTfn.Enabled = false;
                cnpTfn.Enabled = false;
                emailTfn.Enabled = false;
                telefonTfn.Enabled = false;
                panelFinal.Visible = true;




            }
            else if (user.CkeckCnp() is true) { MessageBox.Show($"Acest CNP {user.Cnp} exista in baza de date"); }
            else { MessageBox.Show("Atentie la completare campuri!"); }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelFinal.Visible = false;
            numeTfn.Enabled = true;
            prenumeTfn.Enabled = true;
            cnpTfn.Enabled = true;
            emailTfn.Enabled = true;
            telefonTfn.Enabled = true;
            ChangeText = "TIP TICKET";
            comboIteme.DisplayMember = comboIteme.Text;
        }

        private void comboIteme_Click(object sender, EventArgs e)
        {
            
            stocBiletes = user.StocuriBilete();
            comboIteme.Items.Clear();
            
            
            foreach (var item in this.stocBiletes)
            {
                comboIteme.Items.Add(item.TipTicket.ToUpper());
            }
            

        }
        private void comboIteme_AfisPanou(object sender, EventArgs e)
        {
            if (comboIteme.Text.ToLower() == "premium" || comboIteme.Text.ToLower() == "mid" || comboIteme.Text.ToLower() == "sarac")
            {
                foreach (var item in stocBiletes)
                {
                    if (comboIteme.Text.ToLower() == item.TipTicket)
                    {
                        lbPret.Text = $"Pret bilet: {item.Pret}";
                        lbCantitateBilete.Text = $"Nr. bilete ramase: {item.Cantitate}";
                        btnPayBilet.Text = $"Plateste {item.Pret} lei!";
                        pnBilet.Visible = true;
                        break;
                    }
                    else { pnBilet.Visible = false; }
                    
                }
            }
            
        }
    }
}
