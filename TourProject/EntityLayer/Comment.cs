using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommenUserName { get; set; }
        public string CommentTitle { get; set; }
       
        public string CommentImage { get; set; }


        public int ContactID { get; set; }
        public Contact Contact { get; set; }
        public bool ComentStatus { get; set; }

    }
}
