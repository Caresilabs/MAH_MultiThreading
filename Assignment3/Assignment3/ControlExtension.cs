using System;
using System.Windows.Forms;

namespace Assignment3
{
    public static class ControlExtension
    {
        public static void InvokeMain(this Control control, Action action)
        {
            control.BeginInvoke(new MethodInvoker(action), null);
        }
    }
}
