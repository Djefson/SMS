Create table Documents

(
 ID int not null primary key identity(1,1),
 Data varbinary(max),
 Extension char(4),
 )