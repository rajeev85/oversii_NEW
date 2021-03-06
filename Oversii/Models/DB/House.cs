
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
    
public partial class House
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public House()
    {

        this.Citations = new HashSet<Citation>();

        this.ManagerRequests = new HashSet<ManagerRequest>();

        this.Residents = new HashSet<Resident>();

        this.Variences = new HashSet<Varience>();

    }


    public int HouseID { get; set; }

    public int StreetID { get; set; }

    public string HouseAddressName { get; set; }

    public int AudittrailID { get; set; }



    public virtual Audittrail Audittrail { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Citation> Citations { get; set; }

    public virtual Street Street { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ManagerRequest> ManagerRequests { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Resident> Residents { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Varience> Variences { get; set; }

}

}
