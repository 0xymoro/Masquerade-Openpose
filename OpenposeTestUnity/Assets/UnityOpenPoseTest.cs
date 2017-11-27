using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class UnityOpenPoseTest : MonoBehaviour {
    //[DllImport("DLLTestVSProject", CallingConvention = CallingConvention.Cdecl)]
    //[DllImport("OpenPose", CallingConvention = CallingConvention.Cdecl)]
    [DllImport("extract_from_image", CallingConvention = CallingConvention.Cdecl)]
    public static extern int unityTest0();
    // Use this for initialization
    void Start () {
        Debug.Log(unityTest0());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
