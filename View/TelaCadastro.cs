using MyMetasBeta.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetasBeta.View
{
    public partial class TelaCadastro: Form
    {
        private readonly UsuarioController _usuarioController;
        public TelaCadastro()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void btnConcluirCadastro_Click(object sender, EventArgs e)
        {
            bool sucesso = _usuarioController.CadastrarUsuario(
                textBoxNome.Text,
                textBoxLogin.Text,
                textBoxSenha.Text,
                textBoxConfirmacaoSenha.Text);

            bool validacao = _usuarioController.ValidarCadastro(
                textBoxLogin.Text,
                textBoxSenha.Text,
                textBoxConfirmacaoSenha.Text);

            if (validacao)
            {
                MessageBox.Show("Usuario não cadastrado");
            }
            if (sucesso)
            {
                MessageBox.Show("Usuario cadastrado com sucesso!", "Cadastro concluido");
                this.Close();
                new TelaLogin().Show();
            }
            else
            {
                MessageBox.Show("Erro ao efetuar o cadastro.");
            }
        }
    }
}
