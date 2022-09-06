﻿using MvcApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class Category
    {
        public  int Id { get; set; }
        [Display(Name = "Nome")]

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        public string Name { get; set; }
    }
}
