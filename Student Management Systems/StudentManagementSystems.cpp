#include"StudentManagementSystems.h"

StudentManagementSystem :: StudentManagementSystem(string pass) {
	
	adminpass = pass;
}

void StudentManagementSystem :: AddStudentRecord(Student s) {
	students.push_back(s);
}

void StudentManagementSystem::SearchStudentRecord(string n) {
	
	for (int i = 0; i < students.size(); i++) {
		if (students[i].getname() == n) {
			cout << "\nName Found" << endl;
			cout << "Name: " << students[i].getname() << endl;
			cout << "ID: " << students[i].getid() << endl;
			cout << "Grade: " << students[i].getgrade() << endl;
			cout << "Marks: " << endl;
			vector <int> marks = students[i].getmarks();
			for (int j = 0; j < marks.size(); j++)
			{
				cout << marks[i] << endl;
			}
			cout << "======================================";
		}
		else {
			cout << "Name Not Found" << endl;
		}
	}
}
void StudentManagementSystem::SearchStudentRecord(int id) {

	for (int i = 0; i < students.size(); i++) {
		if (students[i].getid() == id) {
			cout << "\nName Found" << endl;
			cout << "Name: " << students[i].getname() << endl;
			cout << "ID: " << students[i].getid() << endl;
			cout << "Grade: " << students[i].getgrade() << endl;
			cout << "Marks: " << endl;
			vector <int> marks = students[i].getmarks();
			for (int j = 0; j < marks.size(); j++)
			{
				cout << marks[i] << endl;
			}
			cout << "======================================";
		}
		else {
			cout << "Name Not Found" << endl;
		}
	}
}

void StudentManagementSystem::ModifyStudentRecord(int d, string n) {

	for (int i = 0; i < students.size(); i++) {
		if (students[i].getid() == d) {
			cout << "Enter The New Name: ";
			getline(cin, n);

			students[i].setname(n);
		}
		else {
			cout << "ID Not Found" << endl;
		}
	}
}

void StudentManagementSystem::DeleteStudentRecord(int id) {
	
	vector <Student>::iterator it = find_if(students.begin(), students.end(), [id](Student& student) {
		return student.getid() == id;
		});
	if (it != students.end()) {
		students.erase(it);
		std::cout << "Student record deleted successfully." << std::endl;
	}
	else {
		std::cout << "Student with ID " << id << " not found." << std::endl;
	}
}

void StudentManagementSystem::ChangeAdminPassword(string n) {
	adminpass = n;
}