// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 2;
int b = 3;
Console.WriteLine(a+ b);


static int Topla(int d1,int d2)
{
    return d1 + d2;
}


int sonuc = Topla(a,b);
Console.WriteLine(sonuc);


Metodlar ornek = new Metodlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));


int sonuc2 = ornek.ArttırveTopla(ref a,ref b);

ornek.EkranaYazdir(Convert.ToString(sonuc2));


// Console.ReadLine();

class Metodlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttırveTopla(ref int d1, ref int d2)
    {
        d1 += 1;
        d2 += 1;
        return d1 + d2;
    }


}











