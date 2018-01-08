//WPF中定时刷新控件，其他进程可以通过全局变量控制控件


//载入窗口的时候启动定时器
private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
{
    LanuchTimer();
}

//设置定时器并启动
private void LanuchTimer()
{
    DispatcherTimer innerTimer = new DispatcherTimer(TimeSpan.FromSeconds(0.5), DispatcherPriority.Loaded,
                new EventHandler(this.TimerTick), this.Dispatcher);
    innerTimer.Start();
}

//定时到要做的事情
private void TimerTick(object sender, EventArgs e)
{
    //code
}


