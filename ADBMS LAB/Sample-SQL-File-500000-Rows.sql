Select * from user_details
Update user_details
set gender = 'Female'
Update user_details
set gender = case status
when '0' then 'Female'
when '1' then 'Male'
end


