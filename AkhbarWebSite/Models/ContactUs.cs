using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkhbarWebSite.Models
{
    public class ContactUs
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
