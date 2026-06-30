#include "Menu.h"
#include "Student.h"
#include "StudentManagementSystems.h"

void Menu:: DisplayMenu() {
    cout << "Welcome to Student Management System" << endl;
    cout << "1. Add student record" << endl;
    cout << "2. Search student record" << endl;
    cout << "3. Modify student record" << endl;
    cout << "4. Generate mark sheet" << endl;
    cout << "5. Delete student record" << endl;
    cout << "6. Change admin password" << endl;
    cout << "7. Exit" <<endl;
    cout << "Enter your choice: ";
}

int Menu:: SelectOption() {
    int option;
    cin >> option;
    return option;
}

void Menu::ExecuteChoice(StudentManagementSystem s) {
    int choice;
    choice = SelectOption();
    system("cls");
    switch (choice) {
    case 1: {
        int id;
        string name;
        cout << "Enter Student ID : ";
        cin >> id;
        cout << "Enter Student Name : ";
        getline(cin, name);
        Student stu(id, name);
        s.AddStudentRecord(stu);
        break;
    }
    case 2:{
        cout << "1.Search By ID" << endl;
        cout << "2.Search By Name" << endl;
        cin >> choice;
        if (choice == 1)
        {
            int id;
            system("cls");
            cout << "Enter Student ID : ";
            cin >> id;
            system("cls");
            s.SearchStudentRecord(id);
        }
        else if (choice == 2)
        {
            string name;
            system("cls");
            cout << "Enter Student Name: ";
            getline(cin, name);
            s.SearchStudentRecord(name);
        }
        else
        {
            cout << "Invalid Choice!" << endl;
        }
        break;
    }
    case 3:{
        system("cls");
        int id;
        cout << "Enter Student ID : ";
        cin >> id;
        s.ModifyStudentRecord(id, "");
        break;
    }
    case 4:{
        break;
    }
    case 5:{
        system("cls");
        int id;
        cout << "Enter Student ID : ";
        cin >> id;
        s.DeleteStudentRecord(id);
        break;
    }
    case 6:{
        break;
    }
    case 7:{
        ExitSystem();
        break;
    }
    default:
        cout << "Invalid Choice" << endl;
        break;
    }
}
void Menu :: ExitSystem() {
    exit(0);
}
