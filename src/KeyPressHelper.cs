using System;
using System.Windows.Forms;

namespace AxataPOS.App.Helper
{
    /// <summary>
    /// Class untuk menghandle proses penekanan tombol keyboard
    /// </summary>
    public static class KeyPressHelper
    {
        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Enter
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsEnter(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Return);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Enter
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsEnter(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Enter);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Bawah
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsUp(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Up);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Atas
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsDown(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Down);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Kanan
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsRight(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Right);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Kiri
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsLeft(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Left);
        }

        /// <summary>
        /// Untuk mengecek apakah user menekan tombol Esc
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool IsEsc(KeyPressEventArgs e)
        {
            return (e.KeyChar == (char)Keys.Escape);
        }

        public static bool IsEsc(KeyEventArgs e)
        {
            return (e.KeyCode == Keys.Escape);
        }

        public static bool IsShortcutKey(Keys shortcut, KeyEventArgs e)
        {
            return (e.KeyCode == shortcut);
        }

        /// <summary>
        /// Untuk pindah ke inputakan berikutnya
        /// </summary>
        public static void NextFocus()
        {
            SendKeys.Send("{Tab}");
        }

        /// <summary>
        /// Untuk validasi input angka
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool NumericOnly(KeyPressEventArgs e)
        {
            string strValid = "0123456789.";

            if (strValid.IndexOf(e.KeyChar) < 0 && !(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return true; // not valid
            }
            else
            {
                return false; // valid
            }
        }

        /// <summary>
        /// Mengirim sinyal penekanan event enter
        /// </summary>
        /// <returns></returns>
        public static KeyPressEventArgs SendEnter()
        {
            return new KeyPressEventArgs((char)Keys.Return);
        }

        public static void OnEnterFocusTo(this KeyEventArgs keyEventArgs, Control target)
        {
            if (IsEnter(keyEventArgs)) target.Focus();
        }

        public static void OnEnterPerform(this KeyEventArgs keyEventArgs, Action action)
        {
            if (IsEnter(keyEventArgs))
            {
                action?.Invoke();
                keyEventArgs.Handled = true;
                keyEventArgs.SuppressKeyPress = true;
            }
        }
    }
}
