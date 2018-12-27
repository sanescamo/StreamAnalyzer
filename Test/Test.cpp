// MathClient.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

// MathClient.cpp : Client app for MathLibrary DLL.
#include "pch.h"
#include <iostream>
#include "Stream_Analyzer_MPEG2_DLL.h"

int main()
{
	start_analyzer();
	std::string result = ""; 
	while (result != "{end}")
		std::string t = getJSONAnalyzed(nullptr);
	//// Initialize a Fibonacci relation sequence.
	//fibonacci_init(1, 1);
	//// Write out the sequence values until overflow.
	//do {
	//	std::cout << fibonacci_index() << ": "
	//		<< fibonacci_current() << std::endl;
	//} while (fibonacci_next());
	//// Report count of values written before overflow.
	//std::cout << fibonacci_index() + 1 <<
	//	" Fibonacci sequence values fit in an " <<
	//	"unsigned 64-bit integer." << std::endl;
}