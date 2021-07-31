using System.Windows.Forms;
namespace KeyPresser
{
    class KeyboardInterpreterObject
    {
        public bool LShiftDown = false;
        public bool RShiftDown = false;
        public string KeyboardInterpreter(int Code)
        {
            switch (Code)
            {
                case (int)Keys.Escape:
                    {
                        return "ESC";
                    }
                case (int)Keys.Enter:
                    {
                        return "ENTER";
                    }
                case (int)Keys.LMenu:
                    {
                        return "LALT";
                    }
                case (int)Keys.LControlKey:
                    {
                        return "LCTRL";
                    }
                case (int)Keys.Back:
                    { 
                        return "Back";
                    }
                case (int)Keys.RControlKey:
                    {
                        return "RCTRL";
                    }
                case (int)Keys.Space:
                    {
                        return "SPACE";
                    }
                case (int)Keys.LShiftKey:
                    {
                        LShiftDown = true;
                        return "LShift";
                    }
                case (int)Keys.RShiftKey:
                    {
                        RShiftDown = true;
                        return "RShift";
                    }
                case (int)Keys.OemMinus:
                    {
                        return "-";
                    }
                case (int)Keys.Oemplus:
                    {
                        return "=";
                    }
                case (int)Keys.Oemcomma:
                    {
                        return ",";
                    }
                case (int)Keys.OemPeriod:
                    {
                        return ".";
                    }
                case (int)Keys.OemOpenBrackets:
                    {
                        return "[";
                    }
                case (int)Keys.OemCloseBrackets:
                    {
                        return "]";
                    }
                case (int)Keys.Oem1:
                    {
                        return ";";
                    }
                case (int)Keys.Oem2:
                    {
                        return "/";
                    }
                case (int)Keys.OemQuotes:
                    {
                        return "'";
                    }
                case (int)Keys.Oemtilde:
                    {
                        return "`";
                    }
                case (int)Keys.OemPipe:
                    {
                        return "\\";
                    }
                case (int)Keys.F1:
                    {
                        return "F1";
                    }
                case (int)Keys.F2:
                    {
                        return "F2";
                    }
                case (int)Keys.F3:
                    {
                        return "F3";
                    }
                case (int)Keys.F4:
                    {
                        return "F4";
                    }
                case (int)Keys.F5:
                    {
                        return "F5";
                    }
                case (int)Keys.F6:
                    {
                        return "F6";
                    }
                case (int)Keys.F7:
                    {
                        return "F7";
                    }
                case (int)Keys.F8:
                    {
                        return "F8";
                    }
                case (int)Keys.F9:
                    {
                        return "F9";
                    }
                case (int)Keys.F10:
                    {
                        return "F10";
                    }
                case (int)Keys.F11:
                    {
                        return "F11";
                    }
                case (int)Keys.F12:
                    {
                        return "F12";
                    }
                case (int)Keys.Up:
                    {
                        return "Up";
                    }
                case (int)Keys.Down:
                    {
                        return "Down";
                    }
                case (int)Keys.Left:
                    {
                        return "<-";
                    }
                case (int)Keys.Right:
                    {
                        return "->";
                    }
            }
            return System.Convert.ToChar(Code).ToString();
        }
        public string KeyboardInterpreterShift(int Code)
        {
            switch (Code)
            {
                case (int)Keys.D1:
                    {
                        return "!";
                    }
                case (int)Keys.D2:
                    {
                        return "@";
                    }
                case (int)Keys.D3:
                    {
                        return "#";
                    }
                case (int)Keys.D4:
                    {
                        return "$";
                    }
                case (int)Keys.D5:
                    {
                        return "%";
                    }
                case (int)Keys.D6:
                    {
                        return "^";
                    }
                case (int)Keys.D7:
                    {
                        return "&&";
                    }
                case (int)Keys.D8:
                    {
                        return "*";
                    }
                case (int)Keys.D9:
                    {
                        return "(";
                    }
                case (int)Keys.D0:
                    {
                        return ")";
                    }
                case (int)Keys.OemMinus:
                    {
                        return "_";
                    }
                case (int)Keys.Oemplus:
                    {
                        return "+";
                    }
                case (int)Keys.Oemtilde:
                    {
                        return "~";
                    }
                case (int)Keys.Oem2:
                    {
                        return "?";
                    }
                case (int)Keys.OemQuotes:
                    {
                        return "\"";
                    }
                case (int)Keys.Oem1:
                    {
                        return ":";
                    }
                case (int)Keys.Oemcomma:
                    {
                        return "<";
                    }
                case (int)Keys.OemPeriod:
                    {
                        return ">";
                    }
                case (int)Keys.OemPipe:
                    {
                        return "|";
                    }
            }
            return System.Convert.ToChar(Code).ToString();
        }
    }
}
