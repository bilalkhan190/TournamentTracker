using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DB;

namespace TournamentTrackerUI
{
    public partial class CreatePrizesForm : Form
    {
        public CreatePrizesForm()
        {
            InitializeComponent();
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //we can try parse this value but we are using constructor to do this job for us
                PrizeModel model = new PrizeModel(
                    txtPlaceName.Text,
                    txtPlaceNum.Text,
                    txtPrizeAmount.Text,
                    txtPrizePercentage.Text);
               
                   GlobalConfig.Connection.CreatePrize(model);
               

                Reset();
            }
            else
            {
                MessageBox.Show("this form is invalid or empty please check it or, try again");
            }
        }

        private void Reset()
        {
            txtPlaceName.Text = string.Empty;
            txtPlaceNum.Text = string.Empty;
            txtPrizeAmount.Text = "0";
            txtPrizePercentage.Text = "0";
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(txtPlaceNum.Text, out placeNumber);
            if (!placeNumberValid)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (txtPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentage.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            return output;
        }
    }
}
