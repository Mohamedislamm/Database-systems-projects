#include <string>
#include"Student.h"
#include<vector>
using namespace std;

#ifndef GRADEDACTIVITY_H
#define GRADEDACTIVITY_H


class StudentManagementSystem :public Student {
private:
	vector <Student> students;
	string adminpass;
public:
	StudentManagementSystem(string);
	void AddStudentRecord(Student);
	void SearchStudentRecord(string);
	void SearchStudentRecord(int);
	void ModifyStudentRecord(int, string);
	void GenerateMarkSheet();
	void DeleteStudentRecord(int);
	void ChangeAdminPassword(string);
};
#endif