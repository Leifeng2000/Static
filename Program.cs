using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Add();
    }


    static void Add()
    {
        Console.WriteLine("Truong caua ban la " + SinhVien.School);
        SinhVien sv = new SinhVien();
        Console.WriteLine("Lop cua ban la "+ sv.MyClass);
    }
}
class SinhVien
{
    public string MyClass="CNTT";
    public static string School="Fpt";
}