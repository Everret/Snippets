//在引用中加入System.Windows.Forms
private void SaveConfig()
{
    //新建保存文件的窗口
    System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
    saveFileDialog.InitialDirectory = lastPath;
    //默认的保存文件名
    saveFileDialog.FileName = "config.txt";
    //文件类型
    saveFileDialog.Filter = "txt files(*.txt)|*.txt";

    //选择好地方了
    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    {
        //得到保存的文件带有文件名的完整路径
        string savePath = System.IO.Path.GetFullPath(saveFileDialog.FileName);
        //保存文件的函数
        SaveFile(savePath);
    }
}
