<%-- 
    Document   : newjsp
    Created on : Mar 30, 2016, 11:23:48 AM
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

        <div class="container mregister">
            <div id="register">
                <h1>Register</h1>
                <form name="registerform" id="registerform" action="register.jsp" method="POST">
                    <p>
                        <label for="user_login">Identification<br />
                            <input type="text" name="identification" id="identification" class="input" size="32" value="" /></label>
                    </p>

                    <p>
                        <label for="user_login">Full Name<br />
                            <input type="text" name="fullname" id="fullname" class="input" size="32" value="" /></label>
                    </p>

                    <p>
                        <label for="user_pass">E-mail<br />
                            <input type="email" name="email" id="email" class="input" value="" size="32" /></label>
                    </p>

                    <p>
                        <label for="user_pass">Password<br />
                            <input type="password" name="password" id="password" class="input" value="" size="32" /></label>
                    </p>

                    <p class="submit">
                        <input type="submit" name="register" id="register" class="button" value="register" />
                    </p>

                    <p class="regtext">Do you already have an account? <a href="loginuser.jsp" >Enter here!</a>!</p>
                </form>

            </div>
        </div>

    </body>
</html>
