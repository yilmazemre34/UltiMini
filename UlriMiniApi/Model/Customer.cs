namespace UltiMiniApi.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int TenantId { get; set; }
        public int CustomerType { get; set; }
        public string CustomerName { get; set; }
        public int CustomerCategoryId { get; set; }
        public string TicariUnvan { get; set; }
        public string VKN { get; set; }
        public string TCKN { get; set; }
        public int AccountId { get; set; }
        public string VergiDairesi { get; set; }
        public string Adres { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }

    }
}
