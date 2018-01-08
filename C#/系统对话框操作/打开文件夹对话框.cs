//在引用中加入System.Windows.Forms
private string chooseFolder()
{
    FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
    DialogResult result = folderBrowser.ShowDialog();

    if (result == System.Windows.Forms.DialogResult.OK)
    {
        string foladPath = folderBrowser.SelectedPath.Trim();//选择的文件夹的位置
        return foladPath;
    }
    else
    {
        return "";
    }
}