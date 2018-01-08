int value = 1024;
int &refValue = value; //引用
int *pValue = &value;//指针
std::cout << "ref: " << refValue << std::endl;
std::cout << "point:" << *pValue << std::endl;

