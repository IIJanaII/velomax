CREATE DEFINER=`root`@`localhost` PROCEDURE `Gestion_Stock_P`()
BEGIN
(
SELECT num_piece, description_piece, stock_piece,
	CASE
		WHEN stock_piece>15 THEN 'Stock Conséquent'
		WHEN stock_piece<=15 AND stock_piece>2 THEN 'Stock Moyen'
		WHEN stock_piece<=2 AND stock_piece>0 THEN 'Stock Faible'
		WHEN stock_piece=0 THEN 'Rupture de Stock'
	END "Stock Piece"
FROM pieceRechange
);
END