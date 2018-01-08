#include <iostream>

int main() {
    double res = 2.0;
    for (int i = 0; i < 10; i++) {
        res = res * 2;
    }
    std::cout << res << std::endl;


    int value[10] = {5,6,5};
    for (auto i : value)
    {
        std::cout << i << std::endl;
    }
    
    return 0;
}