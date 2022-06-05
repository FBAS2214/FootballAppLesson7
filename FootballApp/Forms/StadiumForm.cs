using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp.Forms
{
    public partial class StadiumForm : Form
    {
        public List<Player>? Players { get; set; }

        public string CountryName
        {
            get { return lbl_country.Text; }
            set { 
                lbl_country.Text = value;
                ChangeFlag();
            }
        }

        public int[]? TacticFormat { get; set; }


        public StadiumForm()
        {
            InitializeComponent();

        }


        private void ChangeFlag()
        {
            pBox_Flag.LoadAsync($"https://countryflagsapi.com/png/{CountryName}");
        }
    }
}
