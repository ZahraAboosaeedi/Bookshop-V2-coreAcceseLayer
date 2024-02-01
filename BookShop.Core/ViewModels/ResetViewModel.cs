using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Core.ViewModels
{
    public class ResetViewModel
    {

        public string Mobile { get; set; }

        [Display(Name = "کلمه عبور ")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        [MinLength(4, ErrorMessage = "مقدار {0} نباید کمتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = " تایید کلمه ورود")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور هم خوانی ندارند")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "کد")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [Phone(ErrorMessage = "فقط عدد میتوانید وارد کنید")]
        [MaxLength(6, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        [MinLength(6, ErrorMessage = "مقدار {0} نباید کمتر از {1} کاراکتر باشد")]

        public string ActiveCode { get; set; }
    }
}
