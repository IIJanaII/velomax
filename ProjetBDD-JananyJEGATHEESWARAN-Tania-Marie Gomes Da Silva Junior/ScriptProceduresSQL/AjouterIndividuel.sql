CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterIndividuel`(
_id_client int,
_nom_client varchar(255),
_prenom_client varchar(255),
_rue_client varchar(255),
_ville_client varchar(255),
_codeP_client varchar(255),
_province_client varchar(255),
_tel_client varchar(255),
_mail_client varchar(255),
_n_programme varchar(255)
)
BEGIN
    if _id_client=0 then
        insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client, tel_client, mail_client, n_programme)
        values (_nom_client,_prenom_client,_rue_client,_ville_client,_codeP_client,_province_client, _tel_client, _mail_client, _n_programme);
    else
        update Individuel
        set
            nom_client=_nom_client,
            prenom_client=_prenom_client,
            rue_client=_rue_client,
            ville_client=_ville_client,
            codeP_client=_codeP_client,
            province_client=_province_client,
            tel_client=_tel_client,
            mail_client=_mail_client,
            n_programme=_n_programme
        where id_client=_id_client;
    end if;
END