CREATE TABLE [dbo].[SchoolLocations]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [street] NCHAR(10) NULL, 
    [postcode] NCHAR(10) NULL, 
    [name] NCHAR(10) NULL, 
    [locality] NCHAR(10) NULL, 
    [source] NCHAR(10) NULL, 
    [type] NCHAR(10) NULL, 
    [operation] NCHAR(10) NULL, 
    [latitiude] NCHAR(10) NULL, 
    [longitude] NCHAR(10) NULL, 
    [URL] NCHAR(10) NULL
)
