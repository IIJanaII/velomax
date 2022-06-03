CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterPiece`(
_num_piece VARCHAR(255),
_siret VARCHAR(40),
_nom_fournisseur VARCHAR(40),
_description_piece VARCHAR(50),
_num_catalogue INT,
_prix_piece INT,
_date_intro_piece DATE,
_date_discon_piece DATE,
_delais INT,
_stock_piece INT
)
BEGIN
        insert into pieceRechange (num_piece, description_piece, siret, nom_fournisseur, num_catalogue, prix_piece,date_intro_piece,date_discon_piece,delais,stock_piece)
        values (_num_piece, _description_piece, _siret, _nom_fournisseur, _num_catalogue, _prix_piece,_date_intro_piece,_date_discon_piece,_delais,_stock_piece);
END