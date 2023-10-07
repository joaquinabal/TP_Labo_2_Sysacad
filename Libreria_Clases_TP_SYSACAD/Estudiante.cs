using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Estudiante
    {
        //Atributos del estudiante
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contrasenia;
        private Guid _identificadorUnico;
        private bool _debeCambiarContrasenia;
        private List<Curso> _cursosInscriptos;
        private List<ConceptoDePago> _conceptosAPagar = new List<ConceptoDePago>();

        /// <summary>
        /// Constructor de la clase Estudiante.
        /// Inicializa los atributos del estudiante.
        /// </summary>
        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contrasenia, bool debeCambiarContrasenia)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contrasenia = contrasenia;
            _debeCambiarContrasenia = debeCambiarContrasenia;
            _cursosInscriptos = new List<Curso>();
        }

        /// <summary>
        /// Registra un nuevo estudiante en la base de datos.
        /// </summary>
        /// <param name="nuevoEstudiante">El estudiante a ser registrado.</param>
        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            Sistema.BaseDatosEstudiantes.IngresarUsuarioBD(nuevoEstudiante);
            AñadirConceptosDePagoIniciales();
        }

        /// <summary>
        /// Añade conceptos de pago iniciales al estudiante.
        /// </summary>
        public void AñadirConceptosDePagoIniciales()
        {
            ConceptoDePago matriculaIngreso = new ConceptoDePago("Matricula de Ingreso", 20000, 20000);
            ConceptoDePago primerCuatrimestre = new ConceptoDePago("Matricula del Primer Cuatrimestre", 15000, 15000);
            ConceptoDePago cargosAdministrativosPrimerCuatrimestre = new ConceptoDePago("Cargos Administrativos primer cuatrimestre", 5000, 5000);
            ConceptoDePago BibliografiaPrimerCuatrimestre = new ConceptoDePago("Bibliografia Primer Cuatrimestre", 5000, 5000);

            _conceptosAPagar.Add(matriculaIngreso);
            _conceptosAPagar.Add(primerCuatrimestre);
            _conceptosAPagar.Add(cargosAdministrativosPrimerCuatrimestre);
            _conceptosAPagar.Add(BibliografiaPrimerCuatrimestre);
        }

        /// <summary>
        /// Actualiza los conceptos de pago del estudiante en base a los pagos realizados.
        /// </summary>
        /// <param name="listaConceptosPagados">La lista de conceptos pagados con sus montos.</param>
        public void ActualizarConceptosDePago(Dictionary<string, double> listaConceptosPagados)
        {
            foreach (ConceptoDePago concepto in _conceptosAPagar)
            {
                foreach (var conceptoPagado in listaConceptosPagados)
                {
                    if (conceptoPagado.Key == concepto.Nombre)
                    {
                        concepto.MontoPendiente -= conceptoPagado.Value; 
                    }
                }
            }
        }

        //Getters y Setters
        public string Legajo { get { return _legajo; } }

        public string Correo { get { return _correo; } }

        public Guid IdentificadorUnico { get{ return _identificadorUnico; } set{ _identificadorUnico = value; } }

        public string Nombre { get { return _nombre; } }

        public string Direccion { get { return _direccion; } }

        public string NumeroTelefono { get { return _numeroTelefono; } }

        public string Contrasenia { get { return _contrasenia; } set { _contrasenia = value; } }

        public List<Curso> CursosInscriptos { get { return _cursosInscriptos; } }

        public bool DebeCambiarContrasenia { get { return _debeCambiarContrasenia; } set { _debeCambiarContrasenia = value; } }

        public List<ConceptoDePago> ConceptosDePago { get { return _conceptosAPagar; } }
    }
}
