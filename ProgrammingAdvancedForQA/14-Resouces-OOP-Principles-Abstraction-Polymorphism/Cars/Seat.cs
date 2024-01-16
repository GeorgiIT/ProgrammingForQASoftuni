using Cars;

public class Seat : ICar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public Seat(string model, string colar)
    {
        this.Model = model;
        this.Color = colar;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {

        return "Break";
    }

    public override string ToString()
    {
        return $"{this.Color} Seat {this.Model}\n" +
        $"{this.Start()}\n" +
        $"{this.Stop()}";
    }
}