using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public DateTime Date { get; set; }

        public DateTime EditedDate { get; set; }

        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }

        public string Author_Id { get; set; }

        public string Author_UserName { get; set; }

    }
}