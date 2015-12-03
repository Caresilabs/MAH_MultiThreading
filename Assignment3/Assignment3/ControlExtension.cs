using System;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Helper class for safe invoking Form controls when on another thread than UI.
    /// </summary>
    public static class ControlExtension
    {
        public static void InvokeMain(this Control control, Action action)
        {
            control.BeginInvoke(new MethodInvoker(action), null);
        }
    }
}
