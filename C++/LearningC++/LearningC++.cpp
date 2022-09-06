// LearningC++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <iostream>
#include <string>
using namespace std;
void TypeDefs()
{
	typedef int cnt;
	typedef unsigned int uint;
	cnt a = 0;
	uint z = 10;
	double b = 3.5;
	char A = 'z';

	cout << "Hello World!" << endl;
 }
void Enums()
{
	enum Color { red, green, blue };
	//          = 0   = 1    = 2     >> тип int
	Color a = Color::red;
	enum Player { first = -10000000, second = 0, third = 1 };
	cout << "Hello World!" << endl;
	cout << a << endl;
	Player a1 = Player::first;
	cout << a1 << endl;
	switch (a)
	{
	case red:
	{
		cout << "it's red" << endl;
		break;
	}
	default:
	{
		cout << "not red" << endl;
		break;
	}
	}

	/*using namespace std;
	typedef unsigned int uint;
	enum class Color : long long;
	void foo(Color a);
	enum class Color : long long { red = -300000000000000, yellow = -3, green = 0, blue };
	int main()
	{
		Color a = Color::blue;
		switch (a)
		{
		case Color::blue:
		{
			cout «"it's blue";
			break;
		}
		default:
		{
			cout «"not blue";
			break;
		}
		}
		int blue = -7;
		cout « (int)Color::blue « endl;
		return 0;
	}*/
}
void Arrays()
{
	struct Car
	{
		int width = 50;
		int length;
		int wheels;
		string name;
	} other_car;
	int array[10];
	double a;

	Car my_car;
	my_car.name = "The best car";
	my_car.length = 100;

	cout << my_car.name << ", length = " << my_car.length << ", width = " << my_car.width << endl;
}

int main()
{  
	Arrays();
	return 0;
}
