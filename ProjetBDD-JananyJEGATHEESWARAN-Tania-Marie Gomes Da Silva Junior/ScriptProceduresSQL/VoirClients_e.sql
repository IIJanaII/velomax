CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirClients_e`()
BEGIN
	SELECT *
    FROM Entreprise;
END