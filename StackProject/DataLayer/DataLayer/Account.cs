using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.DataLayer
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Status { get; set; }
    }
}
