using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Core.ViewModels
{
    public class RegisterViewModel
    {
        
         [Display(Name ="شماره تلفن همراه")]
         [Required(ErrorMessage ="نباید بدون مقدار باشد")]
         [MaxLength(11 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
         [MinLength(11, ErrorMessage = "مقدار {0} نباید کمتر از {1} کاراکتر باشد")]
         [Phone(ErrorMessage ="فقط عدد وارد شود")]

        public string Mobile { get; set; }

         [Display(Name ="کلمه عبور ")]
         [MaxLength(20 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
         [MinLength(4, ErrorMessage = "مقدار {0} نباید کمتر از {1} کاراکتر باشد")]
         [Required(ErrorMessage ="نباید بدون مقدار باشد")]
         [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = " تایید کلمه ورود")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage ="کلمه های عبور هم خوانی ندارند")]
        public string ConfirmPassword { get; set; }
    }
}
