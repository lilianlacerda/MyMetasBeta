using MyMetasBeta.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetasBeta
{
    public partial class TelaLogin: Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TelaCadastro().Show();
        }
    }
}
