private static void func()
{
    string path = "c:";
    ArrayList fileList = new ArrayList();
    SearchFile(path,fileList);
}

//查找文件，将文件的完整路径及名称写入ArrayList
private static void SearchFile(string path, ref ArrayList fileArrayList)
{
    FindFile(path, ref fileArrayList);
}

private static void FindFile(string dirPath, ref ArrayList fileArrayList) //参数dirPath为指定的目录  
{
    //在指定目录及子目录下查找文件,在listBox1中列出子目录及文件  
    DirectoryInfo dir = new DirectoryInfo(dirPath);
    foreach (DirectoryInfo d in dir.GetDirectories()) //查找子目录  
    {
        FindFile(dir + d.ToString() + "\\", ref fileArrayList);
    }
    foreach (FileInfo f in dir.GetFiles()) //查找文件  
    {
        if (f.Extension == ".txt")//符合该文件扩展名的文件加入列表
        {
            fileArrayList.Add(f.FullName);
        }
    }
}