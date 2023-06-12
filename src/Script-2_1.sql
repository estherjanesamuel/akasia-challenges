 SELECT "t"."Date", "t"."NIM", "t"."Fullname"
      FROM (
          SELECT DISTINCT "a"."Date", "a"."NIM", "s"."Fullname"
          FROM "Attendances" AS "a"
          INNER JOIN "Students" AS "s" ON "a"."NIM" = "s"."NIM"
          WHERE "a"."Date" IN ('2020-06-15 00:00:00', '2020-06-17 00:00:00')
      ) AS "t"
      ORDER BY "t"."Date"