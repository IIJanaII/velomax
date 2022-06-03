CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterCommandeE`(
_id_commande_e int,
_nom_e VARCHAR(255),
_nom_modele VARCHAR(255),
_description_piece VARCHAR(40),
_quantite VARCHAR(40),
_rue_livraison VARCHAR(50),
_ville_livraison VARCHAR(50),
_codeP_livraison INT,
_province_livraison VARCHAR(50),
_date_livraison DATE,
_date_commande DATE
)
BEGIN
	if _id_commande_e=0 then
		insert into commande_e (nom_e, nom_modele, description_piece, quantite,rue_livraison, ville_livraison,codeP_livraison,province_livraison,date_livraison,date_commande)
        values (_nom_e, _nom_modele, _description_piece, _quantite, _rue_livraison, _ville_livraison, _codeP_livraison, _province_livraison, _date_livraison, _date_commande);
	else
	update commande_e
        set
            nom_e=_nom_e,
            nom_modele=_nom_modele,
            num_piece=_num_piece,
            quantite=_quantite,
            rue_livraison=_rue_livraison,
            ville_livraison=_ville_livraison,
            codeP_livraison=_codeP_livraison,
            province_livraison=_province_livraison,
            date_livraison=_date_livraison,
            date_commande=_date_commande
        where id_commande_e=_id_commande_e;
    end if;
END