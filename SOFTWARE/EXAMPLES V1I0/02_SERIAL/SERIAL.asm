
_main:

;SERIAL.c,12 :: 		void main()
;SERIAL.c,14 :: 		UART1_init(9600);  // Inicia o modulo UART com velocidade de 9600bps
	BSF         BAUDCON+0, 3, 0
	MOVLW       4
	MOVWF       SPBRGH+0 
	MOVLW       225
	MOVWF       SPBRG+0 
	BSF         TXSTA+0, 2, 0
	CALL        _UART1_Init+0, 0
;SERIAL.c,15 :: 		delay_ms(10);  // Espere 10ms para estabilizar
	MOVLW       156
	MOVWF       R12, 0
	MOVLW       215
	MOVWF       R13, 0
L_main0:
	DECFSZ      R13, 1, 1
	BRA         L_main0
	DECFSZ      R12, 1, 1
	BRA         L_main0
;SERIAL.c,16 :: 		TRISA.F1 = 0;  // Define pino RA1 como saida
	BCF         TRISA+0, 1 
;SERIAL.c,17 :: 		PORTA.F1 = 0;  // Seta valor 0 na saida
	BCF         PORTA+0, 1 
;SERIAL.c,19 :: 		while(1)
L_main1:
;SERIAL.c,21 :: 		if(UART1_Data_Ready())  // Se algum dado foi recebido
	CALL        _UART1_Data_Ready+0, 0
	MOVF        R0, 1 
	BTFSC       STATUS+0, 2 
	GOTO        L_main3
;SERIAL.c,23 :: 		valor = UART1_Read();  // Salva o dado na variavel
	CALL        _UART1_Read+0, 0
	MOVF        R0, 0 
	MOVWF       _valor+0 
;SERIAL.c,24 :: 		if(valor=='A') LED1 = 1;  // Se receber A, liga LED1
	MOVF        R0, 0 
	XORLW       65
	BTFSS       STATUS+0, 2 
	GOTO        L_main4
	BSF         PORTA+0, 1 
	GOTO        L_main5
L_main4:
;SERIAL.c,25 :: 		else if(valor=='B') LED1 = 0;  // Se receber B, desliga LED1
	MOVF        _valor+0, 0 
	XORLW       66
	BTFSS       STATUS+0, 2 
	GOTO        L_main6
	BCF         PORTA+0, 1 
L_main6:
L_main5:
;SERIAL.c,26 :: 		}
L_main3:
;SERIAL.c,27 :: 		} // while
	GOTO        L_main1
;SERIAL.c,28 :: 		} // main
L_end_main:
	GOTO        $+0
; end of _main
