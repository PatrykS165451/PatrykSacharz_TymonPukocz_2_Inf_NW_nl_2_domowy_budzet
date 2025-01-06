
CREATE TABLE categories(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	type VARCHAR(MAX) NULL,
	date_insert DATE NULL
	)

SELECT * FROM categories

CREATE TABLE income (
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	income FLOAT NULL,
	description TEXT NULL,
	date_income DATE NULL,
	date_insert DATE NULL
	)

	SELECT * FROM income

	  SELECT * 
     FROM INFORMATION_SCHEMA.TABLES 
     WHERE TABLE_NAME = 'categories';

	 SELECT category FROM dbo.categories WHERE type = @type