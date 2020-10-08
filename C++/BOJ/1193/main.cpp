#include <iostream>
#include "GetRow.h";
using namespace std;

int main(void) {
	
	int X;
	int a;
	int* D = &a;
	cin >> X;

	int r = GetRow(X, D, 0, 1);
	int f = r - (*D) + 1;
	int b = *D;

	printf("%d, %d, %d, %d\n", r, *D, f, b);

	if (r % 2 != 0)
		printf("%d\/%d", f, b);
	else
		printf("%d\/%d", b, f);

}

