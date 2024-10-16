using EmployeeNamespace;
using System.Windows.Forms;
using System;

namespace Employee_application
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new frmEmployeeDatabase());
        }
    }

}