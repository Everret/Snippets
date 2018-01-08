//首先在项目内创建与项目名称相符的.def文件
//内容是：（项目名为AppFun，生成的dll文件名也是AppFun
LIBRARY "AppFun"

EXPORTS
	fun1 @ 1
	fun2 @ 2
	
	
//.h文件这样写
extern "C" __declspec(dllexport) void fun1();
extern "C" __declspec(dllexport) void fun2();

//.cpp文件这样写
void fun1()
{
	//code
}
void fun2()
{
	//code
}

//这样编译后生成dll然后在其他中调用，例如c#
[DllImport("AppFun.dll", CharSet = CharSet.Unicode, EntryPoint = "fun1", CallingConvention = CallingConvention.Cdecl)]
public extern static void fun1();

[DllImport("AppFun.dll", CharSet = CharSet.Unicode, EntryPoint = "fun2", CallingConvention = CallingConvention.Cdecl)]
public extern static void fun2();