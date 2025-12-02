using System;
using System.Collections.Generic;
using System.Linq;
using NCalc; // Se requiere la librería NCalc (instalada vía NuGet)

namespace MetodosNumericos
{
    public class DerivacionNumerica
    {
        // 1. Estructura para almacenar los puntos proporcionados por el usuario
        public List<double> PuntosX { get; private set; }

        public DerivacionNumerica()
        {
            PuntosX = new List<double>();
        }

        // --- Gestión de Puntos ---

        /// <summary>
        /// Agrega un nuevo punto a la lista.
        /// </summary>
        public void AgregarPunto(double punto)
        {
            PuntosX.Add(punto);
            // Opcional: Mantener la lista ordenada
            PuntosX.Sort();
        }

        /// <summary>
        /// Borra todos los puntos almacenados.
        /// </summary>
        public void BorrarPuntos()
        {
            PuntosX.Clear();
        }

        // --- Método de Evaluación de Función (Optimizado para NCalc) ---

        /// <summary>
        /// Evalúa una función matemática para un valor de x dado, manejando sintaxis como sin(x) y exp(x).
        /// </summary>
        private double EvaluarFuncion(string funcion, double xValue)
        {
            try
            {
                // Reemplaza sin(x), cos(x), exp(x), etc., con Math.Sin(x), Math.Cos(x), Math.Exp(x) para compatibilidad con NCalc
                // Esto es crucial para funciones digitadas sin el prefijo "Math."
                string funcionLimpia = funcion.ToLower()
                    .Replace("sin(", "Sin(")
                    .Replace("cos(", "Cos(")
                    .Replace("tan(", "Tan(")
                    .Replace("log(", "Log10(") // Base 10
                    .Replace("ln(", "Log(")    // Base e (Log natural)
                    .Replace("exp(", "Exp(")
                    .Replace("^", "**"); // NCalc usa ** para potencia

                Expression exp = new Expression(funcionLimpia);
                exp.Parameters["x"] = xValue;

                return Convert.ToDouble(exp.Evaluate());
            }
            catch (Exception ex)
            {
                // Proporcionar información útil al usuario si la sintaxis es incorrecta
                throw new ArgumentException($"Error al evaluar la función. Asegúrese de usar 'x' como variable, '*' para multiplicar y la notación correcta. Detalle: {ex.Message}", ex);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------------
        // --- MÉTODOS DE DERIVACIÓN (Utilizan el punto X y el paso H proporcionados) ---
        // --------------------------------------------------------------------------------------------------------------------------------------

        // Nota: Los métodos ahora usan el 'x' y 'h' proporcionados por el usuario, sin depender directamente de la lista PuntosX 
        // para la existencia de x-h o x+h.

        /// <summary>
        /// 3 Puntos Centrada (O(h^2))
        /// f'(x) ≈ (f(x+h) - f(x-h)) / (2h)
        /// </summary>
        public double DerivadaCentrada3Puntos(string funcion, double x, double h)
        {
            double fxh = EvaluarFuncion(funcion, x + h);
            double fxmh = EvaluarFuncion(funcion, x - h);

            return (fxh - fxmh) / (2.0 * h);
        }

        /// <summary>
        /// 5 Puntos Centrada (O(h^4)) - Mayor precisión
        /// f'(x) ≈ (f(x-2h) - 8f(x-h) + 8f(x+h) - f(x+2h)) / (12h)
        /// </summary>
        public double DerivadaCentrada5Puntos(string funcion, double x, double h)
        {
            double fxh = EvaluarFuncion(funcion, x + h);
            double fx2h = EvaluarFuncion(funcion, x + 2.0 * h);
            double fxmh = EvaluarFuncion(funcion, x - h);
            double fxm2h = EvaluarFuncion(funcion, x - 2.0 * h);

            return (fxm2h - 8.0 * fxmh + 8.0 * fxh - fx2h) / (12.0 * h);
        }

        // --- Fórmulas Hacia Adelante (para puntos cercanos al inicio) ---

        /// <summary>
        /// 3 Puntos Adelante (O(h^2))
        /// f'(x) ≈ (-3f(x) + 4f(x+h) - f(x+2h)) / (2h)
        /// </summary>
        public double DerivadaAdelante3Puntos(string funcion, double x, double h)
        {
            double fx = EvaluarFuncion(funcion, x);
            double fxh = EvaluarFuncion(funcion, x + h);
            double fx2h = EvaluarFuncion(funcion, x + 2.0 * h);

            return (-3.0 * fx + 4.0 * fxh - fx2h) / (2.0 * h);
        }

        // --- Fórmulas Hacia Atrás (para puntos cercanos al final) ---

        /// <summary>
        /// 3 Puntos Atrás (O(h^2))
        /// f'(x) ≈ (3f(x) - 4f(x-h) + f(x-2h)) / (2h)
        /// </summary>
        public double DerivadaAtras3Puntos(string funcion, double x, double h)
        {
            double fx = EvaluarFuncion(funcion, x);
            double fxmh = EvaluarFuncion(funcion, x - h);
            double fxm2h = EvaluarFuncion(funcion, x - 2.0 * h);

            return (3.0 * fx - 4.0 * fxmh + fxm2h) / (2.0 * h);
        }

        // Nota: Las fórmulas de 2 puntos (O(h)) también están disponibles si las incluyes como en la respuesta anterior, 
        // pero las de 3 y 5 puntos (O(h^2), O(h^4)) son generalmente las preferidas por su mayor precisión.
    }
}