using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class ScriptTesting : MonoBehaviour
{
    
    [DllImport("dllExportProj", CallingConvention = CallingConvention.Cdecl)]
    public static extern int openPoseDemo();

    public int result;

    // Use this for initialization
    void Start()
    {
        result = openPoseDemo();
        Debug.Log(result);
    }


}