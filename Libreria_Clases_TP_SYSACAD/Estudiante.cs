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
        private bool _debeCambiarContraseña;
        private List<Curso> _cursosInscriptos;
        private List<ConceptoDePago> _conceptosAPagar = new List<ConceptoDePago>();

        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contrasenia, bool debeCambiarContraseña)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contrasenia = contrasenia;
            _debeCambiarContraseña = debeCambiarContraseña;
            _cursosInscriptos = new List<Curso>();
        }

        //Este metodo se llama desde el forms, tras validar el estudiante, para ingresarlo a la BD.
        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            Sistema.BaseDatosEstudiantes.IngresarUsuarioBD(nuevoEstudiante);
            AñadirConceptosDePagoIniciales();
        }

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

        public string Contrasenia { get { return _contrasenia; } }

        public List<Curso> CursosInscriptos { get { return _cursosInscriptos; } }

        public List<ConceptoDePago> ConceptosDePago { get { return _conceptosAPagar; } }
    }
}
