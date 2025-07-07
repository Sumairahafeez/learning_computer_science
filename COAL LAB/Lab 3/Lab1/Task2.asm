Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
hello TEXTEQU <"HELLO WORLD",0>
asm TEXTEQU <"Assembly Language">
.data 
	firstVal BYTE hello
	firstSize = ($ - firstVal)
	secondval BYTE asm
	secondSize = ($ - secondval)
.code
main proc
	movzx eax,firstVal
	movzx ebx,secondval
	mov eax,firstSize
	mov ebx,secondSize
	call WriteInt
	INVOKE ExitProcess,0
	
main endp
end main