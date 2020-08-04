using System.Collections.Generic;

using AkhbarWebSite.DTOs.Category;

namespace AkhbarWebSite.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
    }
}