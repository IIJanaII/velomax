CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirCommande_p`()
BEGIN
	SELECT *
    FROM commande_individuel;
END