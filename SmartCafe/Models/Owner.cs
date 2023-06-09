﻿using System.ComponentModel.DataAnnotations;

namespace SmartCafe.Models
{
    public class Owner
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public Owner() { }
    }
}
