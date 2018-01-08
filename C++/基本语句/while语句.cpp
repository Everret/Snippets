#include <iostream>

int main() {
    int value = 0;
    double res = 2.0;
    while (value < 10) //先判断，条件为真时执行语句；为假结束
    {
        value++;
        res = res * 2.0;
    }
    std::cout << res << std::endl;
    return 0;
}