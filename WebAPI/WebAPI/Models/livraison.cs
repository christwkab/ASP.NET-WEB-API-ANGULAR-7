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
    
    public partial class livraison
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public livraison()
        {
            this.livraisonDonArticles = new HashSet<livraisonDonArticle>();
        }
    
        public int IDlivraison { get; set; }
        public Nullable<System.DateTime> datelivraison { get; set; }
        public int IDbeneficiaire { get; set; }
    
        public virtual beneficiare beneficiare { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<livraisonDonArticle> livraisonDonArticles { get; set; }
    }
}
