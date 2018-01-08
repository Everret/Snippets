[DllImport("user32.dll")]
private static extern bool SetForegroundWindow(IntPtr hWnd);

SetForegroundWindow(CANopenBuilderType);


BOOL WINAPI SetForegroundWindow(
  _In_ HWND hWnd
);