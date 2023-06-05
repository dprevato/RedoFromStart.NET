using System.Collections.ObjectModel;

namespace Model;

public class Plant
{
    public Guid Id { get; set; }
    public string Tag { get; set; }                 // Codice Impianto - deve essere unico
    public string Name { get; set; }                // Nome Impianto - obbligatorio
    public string? Description { get; set; }        // Descrizione non è obbligatoria
    public DateTime BuiltDate { get; set; }
    public DateTime? DismissedDate { get; set; }
    public string AreaId { get; set; }              // Questo è un Guid
    public double? MaxHeight { get; set; }          // Massimo invaso - qui per comodità
    public double? MinHeight { get; set; }          // Minimo invaso - idem c.s.
    public DateTime? Ts { get; set; }               // Timestamp
    public Area Area { get; set; }                  // NON può essere null - un impianto deve trovarsi in un'area
    public ObservableCollection<ChartDefinition> ChartDefinitions { get; set; } = new();
    public ObservableCollection<Device> Devices { get; set; } = new();
    public ObservableCollection<Journal> Journal { get; set; } = new();
    public ObservableCollection<PersonPlant> PersonPlants { get; set; } = new();
    public ObservableCollection<PlantInfo> PlantInfos { get; set; } = new();
}