namespace Zaku
{
    public class Condition
    {
        public bool IsOk { get; set; }
        public OrderSide Side { get; set; }
        public string? OrderId { get; set; }
        public decimal EntryPrice { get; set; }
        public decimal ClosePrice { get; set; }
    }
}
