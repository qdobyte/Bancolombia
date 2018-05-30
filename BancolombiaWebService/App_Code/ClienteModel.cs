using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de ClienteModel
/// </summary>
public class ClienteModel
{
    public string Error = null;
    public string IdCliente;
    public string Cedula;
    public string Nombre;
    public string Direccion;
    public int Ingresos;
    public int Egresos;
    public int Pasivos;
    public int Scoring;

    private ConexionSQL conexionSQL = null;
    private SqlCommand sqlCommand;
    public ClienteModel()
    {
        this.conexionSQL = new ConexionSQL();
        this.sqlCommand = new SqlCommand();
    }

    public List<ClienteModel> ListarClientes()
    {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "listarClientes";

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;
        List<ClienteModel> lista = new List<ClienteModel> { };
        if (consultaExitosa)
        {
            if (conexionSQL.data.Rows.Count > 0)
            {
                foreach (DataRow row in conexionSQL.data.Rows)
                {
                    lista.Add(new ClienteModel() {
                        IdCliente = row["id_cliente"].ToString(),
                        Cedula = row["cedula"].ToString(),
                        Nombre = row["nombre"].ToString(),
                        Direccion = row["direccion"].ToString(),
                        Ingresos = Int32.Parse(row["ingresos"].ToString()),
                        Egresos = Int32.Parse(row["egresos"].ToString()),
                        Pasivos = Int32.Parse(row["pasivos"].ToString()),
                        Scoring = Int32.Parse(row["scoring"].ToString()),
                    });
                }
            }
            else
            {
                lista.Add(new ClienteModel() { Error = "No hay clientes en la base de datos" });
            }
        }
        else
        {
            lista.Add(new ClienteModel() { Error = conexionSQL.ErrorMessage });
        }
        return lista;
    }

    public bool ConsultarCliente(string cedula) {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "consultarCliente";
        sqlCommand.Parameters.AddWithValue("@Cedula", cedula);

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;

        if (consultaExitosa)
        {
            if (conexionSQL.data.Rows.Count > 0)
            {
                foreach (DataRow row in conexionSQL.data.Rows)
                {
                    this.IdCliente = row["id_cliente"].ToString();
                    this.Cedula = row["cedula"].ToString();
                    this.Nombre = row["nombre"].ToString();
                    this.Direccion = row["direccion"].ToString();
                    this.Ingresos = Int32.Parse(row["ingresos"].ToString());
                    this.Egresos = Int32.Parse(row["egresos"].ToString());
                    this.Pasivos = Int32.Parse(row["pasivos"].ToString());
                    this.Scoring = Int32.Parse(row["scoring"].ToString());
                }
                return true;
            }
            else
            {
                this.Error = "No se encontro cliente en la base de datos";
                return false;
            }
        }
        else
        {
            this.Error = conexionSQL.ErrorMessage;
            return false;
        }
    }

    public bool EliminarCliente(int idCliente)
    {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "eliminarCliente";
        sqlCommand.Parameters.AddWithValue("@IdCliente", idCliente);

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;

        if (consultaExitosa)
        {
            return true;
        }
        else
        {
            this.Error = conexionSQL.ErrorMessage;
            return false;
        }
    }

    public bool InsertarCliente(string cedula, string nombre, string direccion ,int ingresos, string egresos,
	    int pasivos, int scoring)
    {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "insertarCliente";
        sqlCommand.Parameters.AddWithValue("@Cedula", cedula);
        sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
        sqlCommand.Parameters.AddWithValue("@Direccion", direccion);
        sqlCommand.Parameters.AddWithValue("@Ingresos", ingresos);
        sqlCommand.Parameters.AddWithValue("@Egresos", egresos);
        sqlCommand.Parameters.AddWithValue("@Pasivos", pasivos);
        sqlCommand.Parameters.AddWithValue("@Scoring", scoring);

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;

        if (consultaExitosa)
        {
            return true;
        }
        else
        {
            this.Error = conexionSQL.ErrorMessage;
            return false;
        }
    }

    public bool ModificarCliente(int idCliente, string cedula, string nombre, string direccion, int ingresos, string egresos,
        int pasivos, int scoring)
    {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "modificarCliente";
        sqlCommand.Parameters.AddWithValue("@IdCliente", idCliente);
        sqlCommand.Parameters.AddWithValue("@Cedula", cedula);
        sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
        sqlCommand.Parameters.AddWithValue("@Direccion", direccion);
        sqlCommand.Parameters.AddWithValue("@Ingresos", ingresos);
        sqlCommand.Parameters.AddWithValue("@Egresos", egresos);
        sqlCommand.Parameters.AddWithValue("@Pasivos", pasivos);
        sqlCommand.Parameters.AddWithValue("@Scoring", scoring);

        bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
        sqlCommand = null;

        if (consultaExitosa)
        {
            return true;
        }
        else
        {
            this.Error = conexionSQL.ErrorMessage;
            return false;
        }
    }

    public string ValidarViabilidadDeCredito(string cedula) {
        this.ConsultarCliente(cedula);
        if (this.Error == null)
        {
            if (this.Scoring >= 400)
            {
                if ((this.Ingresos - this.Egresos) > 0)
                {
                    float ratio = (float)this.Egresos / (float)this.Ingresos;
                    int capacidadDeEndeudamiento = (int)(100 - (ratio * 100));
                    if (capacidadDeEndeudamiento >= 20)
                    {
                        if (this.Pasivos < (this.Ingresos * 15))
                        {
                            return "aprobado";
                        }
                        else
                        {
                            return "mayor15vecesSalario";
                        }

                    }
                    else
                    {
                        return "capacidadEndeudamiento";
                    }

                }
                else
                {
                    return "flujoCajaNegativo";
                }

            }
            else
            {
                return "scoring";
            }
        }
        else {
            return this.Error;
        }
        
    }


}