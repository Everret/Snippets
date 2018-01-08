//在引用中加入System.Windows.Forms
private string openFile()
{
    //打开“打开文件对话框”
    System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
    //对话框的起始目录
    openFileDialog.InitialDirectory = lastPath;
    //筛选的文件类型
    openFileDialog.Filter = "txt file(*.txt)|*.txt";

    //返回是ok按钮
    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    {
        string fileNameAndPath = System.IO.Path.GetFullPath(openFileDialog.FileName); //得到文件绝对路径
        return fileNameAndPath;
    }
    else
    {
        return "";
    }
}
