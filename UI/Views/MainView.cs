using Serilog;

namespace UI.Views;

public partial class MainView : Form
{
    public MainView() {
        InitializeComponent();
    }

    #region Overrides of Form

    protected override void OnLoad(EventArgs e) {
        Log.Information("Main Application View is loading");
    }

    #region Overrides of Form

    protected override void OnClosed(EventArgs e) {
        Log.Information("Main application Viwe is now closed. Application exits here.");
    }

    #endregion

    #endregion
}