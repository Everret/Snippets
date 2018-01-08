#include <vector>
#include <array>
#include <list>
#include <forward_list>
#include <iostream>

int main() {
    std::vector<int> value1 = {10,5};//初始化
    std::vector<int> value2 = {20,15};
    std::swap(value1,value2);//交换，只能是完全相同才能交换
    std::array<int, 10> array2 = {20};

    std::list<int> list1;
    list1.push_back(2);//在最后加入
    list1.push_front(1);//在最前加入
    list1.pop_back();//删除最后一个
    list1.push_front(0);


    value1.insert(value1.begin() + 1,3);//在某个位置加入

    for(auto i : value1)
    {
        std::cout << i << std::endl;
    }

    std::cout << value1.at(1) << std::endl;//输出第2个元素
    return 0;
}