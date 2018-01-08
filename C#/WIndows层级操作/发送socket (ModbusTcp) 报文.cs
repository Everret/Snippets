Initsocket();
ConnectTcp();
//同步发送和接收
SendTcp();
ReceiveMsg();
CloseTCP(client);


private Socket client;
private String recvdata;
private IPEndPoint ie;
private string ip = "192.18.1.2";//本机ip

//初始化socket
private void Initsocket()
{
    string ipadd = "192.168.1.10"; //目标IP
    int port = 502; //目标port

    //make a socket
    ie = new IPEndPoint(IPAddress.Parse(ipadd), port);
    client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    IPEndPoint bindip = new IPEndPoint(IPAddress.Parse(ip, 0);
    if (client.IsBound == false)
    {
        client.Bind(bindip);
    }
}

//连接socket
private void ConnectTcp()
{
    client.Connect(ie);
}

//发送报文
private void SendTcp()
{
    string senddata = "00 00 00 00 00 06 01 03 00 00 00 01"; //发送报文
    senddata = senddata.Replace(" ", "");
    byte[] data = new byte[senddata.Length / 2];
    byte[] dataUshort = new Byte[senddata.Length / 2];
    for (int i = 0; i < data.Length; i++)
    {
        char str1 = senddata[i * 2];
        char str2 = senddata[i * 2 + 1];
        string str = str1.ToString() + str2.ToString();
        dataUshort[i] = Convert.ToByte(str, 16);
        data[i] = Convert.ToByte(dataUshort[i]);
    }

    if (client == null)
    {
        ;
    }
    else
    {
        client.Send(data);
    }
}

//接收报文
private void ReceiveMsg()
{
    try
    {
        byte[] data = new byte[1024];
        client.Receive(data, data.Length, 0);

        //去除TCP报文头
        int length = data[5];
        Byte[] datashow = new byte[length + 6];
        for (int i = 0; i <= length + 5; i++)
        {
            datashow[i] = data[i];
        }
        recvdata = "";
        for (int i = 0; i <= length + 5; i++)
        {
            var temp = Convert.ToString(datashow[i], 16);
            switch (temp.Length)
            {
                case 1:
                    temp = "0" + temp;
                    break;

                default:
                    break;
            }
            recvdata = recvdata + temp.ToUpper() + " ";
        }
        recvdata = recvdata + "\n";
        //recvdata即为接受的报文
    }
    catch (ThreadAbortException)
    {
        ;
    }
}

//关闭socket
private static void CloseTCP(Socket socket)
{
    if (socket == null)
        return;

    if (!socket.Connected)
        return;

    try
    {
        socket.Shutdown(SocketShutdown.Both);
    }
    catch
    {
    }

    try
    {
        socket.Close();
    }
    catch
    {
    }
}
