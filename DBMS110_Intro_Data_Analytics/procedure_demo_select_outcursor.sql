CREATE OR REPLACE PROCEDURE FETCH_PERSON_BY_REGION_PRC
( 
    c_result OUT SYS_REFCURSOR
)
AS
BEGIN
    /* 
    Very basic select. We normally wouldn't use a stored
    procedure for this, but we will to keep the demo simple.
    */
    OPEN c_result FOR
    SELECT
        PERSON.FULL_NAME
    FROM 
        PERSON
        JOIN PERSON_REGION ON PERSON.ID = PERSON_REGION.PERSON_ID
    FETCH FIRST 10 ROWS ONLY;
END;
/

SET SERVEROUTPUT ON;
DECLARE
    c_names SYS_REFCURSOR;
    l_fullname PERSON.FULL_NAME%TYPE;
BEGIN
    FETCH_PERSON_BY_REGION_PRC( c_names );
            
    LOOP 
        FETCH c_names
        INTO  l_fullname;
        EXIT WHEN c_names%NOTFOUND;

        DBMS_OUTPUT.PUT_LINE( l_fullname );
    END LOOP;
    CLOSE c_names;
END;
