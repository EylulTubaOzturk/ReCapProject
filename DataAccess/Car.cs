namespace DataAccess.Abstract
{
    public class Car
    {
        public int DailyPrice { get; internal set; }
        public int BrandId { get; internal set; }
        public int ColorId { get; internal set; }
        public int Id { get; internal set; }
        public string Description { get; internal set; }
        public int ModelYear { get; internal set; }
    }
}