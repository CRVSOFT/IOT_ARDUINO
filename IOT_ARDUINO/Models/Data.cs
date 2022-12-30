namespace IOT_ARDUINO.Models
{
    public class Data
    {
        #region Fields

        private string? batteryPercent;
        private string? value;
        private SensorType type;
        private string? image;

        #endregion

        #region Constructors
        #endregion

        #region Proprietes

        public string? BatteryPercent
        {
            get => this.batteryPercent;
            set
            {
                batteryPercent = value;
            }
        }

        public string? Value
        {
            get => this.value;
            set
            {
                this.value = value;
            }
        }

        public SensorType Type
        {
            get => this.type;
            set
            {
                this.type = value;
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

    public enum SensorType
    {
        Temperature,
        Humidity,
        Gas
    }
}