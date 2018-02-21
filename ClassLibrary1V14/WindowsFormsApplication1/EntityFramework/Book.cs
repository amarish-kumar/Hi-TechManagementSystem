//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.OrderLineBooks = new HashSet<OrderLineBook>();
        }
    
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public double UnitPrice { get; set; }
        public int YearPublished { get; set; }
        public Nullable<int> Qoh { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLineBook> OrderLineBooks { get; set; }
    }
}