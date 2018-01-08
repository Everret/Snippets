//xaml文件
<ComboBox x:Name="ComboBoxNetworkInterface" DisplayMemberPath="comboMember" SelectionChanged="ComboBoxNetworkInterface_OnSelectionChanged"></ComboBox>


//cs文件
//载入窗口的操作
private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
{
	//得到网卡信息
    GetNetworkInterface();
    
    //将List绑定到ComboBox上，使用DisplayMemberPath="comboMember"来设置显示的描述
    ComboBoxNetworkInterface.ItemsSource = combolist;
	ComboBoxNetworkInterface.SelectedIndex = 0;
}

public struct combomem
{
	public int ID { get; set; }
	public string comboMember { get; set; }
	public string ipadd { get; set; }
}

//从系统级获取网卡信息
private NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

//建立List来表示得到的网卡信息
private List<combomem> combolist = new List<combomem>();

//得到网卡信息
private void GetNetworkInterface()
{
    combomem combomenber = new combomem();

    int i = 0;
    foreach (NetworkInterface networkInterface in NetworkInterfaces)
    {
    	//获得编号
        combomenber.ID = i;
        i++;
        //获得网卡描述
        combomenber.comboMember = networkInterface.Description;
        //获得网卡的ip
        IPInterfaceProperties IPInterfaceProperties = networkInterface.GetIPProperties();
        UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
        foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
        {
            if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
            {
                combomenber.ipadd = UnicastIPAddressInformation.Address.ToString();
            }
        }

		//加入网卡信息到List中
        combolist.Add(combomenber);
    }
}
