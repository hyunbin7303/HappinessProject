PGDMP     (                    w           HPdb    11.2    11.2 7    H           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            I           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            J           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            K           1262    16393    HPdb    DATABASE     �   CREATE DATABASE "HPdb" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE "HPdb";
             postgres    false                        2615    16394    hpschema    SCHEMA        CREATE SCHEMA hpschema;
    DROP SCHEMA hpschema;
             postgres    false                        3079    16395 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                  false            L           0    0    EXTENSION adminpack    COMMENT     M   COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';
                       false    1            �            1255    16404    fnsomefunc(integer, text)    FUNCTION     t  CREATE FUNCTION public.fnsomefunc(numtimes integer, msg text) RETURNS text
    LANGUAGE plpgsql IMMUTABLE SECURITY DEFINER COST 10
    AS $$
    DECLARE
    strresult text;
    BEGIN
    strresult := '';
    IF numtimes > 0 THEN
    FOR i IN 1 .. numtimes LOOP
    strresult := strresult || msg || E'\r\n';
    END LOOP;
    END IF;
    RETURN strresult;
    END;
    $$;
 =   DROP FUNCTION public.fnsomefunc(numtimes integer, msg text);
       public       postgres    false            �            1255    16484 #   proc_displayalltasksofuser(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.proc_displayalltasksofuser(userid integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
	PERFORM * FROM hpschema."User"
	WHERE hpschema."User".id = userID;
	END;
$$;
 B   DROP PROCEDURE public.proc_displayalltasksofuser(userid integer);
       public       postgres    false            �            1255    16496    proc_displaydaily(integer)    FUNCTION     �  CREATE FUNCTION public.proc_displaydaily(userid integer) RETURNS TABLE(task_value integer[])
    LANGUAGE plpgsql
    AS $$
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

END $$;
 8   DROP FUNCTION public.proc_displaydaily(userid integer);
       public       postgres    false            �            1255    16405    proc_displaytaskinfo()    FUNCTION     �  CREATE FUNCTION public.proc_displaytaskinfo() RETURNS TABLE(id integer, description character varying, user_id integer, tname character varying, startdate date, enddate date, score integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
RETURN QUERY
	SELECT T.id, T.description,T.user_id, T."tName", TD.startdate, TD.enddate, TD.score
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid;

END $$;
 -   DROP FUNCTION public.proc_displaytaskinfo();
       public       postgres    false            �            1255    16406    proc_displaytaskinfo(integer)    FUNCTION     �  CREATE FUNCTION public.proc_displaytaskinfo(integer) RETURNS TABLE(taskid integer, tname character varying, description character varying, startdate date, enddate date, score integer)
    LANGUAGE plpgsql
    AS $_$
BEGIN
RETURN QUERY
	SELECT T.id, T."tName",T.description, TD.startdate, TD.enddate, TD.score
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid
	WHERE T.user_id = $1;

END $_$;
 4   DROP FUNCTION public.proc_displaytaskinfo(integer);
       public       postgres    false            �            1255    16502    proc_displaytasksid(integer)    FUNCTION     �   CREATE FUNCTION public.proc_displaytasksid(userid integer) RETURNS TABLE(task_idinfo integer[])
    LANGUAGE plpgsql
    AS $$
BEGIN
RETURN QUERY
	select "tasksID" from hpschema."DailyLife"
    WHERE hpschema."DailyLife".user_id = userID;
END; $$;
 :   DROP FUNCTION public.proc_displaytasksid(userid integer);
       public       postgres    false            �            1255    16407 (   proc_inserttasktest(text, text, integer)    FUNCTION     �   CREATE FUNCTION public.proc_inserttasktest(taskname text, des text, uid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
	INSERT INTO hpschema."Task"(
	"tName", description, user_id)
	VALUES (taskname, des, uid);

END;
$$;
 P   DROP FUNCTION public.proc_inserttasktest(taskname text, des text, uid integer);
       public       postgres    false            �            1255    16408 1   proc_inserttasktest(integer, text, text, integer)    FUNCTION       CREATE FUNCTION public.proc_inserttasktest(idtask integer, taskname text, des text, uid integer) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
	INSERT INTO hpschema."Task"(
	id, "tName", description, user_id)
	VALUES (idtask, taskname, des, uid);

END;
$$;
 `   DROP FUNCTION public.proc_inserttasktest(idtask integer, taskname text, des text, uid integer);
       public       postgres    false            �            1255    16409    proc_seetasks(text)    FUNCTION       CREATE FUNCTION public.proc_seetasks(INOUT p1 text) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
	SELECT id, T."tName", T.description, T.user_id, TD.startdate, TD.enddate, TD.score
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid;
END;
$$;
 3   DROP FUNCTION public.proc_seetasks(INOUT p1 text);
       public       postgres    false            �            1255    16410    procedure1(text)    FUNCTION     �   CREATE FUNCTION public.procedure1(INOUT p1 text) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
    RAISE NOTICE 'Procedure Parameter: %', p1 ;
END ;
$$;
 0   DROP FUNCTION public.procedure1(INOUT p1 text);
       public       postgres    false            �            1255    16411    sum_n_product(integer, integer)    FUNCTION     �   CREATE FUNCTION public.sum_n_product(x integer, y integer, OUT sum integer, OUT prod integer) RETURNS record
    LANGUAGE plpgsql
    AS $$
BEGIN 
	sum := x + y;
	prod := x* y;
END;
$$;
 ]   DROP FUNCTION public.sum_n_product(x integer, y integer, OUT sum integer, OUT prod integer);
       public       postgres    false            �            1255    16412 
   testfunc()    FUNCTION       CREATE FUNCTION public.testfunc() RETURNS TABLE(id integer, description character varying, user_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
RETURN QUERY
	SELECT T.id, T.description,T.user_id
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid;

END $$;
 !   DROP FUNCTION public.testfunc();
       public       postgres    false            �            1255    16413    testfunc(character varying)    FUNCTION     M  CREATE FUNCTION public.testfunc(character varying) RETURNS TABLE(id integer, description character varying, user_id integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
RETURN QUERY
	SELECT T.id, T.description,T.user_id
	FROM hpschema."Task" T
	INNER JOIN hpschema."TaskDetail" TD
	ON T.id = TD.tid
	WHERE T."tName" = 'Breakdance';
END $$;
 2   DROP FUNCTION public.testfunc(character varying);
       public       postgres    false            �            1259    16439 	   DailyLife    TABLE     �   CREATE TABLE hpschema."DailyLife" (
    user_id integer NOT NULL,
    "Date" date NOT NULL,
    score integer,
    "tasksID" integer[]
);
 !   DROP TABLE hpschema."DailyLife";
       hpschema         postgres    false    7            �            1259    16414    Task    TABLE     �   CREATE TABLE hpschema."Task" (
    id integer NOT NULL,
    "tName" character varying(50),
    description character varying(200),
    user_id integer
);
    DROP TABLE hpschema."Task";
       hpschema         postgres    false    7            �            1259    16417 
   TaskDetail    TABLE     z   CREATE TABLE hpschema."TaskDetail" (
    tid integer NOT NULL,
    startdate date,
    enddate date,
    score integer
);
 "   DROP TABLE hpschema."TaskDetail";
       hpschema         postgres    false    7            �            1259    16420    Task_id_seq    SEQUENCE     �   CREATE SEQUENCE hpschema."Task_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE hpschema."Task_id_seq";
       hpschema       postgres    false    7    198            M           0    0    Task_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE hpschema."Task_id_seq" OWNED BY hpschema."Task".id;
            hpschema       postgres    false    200            �            1259    16422    User    TABLE     �   CREATE TABLE hpschema."User" (
    id integer NOT NULL,
    "fName" character varying(30),
    "lName" character varying(30),
    description character varying(100)
);
    DROP TABLE hpschema."User";
       hpschema         postgres    false    7            �            1259    16425    accounts    TABLE     �   CREATE TABLE public.accounts (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    balance numeric(15,2) NOT NULL
);
    DROP TABLE public.accounts;
       public         postgres    false            �            1259    16428    accounts_id_seq    SEQUENCE     �   ALTER TABLE public.accounts ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.accounts_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public       postgres    false    202            �            1259    16454 
   so_headers    TABLE     y   CREATE TABLE public.so_headers (
    id integer NOT NULL,
    customer_id integer,
    ship_to character varying(255)
);
    DROP TABLE public.so_headers;
       public         postgres    false            �            1259    16452    so_headers_id_seq    SEQUENCE     �   CREATE SEQUENCE public.so_headers_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.so_headers_id_seq;
       public       postgres    false    206            N           0    0    so_headers_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.so_headers_id_seq OWNED BY public.so_headers.id;
            public       postgres    false    205            �            1259    16460    so_items    TABLE     �   CREATE TABLE public.so_items (
    item_id integer NOT NULL,
    so_id integer NOT NULL,
    product_id integer,
    qty integer,
    net_price numeric
);
    DROP TABLE public.so_items;
       public         postgres    false            �            1259    16485    testtokentable    TABLE     g   CREATE TABLE public.testtokentable (
    id integer NOT NULL,
    text text,
    category integer[]
);
 "   DROP TABLE public.testtokentable;
       public         postgres    false            �
           2604    16430    Task id    DEFAULT     j   ALTER TABLE ONLY hpschema."Task" ALTER COLUMN id SET DEFAULT nextval('hpschema."Task_id_seq"'::regclass);
 :   ALTER TABLE hpschema."Task" ALTER COLUMN id DROP DEFAULT;
       hpschema       postgres    false    200    198            �
           2604    16457    so_headers id    DEFAULT     n   ALTER TABLE ONLY public.so_headers ALTER COLUMN id SET DEFAULT nextval('public.so_headers_id_seq'::regclass);
 <   ALTER TABLE public.so_headers ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    205    206    206            A          0    16439 	   DailyLife 
   TABLE DATA               J   COPY hpschema."DailyLife" (user_id, "Date", score, "tasksID") FROM stdin;
    hpschema       postgres    false    204   SD       ;          0    16414    Task 
   TABLE DATA               E   COPY hpschema."Task" (id, "tName", description, user_id) FROM stdin;
    hpschema       postgres    false    198   �D       <          0    16417 
   TaskDetail 
   TABLE DATA               H   COPY hpschema."TaskDetail" (tid, startdate, enddate, score) FROM stdin;
    hpschema       postgres    false    199   DE       >          0    16422    User 
   TABLE DATA               E   COPY hpschema."User" (id, "fName", "lName", description) FROM stdin;
    hpschema       postgres    false    201   �E       ?          0    16425    accounts 
   TABLE DATA               5   COPY public.accounts (id, name, balance) FROM stdin;
    public       postgres    false    202   �E       C          0    16454 
   so_headers 
   TABLE DATA               >   COPY public.so_headers (id, customer_id, ship_to) FROM stdin;
    public       postgres    false    206   (F       D          0    16460    so_items 
   TABLE DATA               N   COPY public.so_items (item_id, so_id, product_id, qty, net_price) FROM stdin;
    public       postgres    false    207   EF       E          0    16485    testtokentable 
   TABLE DATA               <   COPY public.testtokentable (id, text, category) FROM stdin;
    public       postgres    false    208   bF       O           0    0    Task_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('hpschema."Task_id_seq"', 11, true);
            hpschema       postgres    false    200            P           0    0    accounts_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.accounts_id_seq', 2, true);
            public       postgres    false    203            Q           0    0    so_headers_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.so_headers_id_seq', 1, false);
            public       postgres    false    205            �
           2606    16443    DailyLife DailyLife_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY hpschema."DailyLife"
    ADD CONSTRAINT "DailyLife_pkey" PRIMARY KEY (user_id);
 H   ALTER TABLE ONLY hpschema."DailyLife" DROP CONSTRAINT "DailyLife_pkey";
       hpschema         postgres    false    204            �
           2606    16432    TaskDetail TaskDetail_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY hpschema."TaskDetail"
    ADD CONSTRAINT "TaskDetail_pkey" PRIMARY KEY (tid);
 J   ALTER TABLE ONLY hpschema."TaskDetail" DROP CONSTRAINT "TaskDetail_pkey";
       hpschema         postgres    false    199            �
           2606    16434    Task Task_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY hpschema."Task"
    ADD CONSTRAINT "Task_pkey" PRIMARY KEY (id);
 >   ALTER TABLE ONLY hpschema."Task" DROP CONSTRAINT "Task_pkey";
       hpschema         postgres    false    198            �
           2606    16436    User User_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY hpschema."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (id);
 >   ALTER TABLE ONLY hpschema."User" DROP CONSTRAINT "User_pkey";
       hpschema         postgres    false    201            �
           2606    16438    accounts accounts_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.accounts
    ADD CONSTRAINT accounts_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.accounts DROP CONSTRAINT accounts_pkey;
       public         postgres    false    202            �
           2606    16459    so_headers so_headers_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.so_headers
    ADD CONSTRAINT so_headers_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.so_headers DROP CONSTRAINT so_headers_pkey;
       public         postgres    false    206            �
           2606    16467    so_items so_items_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.so_items
    ADD CONSTRAINT so_items_pkey PRIMARY KEY (item_id, so_id);
 @   ALTER TABLE ONLY public.so_items DROP CONSTRAINT so_items_pkey;
       public         postgres    false    207    207            �
           2606    16492 "   testtokentable testtokentable_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.testtokentable
    ADD CONSTRAINT testtokentable_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.testtokentable DROP CONSTRAINT testtokentable_pkey;
       public         postgres    false    208            �
           2606    16468    so_items so_items_so_id_fkey    FK CONSTRAINT     ~   ALTER TABLE ONLY public.so_items
    ADD CONSTRAINT so_items_so_id_fkey FOREIGN KEY (so_id) REFERENCES public.so_headers(id);
 F   ALTER TABLE ONLY public.so_items DROP CONSTRAINT so_items_so_id_fkey;
       public       postgres    false    206    2748    207            A   4   x�3�420��50�50�43�6Աб�14��2B�2�1�1�1������ ?>
�      ;   �   x�3�t*JM�NI�KN�t
r��tB\�C<��\\���<B<��8�����`�eL�R5���#.3R�s���ܔ˂��<��C �%gXbNi�BrFjrvf^:gqA"Д��"�P��gIjq	PN�$�8[�1�8%$gH�#b���� 
뇚      <   ?   x�3�420��50�52�2Mu�8M��@|3L)s.K�.���)H��T�����b���� f�I      >   R   x�3��N-���,H,���M��S(-N-�2�LLI��,�/��//���̅I)�e��psz��d�s%�esz8B!W� �[�      ?   #   x�3�t�O�44 =.#Nǜ��T�@� ��3      C      x������ � �      D      x������ � �      E   .   x�3�,��MU(I�(�6�1��2B1����똀�c���� �R!     