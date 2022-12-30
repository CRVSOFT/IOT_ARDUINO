namespace IOT_ARDUINO.Models
{
    public class ErrorViewModel
    {
        #region Fields

        private string? requestId;

        #endregion

        #region Constructors
        #endregion

        #region Proprietes

        public string? RequestId
        {
            get 
            { 
                return this.requestId; 
            }
            set
            {
                this.requestId = value;
            }
        }

        #endregion

        #region Methods

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        #endregion
    }
}