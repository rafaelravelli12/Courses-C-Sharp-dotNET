//Módulo 1
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Blog.Models
//{
//    [Table("Tag")]
//    public class Tag
//    {
//        [Key]
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Slug { get; set; }
//    }
//}

//Módulo 2
using System.Collections.Generic;

namespace Blog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public List<Post> Posts { get; set; }
    }
}
