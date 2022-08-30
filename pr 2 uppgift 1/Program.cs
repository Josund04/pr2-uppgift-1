// See https://aka.ms/new-console-template for more information
Car m = new Car();
        m.tillverkare = "Mazda";
        m.modell = "2";
        m.årtal = 2003;
        m.vikt = 1170;
       
        Console.WriteLine(m.tillverkare);
        Console.WriteLine(m.modell);
        Console.WriteLine(m.årtal);
        Console.WriteLine(m.vikt);

        Car v = new Car();
        v.tillverkare = "Volvo";
        v.modell = "v90";
        v.årtal = 1765;
        v.vikt = 1879;
       
        Console.WriteLine(v.tillverkare);
        Console.WriteLine(v.modell);
        Console.WriteLine(v.årtal);
        Console.WriteLine(v.vikt);
class Car {
    
    public string tillverkare;
    public string modell;
    public int årtal;
    public int vikt;
public int Årtal
{
    get { return årtal; }
    set{
        if (value < 1769){
            Console.WriteLine("Fel!, Årtalet måste vara större än 1768");
            årtal = 1768;
        }
        else
            årtal = value;
    }
}
}

