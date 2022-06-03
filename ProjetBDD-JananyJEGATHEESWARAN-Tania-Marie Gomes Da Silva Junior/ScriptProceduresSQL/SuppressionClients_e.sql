CREATE DEFINER=`root`@`localhost` PROCEDURE `SuppressionClients_e`(
_id_client_e INT)
BEGIN
	DELETE FROM Entreprise
    WHERE id_entreprise=_id_entreprise;
END