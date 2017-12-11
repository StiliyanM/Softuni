SELECT CountryName,IsoCode
FROM Countries
WHERE LEN(CountryName) - LEN(REPLACE(LOWER(CountryName),'a','')) > 2
ORDER BY IsoCode