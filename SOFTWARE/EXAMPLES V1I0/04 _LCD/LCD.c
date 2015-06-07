/*******************************************************************************
* uStart for PIC                                                               *
*                                                                              *
* Compilador: mikroC                                                           *
* Projeto: lCD      REV.0                                                      *
*******************************************************************************/

// LCD module connections
sbit LCD_RS at RD1_bit;
sbit LCD_EN at RD0_bit;
sbit LCD_D4 at RD4_bit;
sbit LCD_D5 at RD5_bit;
sbit LCD_D6 at RD6_bit;
sbit LCD_D7 at RD7_bit;

sbit LCD_RS_Direction at TRISD1_bit;
sbit LCD_EN_Direction at TRISD0_bit;
sbit LCD_D4_Direction at TRISD4_bit;
sbit LCD_D5_Direction at TRISD5_bit;
sbit LCD_D6_Direction at TRISD6_bit;
sbit LCD_D7_Direction at TRISD7_bit;
// End LCD module connections



void main() 
{
   TRISD = 0;
   PORTD = 0;

   Lcd_Init();               // Inicializa LCD
   Lcd_Cmd(_LCD_CLEAR);      // Limpa LCD
   Lcd_Cmd(_LCD_CURSOR_OFF); // Desliga cursor


   // Escrita no LCD
   LCD_Out(1, 1, "uStart for PIC");
   LCD_Out(2, 1, "PIC18F4550");
   LCD_Out(3, 1, "MR");
   LCD_Out(4, 1, "ABCDEFGHIJ1234567890");


   while(1)
   {
   } // while
} // main