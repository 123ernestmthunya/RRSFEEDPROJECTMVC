using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    interface IFeeds
    {
        List<Feeds> RetriveFeeds(int id);
        Feeds RetrieveFeedsFromXml(XElement element);
       
    }
}
