using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ScriptTesting : MonoBehaviour
{
    
    [DllImport("extract_from_image", CallingConvention = CallingConvention.Cdecl)]
    public static extern float openPoseDemo();

    public float result;

    // Use this for initialization
    void Update()
    {
        result = openPoseDemo();
        Debug.Log(result);
    }


}