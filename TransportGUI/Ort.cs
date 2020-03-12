using SwissTransport;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Device.Location;
using System.Collections.Generic;

namespace TransportGUI
{
    public partial class Ort : Form
    {
        SwitchForms Sf = new SwitchForms();
        public Ort()
        {
            InitializeComponent();
            MinimumSize = new Size(371, 237);
        }

        /// <summary>
        /// Button um das Form zu wechseln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtsPlan_Click(object sender, EventArgs e)
        {
            Hide();
            Sf.SwitchToAbfahrtsplan();
        }

        /// <summary>
        /// Button um das Form zu wechseln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Hide();
            Sf.SwitchToAbfahrtstafel();
        }

        /// <summary>
        /// Methode um die Station auf der Karte anzuzeigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Stations st = new Stations();
            Transport t = new Transport();

            st = t.GetStations(ddlStations.Text);

            string xCor = st.StationList[0].Coordinate.XCoordinate.ToString();
            string yCor = st.StationList[0].Coordinate.YCoordinate.ToString();
            System.Diagnostics.Process.Start($"https://www.google.ch/maps/place/{xCor},{yCor}");
        }

        /// <summary>
        /// Event um die Passenden Station zu suchen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            Abfahrtsplan abfahrtsPlan = new Abfahrtsplan();
            abfahrtsPlan.SearchStation(ddlStations);
        }

        /// <summary>
        /// Event um über das Kreuz das Programm zu schliessen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Funktion die Stationen in der Nähe in eine Combobox abfüllt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNearStation_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(false, TimeSpan.FromMilliseconds(3000));

            GeoCoordinate coord = watcher.Position.Location;
            if (coord.IsUnknown != true)
            {
                Coordinate coordinate = new Coordinate();
                string xCor = coord.Longitude.ToString().Replace(",", ".");
                string yCor = coord.Latitude.ToString().Replace(",", ".");
                Transport t = new Transport();
                coordinate = t.GetCoordinates(xCor, yCor);
                foreach(var element in coordinate.Type)
                {
                    ddlNearStation.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("Konnte nicht auf Standort zugreifen");
            }
        }
    }
}
