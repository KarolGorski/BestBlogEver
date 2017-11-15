using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BestBlogEver.Core.Objects;
using FluentNHibernate.Mapping;


namespace BestBlogEver.Core.Mappings
{
    class PostMap: ClassMap<Post>
    {
        public PostMap() //Constructor
        {
            // => operator for lambda 

            Id(x => x.Id);

            Map(x => x.Title)
                .Length(500)
                .Not.Nullable();

            Map(x => x.ShortDescription)
                .Length(5000)
                .Not.Nullable();

            Map(x => x.Description)
                .Length(5000)
                .Not.Nullable();

            Map(x => x.Meta)
                .Length(1000)
                .Not.Nullable();

            Map(x => x.UrlSlug)
                .Length(200)
                .Not.Nullable();

            Map(x => x.Published)
                .Not.Nullable();

            Map(x => x.PostedOn)
               .Not.Nullable();

            Map(x => x.Modified);

            References(x => x.Category)
                .Column("Category")
                .Not.Nullable();

            HasManyToMany(x => x.Tags)
                .Table("PostTagMap");
        }
    }
}
