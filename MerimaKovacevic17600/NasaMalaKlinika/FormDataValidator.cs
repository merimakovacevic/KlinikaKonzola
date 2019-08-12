using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaMalaKlinika
{
    public static class FormDataValidator
    {
        public static void check_and_set_message<T>(T value, Func<T, Boolean> validator_func, Control origin, ErrorProvider errProv, String message)
        {
            if (validator_func(value))
                errProv.SetError(origin, "");
            else
                errProv.SetError(origin, message);
        }

        public static Boolean any_has_error(List<Control> controls, ErrorProvider errProv)
        {
            return controls.Any(x => errProv.GetError(x) != "");
        }

        public static Boolean has_error(Control control, ErrorProvider errProv)
        {
            return errProv.GetError(control) != "";
        }
    }
}
