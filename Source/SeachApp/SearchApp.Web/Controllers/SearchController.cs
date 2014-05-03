using System.Web.Http;

namespace SearchApp.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using SearchApp.Web.Models;

    public class SearchController : ApiController
    {
        public IEnumerable<SearchGroup> Get(string criteria)
        {
            return this.GetSampleData()
                .Where(result => result.Title.ToLowerInvariant().Contains(criteria.ToLowerInvariant()))
                .GroupBy(r => r.Category).Select(group => new SearchGroup { Title = group.Key, Results = new List<SearchResult>(group) });
        }

        private IEnumerable<SearchResult> GetSampleData()
        {
            return new List<SearchResult>
                       {
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS Views" },
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS Controllers" },
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS Modules" },
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS Directives" },
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS NgResource" },
                           new SearchResult { Category = "Code Snippets", Title = "AngularJS Watch Variables" },
                           new SearchResult { Category = "Samples", Title = "Hello World" },
                           new SearchResult { Category = "Samples", Title = "Custom Directives" },
                           new SearchResult { Category = "Samples", Title = "Using Filters" },
                           new SearchResult { Category = "Samples", Title = "Creating Services" },
                           new SearchResult { Category = "Samples", Title = "ng-view in Action" },
                           new SearchResult { Category = "Samples", Title = "PetShop" },
                           new SearchResult { Category = "Samples", Title = "Book Store" },
                           new SearchResult { Category = "Videos", Title = "Introduction to AngularJS" },
                           new SearchResult { Category = "Videos", Title = "What's new in version 2.0" },
                           new SearchResult { Category = "Videos", Title = "Understanding routes" },
                           new SearchResult { Category = "Videos", Title = "AngularJS VS Ember" },
                           new SearchResult { Category = "Videos", Title = "REST Services" },
                           new SearchResult { Category = "Articles", Title = "Building apps with AngularJS" },
                           new SearchResult { Category = "Articles", Title = "Why Angular?" },
                           new SearchResult { Category = "Articles", Title = "Code: Multi Views in AngularJS" },
                           new SearchResult { Category = "Articles", Title = "JavaScript Frameworks" },
                           new SearchResult { Category = "Articles", Title = "Building apps with AngularJS" },
                           new SearchResult { Category = "Images", Title = "AngularJS Architecture" },
                           new SearchResult { Category = "Images", Title = "Multi-tier architecture" },
                           new SearchResult { Category = "Images", Title = "NG-Views" },
                           new SearchResult { Category = "Images", Title = "Directives Compile Diagram" },
                           new SearchResult { Category = "Images", Title = "Roadmap to AngularJS" },
                           new SearchResult { Category = "Podcasts", Title = "AngularJS Chapter 12" },
                           new SearchResult { Category = "Podcasts", Title = "PodJS 116" },
                           new SearchResult { Category = "Podcasts", Title = "This is a Podcast" },
                       };
        }
    }
}
