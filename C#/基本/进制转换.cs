//用10进制读取字符串，用16进制和2进制表现出来
long decNum = Convert.ToInt64(decText, 10);
string newHexString = Convert.ToString(decNum, 16).ToUpper();
string newBinString = Convert.ToString(decNum, 2);