//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaccoBook.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class attachment
    {
        public int Id { get; set; }
        public string DocumentId { get; set; }
        public string Attachment1 { get; set; }
        public string FileExtension { get; set; }
        public string FileType { get; set; }
        public string Description { get; set; }
        public string User { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}