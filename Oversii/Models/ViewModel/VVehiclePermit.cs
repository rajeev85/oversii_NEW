using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Oversii.Models.ViewModel
{
    public class VVehiclePermit
    {
        [Key]
        public int PermitID { get; set; }
        public VVehicle Vehicle { get; set; }
        

    }

   


}