using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            ScreenSaver screenSaver = new ScreenSaver();
            DateTime endTime = DateTime.Now + TimeSpan.FromSeconds(2);
            screenSaver.Show();
            
            while (endTime > DateTime.Now)
            {
                Application.DoEvents();
            }
            screenSaver.Close();
            screenSaver.Dispose();

            Application.Run(new StartInfo());
        }
    }
}
