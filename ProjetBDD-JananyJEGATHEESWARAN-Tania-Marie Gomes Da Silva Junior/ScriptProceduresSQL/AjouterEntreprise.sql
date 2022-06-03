CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterEntreprise`(
	_id_entreprise int,
	_nom_entreprise varchar(255),
	_rue_entreprise varchar(255),
	_ville_entreprise varchar(255),
	_codeP_entreprise  int,
	_province_entreprise varchar(255),
	_tel_entreprise varchar(255),
	_courriel_entreprise varchar(255),
	_nom_contact varchar(255),
	_remise_e varchar(255)
)
BEGIN
    if _id_entreprise=0 then
        INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`)
        values (_nom_entreprise,_rue_entreprise, _ville_entreprise,_codeP_entreprise,_province_entreprise,_tel_entreprise,_courriel_entreprise,_nom_contact,_remise_e);
    else
        update Entreprise
        set
            nom_entreprise=_nom_entreprise,
            rue_entreprise=_rue_entreprise,
            ville_entreprise=_ville_entreprise,
            codeP_entreprise=_codeP_entreprise,
           province_entreprise=_province_entreprise,
            tel_entreprise=_tel_entreprise,
            courriel_entreprise=_courriel_entreprise,
            nom_contact=_nom_contact,
            remise_e=_remise_e
        where id_entreprise=_id_entreprise;
    end if;
END