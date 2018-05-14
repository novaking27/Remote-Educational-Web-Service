CREATE TABLE IF NOT EXISTS users		(userId INTEGER PRIMARY KEY AUTOINCREMENT,
										userName TEXT NOT NULL UNIQUE,
										userPass TEXT NOT NULL,
										firstName TEXT NOT NULL,
										lastName TEXT NOT NULL,
										email TEXT NOT NULL,
										dateOfBirth TEXT NOT NULL,
										phoneNumber INTEGER NOT NULL,
										streetName TEXT NOT NULL,
										houseNumber INTEGER NOT NULL,
										unitNumber INTEGER NOT NULL,
										suburb TEXT NOT NULL,
										state TEXT NOT NULL,
										postCode INTEGER NOT NULL);

CREATE TABLE IF NOT EXISTS roles		(roleId INTEGER PRIMARY KEY AUTOINCREMENT,
										roleName TEXT NOT NULL UNIQUE);

CREATE TABLE IF NOT EXISTS user_roles	(user_role_id INTEGER PRIMARY KEY AUTOINCREMENT,
									    user INTEGER NOT NULL,
									    role INTEGER NOT NULL,
									    FOREIGN KEY (user) REFERENCES users(userId),
									    FOREIGN KEY (role) REFERENCES roles(roleId));



CREATE TABLE IF NOT EXISTS study_blocks  (study_blocks_id INTEGER PRIMARY KEY AUTOINCREMENT,
										 week_block TEXT NOT NULL,
										 month_block TEXT NOT NULL,	
										 user INTEGER NOT NULL,
										 FOREIGN KEY (user) REFERENCES users(userId));


INSERT OR IGNORE INTO roles VALUES (1, 'Student');
INSERT OR IGNORE INTO roles VALUES (2, 'Teacher');
INSERT OR IGNORE INTO roles VALUES (3, 'Management');