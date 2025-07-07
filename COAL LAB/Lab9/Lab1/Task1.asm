INCLUDE Irvine32.inc

.data
    testVal DWORD 0F16Bh

.code
main PROC
    mov eax, 0 
    ;or eax,testVal
    or ax, 0F1h
    shl eax, 8
    or ax, 06Bh         
    call WriteString
    exit
main ENDP

END main
