using MyMetasBeta.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetasBeta
{
    static class Program
    {
        /// <summary>0
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Home home = new Home();
            Teste teste = new Teste();

            Application.Run(new TelaCadastro());

            if (teste.IsDisposed)
            {
                Application.Run(home);
            }
        }
    }
}
