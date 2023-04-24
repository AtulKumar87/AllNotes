                                   ASP.NET MVC
============================================================================================
=>ASP.NET MVC is a web application framework developed by Microsoft.

=>ASP.NET MVC is a developed framework for building web pages and websites.MVC stands for 
  Model View Controller.
  
=>MVC is open source software design pattern.

=>ASP.NET MVC framework is a lightweight, highly testable framework that is integrated
  with existing ASP.NET features.
  :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                          Creation of .NET MVC
----------------------------------------------------------------------------------
=>Inventor of .NET MVC is Scott Guthrie.
=>First official version 1.0 of ASP.NET MVC is released in 2009.and latest version is 
  6.0 that is released in year 2016.						  
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Feature of ASP.NET MVC:
------------------------------------------------------------------------------------------
=>Separation
=>Loosely Coupling
=>Parallel Development
=>Easy to perform unit testing
=>Test Driven Development(TDD) Support.
=>Clean URL's
=>Improved Performance
=>More Controlling on HTML
=>Introduction new concepts
   -Filters                -Scaffolding Template
   -Web API                -LINQ,etc......
=>Easy to Learn
=>Task Support for Asynchronous Controllers(Ajax Support)
=>Bundling and Minification   
===================================================================================
Read::
-------
->wcf(windows communication foundation)
->webservice
->web API
->LINQ(language intigrated query)
->windows&Form authenction
ASPX%Razor me diffrent
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
PrereQuisites for API.NET MVC
-------------------------------------------------------------------------------------
*HTML
*CSS
*JavaScript
*JQuery
*Microsoft C#
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
 
                     ----------
                     |View(GUI)|
                     ----------
					     ^
					    ||
						||
						@
					-----------
                    |Controller|
                    |Buisiness |
                    | Logic    |
					------------
					   ||
				  Model Data Base
					
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                                View
---------------------------------------------------------------------------	---------
=>In MVC ; V stands for"View"
=>View is responsible for designing of user interface.
=>View is responsible to accept request from user and display response to user.
=>View is upper layer of a MVC project.
=>In MVC project View are created inside a"View" folder.
=>View allows code of HTML and C# (for small operations).Hence its extension is".cshtml".
=>Views for processed by Action Method.
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                            Types Of View:
---------------------------------------------------------------------------------------
1)Normal View
2)Layout View
3)Partial View
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Controller:
---------------------------------------------------------------------------
=>In MVC; C stands for Controller.
=>Controller is responsible for Controlling the application by programming logic.
=>Controller acts as a mediator between view and model.
=>In MVC application all Controllers are a class that inherits (derive) a "Controller" class.
=>All Controller are named with Controller postfix .
=>During the use of Controller we have to use only the name of Controller without using Controller postfix.
=>Controller is most important part of a MVC application.
=>Controller consists of various function and variables to perform operation.
=>We can process multiple views by using a Controller. 

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Types of Method in a Controller:
--------------------------------------------------------------------------
=>We have 2 below types of methods in a Controller----

1)Action Method
2)Non-Action Method
//////////////////////////////////////////////////////////////////////////////////////////////
1) Action Method:: 
------------------
=>Action Method are special methods of a Controller that is used to process a view directly.
=>Action methods are directly callable from View.
=>Action methods are used to get data from view and send result back to view.
=>Return types of an Action methods is "ActionResult". We can also change it from parents of ActionResult
  class as per our need.
  Ex: JsonResult

=>We can pass parameters in action method as per our need.
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;
Types Of Action Method::  
-------------------------------------------------------------------------------
1) Get Action Method
2) Post Action 
............................
1)Get Action Method:
--------------------
=>This Action Method is used to process view page for the loading of first time.
=>To create a Get Action Method we have to use "HttpGet" attributes before function declaration.
............................
2)Post Action Method::
----------------------
=>This action method is used to process a view when user sends (posts) some data to server.
=>This action method loads page(view) after postback.
=>It is necessary to having same name of Get and Post action method for a single page.
=>To create a Post action method we have to use "HttpPost" attributes before function declaration.
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
IsPost::
--------
=>IsPost is a boolean property in MVC application that is used to identify postBack of a webPage.
=>When we loads a webPage for first time then page directly comes from server. In that case IsPost
  property will be false.
=>When we post data of a page back to server that time page goes back to server and reloads again. In that 
  case IsPost property will be true.  

Note::It is also necessary to overload get and post action method because that method are 
      declared inside same class

2)Non-Action Method:
---------------------
=> Non-Action Method is a normal UDF that is defined for some internal functionality of Controller Non-Action
   Method.
=> Non-Action Method are not directly accessble from view page.
=> Non-Action method are declared by using "NonAction" attributes.
=================================================================
Send data from view to Controller(Action Method):
------------------------------------------------------------------
=>In MVC application; it is a primary task to communicate from view to Controller.
=>We can send data from a view to Controller by using below 3 solution-

1) Name of form Controller as Action Method parameter
2) Object of FormCollection class as Action method parameter.
3) Object of model class as Action method parameter.
===================================================================
1)Name Of Form Controls as Action method parameter
-------------------------------------------------------------------
=>We can pass name of form controls (input,textarea,select,button,datalist) as parameter in action
  method to read value of form controls inside action method.
=>In this method it is necessary to have same name of parameters and name of form controls.
=>In this method we don't have to perform types conversion. Values will be automatacally converted into
  specified data type of parameter.
=>This method is best method to process small and medium web form.
=>This method is not much suitable to process long web forms because it needs very long list of parameter
  in action method.

-------------------------------------------------------------------
2)  Object of FormCollection class as Action method parameter.
---------------------------------------------------------------------
=>FormCollection is a built-in class in .NET MVC framework.
=>FormCollection class provides collection of all values of form all form controls of web form
=>In this method we do not have to pass a long list of parameters in action method.Hence it is good to 
  process long web forms.

=>we need to perform type conversion of values it this method.
=>It also pass index ways value of form control.
**IIS Express
*IISBreak Point
----------------











::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                                  ADO.NET
----------------------------------------------------------------------
=>ADO.NET is a concepts that is used to perform database operations in .NET framework.
=>ADO.NET is a collection of various classes and methods that are used to perform database operations.
=>In ADO.NET ; ADO stands for ActiveX Data Object.
=>ADO.NET is view concepts from ADO.
=>ADO.NET provides connected and disconnected both mode of database connectivity while ADO 
  provides only connected mode.
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                            Data Providers In ADO.NET:
----------------------------------------------------------------------
=>Data provides are set of rules that are used to handle database operations.
=>In ADO.NET we have 3 below data provides---

1) SQL Data Providers

2) OLEDB Data Providers(Object Linking and Embedding, Database)

3) Oracle Data Providers  
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                            SQL Data Providers
--------------------------------------------------------------------------
=>SQL Data Providers is used to connect with Microsoft SQL Server Database.
=>Classes of SQL Data Providers are mainly defined inside below 2 namespaces--

1) System.Data
2) System.Data.SqlClient
==============================================================================
Some Important Classes of SQL data provides:
==============================================================================							
1) SqlConnection
-------------------------------------------------------------------------------
=> SqlConnection class is used to establish connection with a MS SQL server database.
=>SqlConnection class is located under "System.Data.SqlClient" namespace.

Syntax to Create object of SqlConnection Class:
--------------------------------------------------------------------------------
SqlConnection ObjName=new SqlConnection("Connection String");

Ex: SqlConnection con=new SqlConnection("Data Source=Server Name;Initial Catalog=Database Name;
     Integrated Security=True;User Id=DB User Id;Password=DB User Password"); 
==================================================================================
Some Important Functions and Properties Of SqlConnection class:
----------------------------------------------------------------------------------
1) Open()
---------
=>This function is used to open (establish) database connection.

syntax: Obj_of_ConnectionClass.Open();
Ex: con.Open();

2)Close()
---------
=>This function is used to close (off) database connection.

Syntax:: Obj_of_ConnectionClass.Close();
Ex: con.Close();

3)State:
--------
=>State is a property of SqlConnection class.
=> This property is used to know the current status of database connection.

Syntax: ConnectionState Obj_of_ConnectionClass.State;
Ex: con.State

Note:: Return type of this property is ConnectionState Object.

----------------------------------------------------------------
2) SqlCommand:
----------------------------------------------------------------
=>This  class is used to set and execute (run) a command.
=>This class is located under "System.Data.SqlClient".

Syntax:
------ 
SqlCommand ObjName=new SqlCommand("Command Text",Obj_of_ConnectionClass);

Ex: SqlCommand cmd=new SqlCommand("Delete From Employee where empId=101",con);
-------------------------------------------------------------------------
Some Important Functions and Properties of SqlCommand Class:
-------------------------------------------------------------------------
1) CommandText:
----------------
=> This Properties is used to set(assign) a Sql Command in object of SqlCommand class.

Syntax:
--------
       Obj_of_CommandClass.CommandText="Sql Command";
	   Ex: cmd.CommandText="Insert into City values(1,'ChitraKoot')";
	   --------------------------------------------------------------------
2) Connection:
----------------
=>this Properties is used to set/get database connection to SqlCommand class Object.

Syntax: Obj_of_CommandClass.Connection=Obj_of_ConnectionClass;
Ex:: cmd.Connection=con;
==========================================================================
3) ExecuteNonQuery():
--------------------------------------------------------------------------
=> This function is used to execute any insert update or delete command in sql server database.(not for select)

=> Return type on this function is int. This Functions Returns number of rows affected in database by command.

Syntax :
========
 int ExecuteNonQuery();
 Ex: int n=cmd.ExecuteNonQuery();
 ========================================================================
 4) ExecuteScaler()
 -------------------------------------------------------------------------
 => This function is used to get single value from database .
 =>WE can execute a select command and get a value of single cell by using this function.
 =>Return type of this function is object.
 
 Syntax:: object ExecuteScaler();
 Ex: Object x=cmd.ExecuteScaler();
 ========================================================================
 5) ExecuteReader():
 ------------------------------------------------------------------------
=> This function is used to read bulk records from database.
=> We can run a select command and read data as per our need by using this function.
=> Above all 3 function uses connected mode of database connectivity.

syntax: 
----------
  SqlDataReader ExecuteReader()
  
Note: Return type of this function is instance of SqlDataReader.
 
 Ex: SqlDataReader dr=cmd.ExecuteReader();
 
 Notes:: After calling of ExecuteReader() function we hacve to use "Read()" function of SqlDataReader to 
         display records.
		 
		 
		 
		 
		 
		 
		 
		 
=============================================================================
3) Object of Model class as Action method parameter
==============================================================================
=> class that is responsible for database operations is know as model class
=> We can create model class with properties (getter/setter) and function.
=> It is necessary to have same name of form controls and name of properties of model class. So that it can 
   directly accepts data from view.
=> In this method;There is no need to pass ;long list of parameters in Action method.   
=> In this method we do not have to perform type conversion.
=> Model classes are created under Models folders.To use model class we have to include models namespace in page.
  
Syntax: 
--------
using ProjectName.Models;
========================================================================
HttpPostedFileBase
=======================================================================
=> HttpPostedFileBase is a class in .NET MVC that is used to handle file uploading.
=> when we uploads a file from client to server then server receives that uploaded file in form of object 
   of HttpPostedFileBase.
=> HttpPostedFileBase class provides necessary function and properties to perform operations of uploading.

Some important function & properties HttpPostedFileBase class ::
===============================================================
1) saveAs():
-----------
=> This function is used to save uploaded file in specified location on server.
=> This function takes one argument that argument is a relative path of server location with file name.
=> We have to specified clear mapping(location) of path by using server.MapPath() function.

syntax:
--------
ObjHttpPostedFileBase.SaveAs("FilenameWithLocation");

..................................................
2) FileName:
------------
=> This properties is used to know the real name of uploaded file.
=> This properties returns filename in string format.
.................................................................
3) contentLength:
-----------------
=> this properties is used to get size of uploaded file in bytes.
=> This properties returns size in bytes in int form.
=> we can converted bytes in KB,MB etc as per our need.
=> By default IIS server allows max size of 4mb for uploading file.We can modifies maxRequestLength as per our need.
=> To modify maxRequestLe\ngth we have to add below code snippet inside web.config file.
=> maxRequestLength is specified in Kilo bytes(KB).

<configuration>

<system.web>
  <HttpRuntime maxRequestLength="SizeInKB" />
</system.web>

<configuration>

=> For new versions of IIs server.Like as IIS 7 or above we have to specified "RequestFiltering" also.

<system.webServer>
  <security>
     <RequestFiltering>
          <requestLimits maxAllowedContentLength="SizeInBytes" />
     </RequestFiltering>
  </security>
</system.webServer>

Notes: maxAllowedContentLength is specified in bytes.

6Mb => 6144 KB
6MB => 6291456(Bytes)
===========================================================================================================
                                                 DataTable
-----------------------------------------------------------------------------------------------------------
=> DataTable is a class that is available inside "System.Data" namespace.
=> DataTable is a Virtual table that is used to store data virtually.
=> DataTable is used to store temporarry copy of some Data.
=> DataTable stores data in tabular form so it is very easy to fetch data from DataTable.
=> DataTable has row and columns.We can count the number of Rows by using "Rows.Count" property.
=> DataTable works in disconnected mode.
>>>>>>>
Syntax: DataTable ObjectName=new DataTable();
>>>>
Ex: DataTable dt=new DataTable();

===========================================================================================================                                             :DataSet:
===========================================================================================================
=> Dataset is also a virtual storage to save data virtually.
=> DataSet is collection of various DataTable.
=> DataSet is a class that is used to store data of morethan one table(query) separately.
=> We can fetch a virtual Table from dataset by passing index.
   Ex: ds.Tables[0]
Syntax: DataSet ObjectName=new DataSet();
============================================================================================================
                                          :SqlDataAdapter:
============================================================================================================	
=> SqlDataAdapter is a class that works as a mediator between database and virtual storage.
=> SqlDataAdapter works like a virtual bridge.
=> SqlDataAdapter copies the required data from database and fill(paste) that data inside virtual storage
   like DataTable,DataSet,Array,Array of Object.
=> SqlDataAdapter works in disconnected mode.In disconnected mode we dont have to open or close DB connection
   becouse it performs by framework automatacally.
=> SqlDataAdapter class is located inside "System.Data.SqlClient"namespace.
=> However SqlDataAdapter class can execute any type of command but generally we use this to execute select command.

Syntax: SqlDataAdapter ObjName=new SqlDataAdapter("CommandText",Obj_of_ConnectionClass);

Ex: SqlDataAdapter da =new SqlDataAdapter("select*from student".con);
..............................................................................................................
Fill():
--------------------------------------------------------------------------------------------------------------
=> Fill is a function of SqlDataAdapter class that is used to copy data from database and paste that copied
   dataInside virtual storage.
   
Syntax::
Obj_of_SqlDataAdapter.Fill(Obj_of_Virtual_Storage);

Ex:: da.Fill(dt);
===========================\====================================================================================                               Passing Data From Collection To View.
===============================================================================================================
1) ViewData
2) ViewBag
3) TempData
4) Session
----------------------------------------------------------------------------------------------------------------

      ^
      |   |------|              |------|
	n |   |      |              |  V   |
	o |	  |  C   |              |      |
	i |	  |------|              |------|
    s |      |	                    |
    s |      |TempData       VewData|ViewBag
    e |      |                      |
    S |   |------|  ViewData    |------| ViewData    |------|
	  |   | C    | -----------> |  V   |-----------> |  C   |
	  |   |------|  ViewBag     |------| ViewBag     |------|
	  |
	  ------------------------------------------------------->
                            Session
							
 Note: Here V and V are the same View.
----------------------------------------------------------------------------------------------------------------
1) ViewData:
-----------------------------------------------------------------------------------------------------------------
=> ViewData is used to Transfer some data from controller to view.
=> ViewData is a dictnoay data it store data in key/value pair.
=> Viewdata Can store any type of data but during the data accessing from viewdata we need to perform
   type conversion according to a need.
=> We also a need check for null in viewdata.

Syntax:: ViewData["KEyName"]=Value;
Ex: ViewData["Sum"]=Result;
----------------------------------------------------------------------------------------------------------------
                                  Example to read value to Viewdata.
----------------------------------------------------------------------------------------------------------------
 If(ViewData["Sum"]!=null)
 {
	 int num=int.Parse(ViewData["Sum"]);
 }
----------------------------------------------------------------------------------------------------------------
1) ViewBag:
----------------------------------------------------------------------------------------------------------------- 
=> ViewBag is also use to transfer data from controller to view.
=> ViewBag is use as timiling Expression so we can new any name to ViewBag.
=> In ViewBag we dont have to perform type conversion.
=> In ViewBag we can also ignor it to check formal.
=> It is easy to work with ViewBag because it is simple from ViewData.

Syntax: ViewBag.DynamicExpression=Value;

Ex: ViewBag.Msg=25;
 ----------------------------------------------------------------------------------------------------------------
                                  Example to read Data from ViewdBag.
----------------------------------------------------------------------------------------------------------------
 int Name=ViewBag.Msg;
----------------------------------------------------------------------------------------------------------------
3) TempData:
----------------------------------------------------------------------------------------------------------------- 
=> TempData is used to transfer data in below criteria-

1) From Controller(ActionMethod) To View.
2) From Controller to same Controller(From One ActionMethod to another ActionMethod).
3) From One Controller to another Controller.
=> scope of TempData is Limited to the next request only in redirection.When we create a TempData and Redirect
   to next ActionMethod then that TempData will Be available inside this new ActionMethod and View but for next
   redirection it will be not available.
   
Ex:  Home ------>AboutUs------> Login
      TD  ------>/---- -------> * 
 
=> TempData internally uses session.It is temporarry form of session.
=> TempData Uses key/value pair to save data.
=> We have to perform type conversion and also need to check for null in TempData.
 
 Syntax: TempData["KEyName"]=Value;
 ..................................
 Ex: TempData["Msg"]="Record Deleted SuccessFully";
----------------------------------------------------------------------------------------------------------------
3) Session:
----------------------------------------------------------------------------------------------------------------
=> Session is a globel variables that is accessble in whole project.
=> Generally session is used to store user spacific data(Ex: UserId,UserType,for any Other Key).Show That we can 
   handle user spacific request in project.
=> Session uses key/value pair to store data.
=> We can store any type of value in session but access value of session we need to perform type conversion
   because return type of session is object.
=> Session has a life time by default its life is 20min in .NET framework  if user perform some action in websites
   project then if automatacally increses his life again for 20min.If user does not perform any action in Project
   for last 20min then session will be automatacally expired. 
=> Session is the havywaight in variables so we dont have to create more session variables in over Project.
    Becouse it directly creates effaict in speed of Project.

Syntax: Session["KEyName"]=Value;

Ex: Session["Rno"]=RollNo;

-----------------------------------------------------------------------------------------------------------------
                                      Ex to read Data from Session.
-----------------------------------------------------------------------------------------------------------------

  if(Session["Rno"]!=null)
  {
	  int r=int.Parse(Session["Rno"]);
  }
