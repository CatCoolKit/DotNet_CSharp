using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountLogin
    {
        [Required]
        [EmailAddress]
        public string AccountEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string AccountPassword { get; set; }
    }
}
