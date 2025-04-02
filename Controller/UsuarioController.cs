using MyMetasBeta.Model;
using MyMetasBeta.Model.Repository;
using MyMetasBeta.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetasBeta.Controller
{
    class UsuarioController
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository(new Model.BancoDeDados());
        }

        public bool CadastrarUsuario(string nome, string login, string senha, string confirmacaoSenha)
        {

            Usuario usuario = new Usuario
            {
                Nome = nome,
                Login = login,
                Senha = senha
            };

            return _usuarioRepository.CadastrarUsuario(usuario);
        }

        public bool ValidarCadastro(string senha, string confirmacaoSenha, string login)
        {
            if (senha != confirmacaoSenha)
            {
                return false;
            }

            if (_usuarioRepository.CadastroExistente(login))
            {
                return false;
            }

            try
            {
                _usuarioRepository.CadastroExistente(login);
                return true;
            }
            catch
            {
                return false;
            }

        }

        //public bool ValidarLogin(string login, string senha)
        //{
        //    if (_usuarioRepository.LoginUsuario()) ;
        //}
    }
}
