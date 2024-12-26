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
            user.Name = numeTfn.Text.ToLower();
            user.Prenom = prenumeTfn.Text.ToLower();
            user.Register();
            
        }
    }
}
