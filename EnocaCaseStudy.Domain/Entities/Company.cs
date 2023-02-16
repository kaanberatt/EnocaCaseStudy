using EnocaCaseStudy.Domain.Utilities;

namespace EnocaCaseStudy.Domain.Entities;
public sealed class Company : BaseEntity
{
    public string CompanyName { get; set; }
    public bool isConfirm{ get; set; }
    public TimeSpan OrderAllowStartTime { get; set; }
    public TimeSpan OrderAllowFinishTime { get; set; }
    public  ICollection<Product> Products { get; set; }
    //public ICollection<Order> Orders { get; set; }
}
