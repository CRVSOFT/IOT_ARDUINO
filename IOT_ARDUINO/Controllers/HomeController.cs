using Microsoft.AspNetCore.Mvc;

namespace IOT_ARDUINO.Controllers
{
    public class HomeController : Controller
    {
        #region Fields

        private readonly ILogger<HomeController> logger;

        #endregion

        #region Constructors

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        #endregion

        #region Proprietes

        public ILogger<HomeController> Logger
        {
            get
            {
                return this.logger;
            }
        }

        #endregion

        #region Methods



        #endregion

    }
}