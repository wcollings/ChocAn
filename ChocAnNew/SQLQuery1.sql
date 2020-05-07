SELECT a.Name, b.ServiceDate,c.ServiceName, c.Fee FROM Providers a
INNER JOIN ServiceRecord b ON b.ProviderId = a.Id
INNER JOIN ProviderDirectory c ON b.ServiceCode = c.Id
WHERE b.ProviderID = 100000000;