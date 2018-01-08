Thread newThread = new Thread(newFunction);//新建线程，执行newFunction这个函数
newThread.Name = "newThread";//线程名为newThread
newThread.IsBackground = true;//是后台线程
newThread.Start();//启动线程