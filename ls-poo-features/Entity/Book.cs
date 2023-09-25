namespace ls_poo_features.Entity
{
    public class Book
    {
        public Book() { }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBNCode { get; set; }
        public Editor? Editor { get; set; }
    }
}
