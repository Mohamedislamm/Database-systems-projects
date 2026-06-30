#include<iostream>
#include "StudentManagementSystems.h"
using namespace std;
class Menu
{
public:
	void DisplayMenu();
	int SelectOption();
	void ExecuteChoice(StudentManagementSystem);
	void ExitSystem();
};

