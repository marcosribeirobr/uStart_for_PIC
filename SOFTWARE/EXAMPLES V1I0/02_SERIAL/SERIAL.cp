#line 1 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/02 - SERIAL/SERIAL.c"
#line 10 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/02 - SERIAL/SERIAL.c"
char valor;

void main()
{
 UART1_init(9600);
 delay_ms(10);
 TRISA.F1 = 0;
 PORTA.F1 = 0;

 while(1)
 {
 if(UART1_Data_Ready())
 {
 valor = UART1_Read();
 if(valor=='A')  PORTA.F1  = 1;
 else if(valor=='B')  PORTA.F1  = 0;
 }
 }
}
