##================================================================
##     Davicom Semiconductor Inc.  	For DM9601 V0.00
##   --------------------------------------------------------
## Description:
##              Compile driver dm9601.c to dm9601.o
##
## Modification List:
## 09/05/2000	Fixed SMPFALGS wrong on smp & smp_mod
## 08/02/2000	Changed some description string & include file path
## 07/25/2000	Append smp_mod and changed some descriptions
## 01/25/2000	by Sten Wang
##================================================================
# Comment/uncomment the following line to disable/enable debugging
#DEBUG = y

# Add your debugging flag (or not) to CFLAGS
ifeq ($(DEBUG),y)
  DEBFLAGS = -O -g # "-O" is needed to expand inlines
else
  DEBFLAGS = -O2
endif

CFLAGS += $(DEBFLAGS) -I$(LDDINCDIR)

ifneq ($(KERNELRELEASE),)
# call from kernel build system

obj-m	:= dm9601.o

else

KERNELDIR ?= /lib/modules/$(shell uname -r)/build
PWD       := $(shell pwd)

default:
	$(MAKE) -C $(KERNELDIR) M=$(PWD) LDDINCDIR=$(PWD)/../include modules

endif



clean:
	rm -rf *.o *~ core .depend .*.cmd *.ko *.mod.c .tmp_versions

depend .depend dep:
	$(CC) $(CFLAGS) -M *.c > .depend


ifeq (.depend,$(wildcard .depend))
include .depend
endif
