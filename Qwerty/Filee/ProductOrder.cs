//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qwerty.Filee
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductOrder()
        {
            this.DocumentByProduct = new HashSet<DocumentByProduct>();
        }
    
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentByProduct> DocumentByProduct { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
