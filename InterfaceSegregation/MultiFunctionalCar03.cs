namespace InterfaceSegregation
{
    //Or if we already have implemented the Car class and the Airplane class,
    //we can use them inside our class by using the decorator pattern:

    public class MultiFunctionalCar03 : IMultiFunctionalVehicle
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalCar03(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }

        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}
