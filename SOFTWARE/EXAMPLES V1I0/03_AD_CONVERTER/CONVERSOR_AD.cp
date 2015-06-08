#line 1 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/03 - CONVERSOR AD/CONVERSOR_AD.c"
#line 9 "D:/Dropbox/PRODUTOS/FIRMWARES - SOFTWARES/901002 - PIC BOARD/EXEMPLOS/03 - CONVERSOR AD/CONVERSOR_AD.c"
float adc_rd;
char tensao[16];

void main()
{
 ADCON1 = 0b00001010;
 CMCON = 7;

 UART1_init(9600);
 delay_ms(10);
 ADC_init();
 do
 {
 delay_ms(1000);
 adc_rd = ADC_Read(4);
 delay_us(22);
 adc_rd = ((adc_rd*5)/1023);
 floattostr(adc_rd,tensao);

 UART1_Write_text(tensao);
 UART1_Write(13);

 } while(1);
}
