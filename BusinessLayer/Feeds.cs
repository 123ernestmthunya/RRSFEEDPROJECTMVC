using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [DataContract]
    public class Feeds
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Pub_Date { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Link { get; set; }
        [DataMember]
        public string Image { get; set; }
    }
}
