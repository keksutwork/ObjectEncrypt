namespace TruCrypt
{
    public class TestModel : TestModelFather
    {
        public string Id { get; set; }
        public string Name => "Get";
        public string Price { get; set; }
    }
    public class TestModelFather
    {
        public string No { get; set; }
    }
}
