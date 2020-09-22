#include <string>
using namespace std;

class WordFind {

public :
	int alpa_index[26];

	WordFind();
	void InputIndex(char c);
	int UpperLow(char c);
	void Find();

};