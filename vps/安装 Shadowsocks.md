### 确认Python版本在2.6或者2.7
```bash
python --version
```

### 通过pip安装shadowsocks
```bash
pip install shadowsocks
```

### 创建配置文件
在/etc目录下创建shadowsocks.json配置文件
```bash
vim /etc/shadowsocks.json
```
输入以下内容:[这个文件是一个json文件，要保证json文件格式的正确]
```json
    {
      "server":"你的服务器IP，注意不是127.0.0.1哦",
      "port_password":{
           "8381":"随意设定8381端口使用密码",
           "8382":"随意设定8382端口使用密码",
           "8383":"随意设定8383端口使用密码"
      },
      "timeout":300,
      "method":"aes-256-cfb"
    }
```
如上即设置了三个用户，每个端口对应一个用户。

### 启动shadowsocks
```bash
ssserver -c /etc/shadowsocks.json -d start
```

可以使用netstat -lnp查看对应端口有没有开始监听，如图