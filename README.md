# MiniChat
## A Simple, TCP-Based, Chat-Style Debug Tool

What began as a my first entry into learning programming sockets and internet-based devices in June 2020, I decided to spruce up this project and publish it as a useful little tool.

![Demo](https://github.com/albertbregonia/MiniChat/blob/master/img/demo.jpg?raw=true "Demo")

**MiniChat** is written in C# using the .NET Framework. It exemplifies the fundamentals of socket programming with its main purpose being a visually appealing, easy-to-use, debugging tool for network-capable devices or network-based software.

### Note: If you are to use this software you must:
- Understand the basic concepts of networking such as IP addresses and ports.
- Understand that traffic is ***NOT*** encrypted when messages are sent using this software.
- Understand that this tool is Peer-to-Peer and no more than 1 client can be connected at a time
- Understand that this software was ***NOT*** meant to be a chat app between people. However, you can use it as such at your own risk.
- Know that to use server mode and have a non-local source connect, you will have to port-forward port `54000`. (With default settings)
- Currently, this repository only includes the Windows-based variant using the .NET Framework. However, this project can be easily modified to use the .NET Core and be compiled for many of the other available platforms on Visual Studio 2019:

    ![Windows-MacOSX-Linux](https://github.com/albertbregonia/MiniChat/blob/master/img/compile.jpg?raw=true "OS Support")

## Main Features:
1. Configurable to be a server or client
2. Easy to use Chat-Style GUI
3. Portable and installer versions are available.

## Installation:
Please check the [`Final`](https://github.com/albertbregonia/MiniChat/tree/master/Final) folder if you wish to simply download the Installer or Portable version instead of looking at the source code. Run either `setup.exe` or the `MiniChat.exe` in [`Final\Portable`](https://github.com/albertbregonia/MiniChat/tree/master/Final/Portable)

Let me know if you find any bugs and I will see what I can do! Enjoy.
