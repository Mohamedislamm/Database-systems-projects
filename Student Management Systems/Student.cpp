#include "Student.h"
using namespace std;


Student::Student() {
	id = 0;
	name = '\0';
	grade = '\0';
}
Student::Student(int i, string n) {
	id = i;
	name = n;
}
void Student::Add_Marks(string s,int m) {
	
    auto it = find_if(subjectMarks.begin(), subjectMarks.end(),
        [s](auto& p) {return p.first == s; });
	
    if (it != subjectMarks.end())
    {
        it->second = m;
        cout << "Mark added succesfully" << endl;
    }
    else
    {
        cout << "Subject not found!" << endl;
    }
}

void Student::Calculate_Grade() {

    int TotalMarks = 0;
    for (int i = 0; i < subjectMarks.size(); i++) {
        TotalMarks += subjectMarks[i].second;
    }

    int avgMarks = TotalMarks / subjectMarks.size();

    if (avgMarks >= 90) {
        grade = 'A';
    }
    else if (avgMarks >= 80) {
        grade = 'B';
    }
    else if (avgMarks >= 70) {
        grade = 'C';
    }
    else if (avgMarks >= 60) {
        grade = 'D';
    }
    else {
        grade = 'F';
    }
}

int Student::getid() {
    return id;
}

string Student::getname() {
    return name;
}

void Student :: setname(string n) {
    name = n;
}

void Student::setid(int x) {
    id = x;
}

char Student::getgrade() {
    Calculate_Grade();
    return grade;
}

vector<pair<string, int>> Student::getSubjectMarks()
{
    return subjectMarks;
}

void Student::setsubj(string s)
{
    subjectMarks.push_back(make_pair(s, 0));
}