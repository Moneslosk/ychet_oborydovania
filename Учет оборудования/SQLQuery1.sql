CREATE TABLE Склад (
  ID_Склада INT IDENTITY (1,1), 
  Адрес_склад NVARCHAR(40) NOT NULL,
  Номер_телефона_склада NVARCHAR(12) NOT NULL,
  PRIMARY KEY (ID_Склада)
  ); 

CREATE TABLE Сотрудники (
  ID_Сотрудника INT IDENTITY (1,1), 
  Idd_Склада INT,
  Номер_паспорта NVARCHAR(9) NOT NULL,
  Фамилия NVARCHAR(40) NOT NULL,
  Имя NVARCHAR(20) NOT NULL,
  Отчество NVARCHAR(20) NOT NULL,
  Должность NVARCHAR(30) NOT NULL,
  Адрес_сотрудника NVARCHAR(40) NOT NULL,
  Номер_телефона_сотрудника NVARCHAR(12) NOT NULL,
  PRIMARY KEY (ID_Сотрудника),
  FOREIGN KEY (Idd_Склада) REFERENCES Склад (ID_Склада)   
  ); 

CREATE TABLE Поставщик (
  ID_Поставщика INT IDENTITY (1,1), 
  Наименование_поставщика NVARCHAR(40) NOT NULL,
  Адрес_поставщика NVARCHAR(40) NOT NULL,
  Номер_телефона_поставщика NVARCHAR(12) NOT NULL,
  PRIMARY KEY (ID_Поставщика)
  ); 

 CREATE TABLE Оборудование (
  ID_Оборудования INT IDENTITY (1,1), 
  Id_Склада INT,
  Количество INT NOT NULL,
  Изготовитель NVARCHAR(30) NOT NULL,
  Название_оборудования NVARCHAR(30) NOT NULL,
  PRIMARY KEY (ID_Оборудования),
  FOREIGN KEY (Id_Склада) REFERENCES Склад (ID_Склада)  
  
  ); 
 --ALTER TABLE dbo.Оборудование ADD id_Категории INT
 --ALTER TABLE dbo.Оборудование DROP COLUMN id_Категории;
 
 ALTER TABLE dbo.Оборудование ADD id_Категории int foreign key references Категории (ID_Категории)
  ALTER TABLE dbo.Оборудование ADD Процессор NVARCHAR(30)
  ALTER TABLE dbo.Оборудование ADD Оперативная_память NVARCHAR(30)
  ALTER TABLE dbo.Оборудование ADD Аккумулятор NVARCHAR(30)
  ALTER TABLE dbo.Оборудование ADD Разрешение_экрана NVARCHAR(30)

CREATE TABLE Категории (
  ID_Категории INT IDENTITY (1,1), 
  Id_Оборудования INT,
  Наименование_категории NVARCHAR(40) NOT NULL,
  PRIMARY KEY (ID_Категории),
  FOREIGN KEY (Id_Оборудования) REFERENCES Оборудование (ID_Оборудования)   --!!!!!!!!!!!!!!!!!!!!!!!!!!!
  ); 


CREATE TABLE Поставка (
  ID_Промежуточная_таблица INT IDENTITY (1,1), 
  Idd_Оборудования INT,
  Id_Поставщика INT,
  PRIMARY KEY (ID_Промежуточная_таблица),                                
  FOREIGN KEY (Idd_Оборудования) REFERENCES Оборудование (ID_Оборудования),   
  FOREIGN KEY (Id_Поставщика) REFERENCES Поставщик (ID_Поставщика) 
  ); 

  INSERT INTO dbo.Склад
  (
      Адрес_склад,
      Номер_телефона_склада
  )
  VALUES
  (   N'г.Минск', -- Адрес_склад - nvarchar(40)
      N'375447446345'  -- Номер_телефона_склада - nvarchar(12)
      )

	INSERT INTO dbo.Сотрудники
	(
	    Idd_Склада,
	    Номер_паспорта,
	    Фамилия,
	    Имя,
	    Отчество,
	    Должность,
	    Адрес_сотрудника,
	    Номер_телефона_сотрудника
	)
	VALUES
	(   1,   -- Idd_Склада - int
	    N'МР3545635', -- Номер_паспорта - nvarchar(9)
	    N'Маслов', -- Фамилия - nvarchar(40)
	    N'Александр', -- Имя - nvarchar(20)
	    N'Юрьевич', -- Отчество - nvarchar(20)
	    N'Директор', -- Должность - nvarchar(30)
	    N'г.Минск улица Алибегова 21', -- Адрес_сотрудника - nvarchar(40)
	    N'375447446345'  -- Номер_телефона_сотрудника - nvarchar(12)
	    )

		INSERT INTO dbo.Поставщик
		(
		    Наименование_поставщика,
		    Адрес_поставщика,
		    Номер_телефона_поставщика
		)
		VALUES
		(   N'ИТМБЕЛ', -- Наименование_поставщика - nvarchar(40)
		    N'г.Минск', -- Адрес_поставщика - nvarchar(40)
		    N'375447446345'  -- Номер_телефона_поставщика - nvarchar(12)
		    )

			INSERT INTO dbo.Оборудование
			(
			    Id_Склада,
			    Количество,
			    Изготовитель,
			    Название_оборудования
			)
			VALUES
			(   1,   -- Id_Склада - int
			    20,   -- Количество - int
			    N'Samsung', -- Изготовитель - nvarchar(30)
			    N'Galaxy S4'  -- Название_оборудования - nvarchar(30)
			    )
			INSERT INTO dbo.Категории
			(
			    Id_Оборудования,
			    Наименование_категории
			)
			VALUES
			(   1,  -- Id_Оборудования - int
			    N'Смартфон' -- Наименование_категории - nvarchar(40)
			    )
				INSERT INTO dbo.Поставка
				(
				    Idd_Оборудования,
				    Id_Поставщика
				)
				VALUES
				(   1, -- Idd_Оборудования - int
				    1  -- Id_Поставщика - int
				    )