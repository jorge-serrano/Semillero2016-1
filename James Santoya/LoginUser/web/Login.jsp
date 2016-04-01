
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <title>Login</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta charset="utf-8">
        <link href="css1/style.css" rel='stylesheet' type='text/css' />
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <!--webfonts-->
        <link href='http://fonts.googleapis.com/css?family=Open+Sans:600italic,400,300,600,700' rel='stylesheet' type='text/css'>
    </head>

    <body>

        <!-----start-main---->
        <div class="login-form">
            <h1>Sign In</h1>
            <h2><a href="#">Create Account</a></h2>
            <form  id="form1"   name="form1"  method="POST" action="LoginConexion">
                <li>
                    <input type="text" class="text" name="usuario" id="Usuario" value="User Name" onfocus="this.value = '';" onblur="if (this.value == '') {
                                this.value = 'User Name';
                            }" ><a href="#" class=" icon user"></a>
                </li>
                <li>
                    <input type="password" name="clave" id="clave" value="Password" onfocus="this.value = '';" onblur="if (this.value == '') {
                                this.value = 'Password';
                            }"><a  class=" icon lock"></a>
                </li>

                <div class ="forgot">
                    <h3><a href="#">Forgot Password?</a></h3>

                    <input type="submit"  id="animated" onclick="myFunction()" value="Sign In" > <a href="" class=" icon arrow"></a>                                                                                                                                                                                                                                 </h4>
                </div>
            </form>
        </div>
        <!--//End-login-form-->
        <div class="ad728x90" style="text-align:center">
        </div>


        <!-----start-copyright---->
        <div class="copy-right">
            <p><a>James Santoya</a></p> 
        </div>
        <!-----//end-copyright---->

    </body>

</html>

