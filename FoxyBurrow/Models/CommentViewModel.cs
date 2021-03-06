﻿using FoxyBurrow.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxyBurrow.Models
{
    public class CommentViewModel
    {
        public string UserToReturnId { get; set; }
        public long CommentId { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        public long PostId { get; set; }
    }
}
