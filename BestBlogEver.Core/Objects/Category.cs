using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBlogEver.Core.Objects
{
    //All the properties are virtual because of NHibernate that creates a runtime proxy for classes.
    class Category
    {
        public virtual int Id
        { get; set; }

        public virtual string Name
        { get; set; }

        public virtual string UrlSlug //Title to use in address
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual IList<Post> Posts
        { get; set; }
    }
}
