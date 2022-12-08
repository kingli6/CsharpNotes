// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// MISTAKE 1 ?
// Mistake 2. I didn't have get set in lot of the robot class...

Robot robot1 = new Robot();
robot1.Commands.Append(new RobotPowerOn());  // MISTAKE 1? With array, i tried to add an item with Append(). Does that work? 
                                             // with append, I get: "System.NullReferenceException: 'Object reference not set to an instance of an object"
robot1.Commands[1] = (new MoveForward());
robot1.Commands[2] = (new MoveForward());

robot1.Run();


public class RobotPowerOn : IRobotCommands
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class MoveForward : IRobotCommands
{
    public void Run(Robot robot)
    {
        if(robot.IsPowered) robot.X++;
    }
}

public interface IRobotCommands
{
    void Run(Robot robot);
}
public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommands[] Commands { get; set; } = new IRobotCommands[3]; //Q. Can I have interface as type? Why is it good/bad?

    public void Run()
    {
        foreach (IRobotCommands commands in Commands)   //HEre is a good example of when Interface can be used as a type
        {                                             // IRobotCommans is inherited by all commands, and that's whats 
                                                        // needed here. So that type can be used.
            commands.Run(this);
            Console.WriteLine($"{X}, {Y}, {IsPowered}");
        }
    }

}