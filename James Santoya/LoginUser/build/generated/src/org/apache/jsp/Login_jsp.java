package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class Login_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <title>Login</title>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <meta charset=\"utf-8\">\n");
      out.write("        <link href=\"css1/style.css\" rel='stylesheet' type='text/css' />\n");
      out.write("        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
      out.write("        <script type=\"application/x-javascript\"> addEventListener(\"load\", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>\n");
      out.write("        <!--webfonts-->\n");
      out.write("        <link href='http://fonts.googleapis.com/css?family=Open+Sans:600italic,400,300,600,700' rel='stylesheet' type='text/css'>\n");
      out.write("    </head>\n");
      out.write("\n");
      out.write("    <body>\n");
      out.write("\n");
      out.write("        <!-----start-main---->\n");
      out.write("        <div class=\"login-form\">\n");
      out.write("            <h1>Sign In</h1>\n");
      out.write("            <h2><a href=\"#\">Create Account</a></h2>\n");
      out.write("            <form  id=\"form1\"   name=\"form1\"  method=\"POST\" action=\"LoginConexion\">\n");
      out.write("                <li>\n");
      out.write("                    <input type=\"text\" class=\"text\" name=\"usuario\" id=\"Usuario\" value=\"User Name\" onfocus=\"this.value = '';\" onblur=\"if (this.value == '') {\n");
      out.write("                                this.value = 'User Name';\n");
      out.write("                            }\" ><a href=\"#\" class=\" icon user\"></a>\n");
      out.write("                </li>\n");
      out.write("                <li>\n");
      out.write("                    <input type=\"password\" name=\"clave\" id=\"clave\" value=\"Password\" onfocus=\"this.value = '';\" onblur=\"if (this.value == '') {\n");
      out.write("                                this.value = 'Password';\n");
      out.write("                            }\"><a  class=\" icon lock\"></a>\n");
      out.write("                </li>\n");
      out.write("\n");
      out.write("                <div class =\"forgot\">\n");
      out.write("                    <h3><a href=\"#\">Forgot Password?</a></h3>\n");
      out.write("\n");
      out.write("                    <input type=\"submit\"  id=\"animated\" onclick=\"myFunction()\" value=\"Sign In\" > <a href=\"\" class=\" icon arrow\"></a>                                                                                                                                                                                                                                 </h4>\n");
      out.write("                </div>\n");
      out.write("            </form>\n");
      out.write("        </div>\n");
      out.write("        <!--//End-login-form-->\n");
      out.write("        <div class=\"ad728x90\" style=\"text-align:center\">\n");
      out.write("        </div>\n");
      out.write("\n");
      out.write("\n");
      out.write("        <!-----start-copyright---->\n");
      out.write("        <div class=\"copy-right\">\n");
      out.write("            <p><a>James Santoya</a></p> \n");
      out.write("        </div>\n");
      out.write("        <!-----//end-copyright---->\n");
      out.write("\n");
      out.write("    </body>\n");
      out.write("\n");
      out.write("</html>\n");
      out.write("\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
