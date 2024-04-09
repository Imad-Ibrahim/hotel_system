using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLayer;
using BusinessEntities;

namespace WindowsClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDataLayer _Datalayer = DataLayer.GetInstance();
            IModel _Model = Model.GetInstance(_Datalayer);

            Application.Run(new formContainer(_Model));
            //Application.Run(new LoginForm());

        }      
    }
}
