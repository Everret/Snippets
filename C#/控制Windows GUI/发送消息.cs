[DllImport("user32.dll")]
private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
