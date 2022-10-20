namespace Proyecto;

    public class RoomKey
    {
        public Guid IdLlave { get; private set; }

        public RoomKey(Guid IdLlave)
        {
            this.IdLlave = Guid.NewGuid();
        }
    }
