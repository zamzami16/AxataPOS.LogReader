namespace AxataPOS.LogReader;

internal class Config
{
    internal static int BATCH_SIZE
    {
        get
        {
            var setting = new Settings().Load();
            return setting.BatchSize;
        }
    }
}
