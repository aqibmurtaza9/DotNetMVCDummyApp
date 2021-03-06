USE [lab]
GO
/****** Object:  StoredProcedure [dbo].[pro_labrequest]    Script Date: 3/13/2020 12:08:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[pro_labrequest] 

@Mode nvarchar(10)=null,
@Mr_No int=0,
@Name nvarchar(50)=null,
@Guardian nvarchar(50)=null,
@Contact nvarchar(11)=null,
@Home_Contact nvarchar(11)=null,
@Martial_Status int=null,
@Gender int=null,
@DOB nvarchar(20)=null,
@Email nvarchar(20)=null,
@City int=null,
@CNIC nvarchar(15)=null,
@Address nvarchar(100)=null,
@Location_IP_Address nvarchar(15) = null,
@Location_User_Id nvarchar(15)=null ,
@Is_Active bit=null
as

if @Mode='INSERT'
begin
select @Mr_No=(select  ISNULL( MAX(MR_No),0)+1 from Tbl_PatientRegistration)
insert into Tbl_PatientRegistration(Mr_No,Name,Guardian,Contact,Home_Contact,Gender,Martial_Status,DOB,Email,City,CNIC,Address,Maker_User_Id,Last_Update_User)
              values(@Mr_No,@Name,@Guardian,@Contact,@Home_Contact,@Gender,@Martial_Status,@DOB,@Email,@City,@CNIC,@Address,@Location_IP_Address,@Location_User_Id)
End

if @Mode='Update'
begin
 update Tbl_PatientRegistration set
 
Name=@Name,
Guardian=@Guardian,
Contact=@Contact,
Home_Contact=@Home_Contact,
Martial_Status=@Martial_Status,
Gender=@Gender,
DOB=@DOB,
Email=@Email ,
City=@City ,
CNIC=@CNIC ,
Address=@Address ,
Maker_User_Id = @Location_IP_Address,
Last_Update_User = @Location_User_Id ,
Is_Active=@Is_Active
 where Mr_No=@Mr_No
end

if @Mode='Disable'
begin
update Tbl_PatientRegistration set
 Is_Active=@Is_Active
 where Mr_No=@Mr_No
end