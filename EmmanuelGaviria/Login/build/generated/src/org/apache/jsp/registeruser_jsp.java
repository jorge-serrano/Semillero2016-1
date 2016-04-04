package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.sql.PreparedStatement;
import java.sql.DriverManager;
import java.sql.Connection;

public final class registeruser_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <title>JSP Page</title>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("\n");
      out.write("        <div class=\"container mregister\">\n");
      out.write("            <div id=\"register\">\n");
      out.write("                <h1>Register</h1>\n");
      out.write("                <form name=\"registerform\" id=\"registerform\" action=\"register.jsp\" method=\"POST\">\n");
      out.write("                    <p>\n");
      out.write("                        <label for=\"user_login\">Identification<br />\n");
      out.write("                            <input type=\"text\" name=\"identification\" id=\"identification\" class=\"input\" size=\"32\" value=\"\" /></label>\n");
      out.write("                    </p>\n");
      out.write("\n");
      out.write("                    <p>\n");
      out.write("                        <label for=\"user_login\">Full Name<br />\n");
      out.write("                            <input type=\"text\" name=\"fullname\" id=\"fullname\" class=\"input\" size=\"32\" value=\"\" /></label>\n");
      out.write("                    </p>\n");
      out.write("\n");
      out.write("                    <p>\n");
      out.write("                        <label for=\"user_pass\">E-mail<br />\n");
      out.write("                            <input type=\"email\" name=\"email\" id=\"email\" class=\"input\" value=\"\" size=\"32\" /></label>\n");
      out.write("                    </p>\n");
      out.write("\n");
      out.write("                    <p>\n");
      out.write("                        <label for=\"user_pass\">Password<br />\n");
      out.write("                            <input type=\"password\" name=\"password\" id=\"password\" class=\"input\" value=\"\" size=\"32\" /></label>\n");
      out.write("                    </p>\n");
      out.write("\n");
      out.write("                    <p class=\"submit\">\n");
      out.write("                        <input type=\"submit\" name=\"register\" id=\"register\" class=\"button\" value=\"register\" />\n");
      out.write("                    </p>\n");
      out.write("\n");
      out.write("                    <p class=\"regtext\">Do you already have an account? <a href=\"loginuser.jsp\" >Enter here!</a>!</p>\n");
      out.write("                </form>\n");
      out.write("\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("\n");
      out.write("    </body>\n");
      out.write("</html>\n");
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
