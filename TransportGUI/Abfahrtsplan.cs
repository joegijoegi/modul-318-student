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
    public partial class Abfahrtsplan : Form
    {
        public Transport Transport = new Transport();
        public Abfahrtsplan()
        {
            InitializeComponent();
            dtpDate.CustomFormat = "dd.MM.yyyy   HH:mm";
        }

        /// <summary>
        /// Event, welches ausgelöst wird, wenn auf einen der Buttons "Passende Station finden" gedrückt wird.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchStation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn == btnSearchStartStation)
            {
                SearchStation(ddlStartStation);
            }
            else if(btn == btnSearchEndStation)
            {
                SearchStation(ddlEndStation);
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
                st = Transport.GetStations(dropDown.Text);
                foreach(var element in st.StationList)
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
        /// Event um das Formular zu schliessen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Sucht Verbindungen und listet diese in einem Datagridview auf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchConnection_Click(object sender, EventArgs e)
        {
            Connections con = new Connections();

            if(ddlStartStation == null || ddlEndStation == null)
            {
                MessageBox.Show("Bitte geben sie 2 Stationen ein");
            }
            else
            {
                string timePicked = $"{dtpDate.Value.Year}-{dtpDate.Value.Month}-{dtpDate.Value.Day}T{dtpDate.Value.Hour}%3A{dtpDate.Value.Minute}";
                dgvAbfahrtsplan.Rows.Clear();
                con = Transport.GetConnections(ddlStartStation.Text, ddlEndStation.Text, timePicked);
                foreach (var element in con.ConnectionList)
                {
                    if (element.From.Platform == null || element.From.Platform == "")
                    {
                        dgvAbfahrtsplan.Rows.Add(element.From.Station.Name, DateTime.Parse(element.From.Departure).ToShortTimeString(), element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString(), "1");
                    }
                    else
                    {
                        dgvAbfahrtsplan.Rows.Add(element.From.Station.Name, DateTime.Parse(element.From.Departure).ToShortTimeString(), element.To.Station.Name, DateTime.Parse(element.To.Arrival).ToShortTimeString(), element.From.Platform);
                    }
                }
            }
        }
        /// <summary>
        /// Event öffnet ein neues Form für die Abfahrtstafel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbfahrtsTafel_Click(object sender, EventArgs e)
        {
            Abfahrtstafel abfahrtstafel = new Abfahrtstafel();
            abfahrtstafel.ShowDialog();
        }
    }
}
