using System;
using System.Windows.Forms;

namespace Test_Типограф_
{
    static class Program
    {
        public static Typographer typographer;
        public static Parameters parameters;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Typographer());
        }
    }
}
