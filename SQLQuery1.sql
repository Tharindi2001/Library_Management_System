create database library

create table NewBook(
bid int Not Null IDENTITY(1,1) primary key,
bName varchar (50) not null,
bAuthor varchar (50) not null,
bPubi varchar (50) not null,
bPDate varchar (50) not null,
bPrice varchar (50) not null,
bQuan varchar (50) not null,)

insert into NewBook
(bid,bAuthor,bPubi,bPDate,bPrice,bQuan)
select * from NewBook

create table NewStudent1(
stId int Not Null IDENTITY(1,1) primary key,
stname varchar (50) not null,
Enroll varchar (50) not null,
Dep varchar (50) not null,
Sem varchar (50) not null,
Contact bigint not null,
Email varchar (50) not null,)


insert into NewStudent1
(stId ,Stname,Enroll,Dep,Sem,Contact,Email)
select * from NewStudent1

create table Issuebook(

id int Not Null IDENTITY(1,1) primary key,
st_enroll varchar (250) not null,
st_name varchar (250) not null,
st_Dep varchar (250) not null,
st_Sem varchar (250) not null,
st_Contact bigint not null,
st_Email varchar (250) not null,
book_name varchar (1250) not null,
book_issue_date varchar (250) not null,
book_return_date varchar (250) null,)

insert into Issuebook
(id ,st_enroll,st_name,st_Dep,st_Sem,st_Contact,st_Email,book_name,book_issue_date,book_return_date)
select * from Issuebook 
select * from Issuebook where st_enroll='0011' and book_return_date is Null




