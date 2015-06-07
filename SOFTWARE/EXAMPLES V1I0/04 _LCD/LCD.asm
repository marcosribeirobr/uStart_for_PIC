
_main:

;LCD.c,26 :: 		void main()
;LCD.c,28 :: 		TRISD = 0;
	CLRF        TRISD+0 
;LCD.c,29 :: 		PORTD = 0;
	CLRF        PORTD+0 
;LCD.c,31 :: 		Lcd_Init();               // Inicializa LCD
	CALL        _Lcd_Init+0, 0
;LCD.c,32 :: 		Lcd_Cmd(_LCD_CLEAR);      // Limpa LCD
	MOVLW       1
	MOVWF       FARG_Lcd_Cmd_out_char+0 
	CALL        _Lcd_Cmd+0, 0
;LCD.c,33 :: 		Lcd_Cmd(_LCD_CURSOR_OFF); // Desliga cursor
	MOVLW       12
	MOVWF       FARG_Lcd_Cmd_out_char+0 
	CALL        _Lcd_Cmd+0, 0
;LCD.c,37 :: 		LCD_Out(1, 1, "uStart for PIC");
	MOVLW       1
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       1
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       ?lstr1_LCD+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(?lstr1_LCD+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;LCD.c,38 :: 		LCD_Out(2, 1, "PIC18F4550");
	MOVLW       2
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       1
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       ?lstr2_LCD+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(?lstr2_LCD+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;LCD.c,39 :: 		LCD_Out(3, 1, "MR");
	MOVLW       3
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       1
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       ?lstr3_LCD+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(?lstr3_LCD+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;LCD.c,40 :: 		LCD_Out(4, 1, "ABCDEFGHIJ1234567890");
	MOVLW       4
	MOVWF       FARG_Lcd_Out_row+0 
	MOVLW       1
	MOVWF       FARG_Lcd_Out_column+0 
	MOVLW       ?lstr4_LCD+0
	MOVWF       FARG_Lcd_Out_text+0 
	MOVLW       hi_addr(?lstr4_LCD+0)
	MOVWF       FARG_Lcd_Out_text+1 
	CALL        _Lcd_Out+0, 0
;LCD.c,43 :: 		while(1)
L_main0:
;LCD.c,45 :: 		} // while
	GOTO        L_main0
;LCD.c,46 :: 		} // main
L_end_main:
	GOTO        $+0
; end of _main
