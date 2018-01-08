using Microsoft.Win32;


string registData;
RegistryKey hkml = Registry.LocalMachine;//选择注册表主键值
RegistryKey aimdir = hkml.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\CANopen Builder.exe", true);//打开分键值

//新建项
RegistryKey software = aimdir.CreateSubKey("software\\test");

//删除项
aimdir.DeleteSubKey("software\\test",true); 

//设置值
aimdir.SetValue("test", "hello");

//获得注册表值 
registData = aimdir.GetValue("").ToString();

//删除值
aimdir.DeleteValue("test");

//获得所有子项的名称
string[] subkeyNames;
subkeyNames = software.GetSubKeyNames();