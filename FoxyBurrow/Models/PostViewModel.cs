﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxyBurrow.Models
{
    public class PostViewModel
    {
        public long PostId { get; set; }
        public string UserId { get; set; }
        [MaxLength(1400)]
        public string Text { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
    }
}
