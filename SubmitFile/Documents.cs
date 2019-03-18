using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitFile
{
    internal class Documents
    {
        public string FileIcon { get; set; }
        public Image image { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string user { get; set; }



        public Documents(string _Filepath)
        {

        }


        public Documents(string _FilePath, string _FileName, string _user, string _pathIcon)  
        {  
            this.FilePath = _FilePath;
            this.FileName = _FileName;
            // this.image = _image;
            //this.FileIcon = _icon;
            this.FileIcon = _pathIcon;//Icon.ExtractAssociatedIcon(_pathIcon); 
            this.user = _user;
 
        }  



    }
    
}
