//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public don()
        {
            this.donArticles = new HashSet<donArticle>();
        }
    
        public int IDdon { get; set; }
        public Nullable<System.DateTime> datePromesse { get; set; }
        public Nullable<System.DateTime> dateReception { get; set; }
        public Nullable<System.DateTime> dateAccepter { get; set; }
        public Nullable<long> etat { get; set; }
        public Nullable<int> IDDonateur { get; set; }
        public Nullable<int> IDEmploye { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donArticle> donArticles { get; set; }
        public virtual utilisateur utilisateur { get; set; }
        public virtual utilisateur utilisateur1 { get; set; }
    }
}
