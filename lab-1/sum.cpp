#include "sum.h"

int sum(int a, int b) {
    int sum = 0;
    for (int i = 0; i < 200; ++i) {
        sum += i;
    }
    return sum;
}

int mult() {
    int mult = 1;
    for (int i = 1; i < 10; ++i) {
        mult *= i;
    }
    return mult;
}
