                                    Introduction to .NET:
-----------------------------------------------------------------------------------------------------------------
=> Microsoft .NET is a plateform that is used to devlope the computer software and applications.
=> Developed by Microsoft corporation in 2002.
=> Latest version is".NET Framework 4.8", released in 18 april 2019.
=> Used to devlope console,windows,web mobile,web Services based applications.
=> .NET support multiple language like as Visual C++,VB.NET,Visual C#,Visual J++,Python,Pascal,Perl and many more...
------------------------------------------------------------------------------------------------------------------
ADO.NET:
------------------------------------------------------------------------------------------------------------------
=> ADO stands for "ActiveX Data Object".
=> ADO.NET is a concept that is used to perform database operations in .NET programs/software.
=> ADO.NET is a collection of various classes and function that are used to perform database operations in .NET framework.
=> ADO.NET is a new concept while ADO is old concept.
=> ADO.NET provides both modes of database connectvity-connected and disconnected mode while ADO was supporting only connected mode.
=> ADO.NET has 3 types of data providers-

1) Sql data Providers
=> used to work with MS SQL database.

2) OLEDB data Providers
=> Used to work with MS Excel database,MS Access database,File DateTime,MYSQL,etc.

3) Oracle Data Providers
=> Used to connect with oracle database.

Working With SQL Data Providers:
--------------------------------
=> To do connectvity by using SQL data providers we have to use below general namespace-
    A) System.Data;
	B) System.Data.SqlClient;
	
Some importatnt classes of SQL data providers/ADO.NET:
------------------------------------------------------
1) SqlConnection
----------------
=> SqlConnection class is used to establish connection between our program and SQL dataBase server.
=> This class is located under"System.Data.SqlClient" namespace.
=> We have to set connection string of dataBase by using this class.This class is also used to check and change (open/close)	 database connection.
=> Connection string is a special string that contains information about database.


Syntax:
-------
SqlConnection ObjName=new SqlConnection("Connection String");

Ex: SqlConnection con=new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DemoDB;Integrated Security=true;");

Some importatnt function and properties of SQLConnection class:
---------------------------------------------------------------
A) ConnectionString:
--------------------
=> This Property is used to assign a connection string to SqlConnection class.

Syntax:
------
ObjOfConnectionClass.ConnectionString="connection string";

Ex:
con.ConnectionString="Data Source=.\\SQLEXPRESS;Initial Catalog=DemoDB;Integrated Security=true;";
..................................................................................................................
B) State:
------------------------------------------------------------------------------------------------------------------
=> This property is used to know the current state of database connection.

Syntax:
-------
ObjOfConnectionClass.State

Ex: con.State
..................................................................................................................
c) Open():
------------------------------------------------------------------------------------------------------------------
=> This function is used to open database connection.

Syntax:
-------
ObjOfConnectionClass.Open();
Ex: con.Open();
..................................................................................................................
d) Close():
------------------------------------------------------------------------------------------------------------------
=> This function is used to close database connection.

Syntax:
-------
ObjOfConnectionClass.Close();

Ex: con.Close();
==================================================================================================================
2) SqlCommand:
------------------------------------------------------------------------------------------------------------------
=> SqlCommand class is used to set/assign a dataBase command and SqlConnection so that a specified command can be 
   executed in a specific database.
=> This command also provides function to executed/run database command.
=> this class is located under "System.Data.SqlClient" namespace.
=> SqlCommand default cunstructer non default constructer.
Syntax:
-------
SqlCommand ObjName=new SqlCommand(CommandText,ObjOfConnectionClass);
Ex: Sqlcommand cmd=new SqlCommand("Delete from TblStudent where rno=5",con);

Some Important Function and Properties of SqlCommand Class:
------------------------------------------------------------
A) Connection:
--------------------
=> This properties is used to set the object of SqlConnection class in SqlCommand class.

Syntax:
-------
Obj_of_cmd_Class.Connection=Obj_of_Connection_Class.
Ex:
cmd.Connection=con;

.................................................................
B) CommandText:
---------------
=> This properties is used to set command text of sqlcommand class.

Syntax: Obj_of_cmd_Class.CommandText="Sqlcommand";
Ex: cmd.CommandText="delete from Student where rno=5";

Complete Example:
------------------
Sqlcommand cmd=new Sqlcommand();
cmd.CommandText="delete from Student where rno=5";
cmd.Connection=con;
......................................................................
Note: SqlCommand has 3 below function to executed a specified Command-

i) ExecuteNonQuery():
------------------
=> This function is used to execute and insert ,update and delete command in database.
=> Return types of this function is int.It returns number of affected rows by our command.

Syntax: int Obj_of_cmd_Class.ExecuteNonQuery();
Ex: int x=cmd.ExecuteNonQuery();
............................
ii) ExecuteScaler():
---------------------
=> ExecuteScaler() function is used to get a single value from database.
=> ExecuteScaler() function is used to get a single value of single cell.
=> Return type of this function is "Object".So we can get any type of value by using this function.

Syntax: Object Obj_of_cmd_Class.ExecuteScaler();
Ex: Object ob=cmd.ExecuteScaler();
..........................................
iii) ExecuteReader():
---------------------
=> this function is used to execute a select command.
=> We can read bulk records by using this function.This function uses connected mode of Database.
=> Return type of this function is refrence "SqlDataReader" class.
=> We can call "Read()" function of SqlDataReader class to read one by one all records.

Syntax: SqlDataReader Obj=Obj_of_cmd_Class.ExecuteReader();
Ex: SqlDataReader dr=cmd.ExecuteReader();
while(dr.Read())
{
	//............view command
}
-----------------------------------------------------------------------------------------------------------------
SqlDataAdapter:
---------------
=> SqlDataAdapter is a class that is located under "System.Data.SqlClient;" namespace.
=> SqlDataAdapter class work as a bridge between Database and virtual storage.
=> SqlDataAdapter class is used to fill data in virtual storage from database.So it works like as an Adapter.
=> Syntax of SqlDataAdapter looks like syntax of sqlcommand class.

Syntax: 
-------
SqlDataAdapter Obj=new SqlDataAdapter("Command-Text",Obj_of_Connection_Class);

Ex: SqlDataAdapter da=new SqlDataAdapter("Select * from Student",con);

Note: It is not necessary to open/close dataBase connection for disconnected mode becouse DataAdapter opens/close 
      database connection automatacally.
.................................................................................................................
Fill:
-----------------------------------------------------------------------------------------------------------------
=> Fill is a function of sqldataadapter class that is used to fill/copy data from dataBase into virtual storage by using Adapter.
=> It fills data from Adapter to virtual storage.

Syntax: Obj_of_Adapter_Class.Fill(Obj_of_Virtual_Storage);
Ex: da.Fill(dt);
.................................................................................................................
Virtual Storage to store data of DataBase:
------------------------------------------
=> We have to virtual storage in ADO.NET dataset and datatable.
=> Datatable is a virtual table that have virtual rows and columns.
=> Dataset is a collection of various virtual DataTables that can store data in different-2 virtual DataTables.
=> DataTable and DataSet both are classes that are located under "System.Data;" namespace.
 
 Syntax: DataTable Obj=new DataTable();
         DataSet Obj=new DataSet();
		 
Ex:      DataTable dt=new DataTable();
         DataSet ds=new DataSet();
		 
=> DataTable has "Rows" and "Columns" Property that we can use to process data.
Ex: dt.Rows
    dt.Columns
	ds.Tables[indexPassing].Rows
	ds.Tables[IndexPassing].Columns

=> There is a Count property that is used to know the number of Rows/Columns in a virtual table.
Ex: dt.Rows.Count	

note: yadi datatable ka object banaya gya hai to uska foreach loop me DataRows hi element hoga.
=================================================================================================================
Session:
--------------------------
=> Session is a state management mechanism.
=> Session is a global variable that is used to store and share user specific data.
=> Session variable store in server.It takes memory in server.
=> Session enables various user to use a common portal /webpage same time.
=> Gennarally session is used during login process.
=> Session has a life time.Its default life is of 20min.Program can change it as per need.
=> We can store any type of value in session variable.But during reading value from session;We have to perform type conversion.
=> Session works in key/value pair.

Syntax to create a Session Variable:
------------------------------------
Session["KeyName"]=value;

Ex: Session["Res"]=45;

Note: Session value is accessible in whole project.
