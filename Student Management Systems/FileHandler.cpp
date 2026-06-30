#include "FileHandler.h"

FileHandler::FileHandler(string d) {
	file_path = d;
}
string FileHandler::ReadData() {
	ifstream file(file_path);
	file.open("Marks.txt");
}
bool FileHandler::WriteData(string x) {
	ofstream file(file_path);
	file.open("Marks.txt");
	file << x;
	file.close();
	return true;
}