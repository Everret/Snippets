#include <iostream>

int main() {
    int array[3][5] = {{3,3,3,3,3},{2,2,2,2,2},{1,1,1,1,1}};//定义并初始化数组
    array[2][1] = 10;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            std::cout << array[i][j] << std::endl;
        }
    }

    return 0;
}