using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Fuvar> fuvarok = new List<Fuvar>();
        bool initFinished = false;
        public MainWindow()
        {
            InitializeComponent();
            // << balra: -
            // >> jobbra: Orosz Zsombor
            foreach (string adat in File.ReadAllLines("Datas\\fuvar.csv").Skip(1).ToList())
            {
                fuvarok.Add(new Fuvar(adat));
            }
            List<int> azonositok = new List<int>();
            foreach (Fuvar fuvar in fuvarok)
            {
                if (!azonositok.Contains(fuvar.Azonosito))
                {
                    azonositok.Add(fuvar.Azonosito);
                    cbTaxi.Items.Add($"{fuvar.Azonosito}");
                }
            }
            StreamWriter sw = new StreamWriter("Hibak.txt");
            sw.WriteLine("taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja");
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.TeljesIdotartam > 0 && fuvar.FizetettOsszeg > 0 && fuvar.MegtettTavolsag == 0)
                {
                    sw.WriteLine($"{fuvar.Azonosito};{fuvar.IndulasiIdopont};{fuvar.TeljesIdotartam};{fuvar.FizetettOsszeg};{fuvar.Borravalo};{fuvar.FizetesiMod}");
                }
            }
            sw.Close();
            initFinished = true;
        }

        private void btnOsszesFuvar_Click(object sender, RoutedEventArgs e)
        {
            lbOsszesFuvar.Content = fuvarok.Count.ToString();
        }

        private void cbTaxi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (initFinished)
            {
                int osszesFuvar = 0;
                double bevetel = 0;
                foreach (Fuvar fuvar in fuvarok)
                {
                    if (fuvar.Azonosito == int.Parse(cbTaxi.SelectedItem.ToString()))
                    {
                        osszesFuvar += 1;
                        bevetel += fuvar.FizetettOsszeg + fuvar.Borravalo;
                    }
                }
                lbTaxi.Content = $"${bevetel}, {osszesFuvar} fuvar";
            }
        }

        private void btnFizetesiModok_Click(object sender, RoutedEventArgs e)
        {
            lsbFizetesiModok.Items.Clear();
            Dictionary<string, int> fizetesek = new Dictionary<string, int>();
            foreach (Fuvar fuvar in fuvarok)
            {
                fizetesek[fuvar.FizetesiMod] = 0;
            }
            foreach (Fuvar fuvar in fuvarok)
            {
                fizetesek[fuvar.FizetesiMod] += 1;
            }
            foreach (var item in fizetesek)
            {
                lsbFizetesiModok.Items.Add($"{item.Key} - {item.Value}");
            }
        }

        private void btnOsszesTav_Click(object sender, RoutedEventArgs e)
        {
            double osszesMegtettTav = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                osszesMegtettTav += fuvar.MegtettTavolsag;
            }
            lbOsszesTav.Content = $"{Math.Round(osszesMegtettTav*1.6, 2)}km";
        }

        private void btnLeghosszabbFuvar_Click(object sender, RoutedEventArgs e)
        {
            Fuvar leghosszabbFuvar = fuvarok[0];
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.TeljesIdotartam > leghosszabbFuvar.TeljesIdotartam)
                {
                    leghosszabbFuvar = fuvar;
                }
            }
            lsbLeghosszabbFuvar.Items.Add($"Fuvar hossza: {leghosszabbFuvar.TeljesIdotartam} másodperc");
            lsbLeghosszabbFuvar.Items.Add($"Taxi azonosító: {leghosszabbFuvar.Azonosito}");
            lsbLeghosszabbFuvar.Items.Add($"Megtett távolság: {Math.Round(leghosszabbFuvar.MegtettTavolsag, 2)}km");
            lsbLeghosszabbFuvar.Items.Add($"Viteldíj: ${leghosszabbFuvar.FizetettOsszeg}");
        }
    }
}
