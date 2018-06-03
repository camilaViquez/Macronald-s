using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
//acceso a base de datos
using System.Data.SqlClient;


/// <summary>
/// Descripción breve de BD
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class BD : System.Web.Services.WebService
{

    public BD()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }

    //Metodo para la coneccion con nustra base de datos
    [WebMethod]
    public DataSet GetData()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=LAPTOP-MKRNOBFU; Initial Catalog=Macronals_DB; Integrated Security=True;";
        SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Persona", con);
        //para recibir/mostrar datos de consulta
        DataSet dataSet = new DataSet();
        adaptador.Fill(dataSet);
        return dataSet;

    }


}
