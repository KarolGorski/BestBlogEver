using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBlogEver.Core.Objects
{
    //All the properties are virtual because of NHibernate that creates a runtime proxy for classes.
    class Post
    {
        public virtual int Id 
        { get; set; }

        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual string Meta // For-SEO description
        { get; set; }

        public virtual string UrlSlug //Title to use in address
        { get; set; }

        public virtual bool Published
        { get; set; }

        public virtual DateTime PostedOn
        { get; set; }

        public virtual DateTime? Modified
        { get; set; }

        public virtual Category Category
        { get; set; }

        public virtual IList<Tag> Tags
        { get; set; }

    }
}
