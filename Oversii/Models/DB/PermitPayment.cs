
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
    
public partial class PermitPayment
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PermitPayment()
    {

        this.Permits = new HashSet<Permit>();

    }


    public int PermitPaymentID { get; set; }

    public System.DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public Nullable<System.DateTime> Notice30Day { get; set; }

    public Nullable<System.DateTime> Notice15Day { get; set; }

    public Nullable<System.DateTime> Notice10Day { get; set; }

    public bool NoticeDisable { get; set; }

    public int AudittrailID { get; set; }



    public virtual Audittrail Audittrail { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Permit> Permits { get; set; }

}

}
