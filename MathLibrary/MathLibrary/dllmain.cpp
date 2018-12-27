// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"
#include <string>

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

extern "C" __declspec(dllexport) char * test3(char *data)
{
	std::string str;
	str = "Test2";
	char *p = new char[50];
	strcpy(p, "Esto es una prueba");
	return p;
}