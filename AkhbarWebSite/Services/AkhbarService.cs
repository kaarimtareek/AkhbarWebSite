using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkhbarWebSite.IServices;
using AkhbarWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace AkhbarWebSite.Services
{
    public class AkhbarService : IAkhbarServices
    {
        private readonly AkhbarDbContext context;

        public AkhbarService(AkhbarDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await context.Categories.ToListAsync();
            return categories;
        }
    }
}
