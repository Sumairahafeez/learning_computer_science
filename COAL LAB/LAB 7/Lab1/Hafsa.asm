INCLUDE Irvine32.inc

.data
    dataArray DWORD 5 DUP(?)
    arraySum  DWORD 0
    prompt    BYTE "Enter an integer: ",0
    msg1      BYTE "Sum is Greater than EAX",0
    msg2      BYTE "Sum is Less than EAX",0

.code
main PROC
    mov ebx, OFFSET dataArray
    mov ecx, LENGTHOF dataArray

input_loop:
    mov edx, OFFSET prompt
    call WriteString
    call ReadInt
    mov [ebx], eax
    add arraySum, eax
    add ebx, TYPE dataArray
    loop input_loop

    ; Get another integer for comparison
    mov edx, OFFSET prompt
    call WriteString
    call ReadInt
    mov edx, eax               ; Store user input in EDX

    ; Compare arraySum with user input
    mov eax, arraySum
    cmp eax, edx
    ja call_greater            ; arraySum > user input
    jb call_less               ; arraySum < user input
    jmp done                   ; arraySum == user input, exit

call_greater:
    call message1
    jmp done

call_less:
    call message2

; Procedure to display "Sum is Greater than EAX"
message1 PROC
    mov edx, OFFSET msg1
    call MsgBox
    ret
message1 ENDP

; Procedure to display "Sum is Less than EAX"
message2 PROC
    mov edx, OFFSET msg2
    call MsgBox
    ret
message2 ENDP

done:
    call crlf
    exit
main ENDP

END main