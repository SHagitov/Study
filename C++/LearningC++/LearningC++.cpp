// LearningC++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
void Variables()
{
    int a = 65;
    a = 10;
    float t = 12.34f;
    double z = 34.78750;
    bool var = true;
    char n;
    n = 'n';
    n = '0';
    const float PI = 3.1415f;
    int _a = 10;
    int A_123 = 0;
    std::cout << "Hello, World!\n";
    cout << "Hello, World!" << endl;
    //char v;
    //cin >> v;
    //cout << v;

}
void ArithmeticOperations()
{
    int a = 8;
    int b = 4;
    int c = a - b;
    cout << c << endl;
    cout << a % b << endl;
    a = 11;
    b = 3;
    float z = float(a) / float(b);
    cout << z << endl;
}

int main()
{  
    ArithmeticOperations();
}
