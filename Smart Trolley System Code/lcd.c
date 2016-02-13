
//#include<pins.h>

#define LINE1 0x80
#define LINE2 0xC0

#define to_Ascii(x)	 ((x&0x0F)|0x30)
unsigned int delay;
unsigned char dw, k;

bdata unsigned char byte;
 sbit  a0 = byte^0; 
 sbit  a1 = byte^1 ;
 sbit  a2 = byte^2;
 sbit  a3 = byte^3 ;
 sbit  a4 = byte^4;
 sbit  a5 = byte^5 ;
 sbit  a6 = byte^6 ;
 sbit  a7 = byte^7 ;


void func()
 {
 b4 = a4;
 b5 = a5;
 b6 = a6;
 b7 = a7;
 }

void lcdcmd(char cmd)			  /// to send command to LCD
 {
 lcd_rs=0;
 byte = (byte & 0x0f)|(cmd & 0xf0); func();
 lcd_e=1;
 for ( delay=0; delay<=100; delay++ );	
 lcd_e=0;
 for ( delay=0; delay<=255; delay++ );

 byte = (byte & 0x0f)|(cmd<<4 & 0xf0); func();
 lcd_e=1;
 for ( delay=0; delay<=100; delay++ );	
 lcd_e=0;
 for ( delay=0; delay<=255; delay++ );
 }

void lcddata(char dat)			/// to send data to LCD
 {
 lcd_rs=1;
 byte = (byte & 0x0f)|(dat & 0xf0); func();
 lcd_e=1;
 for ( delay=0; delay<=100; delay++ );	
 lcd_e=0;
 for ( delay=0; delay<=255; delay++ );
 
 byte = (byte & 0x0f)|(dat<<4 & 0xf0); func();
 lcd_e=1;
 for ( delay=0; delay<=100; delay++ );	
 lcd_e=0;
 for ( delay=0; delay<=255; delay++ );
 }

void lcd_init()		  // normal lcd initialisation
{ 	
 lcdcmd(0x33); 				// 2line display
 lcdcmd(0x32);				// 
 lcdcmd(0x28);				//
 lcdcmd(0x0C);				// display on, cursor off blink off				
 lcdcmd(0x06);				// increment cursor mode
 lcdcmd(0x01);
}


void lcd(unsigned char hex_data[] , unsigned char addr)	  //    
{
 lcdcmd(addr);
 for (k=0; k<16; k++)
 {
 dw = hex_data[k];
 if(dw>0)
 { 
 lcddata(dw);	
 }
 else break;		/// added modification
 }
}


void lcd_putUINT16 ( unsigned int number )
{
  unsigned char dig5,dig4,dig3,dig2,dig1;
  
  // Get the Digit5
  dig5 = number / 10000;
  number = number % 10000;

  // Get Digit4
  dig4 = number / 1000;
  number = number % 1000;

  // Get Digit3
  dig3 = number / 100;
  number = number % 100;

  // Get Digit2 and Digit1
  dig2 = number / 10;
  dig1 = number % 10;

  if(dig5 != 0)
	{  
		lcddata(to_Ascii(dig5));
		lcddata(to_Ascii(dig4));
		lcddata(to_Ascii(dig3));
  		lcddata(to_Ascii(dig2));
	}
	else if(dig4 != 0)
	{
		lcddata(to_Ascii(dig4));
		lcddata(to_Ascii(dig3));
  		lcddata(to_Ascii(dig2));
	}
	else if(dig3!=0)
  	{
  		lcddata(to_Ascii(dig3));
  		lcddata(to_Ascii(dig2));
  		//lcddata(toAscii(dig1));
  	}
  	else if(dig2!=0)
  	{
		lcddata(to_Ascii(dig2));
  		
	}
  lcddata(to_Ascii(dig1));

 
}
