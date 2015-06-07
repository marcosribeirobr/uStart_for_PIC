
_main:

;CONVERSOR_AD.c,12 :: 		void main()
;CONVERSOR_AD.c,14 :: 		ADCON1 = 0b00001010;   // Define AN4, AN3, AN2, AN1 e AN0 como Entraga Analógica
	MOVLW       10
	MOVWF       ADCON1+0 
;CONVERSOR_AD.c,15 :: 		CMCON = 7;             // Desabilita comparadores
	MOVLW       7
	MOVWF       CMCON+0 
;CONVERSOR_AD.c,17 :: 		UART1_init(9600);   // Inicia a UART com velocidade de 9600bps
	BSF         BAUDCON+0, 3, 0
	MOVLW       4
	MOVWF       SPBRGH+0 
	MOVLW       225
	MOVWF       SPBRG+0 
	BSF         TXSTA+0, 2, 0
	CALL        _UART1_Init+0, 0
;CONVERSOR_AD.c,18 :: 		delay_ms(10);   // Espere 10ms para estabilizar
	MOVLW       156
	MOVWF       R12, 0
	MOVLW       215
	MOVWF       R13, 0
L_main0:
	DECFSZ      R13, 1, 1
	BRA         L_main0
	DECFSZ      R12, 1, 1
	BRA         L_main0
;CONVERSOR_AD.c,19 :: 		ADC_init();   // Inicia ADC
	CALL        _ADC_Init+0, 0
;CONVERSOR_AD.c,20 :: 		do
L_main1:
;CONVERSOR_AD.c,22 :: 		delay_ms(1000);   // Aguarda 1 seg
	MOVLW       61
	MOVWF       R11, 0
	MOVLW       225
	MOVWF       R12, 0
	MOVLW       63
	MOVWF       R13, 0
L_main4:
	DECFSZ      R13, 1, 1
	BRA         L_main4
	DECFSZ      R12, 1, 1
	BRA         L_main4
	DECFSZ      R11, 1, 1
	BRA         L_main4
	NOP
	NOP
;CONVERSOR_AD.c,23 :: 		adc_rd = ADC_Read(4);   // Obtem o resultado da conversao AN4 (RA5)
	MOVLW       4
	MOVWF       FARG_ADC_Read_channel+0 
	CALL        _ADC_Read+0, 0
	CALL        _Word2Double+0, 0
	MOVF        R0, 0 
	MOVWF       _adc_rd+0 
	MOVF        R1, 0 
	MOVWF       _adc_rd+1 
	MOVF        R2, 0 
	MOVWF       _adc_rd+2 
	MOVF        R3, 0 
	MOVWF       _adc_rd+3 
;CONVERSOR_AD.c,24 :: 		delay_us(22);
	MOVLW       87
	MOVWF       R13, 0
L_main5:
	DECFSZ      R13, 1, 1
	BRA         L_main5
	NOP
	NOP
;CONVERSOR_AD.c,25 :: 		adc_rd = ((adc_rd*5)/1023);   // Mostra valores de tensão de 0 a 5V
	MOVF        _adc_rd+0, 0 
	MOVWF       R0 
	MOVF        _adc_rd+1, 0 
	MOVWF       R1 
	MOVF        _adc_rd+2, 0 
	MOVWF       R2 
	MOVF        _adc_rd+3, 0 
	MOVWF       R3 
	MOVLW       0
	MOVWF       R4 
	MOVLW       0
	MOVWF       R5 
	MOVLW       32
	MOVWF       R6 
	MOVLW       129
	MOVWF       R7 
	CALL        _Mul_32x32_FP+0, 0
	MOVLW       0
	MOVWF       R4 
	MOVLW       192
	MOVWF       R5 
	MOVLW       127
	MOVWF       R6 
	MOVLW       136
	MOVWF       R7 
	CALL        _Div_32x32_FP+0, 0
	MOVF        R0, 0 
	MOVWF       _adc_rd+0 
	MOVF        R1, 0 
	MOVWF       _adc_rd+1 
	MOVF        R2, 0 
	MOVWF       _adc_rd+2 
	MOVF        R3, 0 
	MOVWF       _adc_rd+3 
;CONVERSOR_AD.c,26 :: 		floattostr(adc_rd,tensao);   // Converte ponto flutuante em string
	MOVF        R0, 0 
	MOVWF       FARG_FloatToStr_fnum+0 
	MOVF        R1, 0 
	MOVWF       FARG_FloatToStr_fnum+1 
	MOVF        R2, 0 
	MOVWF       FARG_FloatToStr_fnum+2 
	MOVF        R3, 0 
	MOVWF       FARG_FloatToStr_fnum+3 
	MOVLW       _tensao+0
	MOVWF       FARG_FloatToStr_str+0 
	MOVLW       hi_addr(_tensao+0)
	MOVWF       FARG_FloatToStr_str+1 
	CALL        _FloatToStr+0, 0
;CONVERSOR_AD.c,28 :: 		UART1_Write_text(tensao);   // Escreve o valor de tensão na serial
	MOVLW       _tensao+0
	MOVWF       FARG_UART1_Write_Text_uart_text+0 
	MOVLW       hi_addr(_tensao+0)
	MOVWF       FARG_UART1_Write_Text_uart_text+1 
	CALL        _UART1_Write_Text+0, 0
;CONVERSOR_AD.c,29 :: 		UART1_Write(13);  // Pula linha
	MOVLW       13
	MOVWF       FARG_UART1_Write_data_+0 
	CALL        _UART1_Write+0, 0
;CONVERSOR_AD.c,31 :: 		} while(1); // while
	GOTO        L_main1
;CONVERSOR_AD.c,32 :: 		} // main
L_end_main:
	GOTO        $+0
; end of _main
