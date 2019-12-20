using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace chat_server
{
    [StructLayout(LayoutKind.Sequential)]
    class Blittable
    {
        int x;
    }

    public unsafe static class APIAddress
    {
        public static string GetAPIAddress()
        {
            int i;
            object o = new Blittable();
            int* ptr = &i;
            IntPtr addr = (IntPtr)ptr;

            string retVal = addr.ToString("x");

            GCHandle h = GCHandle.Alloc(o, GCHandleType.Pinned);
            addr = h.AddrOfPinnedObject();
            retVal = addr.ToString("x");

            h.Free();
            Random rnd = new Random();

            return retVal + rnd.Next(0, 9).ToString();
        }
    }
}
