using Serilog;

namespace UI.Views;
public partial class Splash : Form
{
    public Splash() {
        InitializeComponent();
    }

    #region Overrides of Form

    protected override void OnLoad(EventArgs e) {
        Log.Information("Splash Form is loading");
    }

    protected override void OnClosed(EventArgs e) {
        Log.Information("Splash Form is now closed.");
    }

    #endregion
}
