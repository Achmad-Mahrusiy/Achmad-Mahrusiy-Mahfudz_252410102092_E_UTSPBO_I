using System;

abstract class TiketWisata
{
    private string namaPengunjung;
    private string idTiket;
    private string wahanaUtama;

    public string NamaPengunjung
    {
        get { return namaPengunjung; }
        set { namaPengunjung = value; }
    }

    public string IdTiket
    {
        get { return idTiket; }
        set { idTiket = value; }
    }

    public string WahanaUtama
    {
        get { return wahanaUtama; }
        set { wahanaUtama = value; }
    }

    public TiketWisata(string namaPengunjung, string idTiket, string wahanaUtama)
    {
        this.namaPengunjung = namaPengunjung;
        this.idTiket = idTiket;
        this.wahanaUtama = wahanaUtama;
    }

    public virtual void tampilInfo()
    {
        Console.WriteLine($"Pengunjung : {namaPengunjung} | Tiket : {idTiket} | Wahana : {wahanaUtama}");
    }

    public abstract int hitungTotalTiket();

}

class TiketWeekday : TiketWisata
{
    private int hargaMasuk;
    private int jumlahTiket;

    public TiketWeekday(string namaPengunjung, string idTiket, string wahanaUtama, int hargaMasuk, int jumlahTiket)
        : base(namaPengunjung, idTiket, wahanaUtama)
    {
        this.hargaMasuk = hargaMasuk;
        this.jumlahTiket = jumlahTiket;
    }

    public override int hitungTotalTiket()
    {
        return hargaMasuk * jumlahTiket;
    }

    public override void tampilInfo()
    {
        base.tampilInfo();
        Console.WriteLine($"Total Tiket : Rp {hitungTotalTiket()}");
        Console.WriteLine();
    }

}

class TiketWeekend : TiketWisata
{
    private int hargaMasuk;
    private int jumlahTiket;
    private int biayaTerusanWahana;

    public TiketWeekend(string namaPengunjung, string idTiket, string wahanaUtama, int hargaMasuk, int jumlahTiket, int biayaTerusanWahana)
        : base(namaPengunjung, idTiket, wahanaUtama)
    {
        this.hargaMasuk = hargaMasuk;
        this.jumlahTiket = jumlahTiket;
        this.biayaTerusanWahana = biayaTerusanWahana;
    }

    public override int hitungTotalTiket()
    {
        return (hargaMasuk * jumlahTiket) + biayaTerusanWahana;
    }

    public override void tampilInfo()
    {
        base.tampilInfo();
        Console.WriteLine($"Total Tiket : Rp {hitungTotalTiket()}");
        Console.WriteLine();
    }

}

class RiwayatKunjungan
{
    public string JenisTiket { get; set; }
    public int JumlahTiket { get; set; }
    public string TanggalKunjungan { get; set; }

    public RiwayatKunjungan(string jenisTiket, int jumlahTiket, string tanggalKunjungan)
    {
        JenisTiket = jenisTiket;
        JumlahTiket = jumlahTiket;
        TanggalKunjungan = tanggalKunjungan;
    }

    public void tampilRiwayat(int no)
    {
        Console.WriteLine($"{no}. {JenisTiket} | {JumlahTiket} Tiket | {TanggalKunjungan}");
    }

}


class Program
{
    static void Main(string[] Args)
    {
        TiketWisata tiketWisata1 = new TiketWeekend("Feri", "TW001", "Roller Coaster", 4, 50000, 25000);
        TiketWisata tiketwisata2 = new TiketWeekday("Fery", "TW001", "Roller Coaster", 4, 50000);

        tiketWisata1.tampilInfo();
        tiketwisata2.tampilInfo();

        RiwayatKunjungan riwayat1 = new RiwayatKunjungan("Weekend", 4, "18-10-2025");
        RiwayatKunjungan riwayat2 = new RiwayatKunjungan("Weekday", 4, "14-10-2025");

        riwayat1.tampilRiwayat(1);
        riwayat2.tampilRiwayat(2);
    }

}
