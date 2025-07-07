INCLUDE Irvine32.inc  

.DATA  
    myArray DWORD -8, 6, 5, 10, -22, 0, 87, 6, 9, -90, 0  
    arraySize DWORD 10                                    
    largest DWORD ?  
    msgBefore BYTE "Original Array: ", 0  
    msgAfter  BYTE "Updated Array: ", 0  

.CODE  
main PROC  
    call Clrscr  

    ; Print original array
    mov edx, OFFSET msgBefore  
    call WriteString  
    call Crlf  
    call DisplayArray  

    ; Find largest number
    call FindLargest  

    ; Shift elements and insert largest at the beginning
    call ShiftAndInsert  
    inc arraySize  

    ; Print updated array
    mov edx, OFFSET msgAfter  
    call WriteString  
    call Crlf  
    call DisplayArray  

    exit  
main ENDP  

FindLargest PROC  
    mov esi, OFFSET myArray  
    mov eax, [esi]            
    mov ecx, arraySize - 1    
    add esi, 4                

    .WHILE ecx > 0  
        .IF [esi] > eax  
            mov eax, [esi]      
        .ENDIF  
        add esi, 4  
        dec ecx  
    .ENDW  

    mov largest, eax           
    ret  
FindLargest ENDP  

ShiftAndInsert PROC  
    mov ecx, arraySize - 1     
    mov esi, OFFSET myArray  
    add esi, ecx * 4          

    .WHILE ecx > 0  
        mov eax, [esi-4]       
        mov [esi], eax         
        sub esi, 4  
        dec ecx  
    .ENDW  

    mov eax, largest        
    mov [myArray], eax       
    ret  
ShiftAndInsert ENDP  

DisplayArray PROC  
    mov ecx, arraySize  
    mov esi, OFFSET myArray  

    .WHILE ecx > 0  
        mov eax, [esi]  
        call WriteInt  
        mov al, ' '  
        call WriteChar  
        add esi, 4  
        dec ecx  
    .ENDW  

    call Crlf  
    ret  
DisplayArray ENDP  

END main  
