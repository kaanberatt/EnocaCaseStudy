using EnocaCaseStudy.Domain.Utilities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnocaCaseStudy.Domain.Entities;
public sealed class Order : BaseEntity
{
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public int ProductId { get; set; }
    public Product Product{ get; set; }
}
