using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapi_test.Controllers.Model
{
    public class ManageUserRequest:BaseRequest<Guid>
    {
        [StringLength(255)]
        [Display(Name = "name")]
        public string Name { get; set; }

        [StringLength(255)]
        [Display(Name = "email")]
        public string Email { get; set; }

        [StringLength(255)]
        [Display(Name = "phone")]
        public string Phone { get; set; }

        [StringLength(255)]
        [Display(Name = "address")]
        public string Address { get; set; }

        [StringLength(255)]
        [Display(Name = "avatar_url")]
        public string AvatarUrl { get; set; }
    }
}