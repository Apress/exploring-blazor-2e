namespace Task1
{
    public class DataModels
    {
        public class ProductModel
        {
            public Guid id { get; set; }
            public string title { get; set; }
            public string sellername { get; set; }
            public string description { get; set; }
            public decimal value { get; set; }
        }

    }
}
