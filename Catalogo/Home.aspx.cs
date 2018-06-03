using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Consumo del web service
        WebServiceDB.BDSoapClient webService = new WebServiceDB.BDSoapClient();
        DataSet dataSet = webService.GetData();
        GridView1.DataSource = dataSet.Tables[0];
        GridView1.DataBind();
    }



    //Dejar esto aca no quitar
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}