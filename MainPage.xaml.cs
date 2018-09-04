using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace WochentagUwp
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tblDayOfWeek.Text = dpDate.Date.DayOfWeek.ToString();
        }

        private void dpDate_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            tblDayOfWeek.Text = e.NewDate.DayOfWeek.ToString();
        }
    }
}
