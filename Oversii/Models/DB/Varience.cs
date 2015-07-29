
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Oversii.Models.DB
{

using System;
    using System.Collections.Generic;
    
public partial class Varience
{

    public int VarienceID { get; set; }

    public int PropID { get; set; }

    public int SubDivisionID { get; set; }

    public int StreetID { get; set; }

    public int HouseId { get; set; }

    public int VehicleMakeID { get; set; }

    public int VehicleColorID { get; set; }

    public Nullable<System.DateTime> StartDate { get; set; }

    public Nullable<System.DateTime> EndDate { get; set; }

    public string License { get; set; }

    public int AudittrailID { get; set; }

    public int VarienceStatusID { get; set; }



    public virtual House House { get; set; }

    public virtual Property Property { get; set; }

    public virtual Street Street { get; set; }

    public virtual SubDivision SubDivision { get; set; }

    public virtual VarienceStatu VarienceStatu { get; set; }

    public virtual VehicleColor VehicleColor { get; set; }

    public virtual VehicleMake VehicleMake { get; set; }

}

}