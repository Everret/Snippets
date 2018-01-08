#include <fstream>

int main() {
    std::ifstream input("input.txt");//构造函数，打开input.txt文件
    std::ofstream output("output.txt");//构造函数，输出output.txt文件
//    input.open("input.txt");//使用open函数打开
//    output.open("output.txt");
    std::string content;
    input >> content;//读入文件
    output << content + "out2" << std::endl;//输出文件
    input.close();//关闭文件
    output.close();
    input.open("input2.txt");//关闭之后可以再次打开
    input.close();
    return 0;
}