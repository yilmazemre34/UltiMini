namespace UltiMiniApi.Model
{
    public class Banka
    {
        public int BankaId { get; set; }
        public string BankaAdi { get; set; }
        public int TenantId { get; set; }
        public string IBAN { get; set; }
        public decimal Bakiye { get; set; }
        public string MuhasebeKodu { get; set; }
        public int Currency { get; set; }


    }
}
