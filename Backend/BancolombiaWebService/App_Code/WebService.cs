﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    #region Client Methods

    [WebMethod]
    public List<ClienteModel> ListarClientes()
    {
        ClienteModel clienteModelo = new ClienteModel();
        return clienteModelo.ListarClientes();
    }


    [WebMethod]
    public string ConsultarCliente(string cedula)
    {
        ClienteModel clienteModelo = new ClienteModel();
        clienteModelo.ConsultarCliente(cedula);
        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(clienteModelo);
    }

    [WebMethod]
    public string EliminarCliente(string cedula)
    {
        ClienteModel clienteModelo = new ClienteModel();
        if (clienteModelo.EliminarCliente(cedula))
        {
            return "Se elimino el cliente";
        }
        else
        {
            return clienteModelo.Error;
        }
    }

    [WebMethod]
    public string InsertarCliente(string cedula, string nombre, string direccion, int ingresos, int egresos,
        int pasivos, int scoring)
    {
        ClienteModel clienteModelo = new ClienteModel();
        if (clienteModelo.InsertarCliente(cedula, nombre, direccion, ingresos, egresos, pasivos,scoring))
        {
            return "Cliente insertado correctamente";
        }
        else
        {
            return clienteModelo.Error;
        }
    }

    [WebMethod]
    public string ModificarCliente(int idCliente, string cedula, string nombre, string direccion, int ingresos, string egresos,
        int pasivos, int scoring)
    {
        ClienteModel clienteModelo = new ClienteModel();
        if (clienteModelo.ModificarCliente(idCliente, cedula, nombre, direccion, ingresos, egresos, pasivos, scoring))
        {
            return "Cliente modificado correctamente";
        }
        else
        {
            return clienteModelo.Error;
        }
    }

    [WebMethod]
    public string ValidarViabilidadCredito(string cedula)
    {
        ClienteModel clienteModel = new ClienteModel();
        return clienteModel.ValidarViabilidadDeCredito(cedula);
    }
    #endregion

    #region Credit Methods
    [WebMethod]
    public string InsertarCredito(string producto, int plazo, int monto, string cedula)
    {
        CreditosModel creditoModel = new CreditosModel();
        if (creditoModel.InsertarCredito(producto, plazo, monto, cedula))
        {
            return "creado";
        }
        else {
            return creditoModel.Error;
        }
    }

    [WebMethod]
    public string ConsultarProductosPorCliente(string cedula) {
        CreditosModel creditosModel = new CreditosModel();
        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(creditosModel.ConsultarProductosPorCliente(cedula));
    }
    #endregion
}
