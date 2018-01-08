private void getVerison()
{
    var version = Assembly.GetExecutingAssembly().GetName().Version;
    LabelVersion.Content = "Version : " + version.ToString();
    LabelDate.Content = "Compile Date : " + System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location).ToString();
}
