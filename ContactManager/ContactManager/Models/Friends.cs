using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ContactManager.Models
{
    public class Friends
    {
        [Key]
        public int ContactId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}