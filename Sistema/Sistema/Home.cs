using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Home : Form
    {
        UsuarioTO usuario { get; set; }
        public Home(UsuarioTO usuarioT)
        {
            InitializeComponent();

            usuario = usuarioT;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login c = new Login();
            c.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
