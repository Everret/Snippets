[DllImport("user32.dll")]
private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

//ShowWindow参数
private const int SW_SHOWNORMAL = 1;
private const int SW_RESTORE = 9;
private const int SW_SHOWNOACTIVATE = 4;
