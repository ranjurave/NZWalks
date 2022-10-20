using System.Runtime.InteropServices;

namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }    
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //Navigation property can be any number of Walks
        public IEnumerable<Walk> Walks { get; set; }
    }
}