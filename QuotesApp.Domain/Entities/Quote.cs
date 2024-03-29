﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QuotesApp.Domain.Entities
{
    public class Quote : BaseEntity
    {
        [Required]
        [StringLength(3000, MinimumLength = 10)]
        public string Text { get; set; }

        [Required]
        [StringLength(150)]
        public string Author { get; set; }

        [StringLength(150)]
        public string Source { get; set; }

        public DateTime? Date { get; set; }
    }
}
