using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NextResource.Views
{
    class LoginModel
    {
        [Requerid, MaxLength(20)]
        public string UserName { get; set; }
        [Requerid]
        public string Password { get; set; }
        public bool RememberMe{ get; set; }
    }
}
