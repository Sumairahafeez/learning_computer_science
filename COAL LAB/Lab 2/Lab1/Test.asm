; AddTwo.asm - adds two 32-bit integers.
; Chapter 3 example
;Task 1
Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
.data
	a DWORD 10
	b DWORD 7
	f DWORD 5
	d DWORD 6
	e DWORD 9
	g DWORD 0 ; use to store the result
.code
main proc
	mov eax, a
	sub eax,b
	mov eax,f
	add eax,d
	imul eax,eax
	imul eax,e
	mov g,eax
	Call WriteInt

	invoke ExitProcess,0
main endp
end main

COMMENT !
Task 2
Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
.data
	a dword 10
	b dword 7
	e dword 9


 
.code
main proc

	
	mov EAX,a
	sub EAX,b
	imul EAX,5+6
	imul EAX,e

	mov EAX,5*4
	mov EBX, 3
	add EBX,7
	imul EBX,21
	sub eax,ebx
	

	Call WriteInt
	INVOKE ExitProcess,0
main endp
end main
!