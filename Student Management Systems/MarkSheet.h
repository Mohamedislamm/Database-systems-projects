#ifndef MARKSHEET_H
#define MARKSHEET_H

#include <iostream>
#include <vector>
#include "Student.h"

class MarkSheet {
	Student student;
	vector <pair<string, char>> subjectGrade;
	int TotalMarks;
public:
	MarkSheet(Student);
	void Generate();
	void Display();
	char CalcGrade(int);
};
#endif