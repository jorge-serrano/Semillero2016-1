package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import beans.connectedDB;
import java.sql.ResultSet;
import com.microsoft.sqlserver.jdbc.SQLServerException;
import java.sql.SQLException;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.Connection;

public final class register_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      beans.connectedDB beans = null;
      synchronized (_jspx_page_context) {
        beans = (beans.connectedDB) _jspx_page_context.getAttribute("beans", PageContext.PAGE_SCOPE);
        if (beans == null){
          beans = new beans.connectedDB();
          _jspx_page_context.setAttribute("beans", beans, PageContext.PAGE_SCOPE);
          out.write('\n');
          org.apache.jasper.runtime.JspRuntimeLibrary.introspect(_jspx_page_context.findAttribute("beans"), request);
          out.write('\n');
        }
      }
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <title>JSP Page</title>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        ");

            Connection con=null;
            String register = request.getParameter("register");

            if (register != null && request.getMethod().equalsIgnoreCase("POST")) {
                String i = request.getParameter("identification");
                String f = request.getParameter("fullname");
                String e = request.getParameter("email");
                String p = request.getParameter("password");

                try {
                    beans.getConnection();
                    PreparedStatement ps = con.prepareStatement("{call RegisterUserLogin(?,?,?,?)}");
                    ps.setString(1, i);
                    ps.setString(2, f);
                    ps.setString(3, e);
                    ps.setString(4, p);
                    boolean c = ps.execute();

                    if (c == false) {
                        response.sendRedirect("loginuser.jsp?msg=Thank_You_for_registering!");   
                    } else {
                        response.sendRedirect("registeruser.jsp?msg=Insertion_Failed!!_Please_try_again!!! ");
                    }
                    con.close();
                } catch (Exception ex) {
                    out.println(ex);
                } finally {
                }
            }
        
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
