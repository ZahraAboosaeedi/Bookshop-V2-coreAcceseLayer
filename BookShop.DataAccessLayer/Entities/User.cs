using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookShop.DataAccessLayer.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        public int RoleId { get; set; }


         [Display(Name ="شماره تلفن همراه")]
         [Required(ErrorMessage ="نباید بدون مقدار باشد")]
         [MaxLength(11 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }

         [Display(Name ="کلمه عبور")]
         [MaxLength(100 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
         [Required(ErrorMessage ="نباید بدون مقدار باشد")]
        public string Password { get; set; }

         [Display(Name ="کد ملی")]
         [MaxLength(10 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        public string Code { get; set; }

         [Display(Name ="نام و نام خانوادگی")]
         [MaxLength(100 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        public string FullName { get; set; }

         [Display(Name ="کد")]
         [Required(ErrorMessage ="نباید بدون مقدار باشد")]
         [MaxLength(6 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        public string ActiveCode { get; set; }


         [Display(Name ="فعال")]
        public bool IsActive { get; set; }


        [Display(Name = "تاریخ عضویت")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(10, ErrorMessage = "مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]
        public string Date { get; set; }

        public virtual Role Role{ get; set; }


    }
}
