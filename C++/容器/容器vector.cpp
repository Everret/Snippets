#include <iostream>
#include <vector>

int main() {
    std::vector<int> valueList;//定义容器
    valueList.push_back(3);//加入值
    valueList.push_back(5);
    valueList.push_back(7);
    valueList.pop_back();//删除最后一个值
    valueList.push_back(9);
    std::cout << valueList.size() << std::endl;//容器大小
    std::cout << valueList[2] << std::endl;//打印第二个元素
    //打印所有元素
    std::cout << "All Value:" << std::endl;
    for (auto i : valueList)
    {
        std::cout << i << std::endl;
    }
    return 0;
}