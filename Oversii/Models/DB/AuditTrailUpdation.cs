
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
    
public partial class AuditTrailUpdation
{

    public int AuditTrialID { get; set; }

    public int UpdateID { get; set; }

    public System.DateTime UpdateDateTime { get; set; }



    public virtual Audittrail Audittrail { get; set; }

}

}
