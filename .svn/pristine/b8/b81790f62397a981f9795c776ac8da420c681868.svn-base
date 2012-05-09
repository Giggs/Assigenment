<Query Kind="Expression">
  <Connection>
    <ID>361696b3-f3db-4ca2-8bca-39b2fa562684</ID>
    <Persist>true</Persist>
    <Server>neo</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>xmlwebsvc</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAALs/s8EVKSECws4xckgz8+QAAAAACAAAAAAADZgAAwAAAABAAAAAt7owKJii61Pb6g9SwhsSlAAAAAASAAACgAAAAEAAAADdB6kz0XQgmvTbc6mR4xPQQAAAAkTcyI/Ny/eRmB0lXZqBNaBQAAACfHVHt4OzNiNtmStxyqqicEPmeeA==</Password>
    <Database>HotelCore_v_1_0</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>


//Connect to the database HotelCore_v_1_0 on neo
 


//Write LINQ queries for the following:  //(Tables: Hotels, HotelDescription, Amenities, HotelAmenities, MasterAmenities)
 
//	1. List HotelId, SupplierFamily, Name, Rating, Latitude and Longitude of all the hotels whose name begins with ‘Americas’. Order the hotels by rating



from h in Hotels
where h.HotelName.StartsWith("Americas")
orderby h.Rating
select new
{
	h.HotelId,
	h.SupplierFamily,
	h.HotelName,
	h.Rating,
	h.Latitude,
	h.Longitude,
}




//  2. List the HotelId, SupplierFamily and HotelName of all hotels whose rating is 5 and SupplierFamily is “TravImp”. Order by hotel name

from h in Hotels
where h.Rating==5 && h.SupplierFamily=="TravImp"
orderby h.HotelName
select new
{
	h.HotelId,
	h.SupplierFamily,
	h.HotelName,
	h.Rating,	
}



//  3. List the SupplierFamily and general descriptions of all hotels with name = ‘ALTAFIUMARA’

from h in Hotels
join hd in HotelDescriptions
on h.HotelId equals hd.HotelId
where h.HotelName=="ALTAFIUMARA"
select new
{
	h.HotelId,
	h.SupplierFamily,
	h.HotelName,
	hd.DescriptionType,
	hd.Description
}



//  4.  Write a query to list the HotelName, AmentiyName and MasterAmenityName of all hotels with name =” ALTAFIUMARA’”. Order by AmenityName


from ha in HotelAmenities

join h in Hotels
on ha.HotelId equals h.HotelId

join a in Amenities
on ha.AmenityId equals a.AmenityId

join ma in MasterAmenities
on  a.MasterAmenityId equals ma.MasterAmenityId

orderby a.Name

where h.HotelName=="ALTAFIUMARA" 
select new
{
	h.HotelName,
	a.Name,
	ma.MasterAmenityName,
}
