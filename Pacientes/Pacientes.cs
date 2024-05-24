using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes
{
    internal class Pacientes
    {
        #region Propiedades y atributos
        private int id;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int idSexo;
        private int dni;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public int IdSexo
        {
            get { return idSexo; }
            set{ idSexo = value;}
        }
        public int Dni
        {
            get { return dni; }
            set
            {
                dni = value;
            }
        }
        #endregion

        public Pacientes() { }

        public Pacientes(string pNombre, string pApellido, DateTime pFechaNacimiento, int  pIdSexo,int pDni)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNacimiento= pFechaNacimiento;
            IdSexo = pIdSexo;
            Dni = pDni;
        }

        public bool Nuevo()
        {
            bool correcto;
            string consulta = $"INSERT INTO Pacientes (Nombre,Apellido,FechaNacimiento,IdSexo,Dni)" +
                $" VALUES ('{Nombre}', '{Apellido}', '{FechaNacimiento}',{idSexo}, {Dni} ) ";
            correcto = BaseDatos.EjecutarConsulta(consulta);
            return correcto;
        }
        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT Pacientes.id AS IdPaciente, Pacientes.Apellido, Pacientes.FechaNacimiento, Pacientes.IdSexo, Pacientes.Dni, " +
                $"Sexos.Id AS IdSexo, Sexos.Descripcion AS Sexo FROM Pacientes INNER JOIN Sexos ON Pacientes.IdSexo= Sexos.Id";
            dt = BaseDatos.Buscar(consulta);
            return dt;
        }
    }
}
