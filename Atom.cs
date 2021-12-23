using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomApp
{
    public class Atom
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Proton { get; set; }
        public int Neutron { get; set; }
        public double Weight { get; set; }

        public Atom()
        {

        }

        public Atom(string name,
            int proton,
            int neutron,
            double weight,
            string symbol)
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }

        public static Atom Parse(string objectData)
        {
            string[] parts = objectData.Split();

            Atom a = new Atom();

            if (parts.Length != 5)
                throw new Exception("Line doesn't have 5 parts!");
            else
            {
                a.Name = parts[0];
                a.Proton = int.Parse(parts[1]);
                a.Neutron = int.Parse(parts[2]);
                a.Weight = double.Parse(parts[3]);
                a.Symbol = parts[4];
            }

            return a;
        }

        public override string ToString()
        {
            return $"Element Name: {Name}, Element Symbol: {Symbol}, Protons: {Proton}, Neutrons: {Neutron}";
        }
    }
}
