#include <vector>
#include <string>
using namespace std;

class SearchEngine
{
	
public:
	vector<pair<string, string>> searchByID(string id);
	vector<pair<string, string>> searchByName(string name);
};