using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Oversii.Models.ViewModel
{
    public class VVehicle
    {        
            [Key]
            public int VehicleID { get; set; }
            public short MakeYear { get; set; }
            public string LicPlateNum { get; set; }
            public VState State { get; set; }
        public VVehicleColor VehicleColor { get; set; }
        public VVehicleMake VehicleMake { get; set; }

        }
    
}