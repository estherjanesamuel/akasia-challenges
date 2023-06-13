SELECT "a"."Date", COUNT(DISTINCT ("a"."NIM")) AS "DistinctCount"
FROM "Attendances" AS "a"
GROUP BY "a"."Date"