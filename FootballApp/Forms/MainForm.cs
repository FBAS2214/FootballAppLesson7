using FootballApp.Models;

namespace FootballApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cBox_CountryNames.DataSource = FakeDataService.GetCountryNames();
            cBox_TacticsFormats.DataSource = FakeDataService.GetTacticFormats();
        }
    }
}