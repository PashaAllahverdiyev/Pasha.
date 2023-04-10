public class Mercedes : car
{
    public bool IsAmg;
    public Mercedes(string model, int km, int topspeed, int engine, int hp, bool IsAmg)  :base(model, km, topspeed, engine, hp)
    {
        this.IsAmg = IsAmg;
    }


    public void GetMercedesInfo(string model, int km, int topspeed, int engine, int hp, bool IsAmg)
    {
        Console.WriteLine($"{this.model},{this.km},{this.topspeed},{this.engine},{this.hp} ");
        if (IsAmg)
        {
            Console.WriteLine("Amgdir");
        }
        else
        {
            Console.WriteLine("Amg deyil");
        }

    }

}
