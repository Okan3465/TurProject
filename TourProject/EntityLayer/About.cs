using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class About
    {
       
            [Key]
            public int AboutID { get; set; }
            public string AboutDetails1 { get; set; }
            public bool AboutStatus { get; set; }



    }
}
