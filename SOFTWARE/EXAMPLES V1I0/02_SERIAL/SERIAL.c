/*******************************************************************************
* uStart for PIC                                                               *
*                                                                              *
* Compilador: mikroC                                                           *
* Projeto: SERIAL   REV.0                                                      *
*******************************************************************************/

#define LED1 PORTA.F1

char valor; // Variavel que recebe um valor da serial

void main() 
{
   UART1_init(9600);  // Inicia o modulo UART com velocidade de 9600bps
   delay_ms(10);  // Espere 10ms para estabilizar
   TRISA.F1 = 0;  // Define pino RA1 como saida
   PORTA.F1 = 0;  // Seta valor 0 na saida
   
   while(1)
   {
    if(UART1_Data_Ready())  // Se algum dado foi recebido
    {
      valor = UART1_Read();  // Salva o dado na variavel
      if(valor=='A') LED1 = 1;  // Se receber A, liga LED1
      else if(valor=='B') LED1 = 0;  // Se receber B, desliga LED1
    }
   } // while
} // main
