using System.Runtime.CompilerServices;

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
        SimpleDataBase<float> simpleDataBase = new SimpleDataBase<float>();
        simpleDataBase.AddNewData(12);
        simpleDataBase.AddNewData(34);
        simpleDataBase.AddNewData(56);
        simpleDataBase.PrintAllData();
    }
}