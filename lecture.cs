==================================================================================================================
                                              :AJAX:
==================================================================================================================
=> AJAX stands for Asynchronous JavaScript And XML.
=> AJAX is not a programming language.
=> AJAX allows web pages to be updated Asynchronous by exchanging data with a web server behinds the scenes.
=> AJAX makes possible to updated parts of a web pages without reloading the whole page.
=> AJAX is just a term to describe the process of exchanging data from a web server Asynchronously through 
   JavaScript without refreshing the page.
==================================================================================================================
                                           Creation Of AJAX
==================================================================================================================
=> AJAX is Developed by Microsoft Corporation in March 1999.
=> Google Corporation enchanced the feature of AJAX and started to work in this technology from year 2005.
=> So AJAX in an invention by two big corporation Microsoft and Google.
=> The term AJAX was publicly used on 18 febuary 2005 by Jesse James Garrett.
==================================================================================================================
                                           Working Process Of AJAX
==================================================================================================================
=> To perform AJAX communication JavaScript uses a special object built into the browser-an XMLHttpRequest object
   -to make HTTP requests to the server and receive data in response.
=> All modern browser(Chrome,Firefox,Opera) support the XMLHttpRequest object.   

  
 An event is occured on a web page 
  e.g-a button is clicked. 
                                                               ------------------
      |------------------------|                               |                |
	  | ---------------------- |-------------------------->    ------------------
	  |                        |                                             
	  |                        |                               ------------------
	  |                        |                               |                |
	  |                        |<---------------------------   ------------------
	  |                        |                               ------------------
	  |                        |
	  |------------------------|
           
  
  
==================================================================================================================
                                           Features Of AJAX
==================================================================================================================
=> Cross browser support
=> User friendly
=> It make web page faster
=> Independent of server technology. We can use this with .NET/Java/PHP/Python,etc.
=> Increase the performance of webpages.
=> No need to reload the whole page only some part of page is reloaded which is requared to reload.
-----------------------------------------------------------------------------------------------------------------
                                            Disadvanteg::
-----------------------------------------------------------------------------------------------------------------
=> Without JavaScript AJAX can not be anything.
=> JavaScript can be disabled by user in browser.
==================================================================================================================
                                            AJAX Using jQuery
==================================================================================================================
$.ajax():
---------
=> $.ajax() is a function of jQuery library that is used to perform ajax operations using jQuery library.
=> We can send and recieves data to/from web server by using $.ajax() function.
=> This function is used to updated part of a page without reloading webpages.											
==================================================================================================================
=> jQuery library provides features to perform AJAX operation by using below function.

1) $.get : This function is used to get some data from server by using AJAX.
2) $.post: This function is used to send data (post) data to server using AJAX.
3) $.ajax: This function is used to send data to/from server.

Syntax of $.ajax:
-----------------
$.ajax(object_Of_Properties_with_value);
or
	  $.ajax
	  ({
		  type:"GET/POST",
		  url:"Location_of_Webpage_or_method_of_Server",
		  data:Json.Stringnify(JS_Object),
		  ContentType/dataType:"application/Json; Charset=utf-8",
		  success:function()
		  {
			  //code of handle success call
		  },
		  error:function()
		  {
			  //error to handle fail call
		  }
	  });

Note: UTF-8 stands for Unicode transformation Format.It converts text data into equivalent binary format.
      It uses 8 bits (1 Byte) to store a character.
      
Note: In MVC we have to return response in JSON format from server. for this we have to use return Json()
      inside our action method.