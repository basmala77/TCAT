namespace OCP
{
    public class PayItem
    {
        public string Name { get; }
        public decimal Amount { get; }

        public PayItem(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
