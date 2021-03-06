
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
    
public partial class Permit
{

    public int PermitID { get; set; }

    public Nullable<System.DateTime> IssueDate { get; set; }

    public Nullable<System.DateTime> ExpiryDate { get; set; }

    public string PermitNum { get; set; }

    public int PermitStatusID { get; set; }

    public Nullable<int> PermitPaymentID { get; set; }

    public int VehicleID { get; set; }



    public virtual PermitPayment PermitPayment { get; set; }

    public virtual PermitStatus PermitStatu { get; set; }

    public virtual Vehicle Vehicle { get; set; }

}

}
