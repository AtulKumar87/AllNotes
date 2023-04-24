                                               :History of C#:
------------------------------------------------------------------------------------------------------------------
=> Developed by MicroSoft in 2000.
=> Based on Java and C++,but has many additional extensions.
=> Java and C# are both being updated to keep up with each other.
=> Cross-developMent with Visual Basic,Visual c++,and many other .NET languages.
==================================================================================================================
                                                Why to Use C#:
------------------------------------------------------------------------------------------------------------------
=> Pure Object Oriented Language.
=> Power of C with ease of MicroSoft Visual Basic.
=> Easy To learn for Everybody.
=> Much cleaner than c++.
=> Provides More supported for web developMent.
=> More Powerful like Java.
=> Latest version in C# 10,that is released in 8th November 2021.
==================================================================================================================
                                     : A Component Oriented Language:
------------------------------------------------------------------------------------------------------------------
=> com stands for Component object model.
=> The first "component oriented" languages in the c/c++ family.

a) In OOP a component is:- A reusable program that can be combined with other components in the same system to form
   an application.
Example: a single button in a graphical user interface a small interest calculater.

b) Then can be deployed on diffrent servers and communicatate with each other.

=> Always use Main() unlike main() in C/C++.
=> Do not terminate class by semicolon.
=================================================================================================================
                                               :C# overview:
-----------------------------------------------------------------------------------------------------------------
=> Object oriented.
=> Everything belong to a class.
=> Complete C# program.

Example:
                   using system;   // namespace header file.
				   namespace ConsoleTest
				   {
					   class Class1   // class Name:
					   {
						   static void Main(string[]args)
						   {
							   //statement.
						   }
					   }
				   }
=================================================================================================================
                                           :C# program structure:
-----------------------------------------------------------------------------------------------------------------
=> Namespaces
---------------------------------------
a) Contain types and other namespaces.
......................................
=> Types Declarations
---------------------------------------
b) Class,structs,interfaces,enums,and delegates
.......................................
=> Members
----------------------------------------
c) Constants,fields,methods,properties,indexers,events,operators,constructor,destructor. 
.................................................................................................................
=================================================================================================================
                                                Console I/O
-----------------------------------------------------------------------------------------------------------------
A) Printing/ Reading String and Numbers.
-----------------------------------------------------------------------------------------------------------------
The Console Class:
..................
=> provides methods for input and output
=> Input
--------
1) Read(..)-reads a single character.
2) ReadLine(..)-Reads a single line of a character.

=> Output
---------
1) Write(..)-prints the specified argument on the console.
2) WriteLine(..)-prints specified data to the console and moves to the next line.
=================================================================================================================
                                          Working With Date and Time in C#:
------------------------------------------------------------------------------------------------------------------
=> In C# there is a "DateTime" class that is used to work with date and time.
=> DateTime class is located under "system" namespace.
=> We can create the object of dateTime class to perform operations in Date and Time-

Ex: DateTime dt=new DateTime();

=> dateTime class has a property with name "now".This property is used to get current Date and Time.
=> We can set the formate of DateTime by using below characters-

A) dd- For day number (date) of month.
B) MM- For month number.
C) MMM-For 3 character month name like as 'JAN'.
D) yy- For last 2 digits of year
E) yyyy-For four digits year.
F) hh- For hours in 12 hours format.
G) HH- For hours in 24 hours format.
H) mm- For minutes.
I) ss- For seconds.
J) tt- For AM/PM.

=> We can create object of costom date as per our need by using below Syntax-

DateTime objName=new DateTime(int year,int month,int day);

Ex: DateTime dt=new DateTime(1947,8,15);
=================================================================================================================
.Tostring("#.##");
use in any 1 point use tofixed ke liye.
=================================================================================================================
                                            Looping StateMent:
-----------------------------------------------------------------------------------------------------------------
=> repeating statement in multiple time.

A) For Loop      ------     
B) While Loop          |---Just like C/C++
C) Do While Loop ------
D) For Each Loop     //(New Loop In C#)
..............
For Each Loop:
--------------
=> For Each Loop is an item based Loop.
=> For Loop is used to work with collections like as array,Array_Of_Object,List_of_object,IEnumerable,etc.
=> For Each Loop fetch each item one item one by one from a collections.

Syntax- 
foreach(Type Element in collection)
{
  //statement.	
}
=> Iterates over all elements of a collection.
a) The Element is the loop variable that takes sequentially all collection values.
b) The collection can be list,array or other group of elements of the same type.
=> In for each type/DataType is typeof a single item from collection.

Example:
--------
string[] days=new string[]{"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
foreach(string day in days)
{
	Console.Write(day);
}
@) The above loop iterates of the array of days.
@) The variable day takes all its values.
=================================================================================================================
                                            :Process Class:
-----------------------------------------------------------------------------------------------------------------
=> process is a class in c# that is used to start a process in our computer.
=> Process class is located under"System.Diagnostics" namespace.
=> Process class has a static Function "Start()" that starts a process.

How To start Song in C#:
------------------------
Process.start("E:\\MP3 SONG\\ssss.mp3");
-----------------------------------------------
How To Open any File and Application in C#:
------------------------
Process.start("notepad.exe");
================================================================================================================
working \with drive and folder in C#:
--------------------------------------
=> While creating file in by using C# it is a primary task to work with drives folders and files.Many times we have to create
   ,read and delete drives folder and files.
=> In c# folders are known as "Directory".
=> "System.IO" namespace provides classes and function to work with drives,Directory and Files.
=> DriveInfo class is for Drives.Directory class is for Folder and File class is for Files.

namespace=> Using System.IO;
// Create Folder Syntax-
---------------------
Directory.CreateDirectory("E:\\ChitraKoot");
----------------------------------------------
// Delete Folder Syntax-
----------------------
Directory.Delete("E:\\ChitraKott");
-----------------------------------------------
// Folder Check Create and Not Create:
-------------
            bool b = Directory.Exists("E:\\" + FolderName);
            if(b==true)
            {
                Directory.Delete("E:\\" + FolderName);
                Console.Write("Folder Delete Successfully.");
            }
            else
            {
                Console.Write("Folder not exist or invalid Path.");
            }
................................................................................................................ 
                                              Create File in C#:
---------------------------------------------------------------------------------------------------------------
Syntax- 
            File.Create("E:\\KSS\\akpalji.txt");
            Console.WriteLine("File created SuccessFully.");
            File.Copy("E:\\KSS\\akpalji.txt\\", "E:\\akpal.txt");
            Console.WriteLine("Copy File SuccessFully");
            bool b = File.Exists("E:\\KSS\\akpalji");
            if(b==true)
            {
                File.Delete("E:\\KSS\\akpalji");
                 Console.WriteLine("File delete SuccessFully:");
            }
            else
            {
                Console.WriteLine("File not exist or path.");
            }
==================================================================================================================
                                      Array In C#:
------------------------------------------------------------------------------------------------------------------
=> An Array is a collection of singular same type of various data items.
=> Array is used to store and proccess multiple values.
=> Array works on the basis on index.
=> First index of an array is 0 and last index of an array is length-1(size-1).

Declaring an Array:
-------------------
dataType []ArrayName=new dataType[size];

Ex: int []arr=new int[10];
------------------------------------------------------------------------------------------------------------------
Declaring an Inililizing an Array:
----------------------------------
dataType []ArrayName=new dataType[]{value1,values2............nValues};

Ex: int []Nums=new int[]{0,1,2,3,4,5,6,7,8,9};

NOTE: How sort any items in C#
-------------------------------
Array.sort(Array_NAme);
EX: Array.sort(nums);
==================================================================================================================
                                          Console.clear use in C#
------------------------------------------------------------------------------------------------------------------
clear class is used to clear all after input item.
==================================================================================================================
Syntax to declare a 2-D Array in C#
------------------------------------------------------------------------------------------------------------------
dataType [,]ArrayName=new DataType[Row,Colomn];

=================================================================================================================
                                           :String In C#:
-----------------------------------------------------------------------------------------------------------------
=> In C# "string" is a dataType and "String" is a class.
=> In C# string is a collection of various characters.
=> String is a reference type of dataType.
=> String has various function to perform operations.

1) ToUpper(): Used to convert a string into a uppercase.
2) ToLower(): Used to convert a string into a lowerCase.
3) Trim(): Used to remove white/blank space from left and right side both.
4) LTrim(): Used to remove white/blank space from left side only.
5) RTrim(): Used to remove white/blank space right side only.
6) IndexOf(): Used to know first occurance index of a character/word in a string. It notfound then it will return-1
7) LastIndexOf(): Used to know the last occurance index of a character/word in a string.It not found then it will return -1.
8) SubString(): Used to get part of a string as substring.
   Syntax: SubString(int startIndex,int Length);
9) Contains(): It is used to search string in a bool format,It notfound then it will return false. Found it will return true.
NOTE: String is an array of characters so we can get a specific character by using index.We can concate string by using + Symbol.

==================================================================================================================
                                          Static Function:
------------------------------------------------------------------------------------------------------------------
=> Static function is a special type of function.It has below Feature.
1) Static function can be called directly without creating the object of class.
2) Static function are called by using "class name".
3) A static function can call/use only static variables/function.
4) Static function save memory space.
5) static is a keyword that is used to declare a static variable/function.
6) Static is a storage specifier.Default value of static variables is zero.
==================================================================================================================
                                   OOP(Object Oriented Programming) With C#:
------------------------------------------------------------------------------------------------------------------
=> C# is a pure object oriented programmig languages.
=> C# supports all the concepts of oop's.
=> OOP is a programmig methadology that uses concepts of object to write computer programs.
=> OOP is very popular way to write program.
=> OOP uses concept of modular programmig. Hence we can create small-small modules separataly for developing a big software.
=> OOP is very close to our daily life.OOP's tries to implement behaviours of real life in programs.
=> OOP's provides concept of "reusablilty of code".
=> It is easy to debug and test an OOP's based software.
=> OOP's saves time and efforts of a programmer.
=> Object oriented programmig is a combination of some concept/feature.When we use that concepts in our program then our \
   program will be an object oriented program.

Feature/Concepts/pillers of OOP's:
------------------------------------------------------------------------------------------------------------------
1) class
2) object
3) data abstraction
4) data Encapsulation
5) inheritance
6) Polymorphism
7) message-Passing

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
1) class:
------------------------------------------------------------------------------------------------------------------
=> class is a container; it contains various variables and functions.In OOP's variables of class are known 
   as "Data members" and function of class are known as "data methods".
=> class is a collection of various data members and data methods.
=> Class works as a wrapper.It provides portability and security to our code.
=> Class is basic concept of OOP's. So we have to create a class first to work in OOP's.
=> "Class" keyword is used to create a class in C#.

Syntax to Create a class:
--------------------------
<Access_Specifier> class <Class_Name>
{
	//Data members
	//Data methods
}

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
2) object:
------------------------------------------------------------------------------------------------------------------
=> An object is a run-time entity.It represents the features of class.
=> When we went to use features of class from the outside of the class then we have to create object of that class.
=> When we create object of a class that time one copy of that class is created and memory is also assigned to that 
  new_copy of class.
=> Object represents a copy of class.Object creation means memory initilization to that class.

Syntax to create object of a class:
-----------------------------------
Class_Name objName=new Class_Name();

Ex: Studend stu=new Studend();
..................................................................................................................
                                                :NOTE: 
------------------------------------------------------------------------------------------------------------------
=> By default all the members of class are private.It means all the variables and function of class are by default private.

=> By default class is public.
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
3) Data Abstraction:
------------------------------------------------------------------------------------------------------------------
=> Data Abstraction means "data hiding".
=> Concepts of providing only required information without providing details of internal functionality is known as 
   data abstraction.
=> Data abstraction is used to implement security in program.
=> We can define access level in our program by using access specifiers/modifiers.
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                                       ::Access_Specifier in C#::
-==============================================================================================================
=> Access specifiers are used to specify accessibility of data members and data methods.
=> It is used to define area of scope of a data members and data method.
=> Access specifiers are also known as access modifiers.
=> In C# we have 4 Types of access specifiers:-
""""""""""""""""""""""""""""""""""""""""""""""""
1) private
2) internal
3) protected
4) public

<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
1) private:
------------------------------------------------------------------------------------------------------------------
=> Private members are accessible only with-in the block where they are declare.
..................................................................................................................
2) internal:
------------------------------------------------------------------------------------------------------------------
=> Internal members are accessible in current namespace.It means we can call them from anywhere inside the namespace.
..................................................................................................................
3) protected:
------------------------------------------------------------------------------------------------------------------
=> protected members are accessible in current block and inside the child class in same namespace or also in child 
   class of another namespace.OtherThan this protected members are not accessible anywhere in the program.
..................................................................................................................
4) public:
------------------------------------------------------------------------------------------------------------------
=> Public members are accessible in whole program.
=> we can call them from anywhere.
<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
4) Data Encapsulation:
------------------------------------------------------------------------------------------------------------------
=> Wrapping of data members and data methods in a single unite is known as data Encapsulation.
=> Concepts of class is used to implement data encapsulation in our program.
=> Encapsulation provides portability and security to our software code.
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
                                           :Constructor:
------------------------------------------------------------------------------------------------------------------
=> Constructer is also a member function of class it has some special features-
A) Name of constructor must be same as name of related class.
B) We can not define any return type in constructor; Not even void.
C) We can pass parameter into constructor as per our need.
D) Constructer must be defined with public scope.
E) We do not have to call a constructor forcefully.Constructer are called automatacally when we create the 
   object of class.
F) We can create n number of constructors in a class as per our need.

Syntax to create a constructor:
-------------------------------
public <Class_Name>(List_Of_Parameter)
{
	//statement.
}

NOTE: Generally constructor are used to assign default values to the properties of class.Constructer are used for memory 
      initilization.
..................................................................................................................
                                        :Types of Constructer:
------------------------------------------------------------------------------------------------------------------
1) Default Constructer: 
-----------------------
=> a constructor without any parameter is known as default constructor.
///////\\\\\\\\\\\\\\///////////////\\\\\\\\\\\\\\///////////////\\\\\\\\\\\\\//////////////\\\\\\\\\\\\\\\//////
2) Parameterized Constructer: 
-----------------------------
=> A constructor with some parameters is known as parameterized constructor.
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
=> Floor and Ceiling in used C#
------------------------------------------------------------------------------------------------------------------
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
5) Inheritance:
------------------------------------------------------------------------------------------------------------------
=> Inheritance is the ability to access to features of base class into sub class.
=> Inheritance provides concept of re-usability of code.It saves time and effort of program.
=> Inheritance is one of the most important concept of OOP's.
=> Base class is also known as Super class or parent class or main class.
=> Sub class is also known as derived class or child class.
::::::::::::::::::::::::
Types Of Inheritance in C#::
-----------------------------
 1)Single Inheritance
 Ex:
      |------|
	  | class|  =>parent
	  |  a   |
	  |------|
	      |
		  |
		  |
		  ^
	  |------|
      |class | =>child of a
      |  b   |
      |------|	  	  
======================= 
 2)Multi-Level Inheritance
 Ex:
      |------|
	  | class|  =>parent 
	  |  a   |
	  |------|
	      |
		  |
		  |
		  ^
	  |------|
      |class | =>child of a and parent c
      |  b   |
      |------|	  	  
	      |
		  |
		  |
		  ^
	  |------|
      |class | =>child of c
      |  b   |
      |------|	
============================== 
 3)Hierarchical Inheritance
 Ex:
                       |------|
	                   | class|  =>parent 
	                   |  a   |
	                /  |------| \
				   /             \
				  / 	          \
					   
			|------|             |------|  
	        | class|  =>child    | class|
	        |  b   |             |  c   | =>child
	        |------|		     |------| 
==========================================================				   
 4)Hybrid Inheritance
 Ex;:
                       |------|
	                   | class|  =>parent 
	                   |  a   |
	                /  |------|  \
				   /              \	
				  / 	           \
					   
			|------|             |------|  
	        | class|             | class|
	        |  b   |             |  c   | 
	        |------|		     |------| 
               |
			   |
			   |
			   !
            |------|
	        | class|  
	        |  d   |
	        |------|
 
 Note:: Multiple Inheritance is not supported in C# 

  Syntax to Inherit a class:
  ==========================
  <Access_Specifier>class SubClassName:BaseClassName
  {
   //Data Members
   //Data Methods
  }

Notes:: In C# :(colon) symble is used to inherit a class.
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                                            Random Class in C#:
-----------------------------------------------------------------------------------------------------------------
=> Random is a class in C# that is used to generate a random number.
=> Random clas is located under "System" namespace.
=> Random class has a "Next()" function that generates and return a random number between the specified range.

Syntax:
------
Random Obj=new Random();
VarName=Obj.Next(StartValue,EndValue);

Ex: 
--
using System;
namespace demo51
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1000,9999);
            Console.WriteLine("Random Number is: " + n);
            Console.ReadKey();
        }
    }
}
==================================================================================================================
6) Polymorphism:
------------------------------------------------------------------------------------------------------------------
=> Polymorphism is a combination of two words "poly" and "morphism".
=> Poly means "many" and morphism means "form".
=> Polymorphism means "one thing many form".
=> By using Polymorphism we can create multiple function with same name having different functionality.It makes easy
   to handle a program.

Types of Polymorphism in C#:
----------------------------
A) Early Binding/Complie Time Polymorphism.

=> It is also known as "Early Binding."
=> Compile time Polymorphism is implement by using "function overloading."
=> It binds (decide) function call during compile-time.
EX: Function OverLoading.

B) Late Binding/ Run-Time Polymorphism.

=> It is also known as "Late binding"
=> Run time Polymorphism is implement by using "function overriding".
=> It binds (decide) function call during run-time.
EX: Function OverRiding.
------------------------------------------------------------------------------------------------------------------
                                          A) Function OverLoading:
------------------------------------------------------------------------------------------------------------------
=> Function OverLoading is the ability to define various function with same function name.
=> To define various function with same function name having different-2 prototype(syntax/signature) is known as 
   function overLoding.We can create multiple function with' same function name in same scope(in same class ) with 
   different-2 syntax in function OverLoading.
=> Function overLoding simplified the function names.We do not have to remember various function names.
=> We can overLod a function in two basis-

1) On the basis of types of parameter
    EX: int sum(int x,int y);
	    float sum(float x,float y);
		
2) On the Basis of number of parameters.
    EX: int sum(int x,int y);
	int sum(int x,int y,int z);
------------------------------------------------------------------------------------------------------------------
                                          B) Function OverRiding:
------------------------------------------------------------------------------------------------------------------
=> To define same function name having same prototype (syntax/signature) is known as function overriding.
=> We can override a function of base class in child class.
=> To implement function overriding we have to define function in parent and child class (in different-2 scope).
=> Function overriding defines new functionality to a function of base class for child class.
=> In C# we have to define a function as "virtual" function or abstract function in base class to allow function overriding by child class.
=> To OverRiding a function in Cild class we have to use "override" keyword.
==================================================================================================================
                                             Virtual KeyWord:
------------------------------------------------------------------------------------------------------------------
=> Virtual keyword is used to define basic functionality of a function in base class and it also allows to override that function in child class.
=> It depends of child class that it wents to override that function or not.
=> This type of function is known as virtual function.

==================================================================================================================
                                             Abstract function:
------------------------------------------------------------------------------------------------------------------
=> Abstract is a keyword that is used to declare a function without definition in base class.
=> Abstract function must be override in child class.
=> A function without definition in base class is known as abstract function.This abstract function must be override by child class.
=> Abstract keyword is used to define a abstract function.
=> A class also can be an abstract class.

Syntax:
-------   
      public abstract return_type functionName(List-of_Parameters);
EX:
---
     public abstract void getResult();

Abstract class:
---------------
=> Abstract class is a special class that can have abstract and non-abstract both types of function.
=> To define a function as abstract function we must have to define that class as abstract class.
=> Abstract class can not be instantiated.It means we can not create the object of an abstract class.
=> Abstract class is for inheritance.We can inherit an abstract class and override(implement) the abstract function of abstract class(base class) in child class.
=> Abstract keyword is used to define a abstract class.

NOTE: there is no such concept as "virtual class" in C#.
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
??????????????????????????????????????????????????????????????????????????????????????????????????????????????????
abstract class ko sirf inherit hi kiya jata hai.uska object ni bnaya jata hai.yadi base class me abstract ko already definition bna gya hai to child class me usko define krna hi padega.ni to usme error a jayegi.
=================================================================================================================
                                                    Base:
-----------------------------------------------------------------------------------------------------------------
=> Base is a keyword in that is used to call base version of a function.
=> In function overrideing if we have same function names in base and sub class and if we want to call definition of base class function then we have to use base keyword before function name.

=================================================================================================================
                                                 InterFace:
------------------------------------------------------------------------------------------------------------------
=> InterFace is a blueprint of class.It can contains various abstract methods.InterFace is used to achieved concept of multiple inheritance.Becouse we can inherit an interface with a class also.
=> InterFace is a collection of various function declarations.
=> InterFace can have only function declarations. We can declare prototype of functions in interface.Hence interface is a collection of various abstract methods.
=> By default all the methods of interface are abstract method.No Need to write "abstract" keyword.
=> InterFace can not have date members (variable/properties).It can have only abstract methods.
=> "interface" keyword is used to create an interface.
=> By default all the methods of interface are abstract and public.We can not change it.
=> We do not have to use override keyword to define a function of interface in child class.

Syntax to create an InterFace:
------------------------------
interface <interface_Name>
{
	function_1_Prototype
	function_2_Prototype
	
	.......
	function_n_Prototype
}
==================================================================================================================
                           Different between InterFace And Abstract class:
------------------------------------------------------------------------------------------------------------------
Abstract:-
1) There is also write override keyword to define a method of abstract in sub class.
2) We have to define abstract methods in abstract class by using "abstract" keyword.
3) Abstract keyword is used to define a abstract class.
4) Abstract class can have  abstract and non abstract function.
5) Abstract class can have data members and data methods both.
6) Abstract class not supported concept of a multiple inheritance.

InterFace:-

1) But There is no need to write override keyword to define a method of interface in sub class.
2) But default all the methods of interface are abstract method.No Need to write "abstract" keyword.
3) "interface" keyword is used to create an interface.
4) InterFace class can have  abstract function.
5) But InterFace can have only data methods.
6) But InterFace helps to achieve concept of multiple inheritance.
==================================================================================================================
                                           Delegate in C#:
------------------------------------------------------------------------------------------------------------------
=> Delegate is also a UDDT like as struct,class and interface.
=> Delegate works like a function pointer.It is used to store the address of a function.
=> Delegate are created by using "delegate" keyword.
=> It  is necessory to have same prototype(syntax) of function and delegate.Without matching the syntax a delegate cannot store the address of that function.
=> Delegate in a reference type.We can call a function by using address.
=> Generally delegates are used to create events in a languages.(Kisi bhi prakar ka events banane ke liye delegate ka use kiya jata hai jaise change,click etc).

syntax to create a Delegate:
----------------------------
<Access_Specifier> Delegate <Return_Type> <Delegate_Name>(List_of_Parameters);

EX: public delegate int nums(int x,float y);
..................................................................................................................
Syntax to assign address of a function to a delegate/Syntax to create object of a delegate:
-------------------------------------------------------------------------------------------
Delegate_Name ObjName=new Delegate_Name(function_Name);

EX: nums n=new nums(sum);
..................................................................................................................
Syntax to call a function by using Delegate:
--------------------------------------------
Obj_Of_Delegate(List-of_Parameters);

Ex: n(23,34.5);
EX:.................................
namespace Demo62
{
    class Program
    {
        public delegate int MyDeligate(int x, int y);
        static int Add(int num1,int num2)
        {
            return (num1 + num2);
        }
        static int GetMax(int p,int q)
        {
            return p > q ? p : q;
        }
        static void Main(string[] args)
        {
            int a, b, result;
            Console.Write("Enter any 2 numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            MyDeligate md = new MyDeligate(Add);
            result=md(a,b);
            Console.WriteLine("Addition is: " + result);
            MyDeligate md1 = new MyDeligate(GetMax);
            result=md1(a, b);
            Console.WriteLine("Max number is: " + result);
            Console.ReadKey();
        }
    }
}
==================================================================================================================
                                        Exception Handling in C#:
------------------------------------------------------------------------------------------------------------------
=> Exception are the faults/problem that occure in a program during run-time due to some unexpected event.
=> Exception breaks are/terminate the execution on whole program.Hence it leads to data loss and time loss.
=> The proccess that handle the Exception is known as "exception handling".
=> By using exception handling we can mention that what to do when an specific exception occures.
=> Exception handle is a process that helps to handle run time exception in a program.

Exception Handling blocks in C#:
--------------------------------
1) try block
-------------
=> try block is used to write program code that can cause a exception during run-time of program.try block is an essential
   block when we use exception handling.

2) catch block
--------------
=> Catch block is exception handling block.This block is used to write code for handling exception .It means if an exception 
   occure in code of try block then code of catch block will be executed.It is essential to have minimum one catch block with 
   a try block but we can use more-that one catch block with a single try block.

3) finaly block
---------------
=> final block is used to write some important code that we have to run in all situation(exception comes or not).Finally 
   block is an optional block.We can have only one finally block with a try block.

Syntax:
-------
try
{
	// code that can cause some exception.
}

catch
{
	//code to handle exception
}

finally
{
	//common code to run in all cases.
}
==================================================================================================================