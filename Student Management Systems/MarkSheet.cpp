#include "MarkSheet.h"
#include "Student.h"

char MarkSheet::CalcGrade(int m)
{
    if (m >= 90) {
        return 'A';
    }
    else if (m >= 80) {
        return 'B';
    }
    else if (m >= 70) {
        return 'C';
    }
    else if (m >= 60) {
        return 'D';
    }
    else {
        return 'F';
    }
}

MarkSheet::MarkSheet(Student s)
{
	MarkSheet::student = s;
	vector <pair<string, int>> subjectMarks = s.getSubjectMarks();
	for (int i = 0; i < subjectMarks.size(); i++)
	{
		TotalMarks += subjectMarks[i].second;
        subjectGrade.push_back(make_pair(subjectMarks[i].first, CalcGrade(subjectMarks[i].second)));
	}
}

void MarkSheet :: Generate() {

}

void MarkSheet :: Display() {
	cout << "Name: " << student.getname() << endl;
	cout << "ID: " << student.getid() << endl;
	cout << "Grade: " << student.getgrade() << endl;
	cout << "Marks: " << endl;
	vector <pair<string, int>> subjectMarks = student.getSubjectMarks();
	for (int i = 0; i < subjectMarks.size(); i++)
	{
		cout << subjectMarks[i].first << ": " << subjectMarks[i].second << ": " << subjectGrade[i].second << endl;
	}
	cout << "Total Marks: " << TotalMarks << endl;
	cout << "======================================";
}
