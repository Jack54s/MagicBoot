# MagicBoot

**你可以使用你自己定义的命令来打开特定的文件**

程序下载地址：[MagicBoot](https://github.com/Jack54s/MagicBoot/blob/master/CommandStartProgram/bin/Release/app.publish/MagicBoot.exe)

## 使用

程序为绿色版，免安装，第一次运行会在程序所在目录下建立一个ini文件，之后如果ini文件无法被找  

到会重新创建一个新的ini文件。**使用开机启动功能时会要求修改注册表，不要担心，修改的注册表项**

**在HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run里。**

## 功能列表

* 指令打开文件、文件夹或URL
* 管理命令
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

在这个界面你可以看到有开机启动和快捷键以及添加和管理命令的按钮，开机启动就不用说明了，而  

快捷键是你打开主界面的热键，默认是`Ctrl+R`。点击“添加命令”按钮之后进入添加命令界面。


### 添加你自己的指令

![添加文件](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/addCommand_File.png)  
![添加文件夹](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/addCommand_Folder.png)  
![添加URL](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/addCommand_URL.png)

这个界面和1.0版本有了一点不同，你可以在启动指令的框中输入你想自定义的指令如`vs|vs2015| Visual Studio`，  

你可以为一个文件定义多个指令，指令之间用`|`分隔，然后你可以选择打开一个文件（文件打开的方式  

和你电脑的默认方式相同，如果你的电脑不能识别文件，则会让你手动选择），还是一个文件夹，或者  

是一个URL（网页的浏览器为你的默认浏览器），**目前无法选择Internet快键方式(.url文件)，但是你可以**  

**直接查看它的`属性->Web文档`中的URL，将它直接复制到URL选项下的文本框中。**  

*关于URL选项，它有点类似于URL Schemes，比如你可以在URL选项下输入`steam://`，它会打开steam这个软件，*

*如果你的电脑上没有装steam，那么它会提醒你访问商店以下载*

### 管理你的命令

![管理命令](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/commandView.png)  

在这个界面你可以看到你现在所添加的所有命令，你可以勾选删除它们，或者Ctrl或Shift选中右键删除

### ini配置文件

![ini配置文件](https://github.com/Jack54s/MagicBoot/blob/master/SoftwareSnap/ini.png)

这是软件的配置文件，你可以将它添加到你的指令当中，比如`ini`表示打开它，这样你就可以方便的打  

开它，ini文件中有两个域`Command List`和`Set`，Command List表示你所存入的指令，你可以删掉那些  

你不用了的指令，**但注意要整行的删掉。** **但我并不建议你对Set域中的内容做什么修改，显然它是程序**

**的一些设置，或许你可以轻易地看懂它，但不要轻易地修改它，那也许会导致程序的一些异常。**

## Update List

* 支持在设置里查看和删除命令，支持批量删除
* 现在可以为程序添加参数，或者使用程序打开某个文件
* 支持文件夹或URL作为指令打开的目标
* 优化了窗体的实例化，现在每个窗口只能打开一个
* 现在快捷键可以打开或关闭窗口

<br/>

## 鸣谢

* 程序的icon和窗体标题部分来自于Dota2 卡尔
* 程序的部分代码参考自[WindowsHotKeyForm](https://github.com/yuanliwei/WindowsHotKeyForm)
