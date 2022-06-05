using FootballApp.Forms;
using FootballApp.Models;
using FootballApp.UserControls;

namespace FootballApp
{
    public partial class MainForm : Form
    {
        public List<Player> Players { get; set; } = FakeDataService.GetPlayers();
        public StadiumForm StadiumForm { get; set; } = new StadiumForm();



        public MainForm()
        {
            InitializeComponent();

            cBox_CountryNames.DataSource = FakeDataService.GetCountryNames();
            cBox_CountryNames.SelectedIndex = 14;

            cBox_TacticsFormats.DataSource = FakeDataService.GetTacticFormats();
        }



        private void cBox_TacticsFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int[] tacticFormat = Array.ConvertAll(cBox_TacticsFormats.Text.Split('-'), int.Parse);

            int index = 0;

            foreach (var userControl in panel_Players.Controls)
            {
                if(userControl is UC_Player uc)
                {
                    uc.txt_Position.Text = Players[index].Position.ToString();
                    uc.txt_Number.Text = Players[index].Number.ToString();
                    uc.txt_Name.Text = Players[index].Name;

                    index++;
                }
            }

        }




        private void btn_Generate_Click(object sender, EventArgs e)
        {
            StadiumForm.CountryName = cBox_CountryNames.Text;
            StadiumForm.Players = Players;

            StadiumForm.ShowDialog();

        }
    }
}