using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DLLTesting
{
    class Program
    {
        [DllImport(@"C:\Users\RHVR3.RHVR3\Desktop\Projects\Jerry\OpenPosePlayground\OpenPoseTesting\openpose-master\windows\DLLTesting\bin\extract_from_image.dll", CallingConvention = CallingConvention.Cdecl)]

        public static extern int openPoseTutorialPose1();
        static void Main(string[] args)
        {
            Console.WriteLine(openPoseTutorialPose1());
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();



        }
    }
}
