using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Actor.ActorPropery
{
    public class UploadVideosProperty
    {
        public int ActorId { get; set; }
        public int VidId { get; set; }
        public string VideoLink { get; set; }
        public string Caption { get; set; }
        public object UploadedDate { get; set; }
    }
}
