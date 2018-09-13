﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("Announcements")]
    public class Announcement
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [StringLength(250)]
        [Required]
        public string Title { set; get; }

        public string Content { set; get; }

        public DateTime CreatedDate { set; get; }

        [StringLength(128)]
        public string UserId { set; get; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { set; get; }

        public bool Status { set; get; }

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
    }
}