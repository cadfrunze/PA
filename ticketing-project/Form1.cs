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
        public Form1()
        {
            InitializeComponent();
        }

        private void clickNext(object sender, EventArgs e)
        {
            Console.WriteLine($"{numeTfn.Text} {prenumeTfn.Text} {cnpTfn.Text} {emailTfn.Text} {telefonTfn.Text}");
            
        }
    }
}
