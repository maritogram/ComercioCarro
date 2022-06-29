//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comercio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductComments = new HashSet<ProductComment>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public Nullable<int> Year { get; set; }
        public string Description { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public bool Sale { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public string Picture { get; set; }
        public int Rating { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Weight { get; set; }
       // public Nullable<System.DateTime> ExpirationDate { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public bool Enabled { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreationDate { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
