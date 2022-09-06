using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Preço")]

        public decimal Price1 { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [Display(Name = "Quantidade")]

        public decimal Amount { get; set; }
        [Display(Name = "Categoria")]

        public int CategoryId { get; set; }
        public Category Category { get; set;  }
    }
}
