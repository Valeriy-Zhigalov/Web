using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени не менее 4-х символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не менее 4-х символов")]
        public string surname { get; set; }
        [Display(Name = "Введите Email")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина Email не менее 6 символов")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Display(Name = "Введите Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса не менее 15 символов")]
        public string adress { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public virtual Remont Remonts { get; set; }
        public Product Products { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }

    }
}
