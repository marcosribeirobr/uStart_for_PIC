/*******************************************************************************
* uStart for PIC                                                               *
*                                                                              *
* Compilador: mikroC                                                           *
* Projeto: CONVERSOR A/D   REV.0                                               *
* Descricação: Recebe dado do conversor A/D e envia pela Serial                *
*******************************************************************************/

float adc_rd;    // Variavel que recebe o valor da conversão analogica
char tensao[16];

void main()
{
   ADCON1 = 0b00001010;   // Define AN4, AN3, AN2, AN1 e AN0 como Entraga Analógica
   CMCON = 7;             // Desabilita comparadores

   UART1_init(9600);   // Inicia a UART com velocidade de 9600bps
   delay_ms(10);   // Espere 10ms para estabilizar
   ADC_init();   // Inicia ADC
   do
   {
    delay_ms(1000);   // Aguarda 1 seg
    adc_rd = ADC_Read(4);   // Obtem o resultado da conversao AN4 (RA5)
    delay_us(22);
    adc_rd = ((adc_rd*5)/1023);   // Mostra valores de tensão de 0 a 5V
    floattostr(adc_rd,tensao);   // Converte ponto flutuante em string

    UART1_Write_text(tensao);   // Escreve o valor de tensão na serial
    UART1_Write(13);  // Pula linha
    
   } while(1); // while
} // main