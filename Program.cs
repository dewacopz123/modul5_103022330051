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

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " Berisi" + this.storedData[i] + ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData.DapatkanNilaiTerbesar<float>(12, 34, 56);
	SimpleDataBase<float> simpleDataBase = new SimpleDataBase<float>();
        simpleDataBase.AddNewData(12);
        simpleDataBase.AddNewData(34);
        simpleDataBase.AddNewData(56);
        simpleDataBase.PrintAllData();
    }
}