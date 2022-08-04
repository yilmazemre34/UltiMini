namespace UltiMiniApi.Model
{
    public class Account
    {
        public int AccountId { get; set; }
        public int TenantId { get; set; }
        public decimal Balance { get; set; }
        public decimal Debt { get; set; }
        public decimal Credit { get; set; }
    }
}
