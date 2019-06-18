FileManager exercise.

Briefing:
A DAO factory is in charge of the instantiation of the different DAO's to be used in the persistence process.
The files with the extension .txt will be persisted through the StudentDAOTxt, the .xml through StudentDAOXml and the .json thorugh StudentDAOJson.
Every DAO implementation makes use of a IWriter and a IReader objects which will be in charge of the writting and reading details for each different extension, bear
in mind that every file is persisted using a different api.

The persisted files are inside the Debug folder in the WinSite folder.

A UML diagram is provided as a FileManager.dia file.