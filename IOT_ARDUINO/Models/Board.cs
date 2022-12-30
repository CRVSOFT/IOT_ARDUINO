using System.ComponentModel.DataAnnotations;

namespace IOT_ARDUINO.Models
{
    public class Board
    {
        #region Fields

        private string? id;
        private string? deviceName;
        private string? comPort;
        private string? serialBaud;
        private string? image;

        #endregion

        #region Constructors
        #endregion

        #region Proprietes

        [Key]
        public string? IdBoard
        {
            get => this.id;
            set
            {
                id = value;
            }
        }

        public string? DeviceName
        {
            get => this.deviceName;
            set
            {
                this.deviceName = value;
            }
        }

        public string? ComPort
        {
            get => this.comPort;
            set
            {
                this.comPort = value;
            }
        }

        public string? SerialBaud
        {
            get => this.serialBaud;
            set
            {
                this.serialBaud = value;
            }
        }

        public string? Image
        {
            get => this.image;
            set
            {
                this.image = value;
            }
        }

        #endregion

        #region Methods
        #endregion
    }
}