                                              Web API:
===================================================================================================================
-------------------------------------------------------------------------------------------------------------------
=> API stands for application programming interface.
=> API is a framework in .NET that is used to process an aplication from various types of devices.
=> We can call code of API from mobile app,browser,notebook or any other computer device.
Hence API's are plateform independent.
=> API uses "HTTP" protocol.that is available with all web requests.
=> API is a updated version of a web services. Web services uses "SOAP" -simple object access protocol.SOAP is an additional protocol  hence we need to attach it separately to work with web services.
=> We can call a web service from any plateform of technology and programming language.API's has cross language support.
=> Some time we have to use Attributes before the methods of web API-
A) HttpGet: To get/retrive the records.
B) HttpPost: To add/create a new record.
C) HttpPut: To update a record.
D) HttpDelete: To remove a record.
-------------------------------------------------------------------------------------------------------------------
To Display All Record:
.......................
URL: API/APIControllerName
Method: Get
-------------------------------------------------------------------------------------------------------------------
To Display Spacific:
.....................
URL: API/APIControllerName/SearchValue
Method: Get
-------------------------------------------------------------------------------------------------------------------
To Update Record:
.................
URL: API/APIControllerName/KeyValue
Method: PUT
------------------------------------------------------------------------------------------------------------------
To Delete Record:
.................
URL: API/APIControllerName/KeyValue
Method: Delete
------------------------------------------------------------------------------------------------------------------
To Add Record:
..............
URL: API/APIControllerName
Method: POST