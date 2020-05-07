SELECT a.Name, b.ServiceDate,c.ServiceName, c.Fee FROM Providers a
INNER JOIN ServiceRecord b ON b.ProviderId = a.Id
INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id
WHERE b.ProviderID = 100000000;




SELECT  b.ServiceDate, b.CurrentDateAndTime as TimeReceived, d.Id as MemberNumber, d.Name as MemberName, c.ServiceName, c.Fee FROM Providers a
INNER JOIN ServiceRecord b ON b.ProviderId = a.Id
INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id
INNER JOIN Members d ON d.Id = b.MemberId
WHERE b.ProviderID = 100000000;

