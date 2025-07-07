INCLUDE Irvine32.inc

.data
	myArray1 BYTE 1,2,3,4,5,0
	var1 DWORD ? 
	takeInput BYTE "Enter an integer...",0

.code
main PROC
	mov edx,OFFSET takeInput
	call WriteString
	call ReadInt        ; Read user input
	mov var1, eax      ; Store input in var1

	mov ecx, var1      ; Set loop counter
L4:
	push ecx 
	call intSum        ; Call intSum procedure          
	pop ecx            ; Restore ECX

	loop L4            ; Loop var1 times
exit
main ENDP

; intSum procedure - Works correctly now
intSum PROC
	mov eax, 100       ; Set range for RandomNumber
	mov ebx, OFFSET randomInt
	call WriteString
	call RandomRange   ; Generate random number
	call WriteInt      ; Print random number
	call CRLF
	mov ecx, 5          ; Set loop counter
	mov esi, 0          ; Initialize index

L1:
	movzx eax, myArray1[esi]  ; Load array value into EAX
	push eax                  ; Push onto stack
	inc esi                   ; Move to next index
	loop L1                   ; Repeat for 5 elements

	mov ecx, 5                ; Reset loop counter
	mov esi, 0                ; Reset index
	mov bl, 0                 ; Initialize BL to 0 (Fix sum issue)

L2:
	pop eax                   ; Retrieve from stack
	mov myArray1[esi], al     ; Store back into array
	call WriteInt             ; Display value
	call CRLF

	add bl, al                ; Sum values correctly
	inc esi
	loop L2

	movzx eax, bl             ; Convert sum to 32-bit
	call WriteInt             ; Display sum
	call CRLF

	call WriteHex
	call CRLF
	call WriteDec
	call CRLF

	ret
intSum ENDP

END main
