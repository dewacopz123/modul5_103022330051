class PemrosesData
{
    public static void DapatkanNilaiTerbesar<T>(T satu, T dua, T tiga)
    {
        dynamic s = (dynamic)satu;
        dynamic d = (dynamic)dua;
        dynamic t = (dynamic)tiga;

        if(s > d && s > t)
        {
            Console.WriteLine("satu paling besar");
        }else if(d > s && d > t)
        {
            Console.WriteLine("dua lebih besar");
        }
        else
        {
            Console.WriteLine("tiga lebih besar");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData.DapatkanNilaiTerbesar<float>(12, 34, 56);
    }
}