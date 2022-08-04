namespace UltiMiniApi.Model
{
    public class Kasa
    {
        public int KasaID { get; set; }
        public string KasaAdi { get; set; }
        public decimal AcilisBakiye { get; set; }
        public string AcilisBakiyesiTarihi { get; set; }
        public string MuhasebeKodu { get; set; }
        public int TenantId { get; set; }
        public string KasaOlusturmaTarihi { get; set; }
        public int Currency { get; set; }

    }
}
