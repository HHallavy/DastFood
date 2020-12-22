----------------------------------------------------------------------------------
/*
	Queries an Ingredient's Change through a given month in a year
	Parameters:
		$ReportDate - input date in 'YYYY-MM-DD' format as string
					  DD (day) can be given in various ways
					  if DD was n, only n days will be shown.
					  Example:
					  	'12-17-2020' as $ReportDate will give
						Day1, Day2, ..., Day17 and other values will be null
*/
----------------------------------------------------------------------------------
Select
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month')
			)
	) AS Day1,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 1 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+1 day')
			)
	) ELSE NULL END AS Day2,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 2 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+2 day')
			)
	) ELSE NULL END AS Day3,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 3 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+3 day')
			)
	) ELSE NULL END AS Day4,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 4 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+4 day')
			)
	) ELSE NULL END AS Day5,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 5 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+5 day')
			)
	) ELSE NULL END AS Day6,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 6 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+6 day')
			)
	) ELSE NULL END AS Day7,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 7 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+7 day')
			)
	) ELSE NULL END AS Day8,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 8 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+8 day')
			)
	) ELSE NULL END AS Day9,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 9 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+9 day')
			)
	) ELSE NULL END AS Day10,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 10 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+10 day')
			)
	) ELSE NULL END AS Day11,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 11 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+11 day')
			)
	) ELSE NULL END AS Day12,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 12 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+12 day')
			)
	) ELSE NULL END AS Day13,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 13 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+13 day')
			)
	) ELSE NULL END AS Day14,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 14 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+14 day')
			)
	) ELSE NULL END AS Day15,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 15 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+15 day')
			)
	) ELSE NULL END AS Day16,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 16 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+16 day')
			)
	) ELSE NULL END AS Day17,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 17 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+17 day')
			)
	) ELSE NULL END AS Day18,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 18 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+18 day')
			)
	) ELSE NULL END AS Day19,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 19 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+19 day')
			)
	) ELSE NULL END AS Day20,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 20 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+20 day')
			)
	) ELSE NULL END AS Day21,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 21 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+21 day')
			)
	) ELSE NULL END AS Day22,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 22 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+22 day')
			)
	) ELSE NULL END AS Day23,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 23 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+23 day')
			)
	) ELSE NULL END AS Day24,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 24 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+24 day')
			)
	) ELSE NULL END AS Day25,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 25 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+25 day')
			)
	) ELSE NULL END AS Day26,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 26 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+26 day')
			)
	) ELSE NULL END AS Day27,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 27 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+27 day')
			)
	) ELSE NULL END AS Day28,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 28 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+28 day')
			)
	) ELSE NULL END AS Day29,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 29 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+29 day')
			)
	) ELSE NULL END AS Day30,
	CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 30 THEN
	(
		Select SUM(Change) 
		FROM(
			SELECT Change from IngredientsReports 
			WHERE 
				IngredientsReports.Date <= Date($ReportDate,'start of month','+30 day')
			)
	) ELSE NULL END AS Day31