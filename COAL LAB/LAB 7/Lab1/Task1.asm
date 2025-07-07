Include Irvine32.inc
.data
	dataArray DWORD 0,0,0,0,0
	message1 BYTE "Sum is Greater than EAX",0
	message2 BYTE "Sum is Less than EAX",0
	getnumber BYTE "Enter any integer...",0
	sum DWORD 0
.code
main PROC
	mov ecx, 5
	mov esi,0
L1:
	call ReadInt
	mov dataArray[esi * TYPE DWORD], eax
	add sum,eax
	inc esi
	loop L1
	; get another integer from the user
		mov edx, OFFSET getnumber
		call WriteString
		call ReadInt
	; comparing the sum
	cmp sum,eax
	jg greater
	jl less
greater:
	mov edx, OFFSET message1
	call WriteString
	EXIT
less:
	mov edx, OFFSET message2
	call WriteString
	EXIT

main ENDP
END main