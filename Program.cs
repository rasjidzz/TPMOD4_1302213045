// See https://aka.ms/new-console-template for more information


namespace TPMOD4_1302213045
{
    class KodePos
    {
        Dictionary<string, int> Kode_daerah = new Dictionary<string, int>()
        {
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273}
        };
        public void getKodePos(string nama_daerah)
        {
            if (Kode_daerah.ContainsKey(nama_daerah))
            {
                Console.WriteLine(nama_daerah + " : " + Kode_daerah[nama_daerah]);
            }
            else
            {
                Console.WriteLine(nama_daerah + ", Tidak Terdapat kode tersebut");
            }
        }
        public void printdaftarkodepos()
        {
            Console.WriteLine("Kelurahan : Kode Pos");
            Console.WriteLine("");
            foreach(KeyValuePair<string, int> kvp in Kode_daerah)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
        }
    }

    class MainProgram
    {
        public static void Main(string[] args)
        {
            KodePos kodepos = new KodePos();
            kodepos.printdaftarkodepos();
        }
    }
}