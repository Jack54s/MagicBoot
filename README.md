# MagicBoot

**你可以使用你自己定义的命令来打开特定的文件**

程序下载地址：[MagicBoot](https://github.com/Jack54s/MagicBoot/blob/master/CommandStartProgram/bin/Release/app.publish/MagicBoot.exe)

## 使用

程序为绿色版，免安装，第一次运行会在程序所在目录下建立一个ini文件，之后如果ini文件无法被找  

到会重新创建一个新的ini文件。**使用开机启动功能时会要求修改注册表，不要担心，修改的注册表项**

**在HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run里。**

## 功能列表

* 指令打开文件
* 设置热键
* 添加指令
* 开机启动

## 主要界面截图及说明

### 主界面

![主界面](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/MainForm.png)  

> 主界面可以通过你设置的热键进行召出，以及`Esc`键进行隐藏

在主界面的输入框中，你可以输入你自己定义的命令，打开特定的文件，比如`cmd`。在软件第一次  

运行时，会在软件所在的目录下创建一个ini文件，并将cmd这个命令与你的电脑的`C:\Windows\Sys`  

`tem32\cmd.exe`相关联所以你只要输入cmd即可启动命令行。之后你也可以在设置中添加自己的命令。


### 设置

![设置](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/Set.png)

> 热键目前支持Ctrl|Alt|Shift + Key

在这个界面你可以看到又开机启动和快捷键以及添加命令的按钮，开机启动就不用说明了，而快捷键  

是你打开主界面的热键，默认是`Ctrl+R`。点击“添加命令”按钮之后进入添加命令界面。


### 添加你自己的指令

![添加命令](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/addCommand.png)

在这个界面你可以在启动指令的框中输入你想自定义的指令如`vs|vs2015| Visual Studio`，你可以为  

一个文件定义多个指令，指令之间用`|`分隔，然后选择你要打开的文件（文件打开的方式和你电脑  

的默认方式相同，如果你的电脑不能识别文件，则会让你手动选择），**目前无法选择Internet快键方式**

**(.url文件)。**


### ini配置文件

![ini配置文件](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/ini.png)

这是软件的配置文件，你可以将它添加到你的指令当中，比如`ini`表示打开它，这样你就可以方便的打  

开它，ini文件中有两个域`Command List`和`Set`，Command List表示你所存入的指令，你可以删掉那些  

你不用了的指令，**但注意要整行的删掉。** **但我并不建议你对Set域中的内容做什么修改，显然它是程序**

**的一些设置，或许你可以轻易地看懂它，但不要轻易地修改它，那也许会导致程序的一些异常。**

## TODO List

* 对窗体采用单例模式
* 启动带参数的程序

<br/>

## 鸣谢

* 程序的icon和窗体标题部分来自于Dota2 卡尔
* 程序的部分代码参考自[WindowsHotKeyForm](https://github.com/yuanliwei/WindowsHotKeyForm)
