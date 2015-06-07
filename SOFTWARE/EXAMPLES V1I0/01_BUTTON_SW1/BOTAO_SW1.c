/*******************************************************************************
* uStart for PIC                                                               *
*                                                                              *
* Compilador: mikroC                                                           *
* Projeto: Teste SW1   REV.0                                                   *
*******************************************************************************/

#define SW1 PORTA.F0
#define LED1 PORTA.F1
#define LED2 PORTA.F2


void main() 
{
 TRISA.F0 = 1;  //Define o pino RA0 como entrada
 TRISA.F1 = 0;  //Define o pino RA1 como saída
 TRISA.F2 = 0;  //Define o pino RA2 como saída
 ADCON1 |= 0x0F;   //Define todos pinos AN como digital I/O

 while(1)
 {
  if (SW1)   //Se pressionado RA0
  {
   LED1 = 1; //Liga LED1
   LED2 = 0; //Desliga LED2
  }
  else       //Senão
  {
   LED2 = 1; //Liga LED2
   LED1 = 0; //Desliga LED1
  }
 } //while
} // main