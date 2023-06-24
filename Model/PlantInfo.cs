using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class PlantInfo
{
    public string PlantId { get; set; }
    public long Id { get; set; }
    public string? ItemName { get; set; }
    public string? ItemUnit { get; set; }
    public string ItemValue { get; set; }
    public DateTime? Ts { get; set; }

    public Plant Plant { get; set; }
}
