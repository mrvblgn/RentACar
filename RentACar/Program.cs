using RentACar.Service;

CarService carService = new CarService();
ColorService colorService = new ColorService();
FuelService fuelService = new FuelService();
TransmissionService transmissionService = new TransmissionService();

colorService.Remove(1);
colorService.GetAll();