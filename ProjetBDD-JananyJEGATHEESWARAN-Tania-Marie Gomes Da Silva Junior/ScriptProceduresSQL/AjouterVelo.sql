CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterVelo`(
_num_modele int,
_nom_modele varchar(20) ,
_grandeur varchar(20),
_prix_unitaire_modele int,
_ligne_produit varchar(40),
_date_intro_modele date,
_stock_velo int

)
BEGIN
if _num_modele=0 then
	insert into modele (nom_modele,grandeur,prix_unitaire_modele,ligne_produit,date_intro_modele,date_discon_modele,stock_velo)
    values(_nom_modele,_grandeur,_prix_unitaire_modele,_ligne_produit,_date_intro_modele,null,_stock_velo);
else
        update modele
        set
            nom_modele=_nom_modele,
            grandeur=_grandeur,
            prix_unitaire_modele=_prix_unitaire_modele,
            ligne_produit=_ligne_produit,
            date_intro_modele=_date_intro_modele,
            stock_velo=_stock_velo
        where num_velo=_num_velo;
    end if;
END