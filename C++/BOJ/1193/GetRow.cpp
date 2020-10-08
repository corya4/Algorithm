#include "Getrow.h";

int GetRow(int x, int* d, int n, int m) {

	if (n <= x && x <= n + m) {
		int t = x - n;
		*d = t;
		return 1;
	}

	return GetRow(x, d, n + m, m + 1) + 1;
}