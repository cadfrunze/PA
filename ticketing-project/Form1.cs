using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void clickNext(object sender, EventArgs e)
        {
            user.Name = numeTfn.Text.ToLower().Trim();
            user.Prenom = prenumeTfn.Text.ToLower().Trim();
            user.Cnp = cnpTfn.Text.ToString().Trim();
            user.Email = emailTfn.Text.ToLower().Trim();
            user.Telefon = telefonTfn.Text.ToString().Trim();
            user.NewUser();
            //Console.WriteLine(user.Response);
            if (user.Response is false)
            {

            }
            else { MessageBox.Show($"Acest CNP {user.Cnp} exista in baza de date"); }
            
        }
    }
}
