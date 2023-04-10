public class Bmw : car
{
    public bool IsMpower;

    public Bmw(string model, int km, int topspeed, int engine, int hp, bool IsMpower) :base(model, km, topspeed, engine,hp)
    {
        this.IsMpower = IsMpower;
    }
    
      
    public void GetBmwInfo(string model, int km, int topspeed, int engine, int hp, bool IsMpower)
    {
        Console.WriteLine($"{this.model},{this.km},{this.topspeed},{this.engine},{this.hp} ");
        if (IsMpower)
        {
            Console.WriteLine("M powerdir");

        }
        else
        {
            Console.WriteLine("M power deyil");
        }
    }
}