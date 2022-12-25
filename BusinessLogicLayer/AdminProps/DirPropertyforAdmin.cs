using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AdminProps
{
    public class DirPropertyforAdmin
    {
        public int DirId { get; set; }
        public string DirName { get; set; }
        public string DirDob { get; set; }
        public string DirGender{ get; set; }
        public string ProPicDir { get; set; }
        public string DirEmail { get; set; }
        public string DirPh { get; set; }
        public char DirAccStatus { get; set; }
    }
}
