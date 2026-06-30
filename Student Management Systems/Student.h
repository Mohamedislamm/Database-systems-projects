#ifndef STUDENT_H
#define STUDENT_H

#include <iostream>
#include <string>
#include<vector>
using namespace std;

class Student {
private:
    int id;
    string name;
    vector <pair<string, int>> subjectMarks;
    char grade;

public:
    Student();
    Student(int, string);
    void Add_Marks(string,int);
    void Calculate_Grade();
    void setsubj(string);
    void setid(int);
    void setname(string);
    int getid();
    string getname();
    char getgrade();
    vector <pair<string, int>> getSubjectMarks();
};

#endif
