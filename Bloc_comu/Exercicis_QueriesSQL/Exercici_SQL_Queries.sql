/* 1.	Quantitat de registres de la taula de vols: */
SELECT COUNT(flightID) AS Total  FROM usairlineflights2.flights;
/* 2.	Retard promig de sortida i arribada segons l’aeroport origen:*/
SELECT Origin, AVG(ArrDelay) AS Prom_arribades, AVG(DepDelay) AS Prom_sortides FROM usairlineflights2.flights
GROUP BY Origin;
/* 3.	Retard promig d’arribada dels vols, per mesos, anys i segons l’aeroport origen.
A més, volen que els resultat es mostrin de la següent forma (fixa’t en l’ordre de les files):*/
SELECT Origin, colYear, colMonth, AVG(ArrDelay) AS Prom_arribades FROM usairlineflights2.flights
GROUP BY Origin, colYear, colMonth
ORDER BY Origin ASC;
/* 4.	Retard promig d’arribada dels vols, per mesos, anys i segons l’aeroport origen
(mateixa consulta que abans i amb el mateix ordre).
Però a més, ara volen que en comptes del codi de l’aeroport es mostri el nom de la ciutat.*/
SELECT City, colYear, colMonth, AVG(ArrDelay) AS Prom_arribades FROM usairlineflights2.flights
LEFT JOIN usairlineflights2.usairports
ON usairports.IATA = flights.Origin
GROUP BY City, colYear, colMonth
ORDER BY City ASC;
/*5.	Les companyies amb més vols cancelats, per mesos i any.
A més, han d’estar ordenades de forma que les companyies amb més cancel·lacions apareguin les primeres.*/
SELECT UniqueCarrier, colYear, colMonth, SUM(cancelled) AS Total_cancelled FROM usairlineflights2.flights
GROUP BY UniqueCarrier, colYear, colMonth
ORDER BY Total_cancelled DESC;
/* 6.	L’identificador dels 10 avions que més distància han recorregut fent vols.*/
SELECT TailNum, SUM(Distance) AS Total_distance FROM usairlineflights2.flights
GROUP BY TailNum HAVING TailNum <> ""
ORDER BY Total_distance DESC;
/* 7.	Companyies amb el seu retard promig només d’aquelles
les quals els seus vols arriben al seu destí amb un retràs promig major de 10 minuts.*/
SELECT UniqueCarrier, avg(ArrDelay) AS avgDelay FROM usairlineflights2.flights
GROUP BY UniqueCarrier HAVING avgDelay > 10
ORDER BY avgDelay DESC;