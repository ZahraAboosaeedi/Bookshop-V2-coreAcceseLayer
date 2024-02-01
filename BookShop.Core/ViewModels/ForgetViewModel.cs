using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace BookShop.Core.ViewModels
{
    public class ForgetViewModel
    {
        [Display(Name = "شماره تلفن همراه")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(11, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        [MinLength(11, ErrorMessage = "مقدار {0} نباید کمتر از {1} کاراکتر باشد")]
        [Phone(ErrorMessage = "فقط عدد وارد شود")]

        public string Mobile { get; set; }

    }
}
