CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirClients`()
BEGIN
	SELECT *
    FROM Individuel;
END