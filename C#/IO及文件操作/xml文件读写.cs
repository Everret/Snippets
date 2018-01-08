using System.Xml;

private void SaveXml(string path)
{
    //产生下载文件集
    var xmlDoc = new XmlDocument();
    xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));

    //主元素
    var el = xmlDoc.CreateElement("Path");
    xmlDoc.AppendChild(el);

    //次元素
    var el1 = xmlDoc.CreateElement("FileSum");
    el1.InnerText = "10";
    el.AppendChild(el1);

    //次元素
    var el2 = xmlDoc.CreateElement("PrgramPath");
    el.AppendChild(el2);

    //次次元素
    XmlElement element = xmlDoc.CreateElement("Program");
    element.InnerText = "C:\\test.cpp";
    el2.AppendChild(element);

    xmlDoc.Save(path);

}


private void openXml(string Path)
{
        string configFullPath = Path; //得到文件绝对路径

        XmlDocument doc = new XmlDocument();
        try
        {
            doc.Load(configFullPath);
        }
        catch (Exception exception)
        {
            string message = "打开文件错误，" + exception.ToString();
            string caption = "打开错误";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK;
            System.Windows.Forms.MessageBox.Show(message, caption, buttons);
            return;

        }

        XmlNode rootNode;
        try
        {
            rootNode = doc.SelectSingleNode("Path");

        }
        catch (Exception exception)
        {
            string message = "读取文件错误，" + exception.ToString();
            string caption = "读取错误";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK;
            System.Windows.Forms.MessageBox.Show(message, caption, buttons);
            return;
        }

        XmlNode fileSumNode;

        try
        {
            fileSumNode = rootNode.SelectSingleNode("FileSum");

        }
        catch (Exception exception)
        {
            string message = "读取文件错误，" + exception.ToString();
            string caption = "读取错误";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK;
            System.Windows.Forms.MessageBox.Show(message, caption, buttons);
            return;
        }

        int fileSum = Convert.ToInt32(fileSumNode.InnerText);

        XmlNode filePathNode;

        try
        {
            filePathNode = rootNode.SelectSingleNode("PrgramPath");
        }
        catch (Exception exception)
        {
            string message = "读取文件错误，" + exception.ToString();
            string caption = "读取错误";
            System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK;
            System.Windows.Forms.MessageBox.Show(message, caption, buttons);
            return;
        }

        string content = filePathNode.ChildNodes[0].InnerText;

    }
}