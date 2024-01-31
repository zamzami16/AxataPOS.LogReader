using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace AxataPOS.App.Componen
{
    public sealed class AxataBackgroundWorker : BackgroundWorker
    {
        public AxataBackgroundWorker() : base()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo englishCulture = new("en-US");
            if (currentCulture.EnglishName != englishCulture.EnglishName)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = englishCulture;
                    Thread.CurrentThread.CurrentUICulture = englishCulture;
                }
                catch
                {
                }
            }
        }
    }
}
