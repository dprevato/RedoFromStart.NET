using UI.Views;
using Timer = System.Windows.Forms.Timer;

namespace UI;

public class SplashFadeAppContext : ApplicationContext
{
    /// <summary>
    /// flag interno per comunicare al processo in quale stato si trova lo splash form
    /// </summary>
    private enum FormStatus
    {
        Open = 1,
        Opening = 2,
        Closing = 4,
        Closed = 8
    }

    private FormStatus _formStatus = FormStatus.Open;
    private readonly Form _mainForm = null!;
    private readonly Timer _splashTimer = new Timer();
    private int _showSplashInterval = 3000;
    private const int FadeInterval = 50;
    private bool _doFadeClose = false;

    public SplashFadeAppContext(Form mainForm, Form splashForm) : base(splashForm) {
        this._mainForm = mainForm;

        _splashTimer.Tick += SplashTimeUp;
        _splashTimer.Interval = FadeInterval;
        _splashTimer.Enabled = true;
    }

    /// <summary>
    /// Questo è l'evento timer che controlla il funzionamento dello splash form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SplashTimeUp(object? sender, EventArgs e) {
        switch (_formStatus) {
            // Se lo splash form è in apertura, la sua opacità aumenterà in incrementi del 5% finché non sarà completamente visualizzato; una volta che la
            // proprietà Opacity vale 1 (completamente opaco), imposta il flag di stato su Open.
            case FormStatus.Opening when MainForm!.Opacity < 1:
                MainForm.Opacity += .05;
                break;
            case FormStatus.Opening:
                _formStatus = FormStatus.Open;
                break;
            case FormStatus.Closing when MainForm!.Opacity >= .05:
                MainForm.Opacity -= .05;
                _splashTimer.Interval = FadeInterval;
                break;
            case FormStatus.Closing:
                _formStatus = FormStatus.Closed;
                break;
            // Una volta che lo splash form è aperto e completamente visualizzato, l'intrvallo del timer viene impostato al ritardo di visualizzazione dello
            // splashform, che per default è 3 secondi, e infine imposta il flag di stato a seconda che l'utente voglia semplicemente chiudere lo splash form
            // o sfumarlo.
            case FormStatus.Open:
                _splashTimer.Interval = _showSplashInterval;
                _formStatus = _doFadeClose ? FormStatus.Closing : FormStatus.Closed;
                break;
            // Questo viene chiamato se lo splashForm è pronto per essere chiuso. A questo scopo, prima distruggiamo il timer per evitare i memory leaks, e 
            // poi chiamiamo la funzione base.MainForm.Close, la quale scatena l'evento MainFormClosed che abbiamo sovrascritto in modo da poter impostare
            // come form principale dell'Application Context il form che abbiamo passato nel costruttore.
            case FormStatus.Closed:
                _splashTimer.Enabled = false;
                _splashTimer.Dispose();
                MainForm!.Close();
                break;
        }
    }

    #region Overrides of ApplicationContext

    protected override void OnMainFormClosed(object? sender, EventArgs e) {
        if (sender is Splash) {
            MainForm = _mainForm;
            MainForm.Show();
        }
        else if (sender is MainView) {
            base.OnMainFormClosed(sender, e);
        }
    }

    #endregion

    public bool DoFadeOpen {
        set {
            if (value != true) return;
            MainForm!.Opacity = 0;
            _formStatus = FormStatus.Opening;
        }
    }

    public bool DoFadeClose {
        set => _doFadeClose = value;
    }
    
    public int SecondsSplashShown {
        set => _showSplashInterval = value * 1000;
    }
}
