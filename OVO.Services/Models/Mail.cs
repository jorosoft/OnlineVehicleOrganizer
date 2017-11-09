using OVO.Services.Enumerations;

namespace OVO.Services.Models
{
    public class Mail
    {
        public int Day { get; set; }

        public int Month { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string RegNumber { get; set; }

        public string DestinationEmail { get; set; }

        public MailType MailType { get; set; }

        public int NotifiedVehiclesCount { get; set; }
    }
}
