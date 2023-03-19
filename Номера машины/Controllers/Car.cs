namespace Номера_машины.Controllers
{
    internal class Car
    {
        public Car(string gosnomer, string model, string color, string fio)
        {
            Gosnomer = gosnomer;
            Model = model;
            Color = color;
            FIO = fio;
        }

        public string Gosnomer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string FIO { get; set; }
    }
}