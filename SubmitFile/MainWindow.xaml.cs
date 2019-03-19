using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace SubmitFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean isLogin = false;
        //static string host = "ftp://svn.3asoft.vn";
        static string host = "ftp://127.0.0.1";
        private Hashtable hasIcon = new Hashtable();
        
        public static Hashtable hasInfo = new Hashtable();
        public MainWindow()
        {
            InitializeComponent();


            //hash path icon
            hasIcon.Add(".xls", @"resource\excel.png"); 
            hasIcon.Add(".doc", @"resource\word.png");
            hasIcon.Add(".docx", @"resource\word.png");
            hasIcon.Add(".pdf", @"resource\pdf.png");
            hasIcon.Add(".rar", @"resource\rar.png");
            hasIcon.Add(".zip", @"resource\zip.png");
            hasIcon.Add(".png", @"resource\picture.png");
            hasIcon.Add(".jpg", @"resource\picture.png");
            hasIcon.Add(".txt", @"resource\txt.png");
            hasIcon.Add(".pptx", @"resource\pptx.png");


            // hash infomation
            MainWindow.hasInfo.Add("Ten", "");
            MainWindow.hasInfo.Add("PathFTP", "");
            MainWindow.hasInfo.Add("TenDau", "");
            MainWindow.hasInfo.Add("TenCuoi", "");
            MainWindow.hasInfo.Add("FullName", "");
            dbConnect.GetConnect();

        }

        public static FtpClient ftp = new FtpClient(host, "trungnguyen", "trung123"); // tao doi tuong FTP (File Tranfer Protocl
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
            if (!isLogin)
            {
                this.IsEnabled = true;
                frmLogin frmlogin = new frmLogin();
                frmlogin.ShowDialog();
                isLogin = true;
                if (!isLogin)
                {
                    this.Close();
                    return;
                }
 
                ftp.userFolder = hasInfo["Ten"].ToString();
                loadData();
              

            }
        }

        
        private void loadData()
        {
            lbFullName.Text = hasInfo["FullName"].ToString();
            txtTenDau.Text = hasInfo["TenDau"].ToString();
            txtTenCuoi.Text = hasInfo["TenCuoi"].ToString();
            var list = ftp.directoryListSimple(hasInfo["Ten"].ToString());

            ObservableCollection<Documents> listDocuments = new ObservableCollection<Documents>();
            foreach(var file in list)
            {
                if (file.Equals(""))
                    continue;
                var name = Path.GetFileName(file);
                var extension = Path.GetExtension(file).ToLower();

                var pathIcon = hasIcon[extension].ToString();
                //System.Drawing.Image image = new System.Drawing.Image();
                
                listDocuments.Add(new Documents(file, name, hasInfo["Ten"].ToString(), pathIcon));
               
            }
            lstvFicheiros.ItemsSource = null;
            lstvFicheiros.Items.Clear();
            lstvFicheiros.ItemsSource = listDocuments;
            lstvFicheiros.SelectedIndex = 0;
        }


        private string pathFile = "";
        private void BtnChonTep_Click(object sender, RoutedEventArgs e)
        {
            using(OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.Title = "Chọn tệp";
                openfile.Filter = " All files (*.*)|*.*";

                if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtChonFile.Text = openfile.FileName;
                    pathFile = openfile.FileName;
                }
            }
        }

        private void BtnThemTep_Click(object sender, RoutedEventArgs e)
        {
            var nameFile = Path.GetFileName(pathFile);
            ftp.upload(nameFile, pathFile);
            loadData();
            txtChonFile.Text = "";

        }

        private void ContexMenuDown_Click(object sender, RoutedEventArgs e)
        {

            Documents ob = lstvFicheiros.SelectedItem as Documents;
            var nameFileSelected = ob.FileName;
            var extension = Path.GetExtension(nameFileSelected);

            SaveFileDialog downDialog = new SaveFileDialog();

            downDialog.Filter = " All files (*.*)|*.*";
            downDialog.Title = "Lưu tệp";
            downDialog.FileName = nameFileSelected;
            if(downDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var pathFile = downDialog.FileName;

                ftp.download(nameFileSelected, pathFile);
            }
        }

        private void ContextMenuRemove_Click(object sender, RoutedEventArgs e)
        {

            Documents ob = lstvFicheiros.SelectedItem as Documents;
            var nameFileSelected = ob.FileName;
            ftp.delete(nameFileSelected);
            loadData();
        }

        private void BtnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            isLogin = false;
            lbFullName.Text = "";
            lstvFicheiros.ItemsSource = null;
            lstvFicheiros.Items.Clear();
            Window_Loaded(null, null);
            
        }
    }
}
