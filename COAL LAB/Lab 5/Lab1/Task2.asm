INCLUDE Irvine32.inc

.data
    sumResult DWORD ?  ; Variable to store the sum

.code
main PROC
    mov ecx, 40         
    mov edx, 60         

    call addRegisters                 
    mov sumResult, eax   
    call WriteInt
    call CRLF
    add eax, 5           
    push eax             
    pop eax
    call WriteInt
    call CRLF

    exit
main ENDP
addRegisters PROC
    push ebp            
    mov ebp, esp         
    mov eax, ecx
    add eax, edx         
    mov esp, ebp         
    pop ebp              
    ret
addRegisters ENDP

END main
