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

CC	= gcc
CFLAGS  = -DMODULE -D__KERNEL__ -I/usr/src/linux/include -Wall -Wstrict-prototypes -O6 -c
MFLAGS  = -DMODVERSIONS
SMPFLAGS = -D__SMP__

##=============================================
## Default Compiler: make all
##=============================================
all:		org


##=============================================
## One processor and normal kernel: make org
##=============================================
org:	dm9601.c \
	Makefile
	$(CC) $(CFLAGS) dm9601.c


##=============================================
## Set version info. on all module symbol
##     : make mod
##=============================================
mod:	dm9601.c \
	Makefile
	$(CC) $(MFLAGS) $(CFLAGS) dm9601.c


##=============================================
## Symmetric Multi Processor(SMP)
##     : make smp
##=============================================
smp:	dm9601.c \
	Makefile
	$(CC) $(SMPFLAGS) $(CFLAGS) dm9601.c

##=============================================
## SMP & Set all version info. on all module symbols
##     : make smp_mod
##=============================================
smp_mod:dm9601.c \
	Makefile
	$(CC) $(SMPFLAGS) $(MFLAGS) $(CFLAGS) dm9601.c


clean:			
			rm *o
