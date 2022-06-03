CREATE DEFINER=`root`@`localhost` PROCEDURE `Qte_vendues`()
BEGIN
	select SUBSTRING_INDEX(numero_piece_catalogue_commande,'_',-1) as "Numéro pièce", 
	sum(quantite_piece_commande) as "Quantité vendue"
	from liste_piece_commande 
	group by SUBSTRING_INDEX(numero_piece_catalogue_commande,'_',-1);
END