using System;
using System.Threading.Channels;

abstract class TiketWisata
{
    public string namaPengunjung {  get; set; }
    public int idTiket {  get; set; }
    public string wahanaUtama { get; set; }



    public virtual void tampilInfo(string namaPengunjung, int idTiket, string wahanaUtama)
    {
        Console.WriteLine($"Pengunjung : {namaPengunjung} | Tiket : {idTiket} | Wahana : {wahanaUtama}");
    }

    public abstract int hitungTotalTiket
    {
        
    }
}



class TiketWeekday : TiketWisata
{
    string namaPengunjung;

    int hargaMasuk;
    int jumlahTiket;

    public override void tampilInfo(string namaPengunjung, int idTiket, string wahanaUtama)
        : base(namaPengunjung, idTiket, wahanaUtama)
    {
        
        Console.WriteLine("");
    }

}

class TiketWeekend : TiketWisata
{
    int hargaMasuk;
    int biayaTerusanWahana;

    public override void tampilInfo(string namaPengunjung, int idTiket, string wahanaUtama)
        :base

    public override 
    

}



class Program
{
    static void Main()
    {

        Console.WriteLine("========OOPPark========");

        TiketWisata TiketWisata = new TiketWisata();


        Console.WriteLine("=======================");
        Console.ReadLine();
    }
}


