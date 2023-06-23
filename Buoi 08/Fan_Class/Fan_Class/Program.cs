namespace Fan_Class;

class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.turnOn();
        fan1.setSpeed(3);
        fan1.setRadius(10);
        fan1.setColor("Yellow");
        fan1.toString();

        Fan fan2 = new Fan(2, false, "Blue", 5);
        fan2.toString();
    }
}

