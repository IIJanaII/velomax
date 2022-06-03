CREATE DEFINER=`root`@`localhost` PROCEDURE `Membres_Adhesion`()
BEGIN
	select n_programme, count(c.n_programme)
	from Individuel c
	join fidelio f on f.n_programme=c.n_programme
	group by nom_programme;
END