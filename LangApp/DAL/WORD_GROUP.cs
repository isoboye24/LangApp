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
    
    public partial class WORD_GROUP
    {
        public int wordGroupID { get; set; }
        public string wordGroupName { get; set; }
        public int partOfSpeechID { get; set; }
        public int languageID { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> deletedDate { get; set; }
    }
}
