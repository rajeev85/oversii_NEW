
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
    
public partial class PropertyManagement
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PropertyManagement()
    {

        this.Properties = new HashSet<Property>();

    }


    public int PropertyMgmtID { get; set; }

    public string Name { get; set; }

    public Nullable<int> AddressID { get; set; }

    public int AudittrailID { get; set; }



    public virtual Address Address { get; set; }

    public virtual Audittrail Audittrail { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Property> Properties { get; set; }

}

}
