Include Irvine32.inc
.386
.stack 4096
ExitProcess proto,dwExitCode:dword
.data 
	userString BYTE 50 DUP(?)
	message BYTE "Enter a string...",0
	charh BYTE 'h'
	charr BYTE 'r'
	secondString BYTE 50 DUP(?)
	sum WORD ?
	uppercasemsg BYTE "Uppercase string: "
.code
main proc
	mov edx, OFFSET message
	call WriteString
	mov edx, OFFSET userString
	mov ecx, 50
	call ReadString
	;mov edx, OFFSET userString
	;call WriteString
	mov esi, OFFSET userString
	mov ecx, eax
	mov al, charh
	call arrayFind
	mov dl,al
	;Get second string from the user
	mov edx, OFFSET message
	call WriteString
	mov edx, OFFSET secondString
	mov ecx, 50
	call ReadString
	mov esi,OFFSET secondString
	call UpperCase
	;checking the occurance of R
	mov esi, OFFSET secondString
	mov ecx, eax
	mov al, charr
	call arrayFind
	mov dh,al
	;sum of dh and dl
	movzx ax,dl
	movzx bx,dh
	add ax,bx
	mov sum,ax
	cmp sum,25
	jg exitProgram
infiniteloop:
	jmp infiniteloop	
exitProgram:
	EXIT
main endp
arrayFind PROC
	push esi
	push ecx
search:
	cmp ecx, 0
	je notfound
	mov al,[esi]
	cmp al,[esp+8]
	je found
	inc esi
	loop search
notfound:
	mov al,0
	jmp done
found:
	jmp done
done:
	pop ecx
	pop esi
	ret
arrayFind ENDP
UpperCase PROC
	push esi
convert:
	mov al, [esi]
	cmp al,0
	je done
	and al,11011111b
	mov [esi],al
done:
	pop esi
	ret
UpperCase ENDP
end main