﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Makale.Api.Entities
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        public ICollection<Article> Articles { get; set; }
            = new List<Article>();
    }
}