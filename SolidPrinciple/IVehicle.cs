namespace SolidPrinciple
{
    public interface IVehicle
    {
        //Every method defined within an interface is public by default...
        void Move();

        //Properties
        public string Color { get; }
    }
}