using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introAspNetModule4.Models
{
    //Initial State
    //public class Album
    //{

    //    public int ID { get; set; }
    //    public string Artist { get; set; }
    //    public string Name { get; set; }
    //    public string Genre { get; set; }
    //    public DateTime ReleaseDate { get; set; }
    //    public decimal Price { get; set; }
    //}

    public class Album
    {
        public int ID { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        [StringLength(60,MinimumLength =3)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }
        [Required]        
        public DateTime ReleaseDate { get; set; }
        [Range(0,100.00)]
        public decimal Price { get; set; }

        public int Rank { get; set; }
    }
}
