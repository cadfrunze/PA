using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticketing_system.services;

namespace ticketing_system
{
    public partial class Form1 : Form
    {
        private Services services;
        public Form1()
        {
            this.services = new Services();
            InitializeComponent();
        }

        private void tab1TbNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab1TbPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab1TbCnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab1TbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
