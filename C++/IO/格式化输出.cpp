#include <iostream>
#include <iomanip>
#include <math.h>

int main() {
    std::cout << std::showbase;//显示不同进制的前置符
    std::cout << std::boolalpha << true << " " << false << std::endl;//显示true和false
    std::cout << std::noboolalpha << true << " " << false << std::endl;//显示1和0
    std::cout << 10 << std::endl;
    std::cout << std::oct << 10 << std::endl;//显示八进制
    std::cout << std::hex << 10 << std::endl;//显示十六进制
    std::cout << std::dec << 10 << std::endl;//显示十进制

    std::cout.precision(12);
    std::cout << std::setprecision(12);//与上面一行相同，设置12位小数点
    std::cout << std::uppercase;//十六进制的前缀和科学计数法的E都是大写
    std::cout << M_PI << std::endl;
    std::cout << std::scientific << 10 * M_PI << std::endl;//科学计数法
    std::cout << std::hexfloat << 10 * M_PI << std::endl;//十六进制显示浮点数
    std::cout << std::defaultfloat << 10 * M_PI << std::endl;//默认输出


    return 0;
}