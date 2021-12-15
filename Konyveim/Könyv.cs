namespace Konyveim
{
    enum Ertekelesek { Szörnyű, Rossz, Közepes, Jó, NagyonJó, Remek }
    class Könyv
    {
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public Ertekelesek Ertekeles { get; set; }

        public Könyv(string cim, string szerzo, Ertekelesek ertekeles)
        {
            Cim = cim;
            Szerzo = szerzo;
            Ertekeles = ertekeles;
        }

        public override string ToString()
        {
            return $"{Szerzo}: {Cim}\t{Ertekeles}";
        }
    }
}
