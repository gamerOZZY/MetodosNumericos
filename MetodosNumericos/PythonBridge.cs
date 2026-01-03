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
     * 1. En la linea 31, copiar la ruta de donde se haya guardado el proyecyo en tu computadora
     * 2. Ejecutar (si falla algo mas o no corre bien, me mandan mensajexd
     * */

    /*ACTUALIZACION, YA FUNCIONA TODO Y YA NO HAY QUE MOVER LA RUTA, HONESTAMENTE LE PEDI A
     * GEMINI QUE ME AYUDARA A QUITAR LAS RUTAS ABSOLUTAS Y LAS HICIERA DINAMICAS PUESTO QUE 
     * SOLO CORRIA EN MI PC EL PUENTE PERO AHORA YA DEBERIA DE CORRER EN TODOS LADOS. 
     * PRUEBENLO Y ME AVISAN
     */

    public class PythonBridge
    {
        private string _scriptName = "logica_math";
        public PythonBridge()
        {
            // 1. DEFINIR RUTAS DINÁMICAS (EL FIX)
            // Obtenemos dónde está corriendo el .exe (usualmente bin/Debug/net...)
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Buscamos la carpeta py_venv hacia "arriba" (saliendo de bin/Debug...)
            string rutaProyecto = BuscarCarpetaHaciaArriba(directorioBase, "py_venv");

            if (string.IsNullOrEmpty(rutaProyecto))
            {
                // Si no la encuentra buscando hacia arriba, asumimos que estamos en la raíz o es un deploy
                rutaProyecto = directorioBase;
            }

            // OJO: 'rutaProyecto' ahora es la carpeta que CONTIENE a py_venv
            string rutaVenv = Path.Combine(rutaProyecto, "py_venv");

            // Nota: Asegúrate que el nombre de la DLL coincida con la versión de Python instalada en el venv
            string rutaDll = Path.Combine(rutaVenv, "Scripts", "python311.dll");

            // Validaciones (Salvan vidas)
            if (!Directory.Exists(rutaVenv))
                throw new Exception($"No encuentro la carpeta 'py_venv'. Busqué hasta: {rutaProyecto}");

            if (!File.Exists(rutaDll))
                throw new Exception($"No encuentro la DLL de Python en: {rutaDll}. ¿Crearon el venv correctamente?");

            // 2. CONFIGURACIÓN DE VARIABLES DE ENTORNO 
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", rutaDll);
            Environment.SetEnvironmentVariable("PYTHONHOME", rutaVenv);
            // Agregamos DLLs, Lib y site-packages al path
            Environment.SetEnvironmentVariable("PYTHONPATH",
                $"{Path.Combine(rutaVenv, "Lib")};" +
                $"{Path.Combine(rutaVenv, "Lib", "site-packages")};" +
                $"{Path.Combine(rutaVenv, "DLLs")}");

            // 3. CONFIGURACIÓN DEL MOTOR
            PythonEngine.PythonHome = rutaVenv;
            PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH");

            // 4. INICIALIZAR
            if (!PythonEngine.IsInitialized)
            {
                try
                {
                    PythonEngine.Initialize();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fatal al iniciar Python: {ex.Message} \nStack: {ex.StackTrace}");
                }
            }
        }

        // MÉTODO AUXILIAR 
        private string BuscarCarpetaHaciaArriba(string rutaInicial, string carpetaBuscada)
        {
            DirectoryInfo directorio = new DirectoryInfo(rutaInicial);

            while (directorio != null)
            {
                string rutaPosible = Path.Combine(directorio.FullName, carpetaBuscada);
                if (Directory.Exists(rutaPosible))
                {
                    return directorio.FullName; // Encontró la raíz donde vive py_venv
                }
                directorio = directorio.Parent; // Sube un nivel
            }
            return null; // No encontró nada
        }

        // =================================== ECUACIONES DE UNA VARIABLE ===========================================//
        public List<List<double>> CalcularBiseccion(string funcion, double a, double b, double tol, int maxIter)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.metodo_biseccion(funcion, a, b, tol, maxIter);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                List<List<double>> matriz = new List<List<double>>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];


                    for (int j = 0; j < 8; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }

        public List<List<double>> CalcularNewtonRaphson(string funcion, double p0, double tol, int maxIter)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.metodo_newton_raphson(funcion, p0, tol, maxIter);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                List<List<double>> matriz = new List<List<double>>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];

                    for (int j = 0; j < 4; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }

        public List<List<double>> CalcularFalsaPosicion(string funcion, double a, double b, double tol, int maxIter)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");


                dynamic res = modulo.metodo_falsa_posicion(funcion, a, b, tol, maxIter);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                List<List<double>> matriz = new List<List<double>>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];


                    for (int j = 0; j < 8; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }

        public List<List<double>> CalcularSecante(string funcion, double p0, double p1, double tol, int maxIter)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.metodo_secante(funcion, p0, p1, tol, maxIter);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                List<List<double>> matriz = new List<List<double>>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];

                    for (int j = 0; j < 6; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }
        public List<List<double>> CalcularPuntoFijo(string g_funcion, double p0, double tol, int maxIter)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");


                dynamic res = modulo.metodo_punto_fijo(g_funcion, p0, tol, maxIter);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                List<List<double>> matriz = new List<List<double>>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];

                    for (int j = 0; j < 4; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
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
        ya se explico en el archivo logica_math.py, en la linea 392 */
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


        /* Devuelve una lista de listas de doubles (List<List<double>>)
         * se eligio que devolviera una lista de listas ya que pythonnet convierte listas de c
         * en listas de python y viceversa, entonces es mas facil trabajar con ellas gg
         */

        public List<List<double>> CalcularRichardson(string funcion, double x, double h, int niveles)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Llamamos a Python
                dynamic resultado = modulo.extrapolacion_richardson(funcion, x, h, niveles);

                // Verificamos si es string (error)
                if (resultado.ToString().StartsWith("Error"))
                {
                    throw new Exception(resultado.ToString());
                }

                /* --- CONVERSIÓN MANUAL DE LISTA PYTHON A C# --- ASIES ya se que dijeron q era mas facil
               dejar que pythonnet hiciera la conversion solo, pero en algun momento de la creacion d
                la funcion, semenolvido y decidi hacerlo manual klsd;kljasdj;sad 
                */

                List<List<double>> matriz = new List<List<double>>();

                int lenFilas = (int)resultado.__len__(); // Tamaño de la lista principal

                for (int i = 0; i < lenFilas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = resultado[i]; // Obtenemos la sub-lista
                    int lenCols = (int)filaPy.__len__();

                    for (int j = 0; j < lenCols; j++)
                    {
                        double valor = (double)filaPy[j];
                        fila.Add(valor);
                    }
                    matriz.Add(fila);
                }

                return matriz;
            }
        }

        public List<List<double>> ObtenerTablaDiferencias(List<double> lx, List<double> ly)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.obtener_tabla_diferencias(lx, ly);
                string posibleError = res.ToString();
                if (posibleError.StartsWith("Error"))
                {
                    throw new Exception("Python falló: " + posibleError);
                }

                // Convertir matriz de Python a C#
                List<List<double>> matriz = new List<List<double>>();
                int n = (int)res.__len__();

                for (int i = 0; i < n; i++)
                {
                    List<double> fila = new List<double>();
                    for (int j = 0; j < n; j++)
                    {
                        fila.Add((double)res[i][j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }

        // Obtener el Polinomio como Texto
        public string ObtenerPolinomioTexto(List<double> lx, List<double> ly, string tipo)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // "adelante" o "atras" (deben coincidir con el if de Python)
                //FUN FACT, ESTA SOLA LINEA DE CODIGO FALLO MUCHISIMAS, MUCHISIMAS VECES, NO SE QUE MOVI EN EL 
                //CODIGO PY Y POR ALGUNA RAZON FUNCIONO XASJD;KLASHJD;KLASHDKLASHDLSADH;KL
                dynamic res = modulo.obtener_polinomio_texto(lx, ly, tipo);

                return res.ToString();
            }
        }


        public List<List<double>> CalcularNeville(List<double> lx, List<double> ly, double xInt)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.metodo_neville(lx, ly, xInt);

                // Validación de error de texto
                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                // Conversión manual de matriz Python a C#
                List<List<double>> matriz = new List<List<double>>();
                int n = (int)res.__len__();

                for (int i = 0; i < n; i++)
                {
                    List<double> fila = new List<double>();
                    // En Neville, la fila i tiene i+1 elementos válidos, pero la matriz es nxn
                    // Convertimos toda la fila
                    for (int j = 0; j < n; j++)
                    {
                        fila.Add((double)res[i][j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }


        public double CalcularLagrange(List<double> lx, List<double> ly, double xInt)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");
                dynamic res = modulo.evaluar_lagrange(lx, ly, xInt);

                try { return (double)res; }
                catch { throw new Exception(res.ToString()); }
            }
        }

        // 2. Obtener Ecuación (Texto)
        public string ObtenerTextoLagrange(List<double> lx, List<double> ly)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");
                dynamic res = modulo.obtener_texto_lagrange(lx, ly);
                return res.ToString();
            }
        }

        // 3. Obtener Gráfica Específica de Lagrange
        public Image ObtenerGraficaLagrange(List<double> lx, List<double> ly, double xInt)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");
                dynamic res = modulo.generar_grafica_lagrange_bytes(lx, ly, xInt);

                if (res == null) throw new Exception("Error gráfico nulo");

                byte[] netBytes = (byte[])res;

                // Validar error texto
                try
                {
                    string txt = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (txt.StartsWith("ERROR_PY:")) throw new Exception(txt);
                }
                catch (ArgumentException) { }

                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        public double CalcularIntegral(List<double> ly, double h, string metodo)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = null;

                if (metodo == "Trapecio") res = modulo.integrar_trapecio_compuesto(ly, h);
                else if (metodo == "Simpson 1/3") res = modulo.integrar_simpson13_compuesto(ly, h);
                else if (metodo == "Simpson 3/8") res = modulo.integrar_simpson38_compuesto(ly, h);

                if (res == null) throw new Exception("Método no reconocido");

                // Manejo de errores de texto, (realemte no se pq lo puse si en ningun momento dio error
                // pero a este punto, todo se sostiane a base de try-catch y throw-Eceptions, entonces es lo
                // que hayxd)
                string resStr = res.ToString();
                if (resStr.StartsWith("Error")) throw new Exception(resStr);

                return (double)res;
            }
        }


        public Image ObtenerGraficaIntegracion(List<double> lx, List<double> ly, string nombreMetodo, string funcion)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");


                dynamic res = modulo.generar_grafica_integracion(lx, ly, nombreMetodo, funcion);

                byte[] netBytes = (byte[])res;
                try
                {
                    string txt = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (txt.StartsWith("ERROR_PY:")) throw new Exception(txt);
                }
                catch (ArgumentException) { }

                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        /* ==================================== CUADRATURA ADAPTIVA ================================ */
        public class ResultadoAdaptativo
        {
            public double Area { get; set; }
            public List<double> PuntosCorte { get; set; }
        }
        public ResultadoAdaptativo CalcularAdaptativa(string funcion, double a, double b, double tol)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Llamada a Python: retorna tupla (CREO XDDDDDDDDDDDDDDDDASJHDJALSDHLJAKHSDLJAS)
                dynamic res = modulo.integrar_adaptativa_simpson(funcion, a, b, tol);

                // Validación de error (si el primer elemento es string)
                dynamic primerElemento = res[0];
                if (primerElemento.ToString().StartsWith("Error"))
                {
                    throw new Exception(primerElemento.ToString());
                }

                // Convertir resultado
                double area = (double)res[0];
                dynamic listaPy = res[1];

                List<double> puntos = new List<double>();
                int len = (int)listaPy.__len__();
                for (int i = 0; i < len; i++)
                {
                    puntos.Add((double)listaPy[i]);
                }

                return new ResultadoAdaptativo { Area = area, PuntosCorte = puntos };
            }
        }

        // Método Gráfica Adaptativa
        public Image ObtenerGraficaAdaptativa(string funcion, List<double> puntosCorte)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.generar_grafica_adaptativa(funcion, puntosCorte);

                byte[] netBytes = (byte[])res;
                try
                {
                    string txt = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (txt.StartsWith("ERROR_PY:")) throw new Exception(txt);
                }
                catch (ArgumentException) { }

                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        /* ========================================== CUADRATURA GAUSSIANA ==================================== */
        public double CalcularGauss(string funcion, double a, double b, int nPuntos)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.integrar_gauss(funcion, a, b, nPuntos);

                string resStr = res.ToString();
                if (resStr.StartsWith("Error")) throw new Exception(resStr);

                return (double)res;
            }
        }

        // Método Gráfica Gauss
        public Image ObtenerGraficaGauss(string funcion, double a, double b, int nPuntos)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.generar_grafica_gauss(funcion, a, b, nPuntos);

                byte[] netBytes = (byte[])res;
                try
                {
                    string txt = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (txt.StartsWith("ERROR_PY:")) throw new Exception(txt);
                }
                catch (ArgumentException) { }

                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        // =============================================== EXTRAPOLACION DE ROMBERG =====================================
        public List<List<double>> CalcularRomberg(string funcion, double a, double b, int niveles)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.integracion_romberg(funcion, a, b, niveles);

                if (res.ToString().StartsWith("Error")) throw new Exception(res.ToString());

                // Convertir matriz a List<List<double>>
                List<List<double>> matriz = new List<List<double>>();
                int n = (int)res.__len__();

                for (int i = 0; i < n; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic filaPy = res[i];
                    int m = (int)filaPy.__len__();
                    for (int j = 0; j < m; j++)
                    {
                        fila.Add((double)filaPy[j]);
                    }
                    matriz.Add(fila);
                }
                return matriz;
            }
        }

        public Image ObtenerGraficaRomberg(string funcion, double a, double b)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.generar_grafica_romberg(funcion, a, b);

                byte[] netBytes = (byte[])res;
                try
                {
                    string txt = System.Text.Encoding.UTF8.GetString(netBytes);
                    if (txt.StartsWith("ERROR_PY:")) throw new Exception(txt);
                }
                catch (ArgumentException) { }

                using (MemoryStream ms = new MemoryStream(netBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        /* =========================================== INTEGRACION MULTIPLE POR TRAPCIO ================================ */

        public double CalcularIntegralDoble(string funcion, double a, double b, double c, double d)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.integrar_doble_trapecio_simple(funcion, a, b, c, d);

                // Validar errores de texto
                string resStr = res.ToString();
                if (resStr.StartsWith("Error")) throw new Exception(resStr);

                return (double)res;
            }
        }
        public double CalcularIntegralDoble(string funcion, double a, double b, double c, double d, string metodo)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res;

                // Decidimos que funcion llamar segun el ComboBox
                if (metodo.Contains("Simpson"))
                {
                    res = modulo.integrar_doble_simpson(funcion, a, b, c, d);
                }
                else
                {

                    res = modulo.integrar_doble_trapecio_simple(funcion, a, b, c, d);
                }

                string resStr = res.ToString();
                if (resStr.StartsWith("Error")) throw new Exception(resStr);

                return (double)res;
            }


        }


        // ==================================== ALGEBRA LINEAL PIVOTEO PARCIAL ===================================

        public class ResultadoSistema
        {
            public List<List<double>> MatrizTriangular { get; set; }
            public List<double> Raices { get; set; }
        }

        public ResultadoSistema ResolverGauss(List<List<double>> matrizAumentada, string metodo)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Pasamos el método: "Parcial", "Escalado" o "Total"
                dynamic res = modulo.resolver_gauss_general(matrizAumentada, metodo);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                ResultadoSistema resultado = new ResultadoSistema();

                // 1. Matriz
                resultado.MatrizTriangular = new List<List<double>>();
                dynamic mPy = res[0];
                int filas = (int)mPy.__len__();
                for (int i = 0; i < filas; i++)
                {
                    List<double> fila = new List<double>();
                    dynamic fPy = mPy[i];
                    int cols = (int)fPy.__len__();
                    for (int j = 0; j < cols; j++) fila.Add((double)fPy[j]);
                    resultado.MatrizTriangular.Add(fila);
                }

                // 2. Raíces
                resultado.Raices = new List<double>();
                dynamic vPy = res[1];
                int n = (int)vPy.__len__();
                for (int i = 0; i < n; i++) resultado.Raices.Add((double)vPy[i]);

                return resultado;
            }
        }

        /* ====================================== FACTORIZACIONES DE MATRICES ============================== */
        public class ResultadoFactorizacion
        {
            public List<List<double>> MatrizL { get; set; }
            public List<List<double>> MatrizU { get; set; }
            public List<List<double>> MatrizP { get; set; }
        }
        public List<string> ObtenerMetodosValidos(List<List<double>> matriz)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic listaPy = modulo.analizar_metodos_disponibles(matriz);

                List<string> metodos = new List<string>();
                int len = (int)listaPy.__len__();
                for (int i = 0; i < len; i++) metodos.Add(listaPy[i].ToString());

                return metodos;
            }
        }

        // 2. Calcular: Retorna L, U y P
        public ResultadoFactorizacion CalcularFactorizacion(List<List<double>> matriz, string metodo)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.resolver_factorizacion(matriz, metodo);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                ResultadoFactorizacion rf = new ResultadoFactorizacion();
                rf.MatrizL = ConvertirPyList(res[0]);
                rf.MatrizU = ConvertirPyList(res[1]);
                rf.MatrizP = ConvertirPyList(res[2]);

                return rf;
            }
        }

        private List<List<double>> ConvertirPyList(dynamic pyList)
        {
            List<List<double>> resultado = new List<List<double>>();
            int filas = (int)pyList.__len__();
            for (int i = 0; i < filas; i++)
            {
                List<double> fila = new List<double>();
                dynamic fPy = pyList[i];
                int cols = (int)fPy.__len__();
                for (int j = 0; j < cols; j++) fila.Add((double)fPy[j]);
                resultado.Add(fila);
            }
            return resultado;
        }

        /* ========================= METODO DE EULER PARA EDOs =============================== */

        public class FilaEuler
        {
            public int Iteracion { get; set; }
            public double X { get; set; }
            public double Y_Actual { get; set; }     // w_i
            public double Y_Siguiente { get; set; }  // w_i+1
        }
        public List<FilaEuler> ResolverEDO_Euler(string ecuacion, double x0, double y0, double h, double xFinal)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Llamada a Python
                dynamic res = modulo.resolver_euler(ecuacion, x0, y0, h, xFinal);

                // Validacion de errores
                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                // Parsear lista de listas a objetos C#
                List<FilaEuler> tabla = new List<FilaEuler>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    dynamic filaPy = res[i];
                    FilaEuler f = new FilaEuler();
                    f.Iteracion = (int)filaPy[0];
                    f.X = (double)filaPy[1];
                    f.Y_Actual = (double)filaPy[2];
                    f.Y_Siguiente = (double)filaPy[3];
                    tabla.Add(f);
                }

                return tabla;
            }
        }

        /* ========================== TAYLOR DE ORDEN SUPERIOR =============================== */

        public class FilaTaylor
        {
            public int Iteracion { get; set; }
            public double T { get; set; }
            public double W_Orden2 { get; set; }
            public double W_Orden3 { get; set; }
            public double W_Orden4 { get; set; }
        }


        public List<FilaTaylor> ResolverEDO_Taylor(string ecuacion, double t0, double w0, double h, double tFinal)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.resolver_taylor_comparativo(ecuacion, t0, w0, h, tFinal);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                List<FilaTaylor> tabla = new List<FilaTaylor>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    dynamic filaPy = res[i];
                    FilaTaylor f = new FilaTaylor();
                    f.Iteracion = (int)filaPy[0];
                    f.T = (double)filaPy[1];
                    f.W_Orden2 = (double)filaPy[2];
                    f.W_Orden3 = (double)filaPy[3];
                    f.W_Orden4 = (double)filaPy[4];
                    tabla.Add(f);
                }

                return tabla;
            }
        }

        /* ============================== RK DE ORDEN 2,3,4 ============================= */
        public class FilaRK
        {
            public int Iteracion { get; set; }
            public double T { get; set; }
            public double W { get; set; }
            public double K1 { get; set; }
            public double K2 { get; set; }
            public double K3 { get; set; }
            public double K4 { get; set; }
        }
        public List<FilaRK> ResolverRungeKutta(string ecuacion, double t0, double w0, double h, double tFinal, int orden)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Llamamos a la funcion con el orden (2, 3 o 4)
                dynamic res = modulo.resolver_rk_general(ecuacion, t0, w0, h, tFinal, orden);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                List<FilaRK> tabla = new List<FilaRK>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    dynamic filaPy = res[i]; // [i, t, w, [k1, k2...]]

                    FilaRK f = new FilaRK();
                    f.Iteracion = (int)filaPy[0];
                    f.T = (double)filaPy[1];
                    f.W = (double)filaPy[2];

                    // Extraemos la lista interna de Ks
                    dynamic listaKs = filaPy[3];
                    f.K1 = (double)listaKs[0];
                    f.K2 = (double)listaKs[1];
                    f.K3 = (double)listaKs[2];
                    f.K4 = (double)listaKs[3];

                    tabla.Add(f);
                }

                return tabla;
            }
        }

        /* ============================================= RK FELBERG ==================================== */
        public class FilaRKF
        {
            public int Iteracion { get; set; }
            public double H { get; set; }
            public double T { get; set; }
            public double K1 { get; set; }
            public double K2 { get; set; }
            public double K3 { get; set; }
            public double K4 { get; set; }
            public double K5 { get; set; }
            public double K6 { get; set; }
            public double W4 { get; set; }        // wi
            public double W5 { get; set; }        // Wi Mejor
            public double R { get; set; }
            public string Aceptado { get; set; }  // "Si" o "No"
            public double ParteFormula { get; set; } // (Err/R)^1/4
            public double Q { get; set; }
            public double QH { get; set; }

            }
        public List<FilaRKF> ResolverRKF(string ec, double t0, double w0, double h, double tf, double tol, double fac)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                dynamic res = modulo.resolver_rkf(ec, t0, w0, h, tf, tol, fac);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                List<FilaRKF> tabla = new List<FilaRKF>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    dynamic f = res[i];
                    FilaRKF row = new FilaRKF();

                    row.Iteracion = (int)f[0];
                    row.H = (double)f[1];
                    row.T = (double)f[2];

                    // Ks
                    row.K1 = (double)f[3];
                    row.K2 = (double)f[4];
                    row.K3 = (double)f[5];
                    row.K4 = (double)f[6];
                    row.K5 = (double)f[7];
                    row.K6 = (double)f[8];

                    row.W4 = (double)f[9];
                    row.W5 = (double)f[10];
                    row.R = (double)f[11];
                    row.Aceptado = f[12].ToString();
                    row.ParteFormula = (double)f[13];
                    row.Q = (double)f[14];
                    row.QH = (double)f[15];

                    tabla.Add(row);
                }
                return tabla;
            }
        }



            /* =============================== ADAMS BASHHCOFT =========================== */

         public class FilaAdams{
            public int Iteracion { get; set; }
            public double T { get; set; }
            public double W { get; set; }
            public string Metodo { get; set; } 
         }

        public List<FilaAdams> ResolverAdams(string ec, double t0, double w0, double h, double tf, int pasos)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Directory.GetCurrentDirectory());
                dynamic modulo = Py.Import("logica_math");

                // Llamada a Python
                dynamic res = modulo.resolver_adams_bashforth(ec, t0, w0, h, tf, pasos);

                if (res is string || res.ToString().StartsWith("Error"))
                    throw new Exception(res.ToString());

                List<FilaAdams> tabla = new List<FilaAdams>();
                int filas = (int)res.__len__();

                for (int i = 0; i < filas; i++)
                {
                    dynamic f = res[i];
                    FilaAdams row = new FilaAdams();
                    row.Iteracion = (int)f[0];
                    row.T = (double)f[1];
                    row.W = (double)f[2];
                    row.Metodo = f[3].ToString();
                    tabla.Add(row);
                }
                return tabla;
            }
        }






    }



}





