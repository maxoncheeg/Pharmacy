USE pharmacy2;

drop table [Содержимое покупки];
drop table [Покупка];
drop table [Карта лояльности];
drop table [Клиент];
drop table [Фармацевт];
drop table [Администратор];
drop table [Препарат];

CREATE TABLE [Администратор]
(
	[id администратора] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id администратора] BETWEEN 1 AND 99999) PRIMARY KEY,
	[Фамилия] NVARCHAR(20) NOT NULL,
	[Имя] NVARCHAR(20) NOT NULL,
	[Логин] NVARCHAR(20) NOT NULL UNIQUE,
	[Пароль] NVARCHAR(20) NOT NULL
);

CREATE TABLE [Фармацевт]
(
	[id фармацевта] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id фармацевта] BETWEEN 1 AND 99999) PRIMARY KEY,
	[Фамилия] NVARCHAR(20) NOT NULL,
	[Имя] NVARCHAR(20) NOT NULL,
	[Логин] NVARCHAR(20) NOT NULL UNIQUE,
	[пароль] NVARCHAR(20) NOT NULL
);

CREATE TABLE [Препарат]
(
	[id препарата] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id препарата] BETWEEN 1 AND 99999) PRIMARY KEY,
	[название препарата] NVARCHAR(20) NOT NULL,
	[количество на складе] BIGINT NOT NULL CHECK([количество на складе] BETWEEN 0 AND 999),
	[стоимость] DECIMAL(8, 2) NOT NULL CHECK([стоимость] < 1000000)
);

CREATE TABLE [Клиент]
(
	[id клиента] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id клиента] BETWEEN 1 AND 99999) PRIMARY KEY,
	[Фамилия] NVARCHAR(20) NOT NULL,
	[Имя] NVARCHAR(20) NOT NULL,
	[Дата рождения] DATE NOT NULL CHECK(YEAR(GETDATE()) - YEAR([Дата рождения]) > 14 AND YEAR(GETDATE()) - YEAR([Дата рождения]) < 99)
);

CREATE TABLE [Карта лояльности]
(
	[id карты лояльности] BIGINT NOT NULL IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES [Клиент]([id клиента]),
	[дата регистрации в программе] DATE NOT NULL DEFAULT(GETDATE())
);

CREATE TABLE [Покупка]
(
	[id покупки] BIGINT NOT NULL IDENTITY(1, 1) CHECK([id покупки] BETWEEN 1 AND 99999) PRIMARY KEY,
	[id клиента] BIGINT NOT NULL CHECK([id клиента] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [Клиент]([id клиента]),
	[дата покупки] DATE NOT NULL DEFAULT(GETDATE()),
	[сумма покупки] DECIMAL(8, 2) NOT NULL CHECK([сумма покупки] < 1000000),
	[время покупки] time(7) NOT NULL DEFAULT(CONVERT(VARCHAR(8), GETDATE(), 108)),
	[id фармацевта] BIGINT NOT NULL CHECK([id фармацевта] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [Фармацевт]([id фармацевта])
);

CREATE TABLE [Содержимое покупки]
(
	[id содержимого] BIGINT NOT NULL CHECK([id содержимого] BETWEEN 1 AND 99999) IDENTITY(1, 1) PRIMARY KEY,
	[id препарата] BIGINT NOT NULL CHECK([id препарата] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [Препарат]([id препарата]),
	[id покупки] BIGINT NOT NULL CHECK([id покупки] BETWEEN 1 AND 99999) FOREIGN KEY REFERENCES [Покупка]([id покупки])
);