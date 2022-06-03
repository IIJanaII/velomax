CREATE DEFINER=`root`@`localhost` PROCEDURE `Gestion_Stock_V`()
BEGIN
(
SELECT num_modele, nom_modele, stock_velo,
	CASE
		WHEN stock_velo>15 THEN 'Stock Conséquent'
		WHEN stock_velo<=15 AND stock_velo>2 THEN 'Stock Moyen'
		WHEN stock_velo<=2 AND stock_velo>0 THEN 'Stock Faible'
		WHEN stock_velo=0 THEN 'Rupture de Stock'
	END "Stock Velo"
FROM modele
);
END