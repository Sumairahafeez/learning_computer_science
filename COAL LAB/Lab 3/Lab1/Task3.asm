Include Irvine32.inc
.386
.model flat,stdcall
.stack 4096
ExitProcess proto,dwExitCode:dword
Monday EQU 0
Tuesday EQU 1
Wednesday EQU 2
Thursday EQU 3
Friday EQU 4
Saturday EQU 5
Sunday EQU 6
.data
	Weeklist DWORD day1,day2,day3,day4,day5,day6,day7
	day1 BYTE 'Monday',0
	day2 BYTE "Tuesday",0
	day3 BYTE "Wednesday",0
    day4 BYTE "Thursday", 0
    day5 BYTE "Friday", 0
    day6 BYTE "Saturday", 0
    day7 BYTE "Sunday", 0
.code
main proc
	movsx EAX, day1
	call WriteInt
	movsx EBX, day2
	call WriteInt
	movsx ECX, day3
	call WriteInt
	movsx EDX,day4
	call WriteInt
	INVOKE ExitProcess,0
	
main endp
end main