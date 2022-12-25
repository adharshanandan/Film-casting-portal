using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ComplaintsProperty
    {
        public int ComId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Complaints { get; set; }
    }
}
