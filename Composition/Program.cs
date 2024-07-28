/*
 * We can use the idea of composition to create an object that is made up of other object!
 * This models an 'Is made up of' relationship (whereas inheritance models an 'is a' relationship)
 */

/*
 * Let's use composition to model a desktop computer!
 * We will need:
 *  - A case
 *  - A motherboard
 *  - A CPU
 *  - A power supply
 *  - A hard drive
 *  - Ram
 *  - A Graphics Card
 */

public sealed class Case
{
    public void PressPowerButton()
    {
        Console.WriteLine("Power button pressed");
    }
}

public sealed class Motherboard
{
    public void Boot()
    {
        Console.WriteLine("Booting...");
    }
}

public sealed class PowerSupply
{
    public void TurOn()
    {
        Console.WriteLine("Power supply turned on");
    }
}

public sealed class HardDrive
{
    private readonly int _sizeInTb;

    public HardDrive(int sizeInTb)
    {
        _sizeInTb = sizeInTb;
    }

    public void ReadData()
    {
        Console.WriteLine($"Reading date from hard drive with capacity of {_sizeInTb} TB.");
    }
}

public sealed class Ram
{
    private readonly int _sizeInGb;

    public Ram(int sizeInGb)
    {
        _sizeInGb = sizeInGb;
    }

    public void Load()
    {
        Console.WriteLine($"Reading date from hard drive with capacity of {_sizeInGb} TB.");
    }
}

public sealed class GraphicsCard
{
    public void Render()
    {
        Console.WriteLine("Rendering graphics");
    }
}

public sealed class Computer
{
    
    private readonly Case _theCase;
    private readonly Motherboard _theMotherboard;
    private readonly PowerSupply _thePowerSupply;
    private readonly HardDrive _theHardDrive;
    private readonly Ram _theRam;
    private readonly GraphicsCard _theGraphicsCard;

    public Computer(Case theCase, Motherboard motherboard, PowerSupply powerSupply, HardDrive hardDrive, Ram ram, GraphicsCard graphicsCard)
    {
        _theCase = theCase;
       _theMotherboard = motherboard;
       _thePowerSupply = powerSupply;
       _theHardDrive = hardDrive;
       _theRam = ram;
       _theGraphicsCard = graphicsCard;
       
    }
    
    public void PowerOn()
    {
       _theCase.PressPowerButton();
       _thePowerSupply.TurOn();
       _theMotherboard.Boot();
       _theRam.Load();
       _theHardDrive.ReadData();
       _theGraphicsCard.Render();
    }
    
    // Main Method
    public static void Main(String[] args)
    {
        Console.WriteLine("Main Method");
    }
}

