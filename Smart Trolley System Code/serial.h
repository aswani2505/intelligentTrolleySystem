//---------------------------------------
// Serial port driver
// KEIL C51 v7.5
// www.GetMicro.com
//---------------------------------------

#include<serial.c>



void ini_uart(unsigned int baud);
//unsigned char Serial_Rd();
void Serial_Wr(unsigned char ch);
void Serial_putUBYTE ( unsigned char number );
void Serial_puts( unsigned char *str );
//void Serial_putUBYTEHex ( unsigned char number )  ;
void Serial_putUINT16 ( unsigned int number );



