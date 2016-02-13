
#include<pins.h>
#include<lcd.h>
//#include<rfid.h>
#include<serial.h>
#include<string.h>




#define BAUDRATE 9600
#define to_ascii(x)	 ((x&0x0F)|0x30)

#define RFID 1 
#define ZIGBEE 2




unsigned char code  tag1[] = "55000DE0E058";  // Dairy Milk Silk
unsigned char code  tag2[] = "55000DD0D25A";
unsigned char code  tag3[] = "55000DC7B02F";
unsigned char code  tag4[] = "55000D577A75";
unsigned char code  tag5[] = "55000D8A0FDD";
unsigned char code  tag6[] = "55000D6D5E6B";
unsigned char code  tag7[] = "55000DAE19EF";
unsigned char code  tag8[] = "55000DB645AB";
unsigned char code  tag9[] = "55000C80875E";
unsigned char code tag10[] = "15001BFA6195";
unsigned char code tag11[] = "121212121211";
unsigned char code tag12[] = "121212121221";


//unsigned char code  item1[] = "     item 1     ";
//unsigned char code  item2[] = "     item 2     ";
//unsigned char code  item3[] = "     item 3     ";
//unsigned char code  item4[] = "     item 4     ";
//unsigned char code  item5[] = "     item 5     ";
//unsigned char code  item6[] = "     item 6     ";
//unsigned char code  item7[] = "     item 7     ";
//unsigned char code  item8[] = "     item 8     ";
//unsigned char code  item9[] = "     item 9     ";
//unsigned char code item10[] = "     item 10    ";
//unsigned char code item11[] = "     item 11    ";
//unsigned char code item12[] = "     item 12    ";

unsigned char code  *item[] = 
{
 "                ",
 "TATA SALT 1kg ",
 "BISCUIT OREO",
 "DAIRYMILK SILK",
 "MAGGI 100gms",
 "SURF EXCEL MATIC",
 "KISSAN KETCHUP",
 "COLGATE TOTAL",
 "KURKURE",
 " OLD SPICE DEO",
 "     item 10    ",
 "     item 11    ",
 "     item 12    "
};


unsigned int cost[] = { 0, 18, 12 , 100 , 10 , 340 , 120 , 95 , 150 , 350 , 63 };


unsigned char code press_but[] = "Press ADD/REMOVE";




unsigned char store_zigbee[6], store_rfid[15];
unsigned char data_in , t ;
bit start_zigbee_f = 0 , all_zigbee_rec = 0, all_rfid_rec = 0;

unsigned char count_1, count_2 = 0;
unsigned char act , msec;
unsigned int balance = 0;
bit card_1_f = 0 ,card_2_f = 0 ,card_3_f = 0 ,card_4_f = 0 , total_f = 0;

unsigned char idata tmit[35];


void msdelay(unsigned int itime)
 {
  unsigned int i,j;
  for(i=0;i<itime;i++)
  for(j=0;j<1275;j++);
 }





void update_lcd(unsigned char dis)
{
 lcd(item[dis] , LINE1);
 lcd( "                ", LINE2);

 lcd("    Rs: ", LINE2);
 lcd_putUINT16(cost[dis]);
// balance = balance + cost[dis];
// lcdcmd(0xC8);
// lcd_putUINT16(balance);

}


unsigned char item_true[12] = 0;

void take_action(unsigned char dat)
{
 if(dat>=1 && dat<=10)	// rfid 
 {

  if(item_true[dat]==0)
  {
   update_lcd(dat);
   balance = balance + cost[dat];
   item_true[dat] = 1;
  }

  else
  {
   lcd(press_but, LINE1);
   lcd(item[dat], LINE2);
   while(add==1 && remove==1);
   msdelay(5);
   while(add==1 && remove==1 );

   if(add==0)
   {
	   update_lcd(dat);	item_true[dat]=1;
   }
   else 
   {
	 if(balance>0) 	 balance = balance - cost[dat]; item_true[dat]=0;
    lcd(item[dat] , LINE1);
    lcd( "     Removed    ", LINE2);

   }
  }




  
 }


}


unsigned char check_command()
{

///***************** CHECK ZIGBEE COMMAND ****************************///
 unsigned char result;
  result = 10;

  result = strcmp(store_zigbee,"@T2#");
  if(result==0)  { return(1);  }

  result = strcmp(store_zigbee,"@F2#");
  if(result==0)  { return(2);  }
  return(0);
}




unsigned char check_data()
{

///***************** CHECK RFID DATA ****************************///
 unsigned char result;
  result = 10;

  result = strcmp(store_rfid,tag1);
  if(result==0)  { return(1);  }

  result = strcmp(store_rfid,tag2);
  if(result==0)  { return(2);  }

  result = strcmp(store_rfid,tag3);
  if(result==0)  { return(3);  }

  result = strcmp(store_rfid,tag4);
  if(result==0)  { return(4);  }

  result = strcmp(store_rfid,tag5);
  if(result==0)  { return(5);  }

  result = strcmp(store_rfid,tag6);
  if(result==0)  { return(6);  }

  result = strcmp(store_rfid,tag7);
  if(result==0)  { return(7);  }

  result = strcmp(store_rfid,tag8);
  if(result==0)  { return(8);  }

  result = strcmp(store_rfid,tag9);
  if(result==0)  { return(9);  }

  result = strcmp(store_rfid,tag10);
  if(result==0)  { return(10);  }
 return(0);
//  result = strcmp(store_rfid,tag11);
//  if(result==0)  { return(11);  }
//
//  result = strcmp(store_rfid,tag12);
//  if(result==0)  { return(12);  }
 

///***************** CHECK ZIGBEE COMMANDS ****************************///



}  // end of take action routine



void timer_0() interrupt 1
{
 msec++;
 TF0 = 0; 

 if(msec>=40)
 {
  msec = 0;
 total_f = 1;
 TR0 = 0;
 }

 else
 {
  total_f = 0;
  TH0 = 0x4B ;
  TL0 = 0xFD; 
  TR0 = 1;
 }

}



void transmit_bill()
{
unsigned char ptr = 0;//ES = 0;
msdelay(1);
ptr = 0;
tmit[ptr++] = '@';
// Serial_Wr('0');
// Serial_Wr('0');
// Serial_Wr('2');
// Serial_Wr(':');
 if(item_true[1]==1)  {  tmit[ptr++] = '1'; tmit[ptr++] = ',';} 
 if(item_true[2]==1)  {  tmit[ptr++] = '2'; tmit[ptr++] = ',';} 
 if(item_true[3]==1)  {  tmit[ptr++] = '3'; tmit[ptr++] = ',';} 
 if(item_true[4]==1)  {  tmit[ptr++] = '4'; tmit[ptr++] = ',';} 
 if(item_true[5]==1)  {  tmit[ptr++] = '5'; tmit[ptr++] = ',';} 
 if(item_true[6]==1)  {  tmit[ptr++] = '6'; tmit[ptr++] = ',';} 
 if(item_true[7]==1)  {  tmit[ptr++] = '7'; tmit[ptr++] = ',';} 
 if(item_true[8]==1)  {  tmit[ptr++] = '8'; tmit[ptr++] = ',';} 
 if(item_true[9]==1)  {  tmit[ptr++] = '9'; tmit[ptr++] = ',';} 
 if(item_true[10]==1) {  tmit[ptr++] = 'A'; tmit[ptr++] = ',';}

 tmit[--ptr] = '#';
 tmit[++ptr] = '\0';

  Serial_puts(tmit);
// Serial_Wr('#');
// Serial_Wr('#');

// Serial_puts("\r\n");

}







//
//void transmit_bill()
//{
//ES = 0;
//msdelay(2);
//Serial_puts("@1,2,3,4,7,8,9#");
//
//}







void main()
{
 add = 1;	 // input key
 remove = 1; // input key
 msec = 0;
 buzzer = 0;
 Serial_Init();

 
 msdelay(10);

 lcd_init();
 lcd( " SMART TROLLEY  ", LINE1);
 lcd( "     SYSTEM     ", LINE2);

 msdelay(200);

 lcd( "  INITIALIZING  ", LINE1);
 lcd( "     ZIGBEE     ", LINE2);
 
 msdelay(600);


 lcd( "TROLLEY No: 002 ", LINE1);
 lcd( "                ", LINE2);

// msdelay(300);	 // ignore zigbees startup messages
 TMOD = TMOD|0x01;
 TH0 = 0x4B ;
 TL0 = 0xFD; 
// TR0 = 1;

//// 50 msec = 46082 or B402 ... count  4BFD  multiplier 40 for 2 SECs


 RI = 0;
 EA = 1; // enable interrupts
 ET0 = 1;

 RI = 0;
 ES = 1; // serial interrupt enable

 start_led = 1;

 while(1)
 {
  
  if(all_rfid_rec==1)
  {
   all_rfid_rec = 0;  // reusing variable
   ES = 0;
   act = check_data();

   take_action(act);
   
   TF0 = 1;
   count_1 = 0;   count_2 = 0;
	RI = 0;
     ES = 1;
  }

   if(total_f==1)
   {
//	ES = 0;
	lcd( "                ", LINE1);
   	lcd( "                ", LINE2);
//  	ES = 1;
	lcd("   TOTAL: ", LINE2);
	lcdcmd(0xC9);
    lcd_putUINT16(balance);
	total_f = 0;
//	RI = 0;
 //  	ES = 1;
   }

  if(all_zigbee_rec==1)
  {
   ES = 0;

  	all_zigbee_rec = 0;
	act = check_command();
	/// to be cont...  take action
	if(act==1)	// transfer total bill
	{
		 lcd( "                ", LINE1);
   	     lcd( "                ", LINE2);
	 	 lcd( "  SENDING BILL  ", LINE1); 
		  
		 //msdelay(70);
    	 
		 for(t=0;t<5;t++)
		 {
		  buzzer = 1;
		  transmit_bill();
		  msdelay(30);
		  buzzer = 0;
		  msdelay(30);
		 }
		 msdelay(100);

	   	 lcd( "    BILL SENT   ", LINE1);

	}

	else if(act==2)	// flush bill 
	{
		 balance = 0;
		 for(t=0;t<12;t++)
		 {
		  item_true[t] = 0;
		 }
	
		 lcd( "                ", LINE1);
   	     lcd( "                ", LINE2);
	 	 lcd( "    THANK YOU   ", LINE1);
		 buzzer = 1;
		 
		 msdelay(200);
		  buzzer = 0; 
	   	 lcd( "   VISIT AGAIN  ", LINE1);
		 msdelay(200); 
		 lcd( "TROLLEY No: 002 ", LINE1);
         lcd( "                ", LINE2);

	}
   count_1 = 0;   count_2 = 0;
   RI = 0;
   ES = 1;
  }
 

 }

}



void serial_isr() interrupt 4
{
 if(RI)
 {
  RI = 0;	 
  data_in = SBUF;
  if(data_in=='\r'||data_in=='\n')
  {
  
  }	// do nothing
  else 
  {
   if(data_in=='@')
   {
   	start_zigbee_f = 1;
	count_1 = 0;
   }

   if(start_zigbee_f==1)
   {
   	store_zigbee[count_1++]	= data_in;
   }

   if(data_in=='#')
   {
   	start_zigbee_f = 0;
	store_zigbee[count_1++]	= '\0';	 // null char for strcmp
	count_1 = 0;
	all_zigbee_rec = 1;
   }

   if(start_zigbee_f==0&&data_in!='#')
   {
   	if(count_2<=11)
	{
	 store_rfid[count_2++] = data_in;
	}
	if(count_2==12)
	{
	 store_rfid[count_2++]	= '\0';	 // null char for strcmp
	 count_2 = 0;
	 all_rfid_rec = 1;

	}
   
   }
  
  }

 
 }

 else 
 TI = 0;


}