using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SingleSignOn.Models
{
    public class UserDetails
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Required]
    [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}