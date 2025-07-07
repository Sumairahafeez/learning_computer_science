Include Irvine32.inc
.386
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
	var1 WORD 50 DUP(5)
.code
main proc
	mov EAX, SIZEOF var1 ;Finds number of butes consumed by the variable
	mov EAX,LENGTHOF var1
	mov ESI,100
	mov AX,var1[ESI]
	;ADDING INTEGERS
	mov edi, OFFSET var1
	mov ecx, LENGTHOF var1
	mov eax,0
	L1:
		add eax,[edi]
		add edi,TYPE var1
		loop L1
		mov edx,0
		DIV ecx
	call WriteInt
	
main endp
end main