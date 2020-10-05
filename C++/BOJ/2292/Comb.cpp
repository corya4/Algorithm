#include "Comb.h";

int FindCnt(int Increment, int count, int rNum) {

	if (Increment >= rNum) return 1;

	return (FindCnt(Increment + (6 * count), count + 1, rNum)) + 1;
}