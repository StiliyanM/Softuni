SELECT *
FROM Mechanics m
JOIN Jobs j ON j.MechanicId = m.MechanicId
JOIN PartsNeeded pn ON pn.JobId = j.JobId
JOIN Parts p ON p.PartId = pn.PartId
JOIN Vendors v ON v.VendorId = p.VendorId

