using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ticketing_project.DataBase;


namespace ticketing_project
{
    public partial class Form1 : Form
    {
        private Services srv;
        private List<StocBilete> stocBilete;
        private DateClient dateClient;
        private Tools tools;
        private string prelucratSerie;


        public Form1()
        {
            
            InitializeComponent();
            
            TestingServer();
            this.srv = new Services();
            this.tools = new Tools();
           
            

        }
//----------------------DEASUPRA PANOULUI--------------------------------------------
        void TestingServer()
        {   
            DbAcess dbAcess = new DbAcess();
            if (dbAcess.Testconn())
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

//-----------------------TAB 1 (BUY TICKET!)----------------------------------------------
        private void clickNext(object sender, EventArgs e)
        {
            this.srv.Name = numeTfn.Text.ToLower().Trim();
            this.srv.Prenom = prenumeTfn.Text.ToLower();
            this.srv.Cnp = cnpTfn.Text.ToString().Trim();
            this.srv.Email = emailTfn.Text.ToLower().Trim();
            this.srv.Telefon = telefonTfn.Text.ToString().Trim();
            this.srv.TipTicket = comboIteme.Text.ToLower();

            if (this.srv.Name.Length > 2 && this.srv.Prenom.Length > 2 && this.srv.Cnp.Length > 2 && this.srv.CkeckCnp() is false && this.srv.Email.Length > 2)
            {
                numeTfn.Enabled = false;
                prenumeTfn.Enabled = false;
                cnpTfn.Enabled = false;
                emailTfn.Enabled = false;
                telefonTfn.Enabled = false;
                panelFinal.Visible = true;
                AfisareBilete();





            }
            else if (this.srv.CkeckCnp() is true) { MessageBox.Show($"Acest CNP {this.srv.Cnp} exista in baza de date"); }
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
            this.stocBilete = this.srv.StocuriBilete();
            comboIteme.Items.Clear();
            foreach(var item in this.stocBilete)
            {
                Console.WriteLine(item.Cantitate);
            }


            foreach (var item in this.stocBilete)
            {
                comboIteme.Items.Add(item.TipTicket.ToUpper());
            }

            

        }
        private void comboItemeClick(object sender, EventArgs e)
        {
            if (comboIteme.Text.ToLower() == "premium" || comboIteme.Text.ToLower() == "mid" || comboIteme.Text.ToLower() == "sarac")
            {
                foreach (var item in this.stocBilete)
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
            this.srv.TipTicket = comboIteme.Text.ToLower();
            this.srv.NewUser();
            this.srv.CkeckCnp();
            
            panelFinal.Visible = false;
            numeTfn.Enabled = true;
            prenumeTfn.Enabled = true;
            cnpTfn.Enabled = true;
            emailTfn.Enabled = true;
            telefonTfn.Enabled = true;
            ChangeText = "TIP TICKET";
            comboIteme.DisplayMember = comboIteme.Text;

            if (this.srv.CkeckCnp() is true)
            {
                
                MessageBox.Show($"User : {this.srv.Name.ToUpper()} {this.srv.Prenom.ToUpper()} plata efectuata cu succes!");
                labelWait.Visible = false;
                
            }
            else { labelWait.Visible = true; }
            this.srv.TipTicket = ChangeText;
            this.srv.GenerareBon();
            
            
            
            
            
            

        }

//----------------------ACTIVATE LINKS------------------------------------------------------------
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
//-----------------------------TAB2 (ACTIVATE)-------------------------------------------------------
        private void btnVerAct_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Trim().Length < 3 || tb2.Text.Trim().Length < 3 || tb3.Text.Trim().Length < 3 || cnptbCheck.Text.Trim().Length < 3)
            {
                MessageBox.Show("ATENTIE LA CAMPURI!");
            }
            else
            {
                string newSerie = tb1.Text.Trim().ToUpper()+tb2.Text.Trim().ToUpper()+tb3.Text.Trim().ToUpper();
                
                dateClient = this.srv.PrelucrareInfo(cnptbCheck.Text.Trim(), newSerie);
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

        private void btnActiveazaCheck_Click(object sender, EventArgs e)
        {
            string newSerie = tb1.Text.Trim().ToUpper() + tb2.Text.Trim().ToUpper() + tb3.Text.Trim().ToUpper();
            dateClient = this.srv.PrelucareInfoValidare(newSerie);
            if (dateClient.Validare == "1")
            {
                lbStatusCheck.ForeColor = Color.Blue;
                lbStatusCheck.Text = "STATUS TICKET: VALID!";
                btnActiveazaCheck.Visible = false;

            }
        }


// -----------------------Tab3 (Edit)--------------------------------------------------------

        private void AfisarePanouTab3()
        {
            this.prelucratSerie = tools.prelucrareSerieTicket(tab3TbSt1.Text.Trim() + tab3TbSt2.Text.Trim() + tab3TbSt3.Text.Trim());
            if (this.dateClient.SerieTicket == this.prelucratSerie && this.dateClient.Cnp == tab3TbCnp.Text.Trim())
            {
                tab3LbCredential.Visible = false;
                tab3Panel.Visible = true;
                tab3LbNume.Text = $"Nume: {dateClient.Nume.ToUpper()}";
                tab3LbPrenume.Text = $"Prenume: {dateClient.Prenume.ToUpper()}";
                tab3LbBilet.Text = $"Tip bilet: {dateClient.TipTicket}";
                tab3TbEmail.Text = dateClient.Email;
                tab3TbTelefon.Text = dateClient.Telefon;

            }
            else {
                tab3LbCredential.Visible = true;
                tab3Panel.Visible = false;
                tab3LbCredential.Text = "Client Neinnregistrat!"; 
            }
        }
        private void tab3TbSt1_TextChanged(object sender, EventArgs e)
        {
            this.prelucratSerie = tab3TbSt1.Text.Trim() + tab3TbSt2.Text.Trim() + tab3TbSt3.Text.Trim();

            this.dateClient = this.srv.PrelucrareInfo(tab3TbCnp.Text.Trim(), prelucratSerie);
            AfisarePanouTab3();
        }

        private void tab3TbSt2_TextChanged(object sender, EventArgs e)
        {
            this.prelucratSerie = tab3TbSt1.Text.Trim() + tab3TbSt2.Text.Trim() + tab3TbSt3.Text.Trim();
            this.dateClient = this.srv.PrelucrareInfo(tab3TbCnp.Text.Trim(), prelucratSerie);
            AfisarePanouTab3();
        }

        private void tab3TbSt3_TextChanged(object sender, EventArgs e)
        {
            this.prelucratSerie = tab3TbSt1.Text.Trim() + tab3TbSt2.Text.Trim() + tab3TbSt3.Text.Trim();
            this.dateClient = this.srv.PrelucrareInfo(tab3TbCnp.Text.Trim(), prelucratSerie);
            AfisarePanouTab3();
        }

        private void tab3TbCnp_TextChanged(object sender, EventArgs e)
        {
            this.prelucratSerie = tab3TbSt1.Text.Trim() + tab3TbSt2.Text.Trim() + tab3TbSt3.Text.Trim();
            this.dateClient = this.srv.PrelucrareInfo(tab3TbCnp.Text.Trim(), prelucratSerie);
            AfisarePanouTab3();
        }

        private void tab3ButSave_Click(object sender, EventArgs e)
        {
            dateClient.Email = tab3TbEmail.Text.Trim();
            dateClient.Telefon = tab3TbTelefon.Text.Trim();
            this.srv.UpdateClient(dateClient);
            tab3Panel.Visible = false;
            MessageBox.Show("Date actualizate!");
            AfisarePanouTab3();
        }

        private void tab3ButDelete_Click(object sender, EventArgs e)
        {   

            this.srv.DeleteClient(dateClient);
            tab3Panel.Visible = false;
            MessageBox.Show("Client sters cu succes!");
            tab3TbSt1.Text = "";
            tab3TbSt2.Text = "";
            tab3TbSt3.Text = "";
            tab3TbCnp.Text = "";
        }
    }
}
