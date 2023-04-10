using System.Xml.Schema;

public class car
{
    public string model;
    public int topspeed;
    public int engine;
    public int km;
    public int hp;
        public car(string model, int topspeed, int engine,int km, int hp)
     {
        this.model=model;
        this.topspeed=topspeed;

        this.engine=engine;
        this.km=km;
        this.hp=hp;
        
    }

}