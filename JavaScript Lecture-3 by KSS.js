                                         JavaScript Lecture:
========================================================================================================
                                         DOM Manipulation in JS:
--------------------------------------------------------------------------------------------------------
=> We can modify the page content in JS.
=> TO modify the content JS provides 3 below properties-
/////////////////////////////////////////////////////////
1) value
2) innerHTML
3) innerText
///////////////////////////////////////////////////////// 
1) value:
---------
=> This property is used to get/set (read/write) the value of form controls in JS.
=> We can use this property with input tags, select tag, textarea and button tag.
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
Syntax to get value of form controls:
--------------------------------------------------------------------------------------------------------
VariableName=ObjectOfTag.value;
Ex: 
var num=document.getElementById("txtnum").value;

Syntax to set (write) value in form controls:
---------------------------------------------
ObjectOfTag.value=Value_for_tag;

Ex: document.getElementById("txtname").value="Satyam Mishra";
===========================================================================================================
//2) innerHTML:
-----------------------------------------------------------------------------------------------------------
=> This property is used to get/set the content in HTML format.
=> THis property is used with normal HTML tags(otherthan form controls).
=> We can use this property with div, p, a, ul,ol,table,etc tags.
=> innerHTML property is used to read and write content with HTML tag.
//NOTE:- Sometime innerHTML property is also used with select tag to generate Option tag inside select tag.
Syntax to get:
==============
VariableName=ObjectOfTag.innerHTML;
Ex:
<p id="para">
<img src="ram.jpg" /><br>
Ram Kumar</br>
</p>

var x=document.getElementById("para").innerHTML;
//x="<img src='ram.jpg' /><br>Ram Kumar</br>"

Syntax to Set(Write):
---------------------
ObjectOfTag.innerHTML=HTML_content_for_tag;

Ex:
---
document.getElementById("para").innerHTML="<h1>Welcome to JS</h1><br><img src='jsicon.jpg' />";

//3) innerText:
-------------
=> This property is used to get/set content of normal HTML tags in plain text format.
=> We can use this property with normal HTML tags other than form controls.
=> This property generally used with span,p,a,ol,table,etc.Tags.
=> Some versions are firefox browser does not supported innerText property.
//////////////
Syntax to get:
---------------
VariableName=ObjectOfTag.innerText;

Ex:
<p id="para">
 <img src="ram.jpg" /><br>
Ram Kumar</br>
</p>

var x=document.getElementById("para").innerText;

// x="Ram Kumar"

Syntax to Set:
===============
ObjectOfTag.innerText=Value_for_tag;
Ex:
document.getElementById("sp").innerText="Result is: "+res;

Note: innerText property is not supported in some versions of firefox browser.
================================================================================================================
//                                    Conditional Statements in JS:
----------------------------------------------------------------------------------------------------------------
=> Just like C/C++.
=> Js has conditional statement like as if and switch.
--------------------------------------
Types Of Conditional statement in JS:
=====================================
1) if statement
 A) Simple if
 B) if else
 C) ladder if/else if ladder
 D) nested if
...................................... 
2) switch statement:

==================================================================================================================
//                                       Parameterised Function in JS:
==================================================================================================================
=> In JS we can pass parameters in our function as per our need.
=> Generally we pass id of tags as parameters of function. When we pass id of tags as parameter then it will send the object of that tag.

Syntax:
=======
function Function_Name(Parameter1Name,Parameter2Name,...)
{
  // statements...
}
================================================================================================================
//                                       Looping Statements in JS:
================================================================================================================
=> In JS looping statement is almost same as C/C++.

=> In JS we have for, while , do while and advance for loop.
=================================================================================================================
//                                      Manageing Styles by using JS:
=================================================================================================================
=> JS provides feature to manage CSS style in tags during runtime.
=> We can read and modify value of a Css property in a tag by using JS.
=> JS provides "Style" property in all tags that is used to manage CSS for that tag.

Syntax to read value of a CSS property of a Tag:
------------------------------------------------
varName=Object_Of_Tag.style.Name_of_CSS_Property;

Ex:var col=Document.getElementById("mydv").style.color;
................................................
Syntax to write value of a CSS property of a Tag:
------------------------------------------------
Object_Of_Tag.style.Name_of_CSS_Property=value_of_CSS_Property;

Ex:Document.getElementById("mydv").style.backgroundColor="red";
=================================================================================================================
//                                        ::Array in JS::
=================================================================================================================
=> An Array is a collection of varius data items.
=> An Array can store different-2 types of value in js.
=> We can also save store same types of data items in an Array.

Syntax to declare an Array:
-----------------------------------------------------------------------
 ArrayName=new Array(size);  
 
 Ex: var arr=new Array();
 
Note: HERE Array is a constructor that is used to create a new array. We can ignore passing of size becouse it
      is optional. 

Syntax to declare and initilize an array:
-----------------------------------------------------------------------

ArrayName=[Item1,Item2,Item3,.....];

Ex: x=[20,45,"ram",23.1];

NOTE:: We can find size of array by using "length";
=> First index of array in zero and last index of an array is size/length-1;
property. We can print all value of an array without using any loop. it will print all values inserting cama(,) between them.
=================================================================================================================
//                                        ::Array of Object::
=================================================================================================================
=> Collection of various object is known as array of object.
=> Array of object is used to store a very large amount of data.
=> We can easily store multilple data seprately and also we can process that data easily by using array of object.
=> To access each and every object from array of object we have to use index.
Syntax to declare an Array of Object:
-----------------------------------------------------------------------
var ArrayObjName=[{},{},{}.....{}];  
 
 Ex: var arr=[{obj1},{obj2},{obj3}.....{objn}];
 EX: var emp=[{empid:1,empname:"Atul",empsal:123456},{empid:2,empname:"PAPA",empsal:4565654}];
==================================================================================================================
//                                           Sorting in Array:
==================================================================================================================
=> We can sort items of an array in javascript.
=> To sort the items of an array we have to use "sort()" function.
=> Sort function sorts the items is assending order.

syntax:: ArrayName.sort();

Ex: arr.sort();

NOTE: We can sort onLy alphavetical by using sort() function.
=> To arrange items in descending order we have to use "reverse" function after using "sort()" function.

=> sort() function does not supported of int,float or long value bydefault.becouse it sorts alphavete not their value.We can enable sorting of number value in sort function by modify its functionality as shown below.

sort(function(x,y))
{
	return x-y;
}

==================================================================================================================
//                                         String in JS:
==================================================================================================================
=> String is a collection of a characters.
=> JS provides varius function to perform operations in string that function are-

1) charAt(): this function is used to get characters of a specific index from a string.
2) toUpperCase(): This function is used to get a string into upperCase.
3) toLowerCase(); this function is used to get a string into lowerCase.
4) indexOf(): This function is used to get first occurance index of a characters/word in a string.
 //   EX:var str="He live in India."
 //      var x=str.indexOf('i');	  
Note: We can search a characters/words in a string by using indexOf() function.It items not found then it will return-1.

5) lastIndexOf(): This function is used to get last occurance index of a characters/word in a string.
  EX: var str="He live in India.";
      var x=str.lastIndexOf('i');  

6)charCodeAt(): This function is used to get ASCII value of a specific index character in a string.
7) substring(): This function is used to get part of a string.It is used to retrive part of a string from main string.

 Syntax: substring(startindex,lastIndex);

8)split(): this function is used to break a string in various parts .
           split function break a string into array.
Syntax: stringVar.split(Breakcharacter);		   
..................................................................................................................
length:
=======
=> length is a property in string that is used to find number of character in a string.
==================================================================================================================
//                                                ::Object::
------------------------------------------------------------------------------------------------------------------
=> JS is an object based language.
=> We can create object in js to store multilple value in property/value pair.
=> In core JS object and class both are same.We can create bothe by using same Syntax.
=> JS object can store multilple properties- and multiple function.
=> In jS "{}" bracket denotes an object.

Syntax To create an Object:: 
.............................
objName={Property1Name:value,Property2Name:value}'

Ex: student={name:"Atul",age:25,city:"Kalpi",rno:1};
==================================================================================================================
//                                 Creating  class in Modern JavaScript:
==================================================================================================================
=> In Modern Js support 'class ' keyword to create a class .
=> Like as our server side language we can create a class in JS by using "class" keyword.
=> We can define properties and method inside a class.
=> A class is a container that is a collection of a various properties and various methods.
=> We can define properties inside constructor function in JS. constructor function are always created with name   "constructor()".
=> To define a function inside class we do not have to use" function" keyword before function name.
=> Properties are defined and access inside class by using 'this' keyword.

Syntax to create a class:
-------------------------
 class <class_Name>
 {
	 constructor()
	 {
		 //statement.
	 }
	 functionName()
	 {
		 //statement.
	 }
 }

NOTE:: constructor() is a special function of a class. It is called automatacaly when we creates the object of class.So We don not need to call a constructor forcefully.

Syntax to create Object of class.
=================================
var ObjName=new className();
EX: var s=new Student();

========================================================================================================
//                                      Inheritance in JS:
========================================================================================================
=> Modern JS support concept of inheritance.
=> Inheritance is the ability to derive/access features of a base class into child class.
=> Inheritance pro feature of a reusability of code. We can use features of a class inside another class by using inheritance.So it saves times and effort of a user/programmer.
=> class that provides features is known as base class/ super class/parent class.The class that access/uses features of another class in known as child class/sub class/ inheritance class/ derive class.

=> Extends keyword is used to inherit a class in JavaScript.

Syntax to create inheritance in JavaScript:
-------------------------------------------
class SubClassName extends SuperClassName
{
	//statement.
}
Note: during inheritance we have to call constructor of base class inside constructor of child class by using "super()" function/class.
========================================================================================================
//                                 Working with Date And Time:
========================================================================================================
=> In js;We can get system date and time in our program.
=> "Date" class is used to work with date and time in js.
=> To get datetime we have to create object of date class.

Syntax: 
-------
var ObjName=new Date();

Ex: var d=new Date();
----------------------------------------
Some important function of Date class:
---------------------------------------
1) getDate(): Used to gat date of month/day number of month.
2) getMonth(): Used to get index of month name.For example it will provide 0 for january.
3) getFullYear(): Used to get year in 4 digits.
   Ex: 2021,2045,2059;
4) getHours(): Use to get hours in 24 hour format.
5) getMinutes(); Used to get Minute.
6) getSeconds(): used to get Second.
7)    
