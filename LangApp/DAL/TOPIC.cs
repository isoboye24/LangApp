//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LangApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOPIC
    {
        public int topicID { get; set; }
        public string topic1 { get; set; }
        public int languageID { get; set; }
        public int userID { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> deletedDate { get; set; }
    }
}
