
_InitTimer0:

;TIMER.c,18 :: 		void InitTimer0(){
;TIMER.c,19 :: 		T0CON = 0x87;
	MOVLW       135
	MOVWF       T0CON+0 
;TIMER.c,20 :: 		TMR0H = 0x48;
	MOVLW       72
	MOVWF       TMR0H+0 
;TIMER.c,21 :: 		TMR0L = 0xE5;
	MOVLW       229
	MOVWF       TMR0L+0 
;TIMER.c,22 :: 		GIE_bit = 1;
	BSF         GIE_bit+0, BitPos(GIE_bit+0) 
;TIMER.c,23 :: 		TMR0IE_bit = 1;
	BSF         TMR0IE_bit+0, BitPos(TMR0IE_bit+0) 
;TIMER.c,24 :: 		}
L_end_InitTimer0:
	RETURN      0
; end of _InitTimer0

_Interrupt:

;TIMER.c,31 :: 		void Interrupt(){
;TIMER.c,32 :: 		if (TMR0IF_bit){
	BTFSS       TMR0IF_bit+0, BitPos(TMR0IF_bit+0) 
	GOTO        L_Interrupt0
;TIMER.c,33 :: 		TMR0IF_bit = 0;
	BCF         TMR0IF_bit+0, BitPos(TMR0IF_bit+0) 
;TIMER.c,34 :: 		TMR0H = 0x48;
	MOVLW       72
	MOVWF       TMR0H+0 
;TIMER.c,35 :: 		TMR0L = 0xE5;;
	MOVLW       229
	MOVWF       TMR0L+0 
;TIMER.c,37 :: 		LED1 =! LED1;  // Inverte estado do LED1
	BTG         PORTA+0, 1 
;TIMER.c,38 :: 		}
L_Interrupt0:
;TIMER.c,40 :: 		}
L_end_Interrupt:
L__Interrupt5:
	RETFIE      1
; end of _Interrupt

_main:

;TIMER.c,42 :: 		void main()
;TIMER.c,44 :: 		TRISA.F1 = 0;
	BCF         TRISA+0, 1 
;TIMER.c,45 :: 		PORTA.F1 = 0;
	BCF         PORTA+0, 1 
;TIMER.c,46 :: 		ADCON1 |= 0x0F;  // Define todos pinos AN como digital I/O
	MOVLW       15
	IORWF       ADCON1+0, 1 
;TIMER.c,48 :: 		InitTimer0();   // Inicializa TIMER0
	CALL        _InitTimer0+0, 0
;TIMER.c,50 :: 		while(1)
L_main1:
;TIMER.c,52 :: 		}
	GOTO        L_main1
;TIMER.c,54 :: 		} // main
L_end_main:
	GOTO        $+0
; end of _main
