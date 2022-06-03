CREATE DEFINER=`root`@`localhost` PROCEDURE `Adhesion_Fin`()
BEGIN
(
SELECT id_client, nom_client mail_client, date_adhesion, n_programme,
	CASE
		WHEN n_programme='1' THEN DATE_ADD(date_adhesion, INTERVAL 1 YEAR)
        WHEN n_programme='2' or '3' THEN DATE_ADD(date_adhesion, INTERVAL 2 YEAR)
		WHEN n_programme='4' THEN DATE_ADD(date_adhesion, INTERVAL 2 YEAR)
	END "Date Fin"
FROM Individuel
);
END