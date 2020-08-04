using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkhbarWebSite.Models;

namespace AkhbarWebSite.IServices
{
    public interface IAkhbarServices
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
