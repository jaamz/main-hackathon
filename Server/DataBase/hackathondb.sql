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
    company_name    varchar(50)
);

CREATE TABLE Interview (
    interview_id    SERIAL PRIMARY KEY,
    interview_title varchar(100),
    interview_body  varchar(1000),
    appuser_id      int REFERENCES AppUser(appuser_id)
);

CREATE TABLE Collaboration (
    collaboration_id    SERIAL PRIMARY KEY,
    collaboration_title varchar(100),
    collaboration_body  varchar(1000),
    appuser_id          int REFERENCES AppUser(appuser_id)
);


-- CREATE TABLE Thread (
--     thread_id       SERIAL PRIMARY KEY,
--     thread_title    varchar(50),
--     appuser_id      int REFERENCES AppUser(appuser_id)
-- );

-- CREATE TABLE PostedMessage(
--     message_id      SERIAL PRIMARY KEY,
--     appuser_id      int REFERENCES AppUser (appuser_id),
--     thread_id       int REFERENCES Thread (thread_id),
--     message_title   varchar(50),
--     message_content varchar(500),
--     message_time    varchar(50)
-- );

INSERT INTO AppUser(name, username, password, email, phone, bio, user_type)
VALUES 
('James Park', 'jpark' , 'password1', 'jp@rca.com', '949-490-3029', 'Full-Stack Developer South Orange County', 'Searching'),
('Tram Dinh', 'tdinh', 'password2', 'tram@rca.com', '714-394-3849', 'Experienced in full-stack development.', 'Employed'),
('Lucas Cardena', 'lcard', 'password3', 'lc@rca.com', '562-498-9528', 'Full-Stack Developer Inland Empire', 'Searching'),
('Pat Truong', 'ptruong', 'password4', 'pat@rca.com', '714-394-4838', 'ZenMaster', 'Instructor');


INSERT INTO Jobs (position_title, employment_type, company_name)
VALUES
('.Net Developer', 'Contract', 'Yelp'),
('Full-Stack Developer', 'Full Time', 'Google'),
('React-Native Developer', 'Full Time', 'Amazon');


-- INSERT INTO PostedMessage (appuser_id, message_title, message_content, message_time)
-- VALUES
-- (1, 'Untitled', 'Help Please', '10/18/18'),
-- (2, 'Full Time', 'Pending', '10/12/18'),
-- (3, 'Ready', 'Full Time', '10/19/19');

-- INSERT INTO Thread (thread_title, appuser_id)
-- VALUES
-- ('Jobs', 2),
-- ('Collaboration', 3),
-- ('Interviews', 1);

INSERT INTO Interview (interview_title, interview_body, appuser_id)
VALUES 
('Looking for mock interview prep!', 'I am interviewing with Steve Jobs tomorrow. Need some interview prep', 1),
('Need some question help!', 'I do not know what Big O Notation is. Anyone help?', 2),
('Anyone have any idea about how Technossus interviews?', 'I have the interview at 10AM tomorrow!', 3);

INSERT INTO Collaboration (collaboration_title, collaboration_body, appuser_id)
VALUES
('Open source project recruiting!', 'Building chat app for gamers. Message Pat Truong', 1),
('Need mobile developers', 'Phillip is a terrible Tsum Tsum developer. Need someone else', 2);

-- CREATE TABLE Interview(

-- );