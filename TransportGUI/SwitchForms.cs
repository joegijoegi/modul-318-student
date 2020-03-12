using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportGUI
{
    class SwitchForms
    {
        /// <summary>
        /// Methode um das Form zu wechseln
        /// </summary>
        public void SwitchToAbfahrtstafel()
        {
            Abfahrtstafel abfahrtsTafel = new Abfahrtstafel();
            abfahrtsTafel.ShowDialog();
        }

        /// <summary>
        /// Methode um das Form zu wechseln
        /// </summary>
        public void SwitchToAbfahrtsplan()
        {
            Abfahrtsplan abfahrtsPlan = new Abfahrtsplan();
            abfahrtsPlan.ShowDialog();
        }

        /// <summary>
        /// Methode um das Form zu wechseln
        /// </summary>
        public void SwitchToOrt()
        {
            Ort ort = new Ort();
            ort.ShowDialog();
        }
    }
}
