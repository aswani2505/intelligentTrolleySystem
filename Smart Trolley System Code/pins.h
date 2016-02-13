#include<reg51.h>

 sbit lcd_rs=P0^2;
 sbit lcd_e =P0^3;
 sbit b4 = P0^4;
 sbit b5 = P0^5;
 sbit b6 = P0^6;
 sbit b7 = P0^7;


 sbit add = P2^4;
 sbit remove = P2^5;

 sbit start_led = P2^6;

 sbit buzzer = P3^7;