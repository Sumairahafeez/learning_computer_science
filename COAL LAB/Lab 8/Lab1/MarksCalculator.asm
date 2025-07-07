Include Irvine32.inc
.386
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
	marks DWORD ?
	message BYTE "Enter your marks...",0
	result BYTE "Your marks are...",0
	op1 DWORD 70
	op2 DWORD 80
	op3 DWORD 90
	gradeA BYTE "A",0
	gradeB BYTE "B",0
	gradeC BYTE "C",0
	invalid BYTE "Invalid Input",0
.code
main proc
	mov edx, OFFSET message
	call WriteString
	call ReadInt
	mov marks,eax
	cmp eax,op3
	ja A_grade
	cmp eax, op2
	jae B_grade
	cmp eax, op1
    jae grade_c
	A_grade:
	mov edx, OFFSET gradeA
	call WriteString
	exit
	B_grade:
	mov edx, OFFSET gradeB
	call WriteString
	exit
	grade_c:
	mov edx, OFFSET gradeC
	call WriteString
	exit

	exit
main endp
end main