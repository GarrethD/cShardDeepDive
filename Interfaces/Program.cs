//Classes are concrete implementaitons of things like Vehicle > automobile > car|Truck|coupe
//interfaces are differnet to concrete classes
//Interfaces are the API (Application programming interface) contract that we want to have for things we want to create

/*
 * NB!!!! Interfaces are just the definition of how we would interact with something NOT the implementation of that something.
 */

//interfaces in C# are a way to define a contract or API.
//Things that implmeent the interface MUST implement ALL of the members of the interface

//In C# you can NOT inherit from multiple Classes ,but you can Inherit from Multiple interfaces


//===========================Example usage ===================================
Motrocycle motrocycle = new();
motrocycle.StartEngine();
Console.WriteLine(motrocycle.IsEngineRunning);

motrocycle.StopEngine();
Console.WriteLine(motrocycle.IsEngineRunning);

motrocycle.StopEngine();
Console.WriteLine(motrocycle.IsEngineRunning);


//=========================Class construction==================================

public class Motrocycle : IMotorized
{
    public bool IsEngineRunning { get; private set; }

    public void StartEngine()
    {
        if (IsEngineRunning)
        {
            return;
        }

        IsEngineRunning = true;
        Console.WriteLine("Engine has started");
    }

    public void StopEngine()
    {
        if (!IsEngineRunning)
        {
            return;
        }

        IsEngineRunning = false;
        Console.WriteLine("Engine has stopped"); 
    }
}

public class Room : IHasDoors
{
    private readonly bool[] _doors;

    public Room(int numberOfDoors)
    {
        //Note: We're not doing any error checking here or in the rest of the class
        _doors = new bool[numberOfDoors];
    }

    public int NumberOfDoors => _doors.Length;

    public void OpenDoor(int doorIndex)
    {
        _doors[doorIndex] = true;
    }

    public void CloseDoor(int doorIndex)
    {
        _doors[doorIndex] = false;
    }

    public bool IsDoorOpen(int doorIndex) 
    {
        return _doors[doorIndex];
    }
}



//=======================Interface implementation==============================
public interface IHasDoors
{
    int NumberOfDoors { get; }

    void OpenDoor(int doorIndex);

    void CloseDoor(int doorIndex);

    bool IsDoorOpen(int doorIndex);
}

public interface IMotorized
{
    bool IsEngineRunning { get; }

    void StartEngine();

    void StopEngine();
}