using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBlogEver.Core.Objects;
using FluentNHibernate.Mapping;


namespace BestBlogEver.Core.Mappings
{
    class TagMap: ClassMap<Category>
    {
        public TagMap() //Constructor
        {
            // => operator for lambda 

            Id(x => x.Id);

            Map(x => x.Name)
                .Length(50)
                .Not.Nullable();

            Map(x => x.UrlSlug)
                .Length(50)
                .Not.Nullable();

            Map(x => x.Description)
               .Length(200);

            HasMany(x => x.Posts)
                .Inverse()
                .Cascade.All()
                .Table("PostTagMap");
        }
    }
}
