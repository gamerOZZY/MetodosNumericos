using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using NCalc;
using System.Text.RegularExpressions;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;


namespace MetodosNumericos
{
    internal class SolEc1Var
    {
        public float a, b;
        public int NumMaxIter;
        public float ErrorMax;
        public Complex p0, p1, p2;
        public double a1, b1;
        public string FuncionTexto;


        private NCalc.Expression exprFuncion;

        private NCalc.Expression exprDerivada;
        



        public void PrepararFunciong()
        {
            try
            {
                string textoUsuario = Normalizar(FuncionTexto.Trim());


                
                Expr exprSymbolic = Expr.Parse(FuncionTexto);
                Expr derivadaSymbolic = exprSymbolic.Differentiate("x");
                string derivadaTextoInfix = derivadaSymbolic.ToString();
                string derivadaNCalc = Normalizar(derivadaTextoInfix);

                
                exprFuncion = new NCalc.Expression(textoUsuario);

                exprDerivada = new NCalc.Expression(derivadaNCalc);

                
                exprFuncion.Parameters["e"] = Math.E;
                exprFuncion.Parameters["pi"] = Math.PI;
                exprDerivada.Parameters["e"] = Math.E;
                exprDerivada.Parameters["pi"] = Math.PI;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar la función:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrepararFuncion()
        {
            try
            {
                string textoUsuario = Normalizar(FuncionTexto.Trim());


                
                Expr exprSymbolic = Expr.Parse(FuncionTexto);
                Expr derivadaSymbolic = exprSymbolic.Differentiate("x");
                string derivadaTextoInfix = derivadaSymbolic.ToString();
                string derivadaNCalc = Normalizar(derivadaTextoInfix);

                
                exprFuncion = new NCalc.Expression(textoUsuario);
                exprDerivada = new NCalc.Expression(derivadaNCalc);

                
                exprFuncion.Parameters["e"] = Math.E;
                exprFuncion.Parameters["pi"] = Math.PI;
                exprDerivada.Parameters["e"] = Math.E;
                exprDerivada.Parameters["pi"] = Math.PI;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar la función:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string Normalizar(string texto)
        {
            texto = texto.ToLower();

            texto = texto.Replace("sen", "sin");
            texto = texto.Replace("√", "sqrt");
            texto = texto.Replace("π", "pi");

            // 🔥 reemplazamos 'ln' por 'Log' (natural)
            texto = Regex.Replace(texto, @"\bln\s*\(", "Log(");

            // 🔥 opcional: reemplazo 'log(' por 'Log10(' si quisieras log base 10
            // texto = Regex.Replace(texto, @"\blog\s*\(", "Log10(");

            // 10x → 10*x
            texto = Regex.Replace(texto, @"(\d)(x)", "$1*$2");

            // ^ → Pow()
            string pattern = @"(\w+|\([^)]*\))\^(\w+|\([^)]*\))";
            texto = Regex.Replace(texto, pattern, "Pow($1,$2)");

            return texto;
        }



        public float f(float x)
        {
            exprFuncion.Parameters["x"] = x;
            var resultado = exprFuncion.Evaluate();
            return Convert.ToSingle(resultado);
            
        }


        public double fd(double x)
        {
            exprFuncion.Parameters["x"] = x;
            var resultado = exprFuncion.Evaluate();
            return Convert.ToDouble(resultado);

        }
        
        public float f_deriv(float x)
        {
            try
            {
                
                exprDerivada.Parameters["x"] = x;

                
                var resultado = exprDerivada.Evaluate();


                return Convert.ToSingle(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la derivada:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return float.NaN;
            }
        }

        public Complex f_m(Complex z)
        {
            try
            {
                return EvaluarPolinomio(FuncionTexto, z);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error evaluando f_m:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Complex(double.NaN, double.NaN); // POR SI NO TIENE COSO NAN
            }
        }

        private Complex EvaluarPolinomio(string funcionTexto, Complex z)
        {
            string s = funcionTexto.Replace(" ", ""); // Limpieza básica
            var terminos = Regex.Split(s, @"(?=[\+\-])"); // separa + y -

            Complex suma = Complex.Zero;

            foreach (string t in terminos)
            {
                if (string.IsNullOrWhiteSpace(t)) continue;
                string termino = t.Trim();

                //Coso para detectar terminos elevados a algun exponente
                Match m = Regex.Match(termino, @"([+\-]?\d*\.?\d*)\*?x(\^(\d+))?");  
                if (m.Success)
                {
                    string coefStr = m.Groups[1].Value; //???????? NOTOCAR, igual por alguna razon funciona pero aja
                    double coef = 1;

                    // Si hay coeficiente explícito
                    if (!string.IsNullOrEmpty(coefStr) && coefStr != "+" && coefStr != "-")
                        coef = double.Parse(coefStr);
                    else if (coefStr == "-")
                        coef = -1;
                    else if (coefStr == "+")
                        coef = 1;

                    // Exponente
                    string expStr = m.Groups[3].Value; //??????????????????? Por alguna razon funciona. NO TOCAR
                    int exp = string.IsNullOrEmpty(expStr) ? 1 : int.Parse(expStr);

                    suma += coef * Complex.Pow(z, exp);
                }
                else
                {
                    // Término constante
                    if (termino == "+" || termino == "-") continue;

                    double constante = double.Parse(termino);
                    suma += new Complex(constante, 0);
                }
            }

            return suma;
        }




        





        public bool MetBiseccion(ref float AproxRaiz) 
        {
            int i = 0;
            float ErrorAct;
            float c;
            if((f(this.a) * f(this.b)) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if(this.f(this.a) == 0 || this.f(this.b) == 0) 
            {
                AproxRaiz = (this.f(this.a) == 0) ? this.a : this.b;
                return true;
            }
            while(i <= this.NumMaxIter) 
            {
                c = (this.a + this.b) / 2;
                if(f(a) * f(c) < 0) 
                {
                    this.b = c;
                }
                else
                {
                    this.a = c;
                }
                ErrorAct = (this.b - this.a);
                if(ErrorAct <= this.ErrorMax) 
                {
                    AproxRaiz = c;
                    return true;
                }
                i++;

            }
            MessageBox.Show("No se encontro la raiz en el numero maximo de iteraciones");
            return false;
        }

        public bool MetBiseccion(ref DataGridView dgvBiseccion, ref float AproxRaiz)
        {
            int i = 0;
            int IndiceReglon;
            float ErrorAct;
            float c;
            dgvBiseccion.Rows.Clear();
            if ((f(this.a) * f(this.b)) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.f(this.a) == 0 || this.f(this.b) == 0)
            {
                AproxRaiz = (this.f(this.a) == 0) ? this.a : this.b;
                return true;
            }
            while (i <= this.NumMaxIter)
            {
                c = (this.a + this.b) / 2;
                dgvBiseccion.Rows.Add();
                IndiceReglon = dgvBiseccion.Rows.Count - 1;
                dgvBiseccion.Rows[IndiceReglon].Cells[0].Value = i.ToString();
                dgvBiseccion.Rows[IndiceReglon].Cells[1].Value = this.a.ToString();
                dgvBiseccion.Rows[IndiceReglon].Cells[2].Value = c.ToString();
                dgvBiseccion.Rows[IndiceReglon].Cells[3].Value = this.b.ToString();
                dgvBiseccion.Rows[IndiceReglon].Cells[4].Value = (f(a) > 0) ? "+" : "-";
                dgvBiseccion.Rows[IndiceReglon].Cells[5].Value = (f(c) > 0) ? "+" : "-";
                dgvBiseccion.Rows[IndiceReglon].Cells[6].Value = (f(b) > 0) ? "+" : "-";
                dgvBiseccion.Refresh();

                if (f(a) * f(b) < 0)
                {
                    this.b = c;
                }
                else
                {
                    this.a = c;
                }
                ErrorAct = (this.b - this.a);
                dgvBiseccion.Rows[IndiceReglon].Cells[7].Value = ErrorAct.ToString();
                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }
                i++;

            }
            MessageBox.Show("No se encontro la raiz en el numero maximo de iteraciones");
            return false;
        }

        public bool Muller(ref Complex AproxRaiz, ref DataGridView dgvMuller)
        {
            int IterAct = 0;
            Complex v1, v2;
            Complex a = new Complex(), b = new Complex(), c = new Complex();
            Complex p3 = new Complex();
            float ErrorAct;
            dgvMuller.Rows.Clear();

            while (IterAct <= this.NumMaxIter)
            {
             
                c = f_m(p2);
                b = Complex.Pow((p0 - p2), 2) * (f_m(p1) - f_m(p2)) -
                    Complex.Pow((p1 - p2), 2) * (f_m(p0) - f_m(p2));
                b = b / ((p0 - p2) * (p1 - p2) * (p0 - p1));

                a = (p1 - p2) * (f_m(p0) - f_m(p2)) -
                    (p0 - p2) * (f_m(p1) - f_m(p2));
                a = a / ((p0 - p2) * (p1 - p2) * (p0 - p1));

            
                v1 = b + Complex.Sqrt(Complex.Pow(b, 2) - 4 * a * c);
                v2 = b - Complex.Sqrt(Complex.Pow(b, 2) - 4 * a * c);

              
                if (Complex.Abs(v1) > Complex.Abs(v2))
                    p3 = p2 - (2 * c) / v1;
                else
                    p3 = p2 - (2 * c) / v2;

             
                ErrorAct = (float)Complex.Abs(p3 - p2);

           
                dgvMuller.Rows.Add();
                int rowIndex = dgvMuller.Rows.Count - 1;
                dgvMuller.Rows[rowIndex].Cells[0].Value = IterAct.ToString();
                dgvMuller.Rows[rowIndex].Cells[1].Value = p0.ToString();
                dgvMuller.Rows[rowIndex].Cells[2].Value = p1.ToString();
                dgvMuller.Rows[rowIndex].Cells[3].Value = p2.ToString();
                dgvMuller.Rows[rowIndex].Cells[4].Value = p3.ToString();
                dgvMuller.Rows[rowIndex].Cells[5].Value = ErrorAct.ToString("E4");
                dgvMuller.Refresh();

                if (ErrorAct <= this.ErrorMax || Complex.Abs(f_m(p3)) <= this.ErrorMax)
                {
                    AproxRaiz = p3;
                    return true;
                }

                p0 = p1;
                p1 = p2;
                p2 = p3;

                IterAct++;
            }

            MessageBox.Show("No se encontró la raíz en el número máximo de iteraciones", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool MetNewtonRaphson(ref DataGridView dgvNewton, ref float AproxRaiz)
        {
            int IterAct = 0;
            float p0 = this.a;
            float p1;
            float ErrorAct;
            dgvNewton.Rows.Clear();

            while (IterAct <= this.NumMaxIter)
            {
                float f0 = f(p0);
                float f0_deriv = f_deriv(p0);

                if (f0_deriv == 0)
                {
                    MessageBox.Show("La derivada se anuló, no se puede continuar con Newton-Raphson",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                p1 = p0 - f0 / f0_deriv;

                ErrorAct = Math.Abs(p1 - p0);

                dgvNewton.Rows.Add();
                int rowIndex = dgvNewton.Rows.Count - 1;
                dgvNewton.Rows[rowIndex].Cells[0].Value = IterAct.ToString();
                dgvNewton.Rows[rowIndex].Cells[1].Value = p0.ToString("F6");
                dgvNewton.Rows[rowIndex].Cells[2].Value = p1.ToString("F6");
                dgvNewton.Rows[rowIndex].Cells[3].Value = ErrorAct.ToString("E4");
                dgvNewton.Refresh();


                if (ErrorAct <= this.ErrorMax || Math.Abs(f(p1)) <= this.ErrorMax)
                {
                    AproxRaiz = p1;
                    return true;
                }

                p0 = p1;
                IterAct++;
            }

            MessageBox.Show("No se encontró la raíz en el número máximo de iteraciones",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

       
        public bool MetSecante(ref DataGridView dgvSecante, ref double AproxRaiz)
        {
            dgvSecante.Rows.Clear();


            double p0 = this.a;
            double p1 = this.b;
            double p2;
            double ErrorAct;
            int IterAct = 0;


            if (NumMaxIter <= 0)
            {
                MessageBox.Show("Numero maximo de iteraciones invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (fd(p0) == 0f)
            {
                AproxRaiz = p0;
                return true;
            }
            if (fd(p1) == 0f)
            {
                AproxRaiz = p1;
                return true;
            }

            while (IterAct <= this.NumMaxIter)
            {
                double f0 = fd(p0);
                double f1 = fd(p1);


                double denom = (f1 - f0);
                if (denom == 0f)
                {
                    MessageBox.Show("Denominador nulo en el método de la secante (f(p1)-f(p0)=0).",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                p2 = p1 - f1 * (p1 - p0) / denom;


                ErrorAct = Math.Abs(p2 - p1);


                dgvSecante.Rows.Add(
                    IterAct.ToString(),
                    p0.ToString("F6"),
                    p1.ToString("F6"),
                    p2.ToString("F6"),
                    fd(p2).ToString("E4"),
                    ErrorAct.ToString("E4")
                );
                dgvSecante.Refresh();

   
                if (ErrorAct <= this.ErrorMax || Math.Abs(fd(p2)) <= this.ErrorMax)
                {
                    AproxRaiz = p2;
                    return true;
                }


                p0 = p1;
                p1 = p2;
                IterAct++;
            }

            MessageBox.Show("No se encontró la raíz en el número máximo de iteraciones",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool MetFalsaPos(ref DataGridView dgvFalsaPos, ref double AproxRaiz)
        {
            int i = 0;
            int IndiceReglon;
            double ErrorAct;
            double c;
            dgvFalsaPos.Rows.Clear();



            if ((fd(this.a1) * fd(this.b1)) > 0)
            {
                MessageBox.Show("No hay cambio de signo en el intervalo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.fd(this.a1) == 0 || this.fd(this.b1) == 0)
            {
                AproxRaiz = (this.fd(this.a1) == 0) ? this.a1 : this.b1;
                return true;
            }

            while (i <= this.NumMaxIter)
            {
                
                c = (this.a1 * fd(this.b1) - this.b1 * fd(this.a1)) / (fd(this.b1) - fd(this.a1));

                dgvFalsaPos.Rows.Add();
                IndiceReglon = dgvFalsaPos.Rows.Count - 1;

                dgvFalsaPos.Rows[IndiceReglon].Cells[0].Value = i.ToString();
                dgvFalsaPos.Rows[IndiceReglon].Cells[1].Value = this.a1.ToString();
                dgvFalsaPos.Rows[IndiceReglon].Cells[2].Value = c.ToString();
                dgvFalsaPos.Rows[IndiceReglon].Cells[3].Value = this.b1.ToString();
                dgvFalsaPos.Rows[IndiceReglon].Cells[4].Value = (fd(a1) > 0) ? "+" : "-";
                dgvFalsaPos.Rows[IndiceReglon].Cells[5].Value = (fd(c) > 0) ? "+" : "-";
                dgvFalsaPos.Rows[IndiceReglon].Cells[6].Value = (fd(b1) > 0) ? "+" : "-";

                dgvFalsaPos.Refresh();

                
                if (fd(a1) * fd(c) < 0)
                    this.b1 = c;
                else
                    this.a1 = c;

                
                ErrorAct = Math.Abs(this.b1 - this.a1);
                dgvFalsaPos.Rows[IndiceReglon].Cells[7].Value = ErrorAct.ToString();

                if (ErrorAct <= this.ErrorMax)
                {
                    AproxRaiz = c;
                    return true;
                }
                i++;
            }

            MessageBox.Show("No se encontró la raíz en el número máximo de iteraciones");
            return false;


        }



    }
}
