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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.Show();
            this.Close();
        }
    }
}
