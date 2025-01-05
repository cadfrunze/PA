using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ticketing_project
{
    public partial class Form1 : Form
    {
        private User user = new User();
        private List<StocBilete> stocBiletes;
        private DateClient dateClient;
        public Form1()
        {
            
            InitializeComponent();
            
            TestingServer();
            
        }

        void TestingServer()
        {
            if (user.Testconn())
            {
                labelMesServer.Visible = false;
                tabControl1.Enabled = true;
            }
            else
            {   
                tabControl1.Enabled = false;
            }
        }

        private string ChangeText
        {
            get;
            set;
        }
        void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                }
                    );
            }
            catch { MessageBox.Show("Nu am putut accesa browserul"); }
        }

        private void clickNext(object sender, EventArgs e)
        {
            user.Name = numeTfn.Text.ToLower().Trim();
            user.Prenom = prenumeTfn.Text.ToLower();
            user.Cnp = cnpTfn.Text.ToString().Trim();
            user.Email = emailTfn.Text.ToLower().Trim();
            user.Telefon = telefonTfn.Text.ToString().Trim();
            user.TipTicket = comboIteme.Text.ToLower();

            if (user.Name.Length > 2 && user.Prenom.Length > 2 && user.Cnp.Length > 2 && user.CkeckCnp() is false && user.Email.Length > 2)
            {
                numeTfn.Enabled = false;
                prenumeTfn.Enabled = false;
                cnpTfn.Enabled = false;
                emailTfn.Enabled = false;
                telefonTfn.Enabled = false;
                panelFinal.Visible = true;
                AfisareBilete();





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
            
        }

        void  AfisareBilete()
        {
            stocBiletes = user.StocuriBilete();
            comboIteme.Items.Clear();


            foreach (var item in stocBiletes)
            {
                comboIteme.Items.Add(item.TipTicket.ToUpper());
            }

            

        }
        private void comboItemeClick(object sender, EventArgs e)
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

      
        
        private void btnPayBilet_Click(object sender, EventArgs e)
        {
            user.TipTicket = comboIteme.Text.ToLower();
            user.NewUser();
            user.CkeckCnp();
            
            panelFinal.Visible = false;
            numeTfn.Enabled = true;
            prenumeTfn.Enabled = true;
            cnpTfn.Enabled = true;
            emailTfn.Enabled = true;
            telefonTfn.Enabled = true;
            ChangeText = "TIP TICKET";
            comboIteme.DisplayMember = comboIteme.Text;

            if (user.CkeckCnp() is true)
            {
                
                MessageBox.Show($"User : {user.Name.ToUpper()} {user.Prenom.ToUpper()} plata efectuata cu succes!");
                labelWait.Visible = false;
                
            }
            else { labelWait.Visible = true; }
            user.TipTicket = ChangeText;
            user.GenerareBon();
            
            
            
            
            
            

        }

        private void pictureFacebook_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.facebook.com/cadfrunze/");

        }

        private void pictureGithub_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/cadfrunze");
        }

        private void labelMesServer_Click(object sender, EventArgs e)
        {
            TestingServer();
        }

        private void btnVerAct_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Trim().Length < 3 || tb2.Text.Trim().Length < 3 || tb3.Text.Trim().Length < 3 || cnptbCheck.Text.Trim().Length < 3)
            {
                MessageBox.Show("ATENTIE LA CAMPURI!");
            }
            else
            {
                string newSerie = tb1.Text.Trim().ToUpper()+tb2.Text.Trim().ToUpper()+tb3.Text.Trim().ToUpper();
                
                dateClient = user.PrelucrareInfo(cnptbCheck.Text.Trim(), newSerie);
                if (dateClient.Cnp != null && dateClient.SerieTicket != null)
                {
                    lbFalse.Visible = false;
                    panelTrue.Visible = true;
                    lbNumePrenumeCheck.Text = $"Client: {dateClient.Nume.ToUpper()} {dateClient.Prenume.ToUpper()}";
                    lbTipicketCheck.Text = $"Tip Ticket: {dateClient.TipTicket.ToUpper()}";
                    lbCnpCheck.Text = $"CNP: {dateClient.Cnp}";
                    lbTipicketCheck.Text = $"Tip Ticket: {dateClient.TipTicket.ToUpper()}";
                    if (dateClient.Validare == "0") 
                        {
                        lbStatusCheck.ForeColor = Color.Red;
                        lbStatusCheck.Text = "STATUS TICKET: NEVALID!";
                        btnActiveazaCheck.Visible = true;
                    }
                    else {
                        lbStatusCheck.ForeColor = Color.Blue;
                        lbStatusCheck.Text = "STATUS TICKET: VALID!"; 
                        }
                    lbserieTicketCheck.Text = $"Serie Ticket: {dateClient.SerieTicket.ToString()}";
                    

                }
                else
                {
                    panelTrue.Visible = false;
                    lbFalse.Visible = true;
                }
            }
        }
    }
}
