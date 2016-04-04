<%-- 
    Document   : login
    Created on : Mar 30, 2016, 2:38:40 PM
    Author     : emmanuel.gaviria
--%>

<%@page import="java.sql.PreparedStatement"%>
<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.Connection"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>

        <div class="container mlogin">
            <div id="login">
                <h1>Login</h1>
                <form name="loginform" id="loginform" action="login.jsp" method="POST">
                    <p>
                        <label for="user_login">E-mail<br />
                            <input type="text" name="email" id="email" class="input" value="" size="20" /></label>
                    </p>
                    <p>
                        <label for="user_pass">Password<br />
                            <input type="password" name="password" id="password" class="input" value="" size="20" /></label>
                    </p>
                    <p class="submit">
                        <input type="submit" name="login" class="button" value="Enter" />
                        <input type="hidden" name="form1Trigger" value="" />
                    </p>
                    <p class="regtext">it's not registered? <a href="registeruser.jsp" >Register Here</a>!</p>
                </form>
            </div>
        </div>
    </body>
</html>
