using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Views;
using Timer = System.Windows.Forms.Timer;

namespace UI;
internal class SplashAppContext : ApplicationContext
{
    private Form? _mainForm;
    private Timer _splashTimer = new();

    public SplashAppContext(Form mainForm, Form splashForm) : base(splashForm) {
        this._mainForm = mainForm;

        _splashTimer.Tick += SplashTimeUp;
        _splashTimer.Interval = 2000;
        _splashTimer.Enabled = true;
    }

    private void SplashTimeUp(object? sender, EventArgs e) {
        _splashTimer.Enabled = false;
        _splashTimer.Dispose();

        base.MainForm?.Close();
    }

    #region Overrides of ApplicationContext

    protected override void OnMainFormClosed(object? sender, EventArgs e) {
        if (sender is Splash) {
            base.MainForm = MainForm;
            base.MainForm?.Show();
        }
        else if (sender is MainForm) {
            base.OnMainFormClosed(sender, e);
        }
    }

    #endregion
}
