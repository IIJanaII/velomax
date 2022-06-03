CREATE DEFINER=`root`@`localhost` PROCEDURE `Adhésion_client_fidelio`()
BEGIN
	if n_programme='1' then
		update adhesion
        set
            n_programme=_n_programme,
            id_client=_id_client,
            date_debut=_date_debut,
            date_fin=dateadd((year(_date_debut)+1),month(_date_debut),day(_date_debut))
		where n_programme=_n_programme;
	end if;
    if n_programme=('2' or '3') then
		update adhesion
        set
            n_programme=_n_programme,
            id_client=_id_client,
            date_debut=_date_debut,
            date_fin=dateadd((year(_date_debut)+2),month(_date_debut),day(_date_debut))
		where n_programme=_n_programme;
	end if;
    if n_programme='4' then
		update adhesion
        set
            n_programme=_n_programme,
            id_client=_id_client,
            date_debut=_date_debut,
            date_fin=dateadd((year(_date_debut)+4),month(_date_debut),day(_date_debut))
		where n_programme=_n_programme;
	end if;
END