# MiniChat
## A Simple, Peer-to-Peer, TCP-Based Chat App

What began as a my first entry into learning programming sockets and internet-based devices in June 2020, I decided to spruce up this project and publish it as a useful little tool.

![Demo](https://github.com/albertbregonia/MiniChat/img/demo.jpg "Demo")

**MiniChat** is written in C# using the .NET Framework. It exemplifies the fundamentals of socket programming and its main purpose is to be a debugging tool for internet capable devices with more visual appeal and easy of use. Even a very simple network program like this, requires a lot of error-checking in order to be robust. If you are learning to program with sockets off of this code, please keep that in mind.

### Note: If you are to use this software you must:
- Either, know how to port-forward or know someone that does.
- Understand that traffic is ***NOT*** encrypted when messages are sent using this software.
- Understand that this software was ***NOT*** meant to be a chat app between people. However, you can use it as such at your own risk.
- Know that to use server mode with default settings, you will have to port-forward port `54000`.
- Currently, this repository only includes the Windows based variant using the .NET Framework. However, this project can be easily modified to use the .NET Core and be compiled for many of the other available platforms on Visual Studio 2019. ![Windows-MacOSX-Linux](https://github.com/albertbregonia/MiniChat/img/compile.jpg "OS Support")

## Main Features:
1. Configurable to be a server or client
2. Easy to use GUI
3. Portable and installer versions are available.

Please check the `Final` folder if you wish to simply download the Installer or Portable version instead of looking at the source code.
