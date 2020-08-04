using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkhbarWebSite.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
