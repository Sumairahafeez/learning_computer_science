Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
	firstVal DWORD 20000h
	secondval DWORD 111111h
	thirdval DD 22222h
	sum DWORD 0
.code
main proc
	mov eax,firstVal
	add eax, secondval
	add eax, thirdval
	call WriteInt
	call DumpRegs
	INVOKE ExitProcess,0
	
main endp
end main