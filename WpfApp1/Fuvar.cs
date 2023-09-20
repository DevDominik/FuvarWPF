using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Fuvar
    {
        int id, teljesIdotartam;
        string indulasiIdopont, fizetesiMod;
        double megtettTavolsag, fizetettOsszeg, borravalo;
        public Fuvar(string bevitel)
        {
            string[] bontott = bevitel.Split(';');
            this.id = int.Parse(bontott[0]);
            this.indulasiIdopont = bontott[1];
            this.teljesIdotartam = int.Parse(bontott[2]);
            this.megtettTavolsag = double.Parse(bontott[3]);
            this.fizetettOsszeg = double.Parse(bontott[4]);
            this.borravalo = double.Parse(bontott[5]);
            this.fizetesiMod = bontott[6];
        }
        public int Azonosito { get { return id; } }
        public int TeljesIdotartam { get { return teljesIdotartam; } }
        public string IndulasiIdopont { get {  return indulasiIdopont; } }
        public string FizetesiMod { get { return fizetesiMod;} }

        public double Borravalo { get { return borravalo; } }
        public double MegtettTavolsag { get { return megtettTavolsag; } }
        public double FizetettOsszeg { get {  return fizetettOsszeg;} }

    }
}
