using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Python.Runtime;
using System.Drawing;


namespace MetodosNumericos
{

    /* Honestamente, todo el codigo de la conexion, lo saque de internet, medianamente lo comprendo
     * pero no sirve de mucho entenderlo, con que sepan que es el puente entre c# y python, esta bien
     */


    /*INSTRUCCIONES DE CONFIGURACION
     * 1. En la linea 57, copiar la ruta de donde se haya guardado el proyecyo en tu computadora
     * 2. Ejecutar (si falla algo mas o no corre bien, me mandan mensajexd
     * */
    public class PythonBridge
    {
        private string _scriptName = "logica_math";
        public PythonBridge()
        {
            // 1. DEFINIR RUTAS ABSOLUTAS 
            // ESTO DE LA RUTA ESTA MUY EXTRAGNO, LO DEJE ASI PARA QUE FUNCIONE EN MI LAP PERO PUEDEN CAMBIARLA PARA QUE FUNCIONE EN LA SUYA, SOLO RECUERDEN
            // QUE DEBEN DE CREAR UN py_VENV en la carpeta del proyecyo, y ahi dentro instalar numpy, matplotlib y sympy gg:
            string rutaProyecto = @"C:\Users\Acer\source\repos\MetodosNumericos";
            string rutaVenv = Path.Combine(rutaProyecto, "py_venv");
            string rutaDll = Path.Combine(rutaVenv, "Scripts", "python311.dll");

            // Validaciones de seguridad para saber que falla (ME AHORRO angos de vida gg)
            if (!Directory.Exists(rutaVenv)) throw new Exception($"No encuentro la carpeta py_venv en: {rutaVenv}");
            if (!File.Exists(rutaDll)) throw new Exception($"No encuentro la DLL en: {rutaDll}");

            // 2. CONFIGURACIÓN DE VARIABLES DE ENTORNO 
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", rutaDll);
            Environment.SetEnvironmentVariable("PYTHONHOME", rutaVenv);
            Environment.SetEnvironmentVariable("PYTHONPATH", $"{Path.Combine(rutaVenv, "Lib")};{Path.Combine(rutaVenv, "Lib", "site-packages")};{Path.Combine(rutaVenv, "DLLs")}");

            // 3. CONFIGURACIÓN DEL MOTOR
            PythonEngine.PythonHome = rutaVenv;
            // Forzamos el Path explícitamente incluyendo site-packages (donde está numpy)
            PythonEngine.PythonPath = $"{Path.Combine(rutaVenv, "Lib\\site-packages")};{Path.Combine(rutaVenv, "Lib")};{Path.Combine(rutaVenv, "DLLs")}";

            // 4. INICIALIZAR
            if (!PythonEngine.IsInitialized)
            {
                try
                {
                    PythonEngine.Initialize();
                }
                catch (Exception ex)
                {
                    // Si falla, el mensaje nos dirá exactamente el pq
                    throw new Exception($"Error fatal al iniciar Python: {ex.Message}");
                }
            }

        }

        public double ObtenerY(string funcion, double x)
        {
            using (Py.GIL()) // Bloqueo de seguridad de Python
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import(_scriptName);

                dynamic resultado = modulo.evaluar_y(funcion, x);

                // Intentamos convertir a double, si falla es porque devolvió texto de error
                try
                {
                    return (double)resultado;
                }
                catch
                {
                    throw new Exception(resultado.ToString());
                }
            }
        }

        public double CalcularDerivada(List<double> xData, List<double> yData, int indice, string metodo, int puntos)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import(_scriptName);


                dynamic resultado = modulo.calcular_derivada(xData, yData, indice, metodo, puntos);

                try
                {
                    return (double)resultado;
                }
                catch
                {
                    throw new Exception(resultado.ToString());
                }
            }
        }

        public double CalcularDerivadaNewton(List<double> lx, List<double> ly, double xInt)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.derivar_interpolacion_newton(lx, ly, xInt);

                try { return (double)res; }
                catch { throw new Exception(res.ToString()); }
            }
        }

        /*TODA LA FUNCION SIGUIENTE fue sacada de internet, su funcionamiento 
        ya se explico en el archivo logica_math.py, en la linea 172 */
        public Image ObtenerGraficaNewton(List<double> lx, List<double> ly, double xInt)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic pyResultado = modulo.generar_grafica_newton_bytes(lx, ly, xInt);

                if (pyResultado == null) throw new Exception("Python devolvió nulo.");

                byte[] netBytes = (byte[])pyResultado;

                // --- VALIDACIÓN DE ERROR ---
                // Si los bytes empiezan con "ERROR_PY:", es que falló y nos mandó texto.
                // Leemos los primeros 20 caracteres para verificar.
                try
                {
                    string posibleTexto = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (posibleTexto.StartsWith("ERROR_PY:"))
                    {
                        throw new Exception(posibleTexto);
                    }
                }
                catch (ArgumentException)
                {
                  
                }
                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }


    }
}
