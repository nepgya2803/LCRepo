/* Write your T-SQL query statement below */
select unique_id, name 
from 
Employees LEFT JOIN EmployeeUNI ON Employees.id = EmployeeUNI.id