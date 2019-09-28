using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Romanazzi.Models
{
    public enum TypeList { Vela, Venado, Vaso}
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [MinLength(2, ErrorMessage = "Nombre muy corto")]
        [MaxLength(24, ErrorMessage = "Nombre muy largo")]
        public string NickName { get; set; }
        [Required]
        public TypeList Tricks { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Cumpleaños")]
        public DateTime Birthday { get; set; }
    }
}