//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagement.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public Document()
        {
            this.DocumentItems = new HashSet<DocumentItem>();
        }
    
        public int Id { get; set; }
        public int StoreId { get; set; }
        public bool IsOutput { get; set; }
        public string Date { get; set; }
    
        public virtual Store Store { get; set; }
        public virtual ICollection<DocumentItem> DocumentItems { get; set; }
    }
}
