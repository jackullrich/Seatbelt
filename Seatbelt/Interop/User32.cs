using System.Runtime.InteropServices;

namespace Seatbelt.Interop
{
    internal class User32
    {
        [DllImport("User32.dll")]
        public static extern bool GetLastInputInfo(ref LastInputInfo lastInputInfo);

        internal struct LastInputInfo
        {
            public uint Size;
            public uint Time;
        }
    }
}
