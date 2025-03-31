using System;
using System.Collections.Generic;
using System.Data;
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

        public bool CadastroExistente(string login)
        {
            string sql = $@"SELECT COUNT(1) FROM usuarios WHERE login = {login} LIMIT 1";

            DataTable resultado = _banco.ExecutarConsultas(sql);
            //O Rows.Count indica quantos registros foram encontrados. Se for 0, seginifica que a consulta não encontrou resultados.
            return resultado.Rows.Count > 0;
        }

        public bool LoginUsuario(string login, string senha)
        {
            string sql = $@"SELECT COUNT(1) FROM usuarios WHERE login = {login} AND senha = {senha} LIMIT 1";
            DataTable resultado = _banco.ExecutarConsultas(sql);
            return resultado.Rows.Count > 0;
        }
    }
}
