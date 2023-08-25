using System.ComponentModel.DataAnnotations;

namespace QueryTests {
    internal class Program {
        static void Main(string[] args) {
            int[] nbrs = {803, 755, 892, 877, 292, 636, 929, 688, 430, 175, 664, 210, 299, 380, 317, 744, 971, 125, 240, 292, 672, 132, 474, 654, 991, 630, 945, 676, 904, 538, 197, 733, 368, 431, 337, 945, 888, 511, 435, 830, 817, 527, 288, 131, 390, 788, 776, 826, 235, 894, 252, 941, 981, 215, 292, 235, 271, 756, 921, 178, 858, 425, 646, 702, 278, 379, 977, 556, 434, 447, 200, 181, 735, 812, 271, 479, 343, 491, 633, 679, 673, 436, 204, 770, 965, 798, 881, 149, 906, 190, 578, 333, 464, 607, 910, 887, 249, 261, 631, 896};
            Console.Write(nbrs.Max()+" | ");
            Console.Write(nbrs.Min()+" | ");
            Console.Write(nbrs.Average()+"\n");
            var qry1 = from n in nbrs where n % 200 >= 100 select n;
            Console.WriteLine(qry1.Sum());
            foreach (int n in qry1) {
                Console.Write(n+"|");
            }
            Console.WriteLine("\n-----------------------------------------------");
            var qry2 = from n in nbrs where n > nbrs.Average() select n;
            foreach (int n in qry2) {
                Console.Write(n+"|");
            }
        }

        private static void notes() {
            int[] scores = { 98, 87, 86, 92, 100, 83 };
            var result = from s in scores
                         where s > 85
                         orderby s descending
                         select s;
            //var r2 = from cust in customers select cust; // returns all
            //var r2 = from cust in customers selest new {cust.name}; //returns only name
        }
    }
}