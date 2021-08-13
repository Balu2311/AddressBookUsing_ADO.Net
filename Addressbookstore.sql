CREATE PROCEDURE addressProcedure
@first_name varchar(20) ,
@last_name varchar(20) ,
@address varchar(20),
@city varchar(20),
@state varchar(13),
@zip varchar(6),
@phone_number varchar(10),
@email varchar(20),
@bookname varchar(20) ,
@addressbooktype varchar(20)
as
insert into address_book values(@first_name,@last_name,@address,@city,@state,@zip,@phone_number,
    @email,@bookname,@addressbooktype);
go

select * from address_book