CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterCommandeI`(
_id_commande_individuel int,
_nom_client VARCHAR(255),
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
	if _id_commande_individuel=0 then
		insert into velomax.commande_individuel (nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
        values (_nom_client, _nom_modele, _description_piece, _quantite, _rue_livraison, _ville_livraison, _codeP_livraison, _province_livraison, _date_livraison, _date_commande);
	else
	update commande_individuel
        set
            nom_client=_nom_client,
            nom_modele=_nom_modele,
            num_piece=_num_piece,
            quantite=_quantite,
            rue_livraison=_rue_livraison,
            ville_livraison=_ville_livraison,
            codeP_livraison=_codeP_livraison,
            province_livraison=_province_livraison,
            date_livraison=_date_livraison,
            date_commande=_date_commande
        where id_commande_individuel=_id_commande_individuel;
    end if;
END