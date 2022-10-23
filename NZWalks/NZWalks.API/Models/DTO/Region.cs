namespace NZWalks.API.Models.DTO
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        //public double Area { get; set; } Commented out in Model to hide from user.
        //public double Lat { get; set; }
        //public double Long { get; set; }
        //public long Population { get; set; }
    }
}
