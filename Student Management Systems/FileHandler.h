#ifndef FILEHANDLER_H
#define FILEHANDLER_H
#include <string>
#include <fstream>
using namespace std;

class FileHandler
{
	string file_path;
public:
	FileHandler(string);
	string ReadData();
	bool WriteData(string);
	
};
#endif
