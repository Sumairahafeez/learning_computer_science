select * from Data
select * from Data where Name = 'Sumaira'
select * from Data order by RegNo Desc
select COUNT(*) from Data as Count where dbo.Data.CGPA > 3.0
Update Data
set CGPA = 3.9
where RegNo = '2023-CS-27'
select Name from Data where Name like 'F%'