private void makeFile()
{       
    FileStream logfile = new FileStream("Log.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite, 16);
    AddText(logfile, "现在时间：" + System.DateTime.Now + "\n");
    logfile.Close();
}

private static void AddText(FileStream fs, string value)
{
    byte[] info = new UTF8Encoding(true).GetBytes(value);
    fs.Write(info, 0, info.Length);
}