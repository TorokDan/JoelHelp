namespace Konyveim
{
    class Ember
    {
        public string Nev { get; set; }
        public Könyv[] Konyvek { get; set; }

        public Ember(string nev)
        {
            Nev = nev;
            Konyvek = new Könyv[0];
        }

        public void KonyvFelvetel(Könyv konyv)
        {
            Könyv[] seged = new Könyv[Konyvek.Length + 1];
            for (int i = 0; i < Konyvek.Length; i++)
                seged[i] = Konyvek[i];
            seged[Konyvek.Length] = konyv;
            Konyvek = seged;
        }
        public int KonyvTorles(Könyv konyv)
        {
            if (OlvastaE(konyv))
            {
                Könyv[] seged = new Könyv[Konyvek.Length - 1];
                int segedIndex = 0;
                for (int i = 0; i < Konyvek.Length; i++)
                {
                    if (Konyvek[i] != konyv)
                    {
                        seged[segedIndex] = Konyvek[i];
                        segedIndex++;
                    }
                }
                Konyvek = seged;
                return 0;
            }
            return 1;
        }
        public bool OlvastaE(Könyv konyv)
        {
            for (int i = 0; i < Konyvek.Length; i++)
                if (Konyvek[i] == konyv)
                    return true;
            return false;
        }
    }
}
