/*******************************************************************************
* uStart for PIC                                                               *
*                                                                              *
* Compilador: mikroC                                                           *
* Projeto: TIMER0   REV.0                                                      *
* Descricação: Pisca LED a cada 1seg utilizando interrupção TIMER0             *
*******************************************************************************/

#define LED1 PORTA.F1



/*******************************************************************************
* Timer0                                                                       *
* Prescaler 1:256; TMR0 Preload = 18661; Actual Interrupt Time : 1             *
* Inicializa TIMER0                                                            *
*******************************************************************************/
void InitTimer0(){
  T0CON = 0x87;
  TMR0H = 0x48;
  TMR0L = 0xE5;
  GIE_bit = 1;
  TMR0IE_bit = 1;
}


/*******************************************************************************
* Interrupt - High Priority                                                    *
* Inverte estado LED1 a cada 1 segundo                                         *
*******************************************************************************/
void Interrupt(){
  if (TMR0IF_bit){
    TMR0IF_bit = 0;
    TMR0H = 0x48;
    TMR0L = 0xE5;;

    LED1 =! LED1;  // Inverte estado do LED1
  }
  
}

void main() 
{
   TRISA.F1 = 0;
   PORTA.F1 = 0;
   ADCON1 |= 0x0F;  // Define todos pinos AN como digital I/O

   InitTimer0();   // Inicializa TIMER0

   while(1)
   {
   }
 // while
} // main