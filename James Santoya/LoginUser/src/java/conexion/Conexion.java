/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package conexion;

import java.sql.Connection;
import java.sql.DriverManager;
import jdk.nashorn.internal.ir.TryNode;

/**
 *
 * @author Yuxi
 */
public class Conexion {
   
    public static Connection conectar(){
     Connection con=null;
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con= DriverManager.getConnection("jdbc:sqlserver://PRACT-JAMESS\\SQLEXPRESS:1433;databaseName=Login","jamesbd","1234");
        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
    return con;
    }
    

}
