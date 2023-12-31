Use AddressBookService;
select * from AddressBook;


Create Procedure AddContactDetails(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phonenumber varchar(10), 
@email varchar(30) 
)
As
begin insert Into AddressBook values(@firstName,@lastName,@address,@city,@state,@zip,@phonenumber,@email)
End

Create Procedure EditContactDetails(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phone varchar(10), 
@email varchar(30) 
)
As
begin
update AddressBook set firstName=@firstName,lastName=@lastName,address=@address,city=@city,state=@state,zip=@zip,phone=@phone,email=@email where firstName=@firstName
End

Create Procedure DeleteContactDetails(
@firstName varchar(20)
)
As
Begin Delete from AddressBook where firstName=@firstName
End

Create Procedure AllDetail
As
Begin
select * from AddressBook;
end

Alter Procedure DetailsinCity(
@city varchar(20)
)
As
Begin Select * from AddressBook where city=@city order by firstname 
End

Alter Procedure DetailsinState(
@state varchar(20)
)
As
Begin Select * from AddressBook where state=@state order by firstname 
End

Create Procedure CountinCity
As
Begin Select city, count(*)as count from AddressBook group by city
End


Create Procedure CountinState
As
Begin Select state, count(*)as count from AddressBook group by state
End

Create table Type(
id int primary key identity(1,1),
type varchar(20)
);

Insert into Type Values('Family');
Insert into Type Values('Friends');
Insert into Type Values('Profession');
Insert into Type Values('Others');

select * from Type

create Procedure AddMappingValues(
@Contactid int,
@Typeid int
)
As
Begin
Insert into AddressBookMapping values(@Contactid,@Typeid)
End

Create Procedure CountByType
As
Begin
Select Typeid, count(*)as count from AddressBookMapping group by Typeid 
End

Select * from AddressBookMapping
select * from Type
