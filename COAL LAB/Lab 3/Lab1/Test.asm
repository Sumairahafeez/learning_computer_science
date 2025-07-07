Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
matrix1 EQU 10 * 10
matrix2 EQU matrix1
matrix3 EQU <matrix1>
matrix4 EQU <10 * 10>
matrix5 EQU <"Hey this is a code",0>
continueMessage TEXTEQU
.data 
	var1 DWORD 17
	var2 DWORD 6
	var3 DWORD 9
	var4 DWORD 3
.code
main proc
	mov EAX, var1
	mov EBX, var2
	mov ECX, var3
	mov EDX, var4
	add EAX,EBX
	add ECX,EDX
	SUB EAX,ECX
	call WriteInt
	invoke ExitProcess,0
	
main endp
end main