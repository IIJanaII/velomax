CREATE DEFINER=`root`@`localhost` PROCEDURE `VoirPiece`()
BEGIN
	SELECT *
    FROM pieceRechange;
END