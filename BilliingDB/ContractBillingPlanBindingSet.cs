//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilliingDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContractBillingPlanBindingSet
    {
        public int Id { get; set; }
        public int BillingPlanId { get; set; }
        public int ContractId { get; set; }
    
        public virtual BillingPlan BillingPlanSet { get; set; }
        public virtual Contract ContractSet { get; set; }
    }
}
