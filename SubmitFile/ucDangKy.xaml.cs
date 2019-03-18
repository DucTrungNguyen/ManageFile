using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SubmitFile
{
    /// <summary>
    /// Interaction logic for ucDangKy.xaml
    /// </summary>
    public partial class ucDangKy : System.Windows.Controls.UserControl
    {
        public ucDangKy()
        {
            InitializeComponent();
        }

        private void BtnDangKyDB_Click(object sender, RoutedEventArgs e)
        {
            var TaiKhoanDangKy = txtDkyTaiKhoan.Text;
            var PassDangKy = txtDkyPass.Password;
            if (dbConnect.GetStringBySql("select USER from _USERS  where USERNAME  ='" + TaiKhoanDangKy + "'").Equals(""))
            {
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
           
                byte[] bs = System.Text.Encoding.UTF8.GetBytes(PassDangKy);
                bs = sha1.ComputeHash(bs);
                System.Text.StringBuilder s = new System.Text.StringBuilder();
                foreach (byte b in bs)
                {
                    s.Append(b.ToString("x2"));
                }
                PassDangKy = s.ToString();

                string sqlInset = "insert into _USERS values ('" + TaiKhoanDangKy + "','" + PassDangKy + "', '" + txtTenDau.Text + "', '" + txtTenCuoi.Text + "')";
                dbConnect.UpdateTableBySql(sqlInset);


                MainWindow.ftp.createDirectory(TaiKhoanDangKy);


                DialogResult result = System.Windows.Forms.MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.Yes)
                {
                    Switcher.Switch(new ucLogin());
                }
                
            }
            else
            {
                System.Windows.MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
        }

        private void BtnTroVe_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ucLogin());
        }
    }
}
