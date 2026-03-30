using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AxataPOS.LogReader;

public partial class Details : KryptonForm
{
    public LogEntry DataLog { get; set; }

    public Details()
    {
        InitializeComponent();
    }

    private void Details_Load(object sender, EventArgs e)
    {
        try
        {
            DataLog = DataLog ?? throw new ArgumentNullException(nameof(DataLog));
            this.lblModule.Text = DataLog.Logger;
            this.lblDate.Text = DataLog.Time.ToString("dddd, dd-MM-yyyy hh:mm:dd:ff");
            this.lblLevel.Text = DataLog.Level;
            this.rtbMessage.Text = DataLog.Message;
            this.rtbException.Text = DataLog.Exception;
            this.rtbProperties.Text = FormatJson(DataLog.Properties);
            lblLevel_TextChanged(sender, e);
        }
        catch (Exception err)
        {
            MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static string FormatJson(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        try
        {
            JToken token = JToken.Parse(value);

            if (token.Type == JTokenType.String)
            {
                string innerJson = token.Value<string>();

                if (!string.IsNullOrWhiteSpace(innerJson))
                {
                    try
                    {
                        JToken innerToken = JToken.Parse(innerJson);
                        return innerToken.ToString(Formatting.Indented);
                    }
                    catch (JsonReaderException)
                    {
                    }
                }
            }

            return token.ToString(Formatting.Indented);
        }
        catch (JsonReaderException)
        {
            return value;
        }
        catch
        {
            return value;
        }
    }

    private void lblLevel_TextChanged(object sender, EventArgs e)
    {
        LogLevel level = (LogLevel)Enum.Parse(typeof(LogLevel), lblLevel.Text);

        switch (level)
        {
            case LogLevel.Error:
                SetColor(lblLevel, Color.Red);
                break;
            case LogLevel.Warn:
                SetColor(lblLevel, Color.BlueViolet);
                break;
            case LogLevel.Info:
            default:
                SetColor(lblLevel, Color.Green);
                break;
        }
    }

    private void SetColor(Control control, Color color)
    {
        if (control is KryptonLabel label)
        {
            label.StateCommon.ShortText.Color1 = color;
            label.StateCommon.ShortText.Color2 = color;
        }
    }
}
