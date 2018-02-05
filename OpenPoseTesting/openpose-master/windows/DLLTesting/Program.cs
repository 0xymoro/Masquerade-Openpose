using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DLLTesting
{
    class Program
    {
        //C:\Users\RHVR3.RHVR3\Desktop\Projects\Jerry\Masquerade-OpenPose\OpenPoseTesting\openpose-master\windows\x64\Release\extract_from_image.dll"
        [DllImport(@"C:\Users\RHVR3.RHVR3\Desktop\Projects\Jerry\Masquerade-OpenPose\OpenPoseTesting\openpose-master\windows\x64\Release\extract_from_image.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern float openPoseDemo();
        static void Main(string[] args)
        {
            Console.WriteLine(openPoseDemo());
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();



        }
    }
}
