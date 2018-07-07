BEGIN TRANSACTION

DELETE FROM project_employee;
DELETE FROM project;
DELETE FROM employee;
DELETE FROM department;

-- Adding sample data to each table
SET IDENTITY_INSERT project ON;
INSERT INTO project(project_id, name, from_date, to_date) VALUES (1, 'Test Project', '06/25/18','06/26/18');
SET IDENTITY_INSERT project OFF;



SET IDENTITY_INSERT department ON;
INSERT INTO department(department_id,name) VALUES (1, 'Test Department');
SET IDENTITY_INSERT department OFF;

SET IDENTITY_INSERT employee ON;
INSERT INTO employee(employee_id,department_id,first_name,last_name,job_title,birth_date,gender,hire_date) VALUES (1,1,'Test','Employee','slacker','1921-01-01','m','1921-04-01');
SET IDENTITY_INSERT employee OFF;

INSERT INTO project_employee(project_id,employee_id) VALUES (1,1);

SELECT * FROM project_employee;

ROLLBACK TRANSACTION