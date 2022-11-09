using SolidPrinciple;

EngineeringStudent fortunate = new EngineeringStudent();
ScienceStudent shalewa = new ScienceStudent();
OversabiStudent simbi = new OversabiStudent();

Register(fortunate);
Register(shalewa);
Register(simbi);

Console.WriteLine(simbi.IsRegistered());
Console.WriteLine(shalewa.IsRegistered());
Console.WriteLine(fortunate.IsRegistered());



static void Register(IStudent student)
{
    student.Maths = true;
    Console.WriteLine($"Successfully registered for Math:{student.Maths}");
}
















//IVehicle myVehicle = new Vehicle();
//myVehicle.Move();


//IVehicle anotherVehicle = new Car();
//anotherVehicle.Move();



//Never use all caps for identifiers except for constants
//Liskove substitution
//Liskov subtitution simple means when a child can always stand for a  parent
//Liskov subtitution states that if "A" is a child of "B", "A" will be able to stand for "B"


// Interface Segregation
//An Interface can inherit another interface