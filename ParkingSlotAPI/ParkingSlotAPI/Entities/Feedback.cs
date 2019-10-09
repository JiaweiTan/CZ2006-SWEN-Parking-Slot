﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSlotAPI.Entities
{
    public class Feedback
    {
        [Key]
        public Guid id { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Topic { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public bool IsResolved { get; set; }

        [Required]
        [MaxLength(500)]
        public string Comments { get; set; }
    }
}

