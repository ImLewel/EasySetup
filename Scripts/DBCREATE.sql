SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Utils] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Utils] PRIMARY KEY ([Id])
);
CREATE TABLE [Recording] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Recording] PRIMARY KEY ([Id])
);
CREATE TABLE [Misc] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Misc] PRIMARY KEY ([Id])
);
CREATE TABLE [Messengers] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Messengers] PRIMARY KEY ([Id])
);
CREATE TABLE [GameLaunchers] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_GameLaunchers] PRIMARY KEY ([Id])
);
CREATE TABLE [Gamedev] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Gamedev] PRIMARY KEY ([Id])
);
CREATE TABLE [Drivers] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Drivers] PRIMARY KEY ([Id])
);
CREATE TABLE [Coding] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Coding] PRIMARY KEY ([Id])
);
CREATE TABLE [Browsers] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Browsers] PRIMARY KEY ([Id])
);
CREATE TABLE [Benchmarks] (
  [Id] bigint NOT NULL
, [Name] text NOT NULL
, [Link] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Benchmarks] PRIMARY KEY ([Id])
);
COMMIT;

