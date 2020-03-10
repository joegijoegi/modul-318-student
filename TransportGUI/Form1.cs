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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                SearchStation(ddlStartstation);
            }
            else if(btn == btnSearchEndStation)
            {
                SearchStation(ddlEndstation);
            }
        }

        /// <summary>
        /// Methode, welche die Stationen suche und diese auflistet in der Combobox.
        /// </summary>
        /// <param name="station"></param>
        private void SearchStation(ComboBox dropDown)
        {
            Transport transport = new Transport();
            Stations st = new Stations();

            if (dropDown.Text.Length <= 2)
            {
                MessageBox.Show("Bitte geben Sie mehr Buchstaben ein, um das Ergebnis genauer anzuzeigen");
            }
            else
            {
                dropDown.Items.Clear();
                st = transport.GetStations(dropDown.Text);
                foreach(var element in st.StationList)
                {
                    dropDown.Items.Add(element.Name);
                }
                dropDown.DroppedDown = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
