using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spy_Missions
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignMissionBtn_Click(object sender, EventArgs e)
        {
            string spyName = spyNameTextBox.Text;
            string missionName = missionTextBox.Text;

            DateTime priorMission = priorMissionCal.SelectedDate;
            DateTime startDate = startDateCal.SelectedDate;
            DateTime endDate = endDateCal.SelectedDate;

            TimeSpan missionGap = startDate.Subtract(priorMission);
            TimeSpan missionLength = endDate.Subtract(startDate);

            double missionCost = (missionLength.Days > 21) ? missionLength.Days * 500 : (missionLength.Days * 500) + 1000;
            
            if (missionGap.Days < 14)
            {
                resultLabel.Text = "Agents have a mandatory rest period of two weeks. " +
                    "Choose another Agent or set the mission start date to a later time.";
            }
            else if (missionLength.Days < 0)
            {
                resultLabel.Text = "Your mission must be at least a day in length.";
            }
            else
            {
                resultLabel.Text = string.Format("Your mission, {0}, should you choose to accept it is {1}. " +
                    "<br /> Budgetted Cost is: {2:C}", 
                    spyName, missionName, missionCost);
            }
        }
    }
}