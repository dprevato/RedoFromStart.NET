using System.Collections.ObjectModel;
using Model.Enums;

namespace Model;
// ReSharper disable once InconsistentNaming
public class PM
{
    public string Id { get; set; }              // DeviceId + PmId
    public string DeviceId { get; set; }        // Identificativo device
    public string PmId { get; set; }            // identificativo punto di misura
    //
    public string Tag { get; set; }             // Codice di targa del PM
    public string? PmName { get; set; }         // Descrizione del PM
    //
    public DateTime? SettledOn { get; set; }
    public DateTime? RemovedOn { get; set; }
    public decimal? SpecialOffset { get; set; } // Correttivo speciale per le letture al PM
    public bool ShouldReport { get; set; }      // Il PM viene considerato nella reportistica?
    public Status PmStatus { get; set; }        // Verde, Giallo, Rosso; 
    public bool VirtualPm { get; set; }         // true = il PM non corrisponde ad un dispositivo di misura fisico
    public bool DontValidate { get; set; }      // Non serve validare le misure del PM
    //
    public bool AutoImport { get; set; }        // L'importazione delle letture è automatica per questo PM
    public bool Selected { get; set; }          // Il PM è selezionato per l'importazione dei dati (automatici)
    public int FormulaId { get; set; }          // Id formula di ingegnerizzazione
    public DateTime LastImport { get; set; }    // Data ultima importazione automatica
    //
    public DateTime? Ts { get; set; }
    //
    public Device Device { get; set; }
    public Formula Formula { get; set; }
    public Threshold Threshold { get; set; }
    //
    public ObservableCollection<Arg> Args { get; set; }  // Argomenti formula ingegnerizzazione
    public ObservableCollection<Reading> Readings { get; set; }  // Letture strumentali
}

/// <summary>
/// La classe Threshold è in rapporto 1-1 con la classe PM; la separo perché, per ora, le misure di soglia non sono mai state implementate.
/// EF Core gestisce i collegamenti 1-1, quindi la cosa è possibile senza problemi.
/// 
/// </summary>
public class Threshold
{
    // ReSharper disable once InconsistentNaming
    public string? PMId { get; set; }
    public decimal? AlarmLo { get; set; }
    public decimal? AlarmHi { get; set; }
    public decimal? WarningLo { get; set; }
    public decimal? WarningHi { get; set;}
}