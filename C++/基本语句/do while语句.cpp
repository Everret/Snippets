#include <iostream>

int main() {
    double res = 2.0;
    int i = 0;
    do
    {
        res = res * 2;
        i++;
    }
    while (i < 10);//先执行，再判断为真的时候循环，为假的话就结束
    std::cout << res << std::endl;
    return 0;
}