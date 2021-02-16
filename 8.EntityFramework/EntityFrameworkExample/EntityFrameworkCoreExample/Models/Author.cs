using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample.Models
{
    //[Table("Creators")]
    //[Index(nameof(FirstName), nameof(LastName), IsUnique = true)]
    public class Author
    {
        [Key]
        //[Column("CreatorId")]
        public int AuthorIdentifier { get; set; }
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
    }
}