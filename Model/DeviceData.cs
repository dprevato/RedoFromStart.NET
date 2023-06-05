using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class DeviceData
{
    public uint Id { get; set; }
    public Guid DeviceId { get; set; }
    public string? ItemName { get; set; }
    public string? ItemUnit { get; set; }
    public string ItemValue { get; set; }
    public DateTime? Ts { get; set; }

    public Device Device { get; set; }
}
