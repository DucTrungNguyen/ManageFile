using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubmitFile
{
    public static class Switcher
    {
        public static frmLogin frmlogin;

        public static void Switch(UserControl newPage)
        {
            frmlogin.Navigate(newPage);
        }

        public static void Switch(UserControl newPage, object state)
        {
            frmlogin.Navigate(newPage, state);
        }

        public static void Close(Boolean isClose)
        {
            if (isClose)
                frmlogin.Close();
        }
    }
}
