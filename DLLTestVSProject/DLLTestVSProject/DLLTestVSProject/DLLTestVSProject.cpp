// DLLTestVSProject.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <iostream>

extern "C" {
	__declspec(dllexport) int unityTest0() {
		return 15;
	}
}


