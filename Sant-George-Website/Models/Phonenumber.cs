﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SantGeorgeWebsite.Models
{
    public class Phonenumber
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User{ get; set; }
        public int phonenumber { get; set; }
    }
}
