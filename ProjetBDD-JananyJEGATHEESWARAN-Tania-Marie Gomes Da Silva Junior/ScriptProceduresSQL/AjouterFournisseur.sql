CREATE DEFINER=`root`@`localhost` PROCEDURE `AjouterFournisseur`(
_siret VARCHAR(40),
_nom_fournisseur VARCHAR(40) ,
_contact VARCHAR(40) ,
_rue_fournisseur VARCHAR(255) ,
_ville_fournisseur VARCHAR(40) ,
_codeP_fournisseur INT ,
_province_fournisseur VARCHAR(40),
_libelle ENUM('1','2','3','4')
)
BEGIN
        insert into fournisseur (siret,nom_fournisseur,contact,rue_fournisseur,ville_fournisseur,codeP_fournisseur,province_fournisseur,libelle)
        values (_siret,_nom_fournisseur,_contact,_rue_fournisseur,_ville_fournisseur,_codeP_fournisseur,_province_fournisseur,_libelle);
END