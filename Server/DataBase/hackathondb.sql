-- DROP DATABASE hackathondb;
-- CREATE DATABASE hackathondb;

CREATE TABLE AppUser (
    appuser_id      SERIAL PRIMARY KEY,
    name            varchar(50),
    username        varchar(50),
    password        varchar(50),
    email           varchar(50),
    phone           varchar(50),
    company_name    varchar(50),
    bio             varchar(50),
    user_type       varchar(50)
);

CREATE TABLE Jobs (
    jobs_id         SERIAL PRIMARY KEY,
    position_title  varchar(50),
    employment_type varchar(50),
    company_name    varchar(50),
);


CREATE TABLE Thread (
    thread_id       SERIAL PRIMARY KEY,
    thread_title    varchar(50),
    appuser_id      int REFERENCES AppUser(appuser_id)
);

CREATE TABLE PostedMessage(
    message_id      SERIAL PRIMARY KEY,
    appuser_id      int REFERENCES AppUser (appuser_id),
    thread_id       int REFERENCES Thread (thread_id),
    message_title   varchar(50),
    message_content varchar(500),
    message_time    varchar(50)
);

INSERT INTO AppUser(name, username, password, email, phone, bio, user_type)
VALUES 
('James Park', 'jpark' , 'password1', 'jp@rca.com', '949-490-3029', 'Full-Stack Developer South Orange County', 'Searching'),
('Tram Dinh', 'tdinh', 'password2', 'tram@rca.com', '714-394-3849', 'Experienced in full-stack development.', 'Employed'),
('Lucas Cardena', 'lcard', 'password3', 'lc@rca.com', '562-498-9528', 'Full-Stack Developer Inland Empire', 'Searching'),
('Pat Truong', 'ptruong', 'password4', 'pat@rca.com', '714-394-4838', 'ZenMaster', 'Instructor');


INSERT INTO Jobs (position_title, employment_type, company_id)
VALUES
('.Net Developer', 'Contract', 2),
('Full-Stack Developer', 'Full Time', 1),
('React-Native Developer', 'Full Time', 1);


INSERT INTO PostedMessage (appuser_id, message_title, message_content, message_time)
VALUES
(1, 'Untitled', 'Help Please', '10/18/18'),
(2, 'Full Time', 'Pending', '10/12/18'),
(3, 'Ready', 'Full Time', '10/19/19');

INSERT INTO Thread (thread_title, channel_id, appuser_id)
VALUES
('Jobs', 1, 2),
('Collaboration', 2, 3),
('Interviews', 3, 1);
-- CREATE TABLE Interview(

-- );