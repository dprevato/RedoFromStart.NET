﻿using System.Collections.ObjectModel;

namespace Model;
public class ChartDefinition
{
    public Guid Id { get; set; }
    public string Tag { get; set; }         // Dato da Tag Impianto + Tag Kind
    public string MainTitle { get; set; }   // Tutti i grafici definiti qui condividono il titolo principale
    public string Owner { get; set; }       // Proprietario della definizione
    public DateTime? Ts { get; set; }

    public Guid PlantId { get; set; }
    public string KindId { get; set; }

    public Plant Plant { get; set; }
    public DeviceKind Kind { get; set; }
    public ObservableCollection<Chart> Charts { get; set; }

    public ChartDefinition() {
        Tag = $"{Plant.Tag}{Kind.KindName}";
    }
}
