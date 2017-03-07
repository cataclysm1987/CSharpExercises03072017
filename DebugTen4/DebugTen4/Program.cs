// class HotelRoom has child classes SingleRoom which costs less,
// and Suite which costs more
using static System.Console;
class DebugTen04
{
    static void Main()
    {
        HotelRoom aRoom = new HotelRoom(234);
        SingleRoom aSingle = new SingleRoom(135);
        Suite aSuite = new Suite(453);
        WriteLine(aRoom.ToString());
        WriteLine(aSingle.ToString());
        WriteLine(aSuite.ToString());
    }
}
class HotelRoom
{
    public const double PREMIUM = 30.00;
    public const double STD_RATE = 89.99;
    protected int roomNumber;
    protected double rate;
    public HotelRoom(int room)
    {
        roomNumber = room;
        rate = STD_RATE;
    }

    protected HotelRoom()
    {
        roomNumber = 1;
        rate = STD_RATE;
    }

    public int RoomNumber => roomNumber;

    private int roomNum { get; set; }

    
    public override string ToString()
    {
        string temp = GetType() + " Room " + RoomNumber + " Rate: " +
          Rate.ToString("C");
        return temp;
    }

    public double Rate
    {
        get { return rate; } 
        set { rate = value; }
    }
}
class SingleRoom : HotelRoom
{
   public SingleRoom(int room) : base (room)
   {
    rate -= PREMIUM;
}   
}
class Suite : HotelRoom
{
   public Suite(int room)
   {
       rate += PREMIUM;
       roomNumber = room;
   }

}

