using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRAToMail
{
    static class Program
    {

        #region CONSTS

        public const string APPLICATION_NAME = "FraToMail";

        #endregion


        #region properties

        public static OAuthGmail oAuthGmail = null;

        #endregion



        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin login = new FrmLogin();
            if(login.ShowDialog() != DialogResult.OK )
                return;
            
            Application.Run(new FormMain());
        }
    }
}
