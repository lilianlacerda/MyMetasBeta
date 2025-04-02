using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetasBeta.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        Usuario FromDataTable(DataTable dataTable)
        {
            return (

                new Usuario
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]),
                    Nome = dataTable.Rows[0]["nome"].ToString(),
                    Login = dataTable.Rows[0]["login"].ToString(),
                    Senha = dataTable.Rows[0]["senha"].ToString()
                }

                );

        }


    }

    

}
