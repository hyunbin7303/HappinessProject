-- Table: hpschema."Task"
-- DROP TABLE hpschema."Task";
CREATE TABLE hpschema."Task"
(
    id integer NOT NULL,
    "tName" character varying(50) COLLATE pg_catalog."default",
    description character varying(200) COLLATE pg_catalog."default",
    user_id integer,
    CONSTRAINT "Task_pkey" PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hpschema."Task"
    OWNER to postgres;
	
	
-- Table: hpschema."TaskDetail"

-- DROP TABLE hpschema."TaskDetail";

CREATE TABLE hpschema."TaskDetail"
(
    tid integer NOT NULL,
    startdate date,
    enddate date,
    score integer,
    CONSTRAINT "TaskDetail_pkey" PRIMARY KEY (tid)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hpschema."TaskDetail"
    OWNER to postgres;
	
	
	
	-- Table: hpschema."User"

-- DROP TABLE hpschema."User";

CREATE TABLE hpschema."User"
(
    id integer NOT NULL,
    "fName" character varying(30) COLLATE pg_catalog."default",
    "lName" character varying(30) COLLATE pg_catalog."default",
    description character varying(100) COLLATE pg_catalog."default",
    CONSTRAINT "User_pkey" PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE hpschema."User"
    OWNER to postgres;