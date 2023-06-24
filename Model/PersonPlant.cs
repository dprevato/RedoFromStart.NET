using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;
public class PersonPlant
{
    public string PlantId { get; set; }
    public string PersonId { get; set; }
    public string RoleId { get; set; }

    public DateTime SettledOn { get; set; }
    public DateTime? RelievedOn { get; set; }
    public DateTime? Ts { get; set; }

    public Role Role { get; set; }
    public Person Person { get; set; }
    public Plant Plant { get; set; }
}
