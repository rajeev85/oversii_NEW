using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Oversii.Models.ViewModel
{
    public class VVehicleMake
    {
        [Key]
        public int VehicleMakeID { get; set; }
        public string MakeName { get; set; }

    }
}