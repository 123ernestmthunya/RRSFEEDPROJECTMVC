using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class FeedRepository : IFeeds
    {
        
        public List<Feeds> RetriveFeeds(int id)
        {
            string url = null;
            if (id == 1)
            {
                url = ConfigurationManager.AppSettings["Green"];
            }
            else if (id == 2)
            {
                url = ConfigurationManager.AppSettings["TopStories"];
            }
            else if (id == 3)
            {
                url = ConfigurationManager.AppSettings["World"];
            }
            else if (id == 4)
            {
                url = ConfigurationManager.AppSettings["Africa"];
            }
            else if (id == 5)
            {
                url = ConfigurationManager.AppSettings["SouthAfrica"];
            }
            //XDocument doc = XDocument.Parse(url, LoadOptions.None);
            string feeddata = string.Empty;
            WebClient feedclient = new WebClient();
            feeddata =  feedclient.DownloadString(url);
            XDocument doc = XDocument.Parse(feeddata);
            return (from i in doc.Descendants("channel").Elements("item")
                    select RetrieveFeedsFromXml(i)).ToList();
        }
        public Feeds RetrieveFeedsFromXml(XElement element)
        {
            var fd = new Feeds
            {
                Title = element.Element("title") != null ? element.Element("title").Value : string.Empty,
                Description = element.Element("description") != null ? element.Element("description").Value : string.Empty,
                Link = element.Element("link") != null ? element.Element("link").Value : string.Empty,
                Pub_Date = element.Element("pubDate") != null ? element.Element("pubDate").Value : string.Empty,
            };
            var em = element.Element("enclosure");
            if (em != null)
            {
                foreach (var attribute in em.Attributes())
                {
                    if (attribute.Name == "url")
                    {
                        fd.Image = attribute.Value;
                        break;
                    }
                }
            }
            return fd;
        }
    }
}
