#include<iostream>
#include<string>
using namespace std;

template<class type>
class calculator
{
public:
	type answer();
	friend bool operator<<(istream in,calculator & cc);
private:
	int read();
	void figure();
	string input;
	char *stack;
	int depth;
	type base=0;
};

template<class type>
type calculator<type>::answer()
{
	return base;
}

template<class type>
bool operator>>(istream in, calculator<type> & cc)
{
	string input;
	in>>input;
}



template<class type>
int calculator<type>::read()
{
	
}

int main()
{
	calculator<int> *c = new calculator<int>();
	cin<< *c;
	calculator copy = *c;
	system("pause");
}
