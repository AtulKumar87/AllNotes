==================================================================================================================
//                                 :INTRODUCTION TO JQUERY:
==================================================================================================================
=> JQUERY is a JAVASCRIPT library.
=> JQUERY is developed completely based on JAVASCRIPT.
=> JQUERY is an open Source JAVASCRIPT library.
=> JQUERY is not replacement of JAVASCRIPT.It simplifies the JAVASCRIPT task.
=> JQUERY is a cross-plateform JAVASCRIPT library designed to simplify the client-side scripting of HTML.
=> JQUERY is used to overcome the load on server.Many tasks can be performed in client-side by using JQUERY.
=> It's punch line is "Write less do more..."
==================================================================================================================
//                                  :Creation Of JQUERY:
==================================================================================================================
Creation of JQUERY=:> John Resig.
Creation in 2006.
==================================================================================================================
//                                  :Feature Of JQUERY:
==================================================================================================================
=> Simple
=> DOM traversing.
=> DOM Manipulation.
=> Event Handling.
=> Styles Modifications.
=> Effects and Animations.
=> AJAX Support.
=> JQUERY - UI.
=> CSS3 Complaint.
=> Light Weight Library.
=> Cross Browser Support.
=> InterPreted.
==================================================================================================================
//                             Explanation of Above Code:
==================================================================================================================
1) $()
------------------------------------------------------------------------------------------------------------------
=> $ is a basic function of jQuery.
=> $ is also known as "jQuery factory function".
=> $() is short form of "jQuery()" function. It means we can replace $ by "jQuery". 
=> $() function is used to select any tag/object from webpage. It is basically a selector function.

Syntax: $(Selctor)
 EX: $(Document)
 NOTE: $(Document) means we are selected the object of current page/Object of DOM.
.................................................................................................................
a) $(document):
----------------
=> document is a built-in object of current webpage (DOM).
=> $(document) means to select whole page.
=> To assign all weppage to jQuery library we have to use $(document).
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
2) ready():
------------------------------------------------------------------------------------------------------------------
=> ready() is an event function jQuery.
=> It execute when the page loaded completely and ready to use.
=> ready() event is equivalent to "onload" event of JAVASCRIPT.
=> In ready() event we have to define some task/work.generaly that task/work is defined by using annonymous/unnamed function to save time of programmer ;but we can also use named function in that place.
=>ready() function is equivalent after page loading.
=>ready() event starts execution just after the loading of webpage.

Note: In jQuery we have to define task/work for each and every event we can do it by passing 
      named or un-named function.Mostly un-named functions are used for this perpose.
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Assigning task/work to jQuery events:
======================================
=> We can assign task/work to jQuery events by using named/unnamed (anonymoums) function.
=> In case of unnamed function we do not have to write function name and also no need of function calling.
=> Unnamed function calls automatically where we have written it's code.
==================================================================================================================
//                                 jQuery Selector (DOM Accessing):
==================================================================================================================
=> jQuery selectors are used to select an Element to perform some operations..
=> That selectors provides the object of specified tag.
=> In jQuery we have main 3 types of selectors-

1) ID based Selectore:
----------------------
=> we can select a tag on the basis of id. For this process we have to use '#' symbol before id of tag.

Syntax: $("#id_of_tag")
Ex: $("#txtname")
.................................................................................................................
2)Class based Selector:
-----------------------
=> Class selector is generelly used for selecting collection/bunch of object.			  
=> We can access object of tag on by CSS class name for this purpose we have to use '.' symbol before class name.

Syntax: $(".Name_of_Class")
Ex: $(".mycls")
..................................................................................................................
3) Tag based Selector:
----------------------
=> We can select object of tag by using its family.
=> To access a tag by using tag type we do not have to use any symbol.

Syntax: $("TagType") 
Ex: $("div")
-----------------------------------------------------------------------------------------------------------------
Note: In jQuery almost all selectors are just like CSS selectors. We have universal selector,nested
      selector and multiple object selector in jQuery.
=================================================================================================================
//                               DOM ManipulatioN in jQuery:
=================================================================================================================
=>jQuery provides features to access and modify content of DOM.
=> We can read and modify the content of tags by using jQuery.
=>We can read and change the content of DOM element by using jQuery.
=>jQuery provides below function for DOM manipulation-	  
..................................................................................................................
1)val():
=> It stands for value.
=> This function is used to get/set the content of form controls like input tag, select tag,textarea tag.
=> this function is equivalent to "value" property of JS.

Syntax to get:
               varName=ObjectOfTag.val();    (or)
               varName=$(selector).val();
               Ex:var num=$("#txtnum1").val();

Syntax to set:
              ObjectOfTag.val(value/variable);  (or)
              $(selector).val(value/variable);
              Ex: $("#mob").val("8707252768")
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
2)text():
------------------------------------------------------------------------------------------------------------------
=> text() function is used to get/set the content of normal HTML tag in plain text format.
=> this function is used with span,p,div,table,ul,ol,etc tags.
=> this function is work like"innerText" property of javascript.

Syntax to get:
---------------
varName=$(selector).text();
Ex:var x=$("#dv1").text();
---------------------------
Syntax to set:
--------------
$(selector).text(value/variable);
Ex:$("#sp1").txt("record saved in databased")			  
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
3)html():
------------------------------------------------------------------------------------------------------------------
=>This function is used to get/set the content of normal HTML tag in HTML format.
=>This function is used with p, div,span,ul,ol,table,etc tags.Sometime it is also used to generate some child items inside select tag.
Syntax is get:
---------------
 varName=$(selector).html();
Ex: var x=$("#dv1").html();
....................
syntax to set:
--------------
$(selector).html(value/variable);
Ex: $("#dv1").html("<b>record save.</b>");
=============================================================================
4)attr():
--------------------------------
=> It stands for Attribute.
=> attr() function gets/sets the value in string format.
=> This function is used to get/set the attribute of a HTML tag.
Syntax to get:
-----------------
varName=$(selector).attr("Name_of_attribute");
Ex: var x=$("#dv1").attr("width");
....................
syntax to set:
--------------------------
$(selector).attr("Name_of_attribute","Value_of_attribute.");
Ex: $("#dv1").attr("src","tulips.jpg");
=============================================================================
5)prop():
------------------
=>prop stands for property.
=> Generally the propertys are that has some fixed specified value.
=>This function is used to get/set the propertys of a HTML tag.
=> prop() function gets/sets the value in real format.
=> Generally prop() function is used to get/set checked,disabled and readonly values.
Syntax to get:
-----------------
varName=$(selector).prop("Name_of_property");
Ex: var x=$("#gender").prop("checked");
....................
syntax to set:
--------------------------
$(selector).prop("Name_of_property","Value_of_property.");
Ex: $("#gender").prop("checked",true);
================================================================================
//                                  Style Management in jQuery:
--------------------------------------------------------------------------------
=> We can manage CSS style by using jQuery.
=> jQuery also supports propertys of css-3.
=> By using jQuery we can read and modify value of CSS propertys in a tag.
=> jQuery provides below function to manage styles.

1) css()
2) addclass()
3) removeclass()
4) toggleclass()
=====================================================================================
// 1)css():
-------------------------------------------------------------------------------------
=> This function is used to get/set a CSS property to specified object.

syntax to get:
....................
varName=$(Selector).css("Name_of_css_property");
Ex: var x=$("#dv").css("color");
..............................
syntax to set:
------------------
$(Selector).css("Name_of_css_property","property_value");
Ex:- $("#btn").css("display","none");
EX: $("#mydv").css("border","2px solid red");
------------------------------------------------------------------------
// 2)addclass():
------------------------------------------------------------------------
=>This function is used to add(apply) a CSS class in specified object.

syntax to get:
--------------------
$(Selector).addClass("name_of_CSS_Class");
Ex: $("#txt").addClass("form-controls");
object_of_tag.addClass("name_of_CSS_Class");
ex: $("#btn").addClass("btn-danger");
------------------------
// 3)removeClass():
--------------------------------
=>This function is used to remove of CSS class from specified object.

Syntax :
----------------
$(Selector).removeClass("name_of_CSS_Class");
Ex: $("#txt").removeClass("form-controls");
----------------------------------------------------------------------
// 4)toggleClass(): 
---------------------------------------------------------------------
=> This function is used add or remove a CSS class from selected object.
=>It performs the reverse action of add and remove. 

syntax:
.......
$(selector).toggleClass("name_of_CSS_Class");
Ex: $("#txt").toggleClass("form-controls");
//or
object_of_tag.toggleClass("name_of_CSS_Class");
ex: $("#btn").toggleClass("btn-danger");
============================================================================================
//                      Syntax to Set Multiple Properties By using CSS():
============================================================================================
Object_Of_Tag(Object_Of_Properties_with_value);

Create Object: var x={"color":"red","background-color":"yellow","width":"20px"};
Ex: $("#mydv").css(x);
============================================================================================
//                       Advanced(Dynamic) DOM ManipulatioN By using jQuery:
--------------------------------------------------------------------------------------------
=>in jQuery we can add,modify and delete particular content of webpage.
=>jQuery provides below function to performs advance level DOM manipulation-

1) append()
2) before()
3) after()
4) empty()
5) remove()
6) prepend()
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
// 1)append(): 
-----------
=> This function is used concat some content at the end of existing content in selected tag.
=>  
 Syntax: $(selecter).append(Content);
Ex: $("#lst").append("<li>Chitrakoot</li>");
.............................................
// 2)before():
 ----------           
=> This function is used to add/insert are some content before selected object.(before closing of tag-outside the tag.)

 Syntax: $(selecter).before(Content);
Ex: $(".first").before("<li>Chitrakoot</li>");
.............................................
// 3)after():
----------
=> This function is used to insert some content after selected object.(after closing of tag-outside the tag.)
			
 Syntax: $(selecter).after(Content);
Ex: $(".mycls").after("<li>Chitrakoot</li>");
.............................................
// 4)empty():
----------
=> Thism function used to clear all the content of selected object.
=> After using empty() function the tag/object will exist but content will be remove.
=> It also removes all child content tags from selected tag.

Syntax: $(selecter).empty();
Ex: $("#dv").empty();
.............................................
// 5)remove():
-----------
=> This function is used the remove the selected object from DOM.(remove object_of_tag)
	
Syntax: $(selecter).remove();
Ex: $("#dv").remove();	
...............................................
// 6) prepend():
-----------------
=> The jQuery prepend() method inserts content AT THE BEGINNING of the selected HTML elements.

eX:$("p").prepend("Some prepended text.");
====================================================================================================
//                              Stracture of DOM ManipulatioN:
----------------------------------------------------------------------------------------------------
.....................
.  before           .
.       <div>       .
.          append   .
.       </div>      .
.  after            .
.....................
====================================================================================================
//                                 Working with collection in jQuery:
----------------------------------------------------------------------------------------------------
=>In jQuery most of the time we have to the work on collection for that it is very important to get each and every item of collection separately.
=>jQuery provides features to travers object from collection by using 2 below function.
..............
1)each()
----------
=> This function is used to get each item from collection.
=> each() function is an item based function. It works like foreach loop.
=> In every execution each function provides next item
=> each() function is used to get each and every object from a collection of object.
=> each() function is item based function.It does not work on the basis of index.
=> each() function works like a loop.It iterates over all items and provides object of each item one by one.
=> It works like foreach loop.
=> To get/access current item from collection we have to use $(this) inside each function.
Syntax:
--------
Collection_Of_Object.each(function(){
	//statement.
});
//or
$(selecter).each(function(){
 // statement.
 });
 
Note: we can get current items inside each function by using $(this).
NOTE: We can also get the index of items inside each function.For that we have to pass a variable in handler function.

Syntax:
--------
Collection_Of_Object.each(function(index){
	//statement.
});
=========================================================================================================
2)eq()
------
=> eq() function is used to access a single object from collection of object on the basis of index.
=> We can access a single object from collection to perform some operations on that object by using jQuery.
=> this function is used to get each item from collection.
=> eq() function is an index based function.
=> We can get specific item from collection by passing index of that specific item inside eq()
function.
//syntax:
//-------
Collection_Of_Object.eq(index);

 var varName=$(slecter).eq(index);
 Ex: var x=$("3lst option").eq(4);
==========================================================================================================
//                            Dynamic Event handling in jQuery:
----------------------------------------------------------------------------------------------------------
=>JQuery is also capable to handle Dynamic Event.
=>We can add and remove events in specific object during runtime.
=>we can add events in dynamically added object by using jQuery.
=>To add dynamic events we have bind(),live(),and on(),function. on() function is latest function and it has rich features.
=>To remove dynamic events we have unbind(),die() and off() function.Off() function is latest function and it has rich features.

1) bind()/live()/on().
2) unbind()/die()/off().
------------------------
bind():
-------
=> bind function is used to add an event in a selected object during runtime of program.
=> We also have to define event handler code inside bind function.
=> Work of bind(),on(),and live() function is same.

syntax:
-------
object_of_tag.bind("EventName",function(){
	//statement.
});

syntax of on():
...............
                $(selecter).on("EventName",eventhandler function(){});
				$(selecter).on("EventName","Selector/filter","EventHandler")
              Ex:
			  ---
                $(selecter).on("click",function(){
				alert($(this).text());
				});
.....................................................
unbind():
---------
=> This function is used to remove/deattach an event handler from a selected object.
=>  Work of unbind(),die(),and of() function is same.

syntax:
-------
object_of_tag.unbind("EventName");

syntax of off():
...............
                $(selecter).off("EventName");
               Ex:
			   ---
			     $("#btn").off("click");
				 

=============================================================================================================
// Working with parent-child relationship in object by using JQUERY:
-------------------------------------------------------------------------------------------------------------
=> In complex/big webpages sometime we have to perform some task on the basis on parent and child tag.
=> jQuery provides features to access and modify parent-child object in a webpage.
=> below are the main function that are used to work in parent-child tag.

1) parent():
------------
=> This function is used to get/access/read the object of direct parent tag.
=> We can access latest newly parent tag object by using parent() function.

Syntax:
-------

ObjectOfTag.parent();
-------------------------------------------------------------------------------------------------------------
2) children():
---------------
=> This function is used to access the object of direct child of selected tag.
=> We can access the object of any direct child tag by using children() function.

Syntax:
-------
object_of_tag.children("selecter");
Ex: $("#para").children("span");
Ex: $("#para").children("span").eq(0)/each();
-------------------------------------------------------------------------------------------------------------
3) parents():
-------------
=> This function is used to access object of any parent tag i9n parent hierachy of a selected tag.
=> We can access the object a direct parent/grand parent/great grand parent or any other parent by using parents() function.For that we have to pass selector/filter inside parents() function.

Syntax:
-------
ObjectOfTag.parents("selector");
EX: $("#para").parents(".mydv");

=============================================================================================================
// 
1) next():
----------
=> This function is used to get the object of next tag of a selected tag.
=> We can select any next tag by using next() function.For that we have to pass selector/filter inside next() function.

Syntax:
-------
object_of_tag.next("Selector/filter");

2) prev():
----------
=> This function is used to get the object of previous tag of a selected tag.
=> We can read object of any previous tag by using prev() function.For that we have to pass selector/filter inside prev() function.

Syntax:
-------
object_of_tag.prev("selector/filter");
=============================================================================================================
//                                  Effects and Animation in jQuery:
-------------------------------------------------------------------------------------------------------------
=> We can create effects and animation by using jQuery.
=> jQuery library provides function to create some effects and animations in object/tags of a webpages.
=> jQuery provides below function to perform effects and animation.
..........................................................
1)show()
2)hide()
3)toglle()
4)slideUp()
5)slideDown()
6)slideToggle()
7)fadeIn()
8)fadeOut()
9)fadeToggle()
10)animate	
--------------------------------------------------------------------------------------------------------------
// TimeSpan of effects and animation
--------------------------------------------------------------------------------------------------------------
=> We have to pass timespan of effects and animation in above functions.
=> Effects & animation will make some effects in specified timespan.
=> We can specified timespan in below basis-

1) TimeSpan in String Form:
----------------------------
a) slow
b) Normal
c) fast
---------------------------
2) TimeSpan in numeric format:
------------------------------
=> We can pass time in millisecond in above function.
Ex: 1000,3000,8000:
==============================================================================================================
// Category:1
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
1)// show()/fadeIn()/slideDown(): 
---------
=> this function is used to display an object in webpages in specified timespan.
=> this function is used to show the selected object in webpage.

Syntax: 
$(selecter).show(duration);
$(selecter).fadeIn(duration);
$(selecter).slideDown(duration);
Ex:
---
     $("#dv").show("fast");
	 $("#dv").show(5000);
==============================================================================================================
// Category:2
--------------------------------------------------------------------------------------------------------------
2)// hide()/fadeOut()/slideUp(): 
----------
=> That function are used to hide and object in specified timespan.
=> This function is used to hide a selected object from webpage.

syntax: 
$(selecter).hide(duration);
$(selecter).fadeOut(duration);
$(selecter).slideUp(duration);
...................................
Ex:
---
     $(selecter).hide(400);	 
==============================================================================================================
// Category:3	 
--------------------------------------------------------------------------------------------------------------
3)// toggle()/fadeToggle()/slideToggle():
--------------
=> This function is used to hide/show a selected object from webpage.

syntax: 
$(selecter).toggle(duration);
$(selecter).fadeToggle(duration);
$(selecter).slideToggle(duration);
................................
Ex:
---
       $("#btn").toggle("slow");
==============================================================================================================
// Category:4	 	   
------------------------------------------------------------------
10)// animate():
-----------------
=> This function is used to create custom animation in selected object.

Syntax of animate Function:
---------------------------
       $(slecter).animate(style,duration);
............................	   
Ex:
---
      $("#myimg").animate({height:"300px"},2000);	   
================================================================================================================
// jQuery stop() Method
----------------------------------------------------------------------------------------------------------------
The jQuery stop() method is used to stop an animation or effect before it is finished.

The stop() method works for all jQuery effect functions, including sliding, fading and custom animations.

Syntax:
-------
$(selector).stop(stopAll,goToEnd);
=================================================================================================================
//jQuery Callback Functions:
-----------------------------------------------------------------------------------------------------------------
syntax: $(selector).hide(speed,callback);
Ex:
---
$("button").click(function(){
  $("p").hide("slow", function(){
    alert("The paragraph is now hidden");
  });
});
=================================================================================================================
//jQuery Method Chaining:
-----------------------------------------------------------------------------------------------------------------
Syntax:
--------
$("#p1").css("color", "red").slideUp(2000).slideDown(2000);
=================================================================================================================
// jQuery UI :
------------------------------------------------------------------------------------------------------------------
=> jQuery UI stands for "jQuery User InterFace.".
=> jQuery UI is an another library that is developed by jQuery Foundation in year 2007.
=> jQuery UI is a light-weight library for developing modern and intractive web page.
=> jQuery UI library is a collection of various widgets.theames and leyouts that helps to design web page.
=> jQuery UI is an open source,plateform independent library.
=> jQuery UI library works by using features of jQuery core library.Hence it is recommended to use core library of jQuery before using jQuery library.
=> jQuery UI library can be downloaded by using www.jQueryui.com website.