namespace SpiceRanch.structures
{
    internal class Client
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string? address { get; set; }
        public string? postcode { get; set; }
        public string? email { get; set; }
        public string? contact_number { get; set; }
    }
}
