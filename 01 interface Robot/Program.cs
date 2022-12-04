// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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

interface IRobotCommands
{
    void Run(Robot robot);
}
public class Robot
{
    public int X;
    public int Y;
    public bool IsPowered;
    IRobotCommands[] Commands = new IRobotCommands[3];  //Q. Can I have interface as type?

    public void Run()
    {
        foreach (IRobotCommands commands in Commands)
        {
            commands.Run(this);
            Console.WriteLine($"{X}, {Y}, {IsPowered}");
        }
    }

}