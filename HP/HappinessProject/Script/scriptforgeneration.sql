
CREATE OR REPLACE FUNCTION Proc_SeeTasks(INOUT p1 TEXT)
	RETURNS TABLE (
		description text,
	) AS 
	$func$
BEGIN
	RETURN QUERY
	SELECT id, T."tName", T.description, T.user_id, TD.startdate, TD.enddate, TD.score
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid;
END;
$func$ LANGUAGE plpgsql;



CREATE OR REPLACE FUNCTION TestFunc(varchar) returns TABLE(
	id INTEGER,
	description CHARACTER VARYING,
	user_id INTEGER
)
as $$
BEGIN
RETURN QUERY
	SELECT T.id, T.description,T.user_id
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid
	WHERE T."tName" = 'Breakdance';
END $$
LANGUAGE 'plpgsql' 
SELECT * FROM TestFUnc('Breakdance')




select * from hpschema."Task";

CREATE OR REPLACE FUNCTION Proc_DisplayTaskInfo(INTEGER) returns TABLE(
	taskid INTEGER,
	tName CHARACTER VARYING,
	description CHARACTER VARYING,
	startdate date,
	enddate date,
	score integer
)
as $$
BEGIN
RETURN QUERY
	SELECT T.id, T."tName",T.description, TD.startdate, TD.enddate, TD.score
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid
	WHERE T.user_id = $1;

END $$
LANGUAGE 'plpgsql' 
SELECT * FROM Proc_DisplayTaskInfo(1)

Drop function Proc_DisplayTaskInfo(INTEGER)