
_main:

;BOTAO_SW1.c,13 :: 		void main()
;BOTAO_SW1.c,15 :: 		TRISA.F0 = 1;  //Define o pino RA0 como entrada
	BSF         TRISA+0, 0 
;BOTAO_SW1.c,16 :: 		TRISA.F1 = 0;  //Define o pino RA1 como saída
	BCF         TRISA+0, 1 
;BOTAO_SW1.c,17 :: 		TRISA.F2 = 0;  //Define o pino RA2 como saída
	BCF         TRISA+0, 2 
;BOTAO_SW1.c,18 :: 		ADCON1 |= 0x0F;   //Define todos pinos AN como digital I/O
	MOVLW       15
	IORWF       ADCON1+0, 1 
;BOTAO_SW1.c,20 :: 		while(1)
L_main0:
;BOTAO_SW1.c,22 :: 		if (SW1)   //Se pressionado RA0
	BTFSS       PORTA+0, 0 
	GOTO        L_main2
;BOTAO_SW1.c,24 :: 		LED1 = 1; //Liga LED1
	BSF         PORTA+0, 1 
;BOTAO_SW1.c,25 :: 		LED2 = 0; //Desliga LED2
	BCF         PORTA+0, 2 
;BOTAO_SW1.c,26 :: 		}
	GOTO        L_main3
L_main2:
;BOTAO_SW1.c,29 :: 		LED2 = 1; //Liga LED2
	BSF         PORTA+0, 2 
;BOTAO_SW1.c,30 :: 		LED1 = 0; //Desliga LED1
	BCF         PORTA+0, 1 
;BOTAO_SW1.c,31 :: 		}
L_main3:
;BOTAO_SW1.c,32 :: 		} //while
	GOTO        L_main0
;BOTAO_SW1.c,33 :: 		} // main
L_end_main:
	GOTO        $+0
; end of _main
