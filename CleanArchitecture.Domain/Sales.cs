using System;

namespace CleanArchitecture.Domain
{
    public class Sales : IEntity {

        private int quantity;

        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; private set; }
        public int Quantity { get { return this.quantity; } set {
                this.quantity = value;
                this.UpdateTotalPrice();
            } }

        public void UpdateTotalPrice() {
            this.TotalPrice = this.UnitPrice * this.quantity;
        }
    }
}
