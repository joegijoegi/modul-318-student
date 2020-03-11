using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportGUI
{
    public partial class Abfahrtstafel : Form
    {
        Abfahrtsplan Abfahrtsplan = new Abfahrtsplan();
        public Abfahrtstafel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event ruft Methode auf, welche die Passenden Stationen auflistet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            Abfahrtsplan.SearchStation(ddlStartStation);
        }

        /// <summary>
        /// Funktion listet alle Verbindungen von einer vom User gewählten Station aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchConnection_Click(object sender, EventArgs e)
        {
            StationBoardRoot stationBoard = new StationBoardRoot();
            if (ddlStartStation == null)
            {
                MessageBox.Show("Bitte geben sie eine Stationen ein");
            }
            else
            {
                dgvAbfahrtsTafel.Rows.Clear();
                stationBoard = Abfahrtsplan.Transport.GetStationBoard(ddlStartStation.Text, ""); //Redundanz vorhanden, da die Station einzigartig ist.
                foreach (var element in stationBoard.Entries)
                {
                    dgvAbfahrtsTafel.Rows.Add(ddlStartStation.Text, DateTime.Parse(element.Stop.Departure.ToString()).ToShortTimeString(), element.To, element.Operator, element.Name);
                }
            }
        }

        /// <summary>
        /// Mit dieser Funktion geht man zurück auf das andere Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
