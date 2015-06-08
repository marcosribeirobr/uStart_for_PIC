#line 1 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/05 - TIMER/TIMER.c"
#line 18 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/05 - TIMER/TIMER.c"
void InitTimer0(){
 T0CON = 0x87;
 TMR0H = 0x48;
 TMR0L = 0xE5;
 GIE_bit = 1;
 TMR0IE_bit = 1;
}
#line 31 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/05 - TIMER/TIMER.c"
void Interrupt(){
 if (TMR0IF_bit){
 TMR0IF_bit = 0;
 TMR0H = 0x48;
 TMR0L = 0xE5;;

  PORTA.F1  =!  PORTA.F1 ;
 }

}

void main()
{
 TRISA.F1 = 0;
 PORTA.F1 = 0;
 ADCON1 |= 0x0F;

 InitTimer0();

 while(1)
 {
 }

}
