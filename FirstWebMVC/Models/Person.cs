using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; } = default!;

        public string Fullname { get; set;} = default!;

        public string Address { get; set;}= default!;

    }
}