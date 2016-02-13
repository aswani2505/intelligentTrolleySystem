  DAVICOM Semiconductor Inc.				11/24/2006

        A Davicom DM9601 USB Fast Ethernet driver for Linux. 
        Copyright (C) 1997  Sten Wang

        This program is free software; you can redistribute it and/or
        modify it under the terms of the GNU General Public License
        as published by the Free Software Foundation; either version 2
        of the License, or (at your option) any later version.

        This program is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        GNU General Public License for more details.

  A. Compiler command:

 	Run make command
	    
  B. The following steps teach you how to activate NIC:

     B-1: A simple and temporary method

        1. Used the upper compiler command to compile dm9601.c

        2. Insert DM9601 module into kernel
           "insmod dm9601.ko"           ;;Auto Detection Mode (Suggest)
           "insmod dm9601.ko mode=0"    ;;Force 10M Half Duplex
           "insmod dm9601.ko mode=1"    ;;Force 100M Half Duplex
           "insmod dm9601.ko mode=4"    ;;Force 10M Full Duplex
           "insmod dm9601.ko mode=5"    ;;Force 100M Full Duplex

	   NOTE: You can type "man insmod" to see more description.

        3. Config a DM9601 network interface
           "ifconfig eth0 172.22.3.18"
                          ^^^^^^^^^^^ Your IP address

	   NOTE: 1. You can type "man ifconfig" to see more description.
		 2. If eth0 has been used, you should use eth1 instead.

        4. Activate the IP routing table. For some distributions, it is not
           necessary. You can type "route" to check.

           "route add default netmask 255.255.255.0 eth0"

	   NOTE: 1. You can type "man route" to see more description.
		 2. If eth0 has been used, you should use eth1 instead.

        5. Well done. Your DM9601 adapter actived now.

	Note. This is a temporary method. After you reboot the system, you
	      will lost the setting.


     B-2: For Redhat, You can use the following to Activate NIC
	
	1.  login your system used the superuser.
	2.  copy dm9601.ko into	/lib/modules/2.6.x/kernel/drivers/net/
	3.  add the new line with "alias eth0 dm9601" in "/etc/module.conf". 
	4.  execute "netconfig -d eth0".
	5.  Fill your IP address, netmask and gateway
	6.  press <ok> to confirm and exit this setting
	7   reboot

	Note. If eth0 has been used, you should use eth1 instead.


  DAVICOM Web-Site: www.davicom.com.tw
