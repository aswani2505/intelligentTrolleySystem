
//---------------------------------------
// Serial prt driver
// KEIL C51 v7.5
//---------------------------------------

//#include<pins.h>

#define toAscii(x) (x + 0x30)
//---------------------------------------
// Initialize serial port
//---------------------------------------
void Serial_Init()
{
  	SCON = 0x52;    // setup serial port control 
  	TMOD = 0x20;    // hardware (9600 BAUD @11.0592MHZ) 
  	TH1  = 0xFD;    // TH1
	TR1	 = 1;  		// Timer 1 on
}

//unsigned char Serial_Rd()
//{
//	unsigned char dat;
//	while(!RI);	  				//wait for reception interrupt
//	dat=SBUF;					//read data
//	RI=0;
//	return(dat);
//} 
/*****************************************************
	Function name:	Serial_Wr()
	Return 		: nil
	Argument	: unsigned char data
	purpose:	Displays a character in hyper terminal
********************************************************************

******/
void Serial_Wr(unsigned char ch)
{
	SBUF=ch;
	while(TI==0);	  //wait for transmission interrupt
	TI=0;
}
/*******************************************************************

********
* Function: Serial_putUBYTE
* Purpose:  Function to display an 8 bit unsigned number on 

hyperterminal
* Parameters: number
*             number should be unsigned   
*             Range supported 0 to 255
*             No Error checking done pass the input correctly
*             e.g if number is 0xff it will be displayed as 255 on 

hyperterminal
********************************************************************

**************/
void Serial_putUBYTE ( unsigned char number )
{
  unsigned char dig3,dig2,dig1;
  
  // Get the MSB
  dig3 = number / 100;
  number = number % 100;

  // Get the 2 LSB's
  dig2 = number / 10;
  dig1 = number % 10; 
  if(dig3!=0) 						//if the the msb is not zero then the number contains 3 digit 
  	{
  		Serial_Wr(toAscii(dig3));
  		Serial_Wr(toAscii(dig2));
  	}
  else if(dig2!=0)	  				// if the number contains only 2 digit
  	{
		Serial_Wr(toAscii(dig2));
  		
	}
  Serial_Wr(toAscii(dig1));	  			// lsb 
  }


/*******************************************************************

*****/
/*****************************************************
	Function name:	Serial_puts( unsigned char *str )
	Return 		: nil
	Argument	: unsigned char data
	purpose:	Displays a STRING  in hyper terminal
********************************************************************

******/
void Serial_puts( unsigned char *str )
	{
		while(*str)
		{
			Serial_Wr(*str++);
		}

	}
/*************************************************
	Function name:	Serial_putUBYTEHex( unsigned char *str )
	Return 		: nil
	Argument	: unsigned char data
	purpose:	Displays a HEX value of a unsigned char data 

 in hyper terminal
********************************************************************

******/
//void Serial_putUBYTEHex ( unsigned char number )
//{
//  // Display the MSB
//  unsigned char a,b=0;
//  a= (0x0F & number>>4);
//  if(a >9)
//  	a=a+0x37;
//	else
//	a=a+0x30;
//	b= 0x0F & number;
//	 if(b >9)
//  	b=b+0x37;
//	else
//	b=b+0x30;
//  Serial_Wr(a);
//  
//  Serial_Wr(b);
//  
//}

/*******************************************************************

********
* Function: Serial_putUINT16
* Purpose:  Function to display an 16 bit unsigned number on Serial
* Parameters: number
*             number should be unsigned   
*             Range supported 0 to 65535
*             No Error checking done pass the input correctly
*             e.g if number is 0xff it will be displayed as 255 on 

Serial
* NOTE:!!  Leading Zeros will be displayed ... implement other 

function for disp
* zero as space and a master function that will call either the 

leading zero or
* the other based on the requirement
* Returns: None 
********************************************************************

*******/

void Serial_putUINT16 ( unsigned int number )
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
		Serial_Wr(toAscii(dig5));
		Serial_Wr(toAscii(dig4));
		Serial_Wr(toAscii(dig3));
  		Serial_Wr(toAscii(dig2));
	}
	else if(dig4 != 0)
	{
		Serial_Wr(toAscii(dig4));
		Serial_Wr(toAscii(dig3));
  		Serial_Wr(toAscii(dig2));
	}
	else if(dig3!=0)
  	{
  		Serial_Wr(toAscii(dig3));
  		Serial_Wr(toAscii(dig2));
  		//Serial_Wr(toAscii(dig1));
  	}
  	else if(dig2!=0)
  	{
		Serial_Wr(toAscii(dig2));
  		
	}
  Serial_Wr(toAscii(dig1));

 
}
   
		 	 