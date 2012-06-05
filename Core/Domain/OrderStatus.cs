namespace Core.Domain
{
    public enum OrderStatus {
        ReadyToBePicked,
        Canceled,
        ReadyForShipping,
        Shipped
    }
}