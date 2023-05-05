namespace MartinMaker {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Martin!");
            MartinMaker mm;
            MartinMaker[] mmArray = new MartinMaker[2];
            List<MartinMaker> listeVonDatMartin = new List<MartinMaker>();
            //MartinMaker m = new MartinMaker();   // geht nicht
            //mm.Alter = 19;  // geht nicht, weil es kein Objekt geben kann von MatinMaker
            //mm.MalMachen(); // geht nicht, weil es kein Objekt geben kann
            TrueMartin unserMartin = new TrueMartin();
            unserMartin.Alter = 19;  // klappt - weil ein Objekt da ist
            unserMartin.MalMachen();
            mmArray[0] = new TrueMartin(); // ein Martin ohne Eigenschaften
            mmArray[1] = new TrueMartin() { Alter = 19 }; // ein 19-jahre gereifter Martin 
            Console.WriteLine(mmArray[0].Alter); // nix - weil alter Martin leer
            Console.WriteLine(mmArray[1].Alter); // klappt

            listeVonDatMartin.Add(new TrueMartin() { Alter=21});
            foreach (var item in listeVonDatMartin) {
                Console.WriteLine(item.Alter);
            }

            Console.ReadLine();
        }
    }

    abstract class MartinMaker {
        public int Alter { get; set; }

        public void MalMachen() {
            Console.WriteLine("irgendein abgeleiteter MartinMaker tut was ...");
        }
    }

    internal class TrueMartin : MartinMaker{
        // hier ist nichts
     }

}