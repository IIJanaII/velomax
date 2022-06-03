CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirFournisseur`()
BEGIN
	SELECT *
    FROM Fournisseur;
END