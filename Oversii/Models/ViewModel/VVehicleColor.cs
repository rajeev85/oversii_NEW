using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Oversii.Models.ViewModel
{
    public class VVehicleColor
    {
        [Key]
        public int VehicleColorID { get; set; }
        public string ColorName { get; set; }
            }
}