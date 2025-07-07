Include Irvine32.inc
.386
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
	testVal sword -170
.code
main proc
	mov EAX,0
	mov AX, testVal
	SHL EAX, 16
	SAR EAX, 16
	;SHR EAX, 16
	;or EAX,0FFFF0000h
	call Writeint
	call DumpRegs
	exit
main ENDP
end main