using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Oversii.Models.ViewModel
{
    public class VState
    {
        [Key]
        public int StateID { get; set; }
        public char Code { get; set; }
        public String State { get; set; }
    }
}