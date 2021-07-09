namespace InterfaceSegregation
{
    //We can even use a higher level interface if we want in a situation
    //where a single class implements more than one interface:

    public interface IMultiFunctionalVehicle : ICar, IAirplane
    {
    }
}
