[DllImport("user32.dll")]
private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


IntPtr CANopenBuilder6 = IntPtr.Zero;
CANopenBuilder6 = FindWindow(null, "CANopen Builder");

HWND WINAPI FindWindow(
  _In_opt_ LPCTSTR lpClassName,
  _In_opt_ LPCTSTR lpWindowName
);


