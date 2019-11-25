using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessLayer;
namespace DataLayer.Controllers
{
   [EnableCors("*","*","*")]
    public class NewsFeedController : ApiController
    {
        
        FeedRepository repository = new FeedRepository();
        [HttpGet]
        public List<Feeds> Green()
        {
            return repository.RetriveFeeds(1);
        }
        [HttpGet]
        public List<Feeds> TopStories()
        {
            return repository.RetriveFeeds(2);
        }
        [HttpGet]
        public List<Feeds> World()
        {
            return repository.RetriveFeeds(3);
        }
        [HttpGet]
        public List<Feeds> Africa()
        {
            return repository.RetriveFeeds(4);
        }
        [HttpGet]
        public List<Feeds> SouthAfrica()
        {
            return repository.RetriveFeeds(5);
        }
    }
}
