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
        Abfahrtsplan AbfahrtsPlan = new Abfahrtsplan();
        SwitchForms Sf = new SwitchForms();
        public Abfahrtstafel()
        {
            InitializeComponent();
            MinimumSize = new Size(722, 491);
        }

        /// <summary>
        /// Event ruft Methode auf, welche die Passenden Stationen auflistet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            AbfahrtsPlan.SearchStation(ddlStartStation);
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
                stationBoard = AbfahrtsPlan.Transport.GetStationBoard(ddlStartStation.Text, ""); //Redundanz vorhanden, da die Station einzigartig ist.
                foreach (var element in stationBoard.Entries)
                {
                    dgvAbfahrtsTafel.Rows.Add(ddlStartStation.Text, DateTime.Parse(element.Stop.Departure.ToString()).ToShortTimeString(), element.To, element.Operator, element.Name);
                }
            }
        }

        /// <summary>
        /// Methode, welche die Stationen suche und diese auflistet in der Combobox.
        /// </summary>
        /// <param name="station"></param>
        public void SearchStation(ComboBox dropDown)
        {
            Stations st = new Stations();

            if (dropDown.Text.Length <= 2)
            {
                MessageBox.Show("Bitte geben Sie mehr Buchstaben ein, um das Ergebnis genauer anzuzeigen");
            }
            else
            {
                dropDown.Items.Clear();
                st = AbfahrtsPlan.Transport.GetStations(dropDown.Text);
                foreach (var element in st.StationList)
                {
                    if (element.Id != null)
                    {
                        dropDown.Items.Add(element.Name);
                    }
                }
                dropDown.DroppedDown = true;
                dropDown.Focus();
            }
        }

        /// <summary>
        /// Mit dieser Funktion geht man auf das andere Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtsplan_Click(object sender, EventArgs e)
        {
            Hide();
            Sf.SwitchToAbfahrtsplan();
        }

        /// <summary>
        /// Mit dieser Funktion geht man auf das andere Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrtStation_Click(object sender, EventArgs e)
        {
            Hide();
            Sf.SwitchToOrt();
        }

        /// <summary>
        /// Event um über das Kreuz das Programm zu schliessen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abfahrtstafel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
