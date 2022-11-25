
namespace Zaku
{
    public class Position
    {
        public string? OrderId { get; set; }
        public string? Symbol { get; set; }
        public OrderType Type { get; set; }
        public OrderSide Side { get; set; }
        public decimal EntryPrice { get; set; }
        public decimal? SettlementPrice { get; set; }
        public decimal Lots { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
    }
}
