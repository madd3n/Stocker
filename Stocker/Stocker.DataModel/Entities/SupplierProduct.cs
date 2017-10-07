namespace Stocker.DataModel.Entities
{
    public class SupplierProduct: BaseEntity
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
    }
}
