// Problem 1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <iostream>
#include <fstream>

using namespace std;

// Complete the timeInWords function below.
string timeInWords(int h, int m) {
	string nums[] = { "zero", "one", "two", "three", "four",
						"five", "six", "seven", "eight", "nine",
						"ten", "eleven", "twelve", "thirteen",
						"fourteen", "fifteen", "sixteen", "seventeen",
						"eighteen", "nineteen", "twenty", "twenty one",
						"twenty two", "twenty three", "twenty four",
						"twenty five", "twenty six", "twenty seven",
						"twenty eight", "twenty nine",
	};

	string result;

	if (m == 0)
		result = nums[h] + string(" o' clock");

	else if (m == 1)
		result = string("one minute past ") + nums[h];

	else if (m == 59)
		result = string("one minute to ") + nums[(h % 12) + 1];

	else if (m == 15)
		result = string("quarter past ") + nums[h];

	else if (m == 30)
		result = string("half past ") + nums[h];

	else if (m == 45)
		result = string("quarter to ") + nums[(h % 12) + 1];

	else if (m <= 30)
		result = nums[m] + string(" minutes past ") + nums[h];

	else if (m > 30)
		result = nums[60 - m] + string(" minutes to ") + nums[(h % 12) + 1];

	return result;
}

int main()
{
	ofstream fout("C:\\repos\\TesteRadi\\OUTPUT1.TXT");

	int h;
	cin >> h;
	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	int m;
	cin >> m;
	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	string result = timeInWords(h, m);

	fout << result.c_str() << "\n";

	fout.close();

	return 0;
}


