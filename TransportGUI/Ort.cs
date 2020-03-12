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
    public partial class Ort : Form
    {
        SwitchForms Sf = new SwitchForms();
        public Ort()
        {
            InitializeComponent();
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
            System.Diagnostics.Process.Start($"https://www.google.ch/maps/place/47%C2%B010'12.8%22N+8%C2%B005'55.1%22E/@{xCor},{yCor},15.5z/data=!4m2!3m1!1s0x0:0x0");
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
    }
}
