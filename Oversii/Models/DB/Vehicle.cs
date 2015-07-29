
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
    
public partial class Vehicle
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Vehicle()
    {

        this.Permits = new HashSet<Permit>();

    }


    public int VehicleID { get; set; }

    public int VehicleMakeID { get; set; }

    public int VehicleColorID { get; set; }

    public int ResidentId { get; set; }

    public Nullable<short> MakeYear { get; set; }

    public string LicPlateNum { get; set; }

    public string LicPlateState { get; set; }

    public int AudittrailID { get; set; }



    public virtual Audittrail Audittrail { get; set; }

    public virtual Resident Resident { get; set; }

    public virtual VehicleColor VehicleColor { get; set; }

    public virtual VehicleMake VehicleMake { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Permit> Permits { get; set; }

}

}