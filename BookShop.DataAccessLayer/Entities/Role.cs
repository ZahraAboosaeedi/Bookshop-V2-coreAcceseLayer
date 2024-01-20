using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace BookShop.DataAccessLayer.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="نام نقش")]
        [Required(ErrorMessage ="نباید بدون مقدار باشد")]
        [MaxLength(20 , ErrorMessage ="مقدار {0} نباید بیشتر از {1} کاراکتر باشد")]

        public string Name { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
