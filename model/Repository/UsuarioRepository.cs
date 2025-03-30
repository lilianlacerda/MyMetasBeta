using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetasBeta.Model.Repository
{
    class UsuarioRepository
    {
        private readonly BancoDeDados _banco;

        public UsuarioRepository(BancoDeDados banco)
        {
            _banco = banco;
        }

        public void CadastrarUsuario(Usuario novoUsuario)
        {
            string sql = $@"INSERT INTO usuarios(nome, login, senha) VALUES ('{novoUsuario.Nome}', '{novoUsuario.Login}', '{novoUsuario.Senha}')";

            _banco.ExecutarComando(sql);
        }
    }
}
