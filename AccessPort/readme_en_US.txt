SUDT AccessPort 1.33 Readme
=====================

Please read the document carefully before use the program.

1. What's AccessPort
---------------------
SUDT AccessPort is a serial port(RS232) debug and monitor tool for technicians, engineers and software developers designing or debugging serial port related projects.

2. System Requirements
---------------------
Windows 9x/2000/XP/2003

3.Install and Uninstall
---------------------
Unzip the zip file to the default folder. If you want to uninstall the software, please removing the folder completely. 

4.How to use it
---------------------
After installed, then run it.

5.License
---------------------
SUDT AccessPort is a freeware, You may install and use an unlimited number of copies of the SOFTWARE PRODUCT. And you may reproduce and distribute an unlimited number of copies of the SOFTWARE PRODUCT; provided that each copy shall be a true and complete copy, including all copyright and trademark notices, and shall be accompanied by a copy of this EULA. Copies of the SOFTWARE PRODUCT may be distributed as a standalone product or included with your own product as long as The SOFTWARE PRODUCT is not sold or included in a product or package that intends to receive benefits through the inclusion of the SOFTWARE PRODUCT. The SOFTWARE PRODUCT may be included in any free or non-profit packages or products. But You may not reverse engineer, decompile, or disassemble the SOFTWARE PRODUCT and change(add, delete or modify) the resources of the compiled assembly, except and only to the extent that such activity is expressly permitted by applicable law notwithstanding this limitation.

6.Responsibility
---------------------
We ensure that there is not any spyware or Trojan or any baleful code. But we expressly disclaims any warranty for the SOFTWARE PRODUCT. The SOFTWARE PRODUCT and any related documentation is provided "as is" without warranty of any kind, either express or implied, including, without limitation, the implied warranties or merchantability, fitness for a particular purpose, or noninfringement. The entire risk arising out of use or performance of the SOFTWARE PRODUCT remains with you. In no event shall the author of this Software be liable for any special, consequential, incidental or indirect damages whatsoever (including, without limitation, damages for loss of business profits, business interruption, loss of business information, or any other pecuniary loss) arising out of the use of or inability to use this product, even if the Author of this Software is aware of the possibility of such damages and known defects.


7.Copyright
---------------------
Copyright(C) 2002-2006 SUDT Studio, All rights reserved.
Author: Fred Chow
E-Mail: support@sudt.com
WWW:    http://www.sudt.com

8.History
---------------------

Version 1.33 (2006.08.31)
*************************************************************************
New Feature:
1.Rewrite Comm status display code.
2.Rewrite Terminal receive code, compatible with SerialNull.
3.Add DTR,RTS signal control button on Tx Panel.
4.Add multi-language for drop down menu.

Version 1.32 (2006.05.15)
*************************************************************************
Bug Fix:
1.Hot-key Ctrl+F10, Shift+F10 not available.
2.Set XonLim, XoffLim parameters failure.
3.XOn/XOff handshake signal not working when sending data.
4.Prompting can't find PSAPI.DLL under Win9x system.

Version 1.31 (2005.12.28)
*************************************************************************
New Feature:
1.Rewrite monitor kernel code.
2.Update Apsm.sys to Version 2.8, support windows 2003 system.

Bug Fix:
1.Monitor failed when com port number greater than 9.
2.Application exception when click Cancel button on Save Log file dialog under Monitor Mode.
3.Apsm.sys driver incompatible with other serial port driver.
4.Predefine & auto ACK data list loading incorrect under Terminal Mode.

Version 1.30 (2005.10.13)
*************************************************************************
New Feature:
1.Add "Edit" item for main menu.
2.Right button popup menu support multi-language and hot-key.
3.Add sub toolbar for monitor mode.
4.Add enable insert log header item for monitor log file, etc.(COM port/System version/Computer name)
5.Add capture time for monitor data package.
6.Change some Terminal toolbar's icon.
7.Update Apsm.sys to version 2.3.
8.Auto close save progress dialog after saving monitor log file.

Bug Fix:
1.Monitor driver install failed on windows 2000 platform.
2.Save monitor log file failed after stopping monitor.
3.Stop send failed if Auto send interval less than 100ms.

Version 1.29 (2005.08.03)
*************************************************************************
New Feature:
1.Add hotkey Ctrl+Enter for manual send button.
2.Remove Monitor mode for win98 system.

Bug Fix:
1) Fix bug which couldn't send char manually in win98 system.

Version 1.28 (2005.07.19)
*************************************************************************
New Feature:
1.Rewrite code for USB-RS232 converter.
2.Changed Terminal/Monitor mode control settings.

Bug Fix:
1) Fix some bugs.

Version 1.27 (2005.07.11)
*************************************************************************
New Feature:
1.Save window's placement.
2.Auto load flow control settings.

Version 1.26 (2005.07.08)
*************************************************************************
New Feature:
1.Add Auto ACK fuction for Terminal mode, support Hex/Text/Float.

Bug Fix:
1) Fix some bugs.

Version 1.25 (2005.07.06)
*************************************************************************
New Feature:
1.Add save progress dialog for Monitor mode.
2.Update Apsm.sys to version 2.0.
3.Add predefine data list for manual send, support Hex/Text/Float.

Bug Fix:
1) Fix some bugs.

Version 1.24 (2005.06.21)
*************************************************************************
New Feature:
1.Add colorful list view for Monitor mode.
2.Remove mode change after stopping monitor.

Bug Fix:
1) Fix some bugs.

Version 1.23 (2005.06.18)
*************************************************************************
New Feature:
1.Add context menu, support cut & copy & paste functions.
2.Change the hotkey of Monitor AutoScroll from Ctrl+A to Alt+A.

Bug Fix:
1) Fix some bugs.

Version 1.22 (2005.05.31)
*************************************************************************
New Feature:
1.Add echo in Rx pane and press enter to send functions.
2.Add text color, background color in Terminal mode.
3.Relayout Rx and Tx pane.

Bug Fix:
1) Fix background screen flicker after openning port.
2) Fix display caret position wrong in real time send mode.
3) Fix save real time send status failure.

Version 1.21 (2005.05.26)
*************************************************************************
New Feature:
1.Add event and timeout control settings.
2.Add comm status pane.
3.Add Hex String function, support hex string send and dump.
4.Add auto new line function in Rx pane.
5.Add Work mode button in toolbar, support Terminal and Monitor.
6.Add font settings.
7.Add port refresh function.
8.Add show hex function in monitor mode.
9.Add autosrcoll function in monitor mode.
10.Add waitting for stop monitor dialog.
11.Extend sending limit to 64K in Tx Pane.
12.Rewrite monitor code, avoid bule screen when data accumulate to some quantity.
13.Add cts/dsr hold status test, if these signal hold then unable sending.

Bug Fix:
1) Fix Hex editor's bug, for example: input AA then become EA in upper case.

Version 1.20 (2005.04.26)
*************************************************************************
New Feature:
1.Added flow control settings.

Bug Fix:
1) Fix some bugs.

Version 1.19 (2005.04.02)
*************************************************************************
New Feature:
1.Added custom baud rate setting, extended max baud rate to 256000.
2.Extended max port number to 255.

Bug Fix:
1) Fix some bugs.

Version 1.18 (2004.12.25)
*************************************************************************
Bug Fix:
1) Fix some bugs.

Version 1.17 (2004.12.10)
*************************************************************************
New Feature:
1.Add real-time send function for data send area.
2.Changed data display format for serial port monitor.

Bug Fix:
1) Fix some bugs.

Version 1.16 (2004.11.04)
*************************************************************************
New Feature:
1.Add save as function.
2.Add reload file function when file transfer starting.

Bug Fix:
1) Fix some bugs.

Version 1.15 (2004.10.10)
*************************************************************************
New Feature:
1.Rewrite hex display code for data receive function.
2.Add clear all records function for serial port monitor.

Bug Fix:
1) Fix some bugs.

Version 1.14 (2004.09.22)
*************************************************************************
New Feature:
1.Rewrite framework of application.
2.Add Hide/Show function for sending bar.

Bug Fix:
1) Fix some bugs.

Version 1.13 (2004.07.18)
*************************************************************************
Bug Fix:
1) Fix some bugs.

Version 1.12 Beta 6 (2004.06.16)
*************************************************************************
Bug Fix:
1) Fix some bugs, etc.(Couldn't save received data under win98; Couldn't
open specify serial ports larger than COM9; Couldn't receive return key
under word edit mode).

Version 1.12 Beta 5 (2004.03.20)
*************************************************************************
Bug Fix:
1) Fix some bugs, etc.(Delete temp file failure when exit).

Version 1.12 Beta 4 (2004.02.15)
*************************************************************************
New Feature:
1.Extended data buffer from 10 Bytes to 8192 Bytes.
2.Automatic set local language.
3.Unlimited data monitor, add record funcation.

Version 1.12 Beta 3 (2003.10.21)
*************************************************************************
New Feature:
1.Add Serial Port Monitor, this function allows you capture kernel event 
and capture all of data transfer through serial port.

Version 1.12 Beta 2 (2003.10.04)
*************************************************************************
New Feature:
1.Add hex editor in send area.

Version 1.12 Beta 1 (2003.09.25)
*************************************************************************
New Feature:
1.Support multiple language.
2.Auto prompt when update is available.

Bug Fix:
1) Change AccPort.dat to AccessPort.ini.
2) Disable the button of clear failure when auto send data , application can't exit.

Version 1.11 (2003.01.10)
*************************************************************************
New Feature:
1.Add Hot key.
2.Add 28800bps baud rate.
3.Extend the numbers of serial port from 4 to 32.

Bug Fix:
1)Lost data when save received data.
2)Can't load ini file when application start.

Version 1.10 (2002.11.10)
*************************************************************************
New Feature:
1.Redesigns layout.
2.Add auto send feature.
3.Save application parameters to ini file.

Bug Fix:
1)Thread dead lock when transfer file.
2)Delete temporary file failure.

Version 1.00 (2002.10.23)
*************************************************************************

Initial release
