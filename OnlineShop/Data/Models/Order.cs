using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        
        [Display(Name = "Введите имя")]
        [StringLength(2)]
        [Required(ErrorMessage = "Длина имени не менее 2-ух символов")]
        public string FirstName { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(2)]
        [Required(ErrorMessage = "Длина фамилии не менее 2-ух символов")]
        public string LastName { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина адреса не менее 5-ти символов")]
        public string Address { get; set; }

        [Display(Name = "Введите телефон")]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина телефона не менее 11-ти цифр")]
        public string Phone { get; set; }

        [Display(Name = "Введите E-mail")]
        [StringLength(5)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина E-mail не менее 5-ти символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderDateTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
