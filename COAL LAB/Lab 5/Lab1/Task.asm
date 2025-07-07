INCLUDE Irvine32.inc

.data
    myArray1 BYTE 1,2,3,4,5,0
    var1 DWORD ?  ; Variable to store user input

.code
main PROC
    call Randomize     ; Initialize random number generator

    ; Get user input for var1
    call ReadInt       ; Read input from the console
    mov var1, eax      ; Store input in var1

    ; Loop var1 times to call intSum
    mov ecx, var1
L3:
    mov eax, 100       ; Set range for random number
    call RandomRange   ; Generate random number
    call WriteInt      ; Print random number
    call CRLF

    call intSum
    loop L3

    exit
main ENDP

intSum PROC
    mov ecx, 5
    mov esi, 0

L1:
    movzx eax, myArray1[esi]  ; Load array element
    push eax                  ; Push onto stack
    inc esi
    loop L1

    mov ecx, 5
    mov esi, 0

L2:
    pop eax
    mov myArray1[esi], al     ; Store back into array
    call WriteInt
    call CRLF
    call sum
    inc esi
    loop L2

    mov al, bl
    call WriteInt
    call CRLF

    movzx eax, al  ; Convert AL to EAX for WriteHex
    call WriteHex
    call CRLF

    movzx eax, al    ; Convert AL to EAX for WriteDec
    call WriteDec
    call CRLF

    mov al, myArray1[0]  ; Load first array element
    ret
intSum ENDP

sum PROC
    ADD bl, al
    ret
sum ENDP

END main
