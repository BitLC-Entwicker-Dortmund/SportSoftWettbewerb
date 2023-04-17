namespace SportSoftWettbewerb {
    internal class Program {
        static void Main(string[] args) {
            // HPRG
            Disziplin m100 = new Disziplin("100m");
            Disziplin m200 = new Disziplin("200m");
            Disziplin m400 = new Disziplin("400m");

            Sportler sa = new Sportler("Ugur");
            Sportler sb = new Sportler("Alex");
            Sportler sc = new Sportler("Tony");

            Vorlauf vl = new Vorlauf(m100);
            vl.addSportler(sa);
            vl.addSportler(sb);
            vl.addSportler(sc);

            vl.addErgebnis(sa, 10);
            vl.addErgebnis(sb, 20);
            vl.addErgebnis(sc, 90);

            vl.ausgabe();

            Console.Read();
        }
    }
}