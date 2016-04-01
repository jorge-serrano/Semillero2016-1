<%-- 
    Document   : logout
    Created on : Mar 31, 2016, 5:22:20 PM
    Author     : Yuxi
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
session.invalidate();
 response.sendRedirect("index2.jsp");
%>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Home</title>
    </head>
    <body>
       
    </body>
</html>
