namespace Proyecto;

    public class Hotel
    {
        public string HotelLocation { get; private set; }
        public List<Habitacion> Habitaciones { get; private set; }

        public Hotel(string HotelLocation)
        {
            this.HotelLocation = HotelLocation;
            this.Habitaciones = new List<Habitacion>();
        }
    }