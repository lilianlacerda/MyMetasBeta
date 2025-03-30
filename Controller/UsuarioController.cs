using MyMetasBeta.Model;
using MyMetasBeta.Model.Repository;
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

        public bool CadastrarUsuario(string nome, string login, string senha)
        {
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Login = login,
                Senha = senha
            };

            try
            {
                _usuarioRepository.CadastrarUsuario(usuario);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
