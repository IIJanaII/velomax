CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirCommande_e`()
BEGIN
	SELECT *
    FROM commande_e;
END