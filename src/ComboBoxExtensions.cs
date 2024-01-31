using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;

namespace AxataPOS.LogReader
{
    public static class ComboBoxExtensions
    {
        public static void SetItems<TEnum>(this KryptonComboBox comboBox) where TEnum : Enum
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("The provided type is not an enum.", nameof(TEnum));
            }

            comboBox.Items.Clear();
            comboBox.Items.AddRange(Enum.GetValues(typeof(TEnum)).Cast<object>().ToArray());
            comboBox.SelectedIndex = 0;
        }

        public static TEnum GetSelectedEnumValue<TEnum>(this KryptonComboBox comboBox) where TEnum : Enum
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("The provided type is not an enum.", nameof(TEnum));
            }

            if (comboBox.SelectedItem == null)
            {
                throw new InvalidOperationException("No item selected in the ComboBox.");
            }

            return (TEnum)comboBox.SelectedItem;
        }
    }
}
