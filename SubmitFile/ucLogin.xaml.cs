﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SubmitFile
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        private void BtnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Password.ToString();

            try
            {
                SHA1CryptoServiceProvider sha512 = new SHA1CryptoServiceProvider();

                byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
                bs = sha512.ComputeHash(bs);
                System.Text.StringBuilder s = new System.Text.StringBuilder();
                foreach (byte b in bs)
                {
                    s.Append(b.ToString("x2"));
                }
                pass = s.ToString();
                string sql = "select * from _USERS where USERNAME = '" + user + "' and PASSS = '" + pass + "'";
                System.Data.DataTable dt = dbConnect.GetDataTableBySql(sql);
                if (dt.Rows.Count > 0)
                {
                    var fullName = dt.Rows[0]["TENDAU"].ToString()  + " " + dt.Rows[0]["TENCUOI"].ToString();
                    Boolean isLogin = true;
                    MainWindow.hasInfo.Add("Ten", user);
                    MainWindow.hasInfo.Add("PathFTP", user);
                    MainWindow.hasInfo.Add("TenDau", dt.Rows[0]["TENDAU"].ToString());
                    MainWindow.hasInfo.Add("TenCuoi", dt.Rows[0]["TENCUOI"].ToString());
                    MainWindow.hasInfo.Add("FullName", fullName);
                    Switcher.Close(isLogin);
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

            }

        }

        private void BtnDangKy_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ucDangKy());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
#if DEBUG

            //ucLogin _ucLogin = new ucLogin();
            //this.Content = _ucLogin;    

#endif
        }
    }
}
