DECLARE 
a integer: = 10; 
b integer: = 20; 
c integer; 
f real; 
BEGIN 
c: = a + b; 
dbms_output.put_line ('Value of c: ' || c); 
f: = 70.0/3.0; 
dbms_output.put_line ('Value of f: ' || f); 
END; 
--if developer performs a small change to make code dynamic we use real