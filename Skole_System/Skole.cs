using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_System
{
    internal class Skole
    {
        public string skoleNavn;
        public string skoleÅr;
        public string navn;
        public int alder;

        public Skole(string skoleNavn, string skoleÅr, string navn, int alder)
        {

            this.skoleNavn = skoleNavn;
            this.skoleÅr = skoleÅr;
            this.navn = navn;
            this.alder = alder;

        }
    }
}
