using System.Collections.ObjectModel;

namespace Model;
public class Device
{
    public string Id { get; set; }                // campo calcolato persisted: AreaId + PlantID + KindId + Item
    public string AreaId { get; set; }
    public string PlantId { get; set; }
    public string KindId { get; set; }
    public string Item { get; set; }

    public string Tag { get; set; }             // Codice di targa: nome breve del device
    public string Batch { get; set; }           // Gruppo di device di cui fa parte (reportistica ecc.)
    public string DeviceName { get; set; }      // 
    public DateTime PlacedOn { get; set; }      // Questo è obbligatorio
    public DateTime? RemovedOn { get; set; }    // Questo no  

    public string? Unit { get; set; }           // Unità di misura 
    public bool VirtualDevice { get; set; }     // Device fittizio? Se si, non entra nei report
    public bool ShouldReport { get; set; }      // Questo è da considerare; entra solo nei report tabulari, in quelli grafici o in entrambi?
    public bool Validation { get; set; }        // Le misure rilevate devono essere validate?
    public decimal? Longitude { get; set; }     // Posizione del device
    public decimal? Latitude { get; set; }      // idem
    public decimal? Height { get; set; }        // Quota di installazione
    public DateTime? Ts { get; set; }           // Timestamp

    public DeviceKind Kind { get; set; }        // 
    public Area Area { get; set; }
    public Plant Plant { get; set; }

    public ObservableCollection<DeviceData> DeviceData { get; set; }
    public ObservableCollection<PM> Pms { get; set; }
}
