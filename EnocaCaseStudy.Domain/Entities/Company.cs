using EnocaCaseStudy.Domain.Utilities;

namespace EnocaCaseStudy.Domain.Entities;
public sealed class Company : BaseEntity
{
    public string CompanyName { get; set; }
    public bool isConfirm{ get; set; }
    public DateTime OrderAllowStartTime { get; set; }
    public DateTime OrderAllowFinishTime { get; set; }
    public  ICollection<Product> Products { get; set; }
}
