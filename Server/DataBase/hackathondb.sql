-- DROP DATABASE hackathondb;
-- CREATE DATABASE hackathondb;


CREATE TABLE Company (
    company_id      SERIAL PRIMARY KEY,
    company_name    varchar(50),
    company_phone   varchar(50),
    company_address varchar(50),
    company_notes   varchar(1000)
);

CREATE TABLE AppUser (
    user_id         SERIAL PRIMARY KEY,
    name            varchar(50),
    email           varchar(50),
    phone           varchar(50),
    company_id      int REFERENCES Company (company_id),
    bio             varchar(50),
    user_type       varchar(50)
);

CREATE TABLE Jobs (
    jobs_id          SERIAL PRIMARY KEY,
    position_title  varchar(50),
    employment_type varchar(50),
    company_id      int REFERENCES Company (company_id)
);

INSERT INTO AppUser(name, email, phone, bio, user_type)
VALUES 
('James Park', 'jp@rca.com', '949-490-3029', 'Full-Stack Developer South Orange County', 'Searching'),
('Tram Dinh', 'tram@rca.com', '714-394-3849', 'Experienced in full-stack development.', 'Employed'),
('Lucas Cardena', 'lc@rca.com', '562-498-9528', 'Full-Stack Developer Inland Empire', 'Searching'),
('Pat Truong', 'pat@rca.com', '714-394-4838', 'ZenMaster', 'Instructor');


INSERT INTO Company (company_name, company_phone, company_address, company_notes)
VALUES
('Ruber', '714-958-5049', 'Costa Mesa, Ca', 'Very Responive'),
('Dash', '949-938-5049', 'Newport, Ca', 'Tough Interview');

INSERT INTO Jobs (position_title, employment_type, company_id)
VALUES
('.Net Developer', 'Contract', 2),
('Full-Stack Developer', 'Full Time', 1),
('React-Native Developer', 'Full Time', 1);
-- CREATE TABLE Interview(

-- );