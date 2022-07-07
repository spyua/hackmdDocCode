using System.Windows.Forms;

namespace MVP.Helper
{
    public static class ViewHelp
    {
        public static bool InVaildKeyNumber(this KeyPressEventArgs key, bool withDot = false)
        {
            /*
             48-57是數字0-9
            8是Backspace
            46是小數點
             */
            if (withDot)
            {
                return ((int)key.KeyChar < 48 || (int)key.KeyChar > 57) && (int)key.KeyChar != 8 && (int)key.KeyChar != 46;
            }

            return (((int)key.KeyChar < 48 || (int)key.KeyChar > 57) && (int)key.KeyChar != 8);
        }
    }
}
