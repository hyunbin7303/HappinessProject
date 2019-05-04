
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

CREATE OR REPLACE FUNCTION Proc_DisplayTasksID(userID INTEGER) returns TABLE(
	task_idinfo integer[]
)
as $$
BEGIN
RETURN QUERY
	select "tasksID" from hpschema."DailyLife"
    WHERE hpschema."DailyLife".user_id = userID;
END; $$
LANGUAGE 'plpgsql' 


-- name, description, startdate, enddate
CREATE OR REPLACE FUNCTION Proc_InsertTaskTest(taskname TEXT, des TEXT, uid INTEGER)
RETURNS void as
$BODY$
BEGIN
	INSERT INTO hpschema."Task"(
	"tName", description, user_id)
	VALUES (taskname, des, uid);

END;
$BODY$
LANGUAGE 'plpgsql' VOLATILE

SELECT * FROM Proc_InsertTaskTest('Breakdance', 'BREKdance - TESTING DESCRIPTION', 5);
-- FUnction for display the task information with start,end and score ifnormation from db.


select * From hpschema."Task" t
INNER JOIN hpschema."TaskDetail" td
ON t.id = td.tid
WHERE t.id = 2;







-- 5/4 TOdolist!!!!
CREATE OR REPLACE FUNCTION Proc_DisplayDaily(userID INTEGER) returns TABLE(
	task_value integer[]
)
as $$
DECLARE 
numTasks INTEGER :=  (select array_length(task_idinfo, 1) from Proc_DisplayTasksID(userID));
BEGIN
RETURN QUERY
	select "tasksID" from hpschema."DailyLife";   
	 RAISE NOTICE 'The number of tasks : %', numTasks;

    FOR counter IN 1..numTasks from Proc_DisplayDaily(userID) 
	LOOP
    RAISE NOTICE 'Counter: %', counter;
    END LOOP;

END $$
LANGUAGE 'plpgsql' 



select * from Proc_DisplayDaily(1)
select * from Proc_DisplayTasksID(2)

select * from hpschema."DailyLife"
select * from hpschema."User"
select * from hpschema."Task"