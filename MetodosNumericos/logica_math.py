## P O R F A V O R
##COMENTAR HASTA EL MAS MINIMO DETALLE DE LAS FUNCIONES, somos 3 y aunque el codigo sea basura, tenemos que
##entender claramente que es lo que hacexd
import sympy as sp
import numpy as np
import matplotlib
matplotlib.use('Agg')
import matplotlib.pyplot as plt
import io
from math import *
import math
import sys
import base64

#SYMPY NOS AHORRO AGNOS DE VIDA GGGGGGGGGGG


def evaluar_y(func_str, x_val): #Funcion para evalaluar x en una f(x)
    """Convierte texto a funcion y evalua en x."""
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        # Usamos numpy para evaluacion rapida y segura
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])
        return float(f(x_val))
    except Exception as e:
        return f"Error: {str(e)}"
    
####################################################### ECUACIONES DE UNA VARIABLE ######################################
def metodo_biseccion(func_str, a, b, tol, max_iter):
    """
    Retorna tabla con: [iter, a, c, b, f(a), f(c), f(b), error]
    Donde c es el punto medio y Error = b - a
    """
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])

        if f(a) * f(b) > 0:
            return "Error: f(a) y f(b) tienen el mismo signo. No hay raiz garantizada."

        tabla = []
        
        for i in range(1, int(max_iter) + 1):
            c = (a + b) / 2.0
            
            fa = f(a)
            fb = f(b)
            fc = f(c)
            error = b - a
            fila = [float(i), float(a), float(c), float(b), float(fa), float(fc), float(fb), float(error)]
            tabla.append(fila)

            if error < tol or abs(fc) < 1e-15: 
                break
            

            if fa * fc < 0:
                b = c
            else:
   
                a = c
                
        return tabla

    except Exception as e:
        return f"Error Biseccion: {str(e)}"

def metodo_falsa_posicion(func_str, a, b, tol, max_iter):
    """
    Retorna tabla: [iter, a, c, b, f(a), f(c), f(b), errorAprox]
    """
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])

        fa = f(a)
        fb = f(b)
        
        if fa * fb > 0:
            return "Error: f(a) y f(b) tienen el mismo signo. No hay raIz garantizada."
        
        tabla = []
        c_old = a # Valor inicial 
        
        for i in range(1, int(max_iter) + 1):
            fa = f(a)
            fb = f(b)
            

            if fb - fa == 0: return "Error: Division por cero en la formula."


            c = (a * fb - b * fa) / (fb - fa)
            fc = f(c)

            if i == 1:
                error = abs(b - a) 
            else:
                error = abs(c - c_old)
            

            fila = [
                float(i), float(a), float(c), float(b), 
                float(fa), float(fc), float(fb), float(error)
            ]
            tabla.append(fila)


            if error < tol or abs(fc) < 1e-15:
                break
                
            if fa * fc < 0:
                b = c 
            else:
                a = c 
                
            c_old = c 
            
        return tabla

    except Exception as e:
        return f"Error Falsa PosiciOn: {str(e)}"
    
def metodo_newton_raphson(func_str, p0, tol, max_iter):
    """
    Retorna tabla: [iter, p0, p1, error]
    """
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        derivada_expr = sp.diff(expr, x) 
    
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])
        df = sp.lambdify(x, derivada_expr, modules=['numpy', 'math'])
        
        tabla = []
        p_actual = float(p0)
        
        for i in range(1, int(max_iter) + 1):
            f_val = f(p_actual)
            df_val = df(p_actual)
            
            if df_val == 0:
                return "Error: La derivada se hizo cero. El metodo falla (division por 0)."
           
            p_siguiente = p_actual - (f_val / df_val)

            error = abs(p_siguiente - p_actual)

            fila = [float(i), p_actual, p_siguiente, error]
            tabla.append(fila)

            if error < tol or abs(f(p_siguiente)) < 1e-15:
                break
                
            p_actual = p_siguiente
            
        return tabla

    except Exception as e:
        return f"Error Newton-Raphson: {str(e)}"
    
def metodo_secante(func_str, p0, p1, tol, max_iter):
    """
    Retorna tabla: [iter, p0, p1, p2, f(p2), error]
    """
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])
        
        tabla = []
        
        p_prev = float(p0)  
        p_curr = float(p1) 
        
        for i in range(1, int(max_iter) + 1):
            f_prev = f(p_prev)
            f_curr = f(p_curr)
            
            denom = f_curr - f_prev
            if denom == 0:
                return "Error: Division por cero. f(p0) y f(p1) son iguales."

            p_next = p_curr - (f_curr * (p_curr - p_prev) / denom)

            error = abs(p_next - p_curr)

            f_next = f(p_next)

            fila = [float(i), p_prev, p_curr, p_next, f_next, error]
            tabla.append(fila)

            if error < tol or abs(f_next) < 1e-15:
                break

            p_prev = p_curr
            p_curr = p_next
            
        return tabla

    except Exception as e:
        return f"Error Secante: {str(e)}"

def metodo_punto_fijo(g_func_str, p0, tol, max_iter):
    """
    Retorna tabla: [iter, p0, p1, error]
    """
    try:
        x = sp.symbols('x')
        expr_g = sp.sympify(g_func_str)
        g = sp.lambdify(x, expr_g, modules=['numpy', 'math'])
        
        tabla = []
        p_00 = float(p0)
        
        for i in range(1, int(max_iter) + 1):
            p_11 = g(p_00)
            
            error = abs(p_11 - p_00)
            
            fila = [float(i), p_00, p_11, error]
            tabla.append(fila)
            
            if error < tol:
                break
            
            if error > 1e10: 
                return f"Error: el error crece al infinito. Revisa tu g(x)."
                

            p_00 = p_11
            
        return tabla

    except Exception as e:
        return f"Error Punto Fijo: {str(e)}"
    




########################################################## DERIVADAS 2,3,5 PUNTOS ###################################

def calcular_derivada(lista_x, lista_y, indice, metodo, puntos):
    """
    Realiza la derivada numerica basada en listas de datos.
    """
    try:
        # Recuperamos h de los datos (asumiendo que son equidistantes)
        h = lista_x[1] - lista_x[0]
        y = lista_y
        i = indice # Indice del punto de interes

        # --- FORMULAS DE 2 PUNTOS ---
        if puntos == 2:
            if metodo == 'adelante':
                return (y[i+1] - y[i]) / h
            elif metodo == 'atras':
                return (y[i] - y[i-1]) / h
            elif metodo == 'centrada':
                return (y[i+1] - y[i-1]) / (2*h)

        # --- FORMULAS DE 3 PUNTOS ---
        elif puntos == 3:
            if metodo == 'adelante':
                return (-3*y[i] + 4*y[i+1] - y[i+2]) / (2*h)
            elif metodo == 'atras':
                return (3*y[i] - 4*y[i-1] + y[i-2]) / (2*h)
            elif metodo == 'centrada': 
                # Centrada O(h^2) usa i-1 e i+1
                return (y[i+1] - y[i-1]) / (2*h)

        # --- FORMULAS DE 5 PUNTOS ---
        elif puntos == 5:
            if metodo == 'centrada':
                return (-y[i+2] + 8*y[i+1] - 8*y[i-1] + y[i-2]) / (12*h)
            elif metodo == 'adelante':
                return (-25*y[i] + 48*y[i+1] - 36*y[i+2] + 16*y[i+3] - 3*y[i+4]) / (12*h)
            elif metodo == 'atras':
                return (25*y[i] - 48*y[i-1] + 36*y[i-2] - 16*y[i-3] + 3*y[i-4]) / (12*h)

        return "Metodo no configurado"

    except IndexError:
        return "Error: Faltan puntos vecinos para este metodo."
    except Exception as e:
        return f"Error matematico: {str(e)}"
    
################################################# DERIVADA H IRREGULAR ###############################
def derivar_interpolacion_newton(lista_x, lista_y, x_interes):
    try:
        x = sp.symbols('x')
        n = len(lista_x)
        
        if n < 2:
            return "Error: Se necesitan al menos 2 puntos."

        # Algoritmo de Diferencias Divididas
        F = [[0] * n for _ in range(n)]
        
        # Columna 0 son las Y
        for i in range(n):
            F[i][0] = lista_y[i]
            
        # Calcular coeficientes
        for j in range(1, n):
            for i in range(j, n):
                # (f[i, j-1] - f[i-1, j-1]) / (xi - x(i-j))
                numerador = F[i][j-1] - F[i-1][j-1]
                denominador = lista_x[i] - lista_x[i-j]
                
                if denominador == 0:
                    return "Error: X repetidos (division por cero)."
                F[i][j] = numerador / denominador

        # Diagonal principal = coeficientes
        b = [F[i][i] for i in range(n)]

        # Construir el polinomio P(x) simb�licamente
        polinomio = b[0]
        factor = 1
        for i in range(1, n):
            factor = factor * (x - lista_x[i-1])
            polinomio = polinomio + b[i] * factor
            
        # Derivar el polinomio resultante
        derivada = sp.diff(polinomio, x)
        
        # Evaluar en el punto de interes
        resultado = derivada.subs(x, x_interes)
        
        return float(resultado)

    except Exception as e:
        return f"Error Python: {str(e)}"
    

    
def generar_grafica_newton_bytes(lista_x, lista_y, x_interes):
    try:
        n = len(lista_x)
        if n < 2: return None

        # ---  Recalcular Coeficientes (Diferencias Divididas) ---
        F = [[0] * n for _ in range(n)]
        for i in range(n): F[i][0] = lista_y[i]

        for j in range(1, n):
            for i in range(j, n):
                numerador = F[i][j-1] - F[i-1][j-1]
                denominador = lista_x[i] - lista_x[i-j]
                if denominador == 0: return None
                F[i][j] = numerador / denominador
        
        b = [F[i][i] for i in range(n)] # Coeficientes

        # ---  Crear funcion para evaluar el polinomio ---
        # Esta funcion  evalua P(x) usando los coeficientes b
        def P(x_val):
            resultado = b[0]
            factor = 1
            for i in range(1, n):
                factor = factor * (x_val - lista_x[i-1])
                resultado = resultado + b[i] * factor
            return resultado

        # - Configurar la Grafica con Matplotlib ---
        plt.figure(figsize=(6, 4)) # Tamagnoo de la imagen
        plt.style.use('seaborn-v0_8-whitegrid') # Estilo bonito 

        # Generar dominio X suave para la curva (desde el minX hasta maxX un poco extendido)
        x_min, x_max = min(lista_x), max(lista_x)
        padding = (x_max - x_min) * 0.1
        x_suave = np.linspace(x_min - padding, x_max + padding, 200)
        y_suave = [P(val) for val in x_suave]

        # Dibujar Curve e Puntos
        plt.plot(x_suave, y_suave, 'b-', label='Polinomio Interpolante', linewidth=2)
        plt.scatter(lista_x, lista_y, color='red', s=50, label='Datos Originales', zorder=5)
        
        # Marcar el punto de interes
        y_interes = P(x_interes)
        plt.scatter([x_interes], [y_interes], color='green', s=100, marker='*', label='Punto Interes', zorder=10)

        plt.title("Grafica")
        plt.xlabel("X")
        plt.ylabel("Y")
        plt.legend()
        plt.grid(True)

        ##Toda esta parte (la de guardar en la memoria) fue sacada de internet ya que no se sabia como se debia realizar
        ## y opte por investigar, de una forma simple, la grafica la pasamos a bytes, la mandamos al buffer,
        #la mandamos a c y c la vuelve a armar.

        # --- 4. Guardar en Memoria (La parte magica) ---
        buf = io.BytesIO() # Crear un buffer en RAM
        plt.savefig(buf, format='png', dpi=100) # Guardar la grafica en el buffer
        buf.seek(0) # Rebobinar el buffer al inicio
        
        plt.close() # Cerrar la figura para liberar memoria en Python
        return buf.getvalue() # Devolver los bytes crudos de la imagen PNG

    except Exception as e:
        print(f"Error graficando: {str(e)}")
        return None # Devolvemos None si falla

################################################## EXTRAPOLACION DE RICHARDSON #############################
def extrapolacion_richardson(func_str, x_val, h_init, niveles):
    """
    Retorna una matriz (lista de listas) con la tabla de Richardson.
    func_str: Funcion texto
    x_val: Punto a evaluar
    h_init: Paso inicial
    niveles: Numero de filas (iteraciones)
    """
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])
        
        # Matriz D donde guardaremos los valores
        # D[i][j]
        D = [[0.0] * (i + 1) for i in range(niveles)]

        # 1. Llenar la primera columna (Derivadas Centradas O(h^2))
        # Formula: (f(x+h) - f(x-h)) / 2h
        h = h_init
        for i in range(niveles):
            # Derivada centrada basica (reutilizando el concepto de 3 puntos)
            D[i][0] = (f(x_val + h) - f(x_val - h)) / (2 * h)
            h = h / 2 # Preparamos h para la siguiente fila (mitad del paso)

        # 2. Llenar el resto de columnas (Extrapolacion)
        # Formula: D[i,j] = (4^j * D[i, j-1] - D[i-1, j-1]) / (4^j - 1)
        for j in range(1, niveles):
            for i in range(j, niveles):
                factor = 4 ** j
                numerador = factor * D[i][j-1] - D[i-1][j-1]
                denominador = factor - 1
                D[i][j] = numerador / denominador
        
        return D

    except Exception as e:
        return f"Error: {str(e)}"
    
#################################################### DIFERENCIAS DIVIDIDAS #####################
def obtener_tabla_diferencias(lista_x, lista_y):
    """Retorna la matriz de diferencias divididas como lista de listas"""
    try:
        n = len(lista_x)
        # Inicializamos matriz de floats
        F = [[0.0] * n for _ in range(n)]

        # Llenar columna 0 con Y
        for i in range(n):
            F[i][0] = float(lista_y[i])

        # Calcular diferencias divididas
        for j in range(1, n):
            for i in range(j, n):
                
                numerador = F[i][j-1] - F[i-1][j-1]
                denominador = lista_x[i] - lista_x[i-j]
                
                if denominador == 0: return "Error: X duplicado (division por 0)"
                
                F[i][j] = numerador / denominador 
        
        return F 
    except Exception as e:
        return f"Error: {str(e)}"

def obtener_polinomio_texto(lista_x, lista_y, tipo):
    """Retorna el string del polinomio"""
    try:
        n = len(lista_x)
        # Llamamos a la funcion corregida de arriba
        F = obtener_tabla_diferencias(lista_x, lista_y)
        

        polinomio_str = "P(x) = "
        
        # --- ADELANTE (Usando diagonal superior) ---
        if tipo == 'adelante':
            # Los coeficientes son F[0][0], F[1][1], F[2][2]...
            coefs = [F[i][i] for i in range(n)]
            
            for i in range(n):
                c = coefs[i]
                if abs(c) < 1e-9: continue # Ignorar ceros
                
                signo = "+ " if c >= 0 else "- "
                if i == 0: signo = "" if c >= 0 else "-"
                
                termino = f"{signo}{abs(c):.4f}"
                
                for k in range(i):
                    val_x = lista_x[k]
                    signo_x = "-" if val_x >= 0 else "+"
                    termino += f"*(x {signo_x} {abs(val_x):.4f})"
                
                polinomio_str += termino + " "

        # ---  ATRAS (Usando diagonal inferior) ---
        elif tipo == 'atras':
            # Los coeficientes estan en la ultima fila llena de cada columna
            # F[n-1][0] (no se usa para el polinomio, es y), F[n-1][1]... 
            # Usamos la ultima fila disponible para ese orden
            # El coefpiciente b0 esta en F[n-1][0]
            # El coeficiente b1 esta en F[n-1][1] y asi
            coefs = F[n-1]
            
            for i in range(n):
                c = coefs[i]
                if abs(c) < 1e-9: continue
                
                signo = "+ " if c >= 0 else "- "
                if i == 0: signo = "" if c >= 0 else "-"
                
                termino = f"{signo}{abs(c):.4f}"
                
                # Multiplicamos por (x - x_n-1), (x - x_n-2)...
                for k in range(i):
                    idx = (n - 1) - k
                    val_x = lista_x[idx]
                    signo_x = "-" if val_x >= 0 else "+"
                    termino += f"*(x {signo_x} {abs(val_x):.4f})"
                
                polinomio_str += termino + " "

        return polinomio_str
    except Exception as e:
        return f"Error texto: {str(e)}"
    
########################################################### NEVILLE ######################################################
def metodo_neville(lista_x, lista_y, x_interes):
    """
    Retorna la matriz Q de Neville.
    Q[i][j] es la aproximacion usando i puntos.
    """
    try:
        n = len(lista_x)
        if n < 2: return "Error: Faltan puntos"

        # Inicializamos la matriz Q con ceros (nxn)
        Q = [[0.0] * n for _ in range(n)]

        # Paso 1: La primera columna son las Yi (Q[i][0] = yi)
        for i in range(n):
            Q[i][0] = float(lista_y[i])

        # Paso 2: Llenar la matriz triangular usando la formula recursiva
        # Formula: Q[i,j] = [ (x - xi-j)*Q[i,j-1] - (x - xi)*Q[i-1,j-1] ] / (xi - xi-j)
        for j in range(1, n):
            for i in range(j, n):
                numerador = (x_interes - lista_x[i-j]) * Q[i][j-1] - (x_interes - lista_x[i]) * Q[i-1][j-1]
                denominador = lista_x[i] - lista_x[i-j]
                
                if denominador == 0: return "Error: Division por cero (X duplicados)"
                
                Q[i][j] = numerador / denominador

        return Q
    except Exception as e:
        return f"Error Neville: {str(e)}"
    
####################################################### LAGRANJE ################################################3
def evaluar_lagrange(lista_x, lista_y, x_val):
    """Evalua el polinomio de Lagrange en un punto x_val."""
    try:
        n = len(lista_x)
        if n < 2: return "Error: Faltan puntos"
        
        resultado = 0.0
        
        for i in range(n):
            # Calculamos el termino Li(x)
            termino_L = 1.0
            for j in range(n):
                if i != j:
                    numerador = x_val - lista_x[j]
                    denominador = lista_x[i] - lista_x[j]
                    if denominador == 0: return "Error: X duplicado"
                    termino_L = termino_L * (numerador / denominador)
            
            # Sumamos yi * Li(x)
            resultado += lista_y[i] * termino_L
            
        return float(resultado)
    except Exception as e:
        return f"Error Lagrange: {str(e)}"



def obtener_texto_lagrange(lista_x, lista_y):
    """Genera la representacion escrita del polinomio."""
    try:
        n = len(lista_x)
        texto = "P(x) = "
        
        for i in range(n):
            y_i = lista_y[i]
            if abs(y_i) < 1e-9: continue # Saltar trrminos cero
            
            signo = "+ " if y_i >= 0 else "- "
            if i == 0 and y_i >= 0: signo = ""
            
            # Formato: 2.5 * [ (x-x1)/(x0-x1) * ... ]
            texto += f"{signo}{abs(y_i):.4f}"
            
            terminos_L = ""
            denominador_total = 1.0
            
            for j in range(n):
                if i != j:
                    signo_x = "- " if lista_x[j] >= 0 else "+ "
                    terminos_L += f"(x {signo_x}{abs(lista_x[j]):.2f})"
                    denominador_total *= (lista_x[i] - lista_x[j])
            
            texto += f" * [ {terminos_L} / {denominador_total:.4f} ]\n"
            
        return texto
    except Exception as e:
        return f"Error Texto: {str(e)}"



def generar_grafica_lagrange_bytes(lista_x, lista_y, x_interes):
    """Grafica usando la formula de Lagrange."""
    try:
        n = len(lista_x)
        if n < 2: return "ERROR_PY: Faltan puntos".encode('utf-8')

        # Funcion interna para evaluar Lagrange en cualquier punto v
        def P_Lagrange(v):
            res = 0.0
            for i in range(n):
                term = 1.0
                for j in range(n):
                    if i != j:
                        term *= (v - lista_x[j]) / (lista_x[i] - lista_x[j])
                res += lista_y[i] * term
            return res

        # Configurar grafica
        plt.figure(figsize=(5, 3.5))
        x_min, x_max = min(lista_x), max(lista_x)
        pad = (x_max - x_min) * 0.1 if n > 1 else 1.0
        
        # Generamos 100 puntos para que la curva se vea suave
        x_suave = np.linspace(x_min - pad, x_max + pad, 100)
        y_suave = [P_Lagrange(val) for val in x_suave]

        plt.plot(x_suave, y_suave, 'purple', label='Lagrange', linewidth=1.5) # Color morado para variar
        plt.scatter(lista_x, lista_y, color='red', zorder=5)
        
        # Punto de interes, por alguna razon, esta grafica me costo horrores cuando era casi igual a las demasxd,

        y_int = P_Lagrange(x_interes)
        plt.scatter([x_interes], [y_int], color='orange', marker='*', s=150, zorder=10, label='Interpolado')

        plt.title("Interpolacion de Lagrange")
        plt.grid(True, alpha=0.3)
        plt.legend()
        plt.tight_layout()

        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=90)
        buf.seek(0)
        plt.close('all')
        return buf.getvalue()

    except Exception as e:
        return f"ERROR_PY: {str(e)}".encode('utf-8')

###################################################### INTEGRAGION NUMERICA COMPUESTA ###################################
def integrar_trapecio_compuesto(lista_y_csharp, h):
    """Formula: h/2 * [y0 + 2*sum(yi) + yn]"""
    try:
        # Convertir C# List a Python List (ESTA SOLA LINEA ME TOMO DOS HORAS CORREGIRLA PQ POR ALGUNA RAZON,
        # ARRIBA NO ME DABA ESTE ERRR
        lista_y = list(lista_y_csharp) 


        n = len(lista_y) - 1 
        if n < 1: return "Error: Faltan puntos"
        
        # Ahora si podemos usar slicing de Python [1:-1]
        suma_interna = sum(lista_y[1:-1]) 
        resultado = (h / 2.0) * (lista_y[0] + 2 * suma_interna + lista_y[-1])
        return float(resultado)
    except Exception as e:
        return f"Error Trapecio: {str(e)}"

def integrar_simpson13_compuesto(lista_y_csharp, h):
    """Formula: h/3 * [y0 + 4(impares) + 2(pares) + yn]"""
    try:

        lista_y = list(lista_y_csharp)


        n = len(lista_y) - 1
        if n < 2 or n % 2 != 0: return "Error: Intervalos deben ser pares (Puntos impares)"
        
        # Slicing: [inicio:fin:paso]
        impares = sum(lista_y[1:-1:2]) 
        pares = sum(lista_y[2:-1:2])   
        
        resultado = (h / 3.0) * (lista_y[0] + 4*impares + 2*pares + lista_y[-1])
        return float(resultado)
    except Exception as e:
        return f"Error Simpson 1/3: {str(e)}"

def integrar_simpson38_compuesto(lista_y_csharp, h):
    """Formula: 3h/8 * [y0 + 3(no multiplos de 3) + 2(multiplos de 3) + yn]"""
    try:

        lista_y = list(lista_y_csharp)


        n = len(lista_y) - 1
        if n < 3 or n % 3 != 0: return "Error: Intervalos deben ser multiplo de 3"
        
        suma_total = lista_y[0] + lista_y[-1]
        
        for i in range(1, n):
            if i % 3 == 0:
                suma_total += 2 * lista_y[i]
            else:
                suma_total += 3 * lista_y[i]
                
        resultado = (3.0 * h / 8.0) * suma_total
        return float(resultado)
    except Exception as e:
        return f"Error Simpson 3/8: {str(e)}"

def generar_grafica_integracion(lista_x, lista_y, metodo, func_str):
    """
    Grafica la funcion real (suave) y sombrea el area de los trapecios.
    """
    try:
        n = len(lista_x)
        if n < 2: return "ERROR_PY: Faltan puntos".encode('utf-8')

        plt.figure(figsize=(5, 3.5))
        
        # --- 1. DIBUJAR LA CURVA SUAVE (LA FUNCIoN REAL) ---
        # Creamos una 'x' simbolica y convertimos el texto a funcion GRACIAS SYMPY TEAMO
        x_sym = sp.symbols('x')
        expr = sp.sympify(func_str)
        f_real = sp.lambdify(x_sym, expr, modules=['numpy', 'math'])
        
        # Genero 200 puntos entre el inicio y el fin para que se vea curva
        x_min, x_max = min(lista_x), max(lista_x)
        pad = (x_max - x_min) * 0.05 # Un poquito de margen extra
        
        x_suave = np.linspace(x_min, x_max, 200)
        y_suave = [f_real(val) for val in x_suave]
        
        # Dibujamos la funcion real en AZUL OSCURO
        plt.plot(x_suave, y_suave, 'b-', linewidth=2, label=f'f(x) Real')

        # --- 2. SOMBREAR EL aREA (LA APROXIMACI�N) ---
        # Usamos fill_between con los puntos ORIGINALES. 
        # Esto conectara los puntos con lineas rectas (Trapecios),
        # permitiendo ver visualmente la diferencia con la curva real.
        plt.fill_between(lista_x, lista_y, color='skyblue', alpha=0.4, label='Aprox. Numerica')
        
        # --- 3. DIBUJAR LOS PUNTOS Y DETALLES ---
        plt.scatter(lista_x, lista_y, color='red', zorder=5, s=30)
        
        # Lineas verticales para los intervalos
        for val_x in lista_x:
            plt.axvline(val_x, color='gray', linestyle='--', linewidth=0.5, alpha=0.5)

        plt.title(f"Integracion: {metodo}")
        plt.grid(True, alpha=0.3)
        plt.legend(loc='upper right', fontsize='small')
        plt.tight_layout()

        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=90)
        buf.seek(0)
        plt.close('all')
        return buf.getvalue()

    except Exception as e:
        return f"ERROR_PY: {str(e)}".encode('utf-8')
    
########################################################### CUADRATURA ADAPTIVA ############################################
def simpson_step(f, a, b): #definicion de sipsion (de nuevo) para no perderme con nada de lo de arriba (la reutilizacion de modulos se fue de sabatico)
    c = (a + b) / 2.0
    h = (b - a) / 2.0
    return (h / 3.0) * (f(a) + 4*f(c) + f(b))

# Coso recursivo gg
def adaptive_core(f, a, b, tol, puntos_corte):
    """
    f: funcion compilada
    a, b: intervalo actual
    tol: tolerancia para este intervalo
    puntos_corte: conjunto  para guardar coordenadas x
    """
    c = (a + b) / 2.0
    S_total = simpson_step(f, a, b)
    S_izq = simpson_step(f, a, c)
    S_der = simpson_step(f, c, b)
    
    # Error estimado (Richardson)
    error = abs(S_total - (S_izq + S_der)) / 15.0
    
    if error < tol:
        # Aceptamos el paso
        puntos_corte.add(a)
        puntos_corte.add(b)
        puntos_corte.add(c) # Agregamos el punto medio tambien
        return S_izq + S_der + error # Devolvemos valor refinado
    else:
        # Rechazamos y dividimos mas (tolerancia se divide por 2)
        return adaptive_core(f, a, c, tol/2.0, puntos_corte) + \
               adaptive_core(f, c, b, tol/2.0, puntos_corte)

# --- FUNCIoN PRINCIPAL ADAPTATIVA ---
def integrar_adaptativa_simpson(func_str, a, b, tol):
    try:
        x_sym = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x_sym, expr, modules=['numpy', 'math'])
        
        # Usamos un set para evitar puntos duplicados al guardar
        puntos_corte = set()
        
        # Llamada recursiva inicial
        area = adaptive_core(f, a, b, tol, puntos_corte)
        
        # Convertimos el set a lista ordenada para devolverla
        lista_puntos = sorted(list(puntos_corte))
        
        return area, lista_puntos

    except RecursionError:
        return "Error: La funcion requiere demasiadas divisiones (Recursion infinita).", []
    except Exception as e:
        return f"Error: {str(e)}", []

# --- GRAFICA ADAPTATIVA ---
def generar_grafica_adaptativa(func_str, lista_x_cortes):
    try:
        lista_x_cortes = list(lista_x_cortes)
        x_sym = sp.symbols('x')
        f = sp.lambdify(x_sym, sp.sympify(func_str), modules=['numpy', 'math'])
        
        plt.figure(figsize=(5, 3.5))
        
        # 1. Curva Suave (f(x))
        a, b = lista_x_cortes[0], lista_x_cortes[-1]
        pad = (b - a) * 0.05
        x_suave = np.linspace(a, b, 300)
        y_suave = [f(val) for val in x_suave]
        
        plt.plot(x_suave, y_suave, 'b-', linewidth=2, label='f(x)')
        
        # 2. Sombrear area
        # Evaluamos Y en los puntos de corte para el relleno
        y_cortes = [f(val) for val in lista_x_cortes]
        plt.fill_between(lista_x_cortes, y_cortes, color='lime', alpha=0.2, label='area')
        
        # 3. DIBUJAR LAS LINEAS ADAPTATIVAS (La parte visual importante)
        # Dibujamos lineas verticales rojas donde el algoritmo hizo cortes
        for x_c in lista_x_cortes:
            plt.axvline(x_c, color='red', linestyle='-', linewidth=0.5, alpha=0.6)
            
        plt.title("Malla Adaptativa (Simpson)")
        plt.xlabel(f"Intervalos generados: {len(lista_x_cortes)-1}")
        plt.grid(True, alpha=0.3)
        plt.legend()
        plt.tight_layout()
        
        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=90)
        buf.seek(0)
        plt.close('all')
        return buf.getvalue()

    except Exception as e:
        return f"ERROR_PY: {str(e)}".encode('utf-8')
    
########################################################## CUADRATURA GAUSSIANA #######################################

## Aca de chicharrines, esto de gauss_Data y una parte de las funciones de abajo, se las pedi a chat, busque 
## el como se calculaban las raices de los polinomios de legendre y no pude hacerloxd, entonces opte por solamente
## poner hasta grado 6 (2*6 - 1 = 11), si nos dice algo el maestro, pues ya ni modo, hice lo que pude gg
GAUSS_DATA = {
    2: [(-0.5773502692, 1.0), (0.5773502692, 1.0)],
    3: [(-0.7745966692, 0.5555555556), (0.0, 0.8888888889), (0.7745966692, 0.5555555556)],
    4: [(-0.8611363116, 0.3478548451), (-0.3399810436, 0.6521451549), 
        (0.3399810436, 0.6521451549), (0.8611363116, 0.3478548451)],
    5: [(-0.9061798459, 0.2369268850), (-0.5384693101, 0.4786286705), (0.0, 0.5688888889),
        (0.5384693101, 0.4786286705), (0.9061798459, 0.2369268850)],
    6: [(-0.9324695142, 0.1713244924), (-0.6612093865, 0.3607615730), (-0.2386191861, 0.4679139346),
        (0.2386191861, 0.4679139346), (0.6612093865, 0.3607615730), (0.9324695142, 0.1713244924)]
}

def integrar_gauss(func_str, a, b, n_puntos):
    try:
        if n_puntos not in GAUSS_DATA:
            return f"Error: No tengo datos para {n_puntos} puntos. Elige entre 2 y 6." #esto nunca va a pasar ya que se elige en un combobox pero a este punto, estoy poniendo excepciones en todos lados, me ha ahorrado agnos de vida

        x_sym = sp.symbols('x')
        expr = sp.sympify(func_str)
        f = sp.lambdify(x_sym, expr, modules=['numpy', 'math'])

        suma = 0.0
        datos = GAUSS_DATA[n_puntos]

        m = (b - a) / 2.0
        c = (b + a) / 2.0

        for raiz, peso in datos:
            x_real = m * raiz + c
            suma += peso * f(x_real)

        resultado = m * suma
        return float(resultado)

    except Exception as e:
        return f"Error Gauss: {str(e)}"

def generar_grafica_gauss(func_str, a, b, n_puntos):
    """
    Grafica la funcion, sombrea el area y MARCA los puntos exactos
    donde Gauss evaluo la funcion 
    """
    try:
        x_sym = sp.symbols('x')
        f = sp.lambdify(x_sym, sp.sympify(func_str), modules=['numpy', 'math'])
        
        plt.figure(figsize=(5, 3.5))
        
        # 1. Graficar Curva Suave
        # Damos un margen del 5% para que se vea bien
        margen = (b - a) * 0.05
        if margen == 0: margen = 0.1
        
        x_suave = np.linspace(a - margen, b + margen, 200)
        y_suave = [f(val) for val in x_suave]
        plt.plot(x_suave, y_suave, 'b-', linewidth=2, label='f(x)')
        
        # 2. Sombrear Area Real
        x_area = np.linspace(a, b, 100)
        y_area = [f(val) for val in x_area]
        plt.fill_between(x_area, y_area, color='orange', alpha=0.3, label='Area Integrada')

        # 3. MOSTRAR LOS PUNTOS DE GAUSS (La parte did�ctica)
        # Calculamos donde caen los puntos en el intervalo real
        if n_puntos in GAUSS_DATA:
            m = (b - a) / 2.0
            c = (b + a) / 2.0
            
            puntos_x = []
            puntos_y = []
            
            for raiz, _ in GAUSS_DATA[n_puntos]:
                x_real = m * raiz + c
                puntos_x.append(x_real)
                puntos_y.append(f(x_real))
            
            # Dibujamos puntos rojos grandes
            plt.scatter(puntos_x, puntos_y, color='red', s=60, zorder=10, label='Puntos Gauss')
            
            # Dibujamos lineas punteadas hacia el eje X
            for px, py in zip(puntos_x, puntos_y):
                plt.plot([px, px], [0, py], 'r--', linewidth=0.8, alpha=0.5)

        plt.title(f"Cuadratura Gaussiana (n={n_puntos})")
        plt.grid(True, alpha=0.3)
        plt.legend(loc='upper right', fontsize='small')
        plt.tight_layout()

        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=90)
        buf.seek(0)
        plt.close('all')
        return buf.getvalue()

    except Exception as e:
        return f"ERROR_PY: {str(e)}".encode('utf-8')
    
############################################################ EXTRAPOLACION DE ROMBERG ################################
def integracion_romberg(func_str, a, b, niveles):
    """
    Genera la matriz de Romberg (Extrapolacion de Richardson para integrales).
    Retorna: Lista de listas (Matriz Triangular).
    """
    try:
        x_sym = sp.symbols('x')
        f = sp.lambdify(x_sym, sp.sympify(func_str), modules=['numpy', 'math'])
        
        # Inicializar matriz R (niveles x niveles)
        R = [[0.0] * (i + 1) for i in range(niveles)]
        
        # ---  Columna 0 (Trapecio Recursivo) ---
        # R[0,0] = Trapecio con 1 segmento (h = b-a)
        h = b - a
        R[0][0] = 0.5 * h * (f(a) + f(b))
        
        # Calcular los siguientes niveles de trapecio
        # Usamos la formula recursiva del trapecio para no recalcular todo
        for i in range(1, niveles):
            # h se divide a la mitad en cada nivel
            h = h / 2.0 
            
            # Suma de los nuevos puntos (los que esten en medio de los anteriores)
            # Puntos: a+h, a+3h, a+5h, etc
            suma_nuevos = sum(f(a + k*h) for k in range(1, 2**i, 2))
            
            # Formula recursiva del Trapecio: T_nuevo = 0.5 * T_anterior + h * suma_nuevos
            R[i][0] = 0.5 * R[i-1][0] + h * suma_nuevos
            
        # --- PASO 2: Extrapolacion de Richardson (Columnas 1..k) ---
        # Formula: R[i,j] = (4^j * R[i,j-1] - R[i-1,j-1]) / (4^j - 1)
        for j in range(1, niveles):
            for i in range(j, niveles):
                factor = 4**j
                numerador = factor * R[i][j-1] - R[i-1][j-1]
                denominador = factor - 1
                R[i][j] = numerador / denominador
                
        return R

    except Exception as e:
        return f"Error Romberg: {str(e)}"

def generar_grafica_romberg(func_str, a, b):
    """
    Grafica la funcion y sombrea el area (Simple, para referencia visual).
    """
    try:
        x_sym = sp.symbols('x')
        f = sp.lambdify(x_sym, sp.sympify(func_str), modules=['numpy', 'math'])
        
        plt.figure(figsize=(5, 3.5))
        
        # Graficar funcion suave
        margen = (b - a) * 0.1
        if margen == 0: margen = 0.1
        x_suave = np.linspace(a - margen, b + margen, 200)
        y_suave = [f(val) for val in x_suave]
        
        plt.plot(x_suave, y_suave, 'b-', linewidth=2, label='f(x)')
        
        # Sombrear el area de integracion
        x_area = np.linspace(a, b, 100)
        y_area = [f(val) for val in x_area]
        plt.fill_between(x_area, y_area, color='cyan', alpha=0.3, label='Area')
        
        # Lineas verticales en los limites
        plt.axvline(a, color='gray', linestyle='--')
        plt.axvline(b, color='gray', linestyle='--')

        plt.title("Integracion (area bajo la curva)")
        plt.grid(True, alpha=0.3)
        plt.legend(loc='upper right')
        plt.tight_layout()

        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=90)
        buf.seek(0)
        plt.close('all')
        return buf.getvalue()

    except Exception as e:
        return f"ERROR_PY: {str(e)}".encode('utf-8')
    
################################################# INTEGRACION MULTIPLE ############################################3
## Como no vimos ninguna tecnica de integracion multiple, se investigo la tecnica del trapecio en 2d
## y simpson 2d.

def integrar_doble_trapecio_simple(func_str, a, b, c, d):
    """
    Calcula la integral doble aproximada usando Trapecio Simple 2D.
    a, b: Limites de x
    c, d: Limites de y
    """
    try:
        # 1. Definir dos simbolos
        x, y = sp.symbols('x y')
        
        # 2. Parsear la funcion
        expr = sp.sympify(func_str)
        
        # 3. Compilar con dos letras gg (x,y)
        f = sp.lambdify((x, y), expr, modules=['numpy', 'math'])
        
        # 4. Evaluar en las 4 esquinas
        # f(a, c), f(b, c), f(a, d), f(b, d)
        val_ac = f(a, c)
        val_bc = f(b, c)
        val_ad = f(a, d)
        val_bd = f(b, d)
        
        # 5. Aplicar formula: AreaBase / 4 * SumaAlturas
        area_base = (b - a) * (d - c)
        promedio_alturas = (val_ac + val_bc + val_ad + val_bd) / 4.0
        
        resultado = area_base * promedio_alturas
        
        return float(resultado)

    except Exception as e:
        return f"Error Integral Doble: {str(e)}"
    
    
## Esta funcion se investigo y medianamente se intento programar, diria yo que no tiene errores pero no termine
## de entender bien la parte de la malla, vi videos y la implementacion era algo asixd
def integrar_doble_simpson(func_str, a, b, c, d):
    
    """
    Calcula la integral doble usando Simpson 1/3 
    """
    try:
        x, y = sp.symbols('x y')
        f = sp.lambdify((x, y), sp.sympify(func_str), modules=['numpy', 'math'])
        
        # Puntos medios y pasos
        mx = (a + b) / 2.0
        my = (c + d) / 2.0
        
        hx = (b - a) / 2.0
        hy = (d - c) / 2.0
        
        # Evaluamos los 9 puntos de la malla
        # Fila superior (d)
        z1 = f(a, d)  # Esquina
        z2 = f(mx, d) # Medio borde
        z3 = f(b, d)  # Esquina
        
        # Fila media (my)
        z4 = f(a, my) # Medio borde
        z5 = f(mx, my)# CENTRO
        z6 = f(b, my) # Medio borde
        
        # Fila inferior (c)
        z7 = f(a, c)  # Esquina
        z8 = f(mx, c) # Medio borde
        z9 = f(b, c)  # Esquina
        
        # Aplicamos pesos de Simpson (1-4-1) * (1-4-1)
        # Esquinas * 1
        suma_esquinas = z1 + z3 + z7 + z9
        
        # Bordes * 4
        suma_bordes = 4 * (z2 + z4 + z6 + z8)
        
        # Centro * 16
        centro = 16 * z5
        
        suma_total = suma_esquinas + suma_bordes + centro
        
        # Formula: (hx * hy / 9) * Suma
        resultado = (hx * hy / 9.0) * suma_total
        
        return float(resultado)

    except Exception as e:
        return f"Error Simpson Doble: {str(e)}"

############################################ ALGEBRA LINEAL PIVOTEO NORMAL ###################################


## A este punto, el codigo a partir de aqui, es PURA BASURA, la mayor parte salio con prueba y error,
## se que hace la mayor parte del codigo pero si me preguntan que hace x linea explicitamente, seguramente
## no me voy a acordar del todo (si es muy compleja. btw, segun yo, comente bien paso a paso
# pero pues es igual) puesto que unas partes (seguramente se van a dar
## cuenta de cuales) tuve que investigarlas como hacerlas. MUY POSIBLEMENTE, habia formas mas eficientes
## o mas sencillas de realizarse, sin embargo, mi cerebro no me dio para masxd, si quieren, pueden tocar
## el codigo si ven que en alguna parte se podria hacer mas eficiente, sino, dejenlo como esta, si funciona,
## no veo razon para cambiarlo. ah si, la modularizacion se fue de sabatico, hay partes del codigo donde
## hubiera sido mas facil crear una funcion y solo mandarla a llamar, pero como notaran, solo copiaba esas
## partes del codigo y las volvia a pegar. Ya se que python es muy flexible en cuanto a tipos de datos, 
## sin embargo, no modularizaba para evitarme problemas con el tipado (comportamientos extragnos).

## ESA ULTIMA PARTE, la de evitarme problemas copiando y pegando codigo, la hice asi porque de esa forma me
## era muchisimo, MUCHISIMO mas facil debuggear puesto que el codigo esta lleno de try-catch y 
## throw-exceptionsxd

##ACTUALIZACION = mande al diablo todo el codigo de los pivoteos y lo hice casi de 0 pq de plano la funcion
## quedo horriblemente mal y aun con los comentarios que le iba poniendo, yo mismo me perdia en el codigoxd
## Entonces, diria yo que esta vez el codigo ya se ve bien y esta medianamente optimizado, asi mismo
## ya no parece espageti (quiero pensar). Por otro lado, cada linea tiene su comentario de lo que hace,
## en caso de que el profesor nos pregunte que hace cada cosa gg.

def resolver_gauss_general(matriz_aumentada, metodo):
    """
    Resuelve el sistema Ax=b usando Eliminacion Gaussiana con el metodo de pivoteo elegido.
    metodo: "Parcial", "Escalado", "Total"
    """
    try:
        # Convertimos a float y trabajamos con copias
        M = [[float(val) for val in fila] for fila in matriz_aumentada]
        n = len(M)
        
        # Para Pivoteo Total: Necesitamos rastrear el orden de las variables (x0, x1, x2...)
        # Inicialmente el orden es [0, 1, 2, ..., n-1]
        orden_vars = list(range(n))

        # Para Pivoteo Escalado: Calculamos los factores de escala iniciales (maximo abs de cada fila)
        # S[i] = max(|ai1|, |ai2|..., |ain|)xd
        S = []
        if metodo == "Escalado":
            for i in range(n):
                max_val = max(abs(M[i][j]) for j in range(n))
                if max_val == 0: return "Error: Una fila es completamente ceros."
                S.append(max_val)

        # --- CICLO PRINCIPAL DE ELIMINACIÓN ---
        for k in range(n - 1):
            
            # --- ESTRATEGIA DE SELECCIÓN DEL PIVOTE ---
            fila_max = k
            col_max = k # Solo usado en Total

            if metodo == "Parcial":
                # Buscar el mayor |M[i][k]| en la columna k (desde k hacia abajo)
                mayor_valor = abs(M[k][k])
                for i in range(k + 1, n):
                    val = abs(M[i][k])
                    if val > mayor_valor:
                        mayor_valor = val
                        fila_max = i
            
            elif metodo == "Escalado":
                # Buscar el mayor cociente |M[i][k]| / S[i]
                mayor_ratio = abs(M[k][k]) / S[k]
                for i in range(k + 1, n):
                    ratio = abs(M[i][k]) / S[i]
                    if ratio > mayor_ratio:
                        mayor_ratio = ratio
                        fila_max = i

            elif metodo == "Total":
                # Buscar el mayor valor absoluto en TODA la submatriz restante, ESTA PARTE SALIO A PRUEBA Y ERROR JDASDJSAJKL
                mayor_valor = 0
                for i in range(k, n):
                    for j in range(k, n):
                        if abs(M[i][j]) > mayor_valor:
                            mayor_valor = abs(M[i][j])
                            fila_max = i
                            col_max = j

            # --- INTERCAMBIOS ---
            
            #  Si es Pivoteo Total y el maximo esta en otra columna, cambiamos COLUMNAS
            if metodo == "Total" and col_max != k:
                # Intercambiar columnas en la matriz
                for i in range(n):
                    M[i][k], M[i][col_max] = M[i][col_max], M[i][k]
                
                # IMPORTANTE: Recordar que cambiamos el orden de las variables
                orden_vars[k], orden_vars[col_max] = orden_vars[col_max], orden_vars[k]

            #  Intercambio de FILAS (Comun para todos los metodos)
            if fila_max != k:
                M[k], M[fila_max] = M[fila_max], M[k]
                # En escalado, tambien intercambiamos el factor de escala correspondiente
                if metodo == "Escalado":
                    S[k], S[fila_max] = S[fila_max], S[k]

            # Validacion: Si el pivote es 0, el sistema no tiene solucion unica
            if abs(M[k][k]) < 1e-31: #ya se que no es cero, pero si pasa de los 15 ceros, el float no lo va a guardar directamente
                return f"Error: Pivote cercano a cero en paso {k}."

            # --- ELIMINACIÓN GAUSSIANA (Hacer ceros abajo) ---
            for i in range(k + 1, n):
                factor = M[i][k] / M[k][k]
                for j in range(k, n + 1): # n+1 porque incluye la columna de resultados (i guess)
                    M[i][j] -= factor * M[k][j]

        # Guardamos la matriz triangular para mostrarla
        matriz_triangular = [fila[:] for fila in M]

        # --- SUSTITUCIoN HACIA ATRÁS ---
        x_calc = [0.0] * n
        
        # Validacion final del último elemento (M[n-1][n-1])
        if abs(M[n-1][n-1]) < 1e-31: return "Error: ultimo pivote 0."

        for i in range(n - 1, -1, -1):
            suma = sum(M[i][j] * x_calc[j] for j in range(i + 1, n))
            x_calc[i] = (M[i][n] - suma) / M[i][i]

        # --- REORDENAMIENTO FINAL (Solo afecta a Total) ---
        # Si x_calc nos dio [val1, val2], pero orden_vars es [1, 0] (se cambiaron las cols)
        # significa que val1 corresponde a x1 y val2 a x0.
        #ESTE SOLO BLOQUE DE CODIGO ME COSTO AGNOS DE VIDA, ACA DE CHICHARRINES
        #ME QUERIA SACAR LOS OJOS Y NO QUERIA SABER NADA DE NADIE
        #ESTUVE APUNTO DE DECIRLES QUE NOS FUERAMOS A EXTRA DJDSAKJASDKLASDKJLADSKJLASDL;KJDSAKJLSADKJ;L
        
        x_final = [0.0] * n
        for i in range(n):
            var_index = orden_vars[i] # Que variable es esta realmente?
            x_final[var_index] = x_calc[i] # Es la encargada de decir que x le corresponde a cada una,
            #por ejemplo, digamos que el orden de las columnas quedo x3,x2,x1, y si no lo guardaramos en esa
            #lista, el messageDialog diria que el valor de las variables es x1= a, x2=b, x3=c
            #cuando realmente deberia de decir algo como x1=c,x2=b,x3=a.
            #mandame mensaje si no etendiste gg.

        return [matriz_triangular, x_final]

    except Exception as e:
        return f"Error Gauss {metodo}: {str(e)}"
    
#################################################### FACTORIZACIONES DE MATRICES ################################
"""
Seguramente ya se dieron cuenta en la parte de arriba, pero a partir de aca se nota un poco mas, comence a
usar a cada rato ciclos del tipo [[loquesea for i in range(x)] for j in range(y)], lo que esta pasando
aca es que creamos una lista (for entre corchetes de adentro) de listas (for de afuera de los corchetes 
centrales), lo hice de esta forma ya que c# esta recibiendo list<list<loquesea>>, entonces para tener 
todas las matrices de una forma similar, las cree asi

Por si no sabian, el hacer [algo for i in range(k)], evalua 'algo' y posteriormente crea una lista con ello,
al principio se ve extragno pero es realmente util para todo lo que hago mas adelante
"""
def obtener_determinante(matriz): #aca de amigos, esta funcion la saque de youtube (vi un tutorial y la copie), todo lo demas si lo hicexd
    """Calculo recursivo de determinante."""
    n = len(matriz)
    if n == 1: return matriz[0][0]
    if n == 2: return matriz[0][0]*matriz[1][1] - matriz[0][1]*matriz[1][0]
    det = 0
    for c in range(n):
        sub_m = [fila[:c] + fila[c+1:] for fila in matriz[1:]]
        det += ((-1)**c) * matriz[0][c] * obtener_determinante(sub_m)
    return det

def es_simetrica(M):
    """Verifica si A == A^T"""
    n = len(M)
    for i in range(n):
        for j in range(i + 1, n):
            if abs(M[i][j] - M[j][i]) > 1e-15: ##lo mismo que en los anteiores, usamos floats
                return False
    return True

def esMatrizDF(M): #Esta funcion igual la saque de un tutorial de youtube j;adssadjjkl
    """
    Verifica si es Definida Positiva.
    """
    if not es_simetrica(M): return False
    
    n = len(M)
    for k in range(1, n + 1):
        # Submatriz de k x k (esquina superior izquierda)
        sub_matriz = [fila[:k] for fila in M[:k]]
        if obtener_determinante(sub_matriz) <= 0:
            return False
    return True

# --- LOGICA DE SELECCION ---

def analizar_metodos_disponibles(matriz_aumentada):
    """Devuelve la lista de metodos validos para la matriz dada."""
    M = [[float(val) for val in fila] for fila in matriz_aumentada]
    metodos = []

    # PLU siempre es una opcion (general)
    metodos.append("PLU (Pivoteo)")

    # LU Simple requiere que no haya ceros en la diagonal
    if all(abs(M[i][i]) > 1e-10 for i in range(len(M))):
        metodos.append("LU Simple")

    # Cholesky requiere Simetrica Definida Positiva
    if esMatrizDF(M):
        metodos.append("LLT (Cholesky)")

    return metodos

# ---  ALGORITMOS DE FACTORIZACION ---

def resolver_factorizacion(matriz, metodo):
    """Retorna [L, U, P] dependiendo del metodo."""
    M = [[float(val) for val in fila] for fila in matriz]
    n = len(M)
    
    # Matriz P inicializada como Identidad
    P = [[1.0 if i == j else 0.0 for j in range(n)] for i in range(n)]
    L = [[0.0]*n for _ in range(n)]
    U = [[0.0]*n for _ in range(n)]

    try:
        if "Cholesky" in metodo:
            # --- CHOLESKY (LLT) ---
            if not esMatrizDF(M): return "Error: La matriz no es Definida Positiva." #btw, esto nunca deberia de pasar
            
            for i in range(n):
                for k in range(i + 1):
                    suma = sum(L[i][j] * L[k][j] for j in range(k))
                    if i == k: # Elementos diagonal
                        val = M[i][i] - suma
                        if val <= 0: return "Error: Raiz negativa en Cholesky."
                        L[i][k] = math.sqrt(val)
                    else: # Elementos fuera diagonal
                        L[i][k] = (1.0 / L[k][k] * (M[i][k] - suma))
            
            # En Cholesky, U es la transpuesta de L
            U = [[L[j][i] for j in range(n)] for i in range(n)]
            return [L, U, P] # P es identidad

        elif "PLU" in metodo:
            # --- PLU (Con Pivoteo) ---
            U = [fila[:] for fila in M] # Copia inicial

            for k in range(n):
                # Pivoteo Parcial
                pivote = k
                max_val = abs(U[k][k])
                for i in range(k+1, n):
                    if abs(U[i][k]) > max_val:
                        max_val = abs(U[i][k])
                        pivote = i
                
                # Intercambios en U, P y L
                U[k], U[pivote] = U[pivote], U[k]
                P[k], P[pivote] = P[pivote], P[k]
                if k > 0:
                    for col in range(k):
                        L[k][col], L[pivote][col] = L[pivote][col], L[k][col]

                L[k][k] = 1.0
                for i in range(k+1, n):
                    if abs(U[k][k]) < 1e-15: return "Error: Pivote 0 en PLU."
                    factor = U[i][k] / U[k][k]
                    L[i][k] = factor
                    U[i][k] = 0.0
                    for j in range(k+1, n):
                        U[i][j] -= factor * U[k][j]
            return [L, U, P] # PLU la hice con ayuda de chat pq no me salia P E R D O N, hice lo mejor que pude

        else:
            # --- LU  ---
            for i in range(n):
                # Calcular U
                for k in range(i, n):
                    suma = sum(L[i][j] * U[j][k] for j in range(i))
                    U[i][k] = M[i][k] - suma
                # Calcular L
                for k in range(i, n):
                    if i == k:
                        L[i][i] = 1.0
                    else:
                        suma = sum(L[k][j] * U[j][i] for j in range(i))
                        if abs(U[i][i]) < 1e-15: return "Error: Pivote 0 en LU Simple."
                        L[k][i] = (M[k][i] - suma) / U[i][i]
            return [L, U, P] # P es identidad

    except Exception as e:
        return f"Error Algoritmo: {str(e)}"
   

############################## METODO DE EULER PARA ECUACIONES DIFERENCIALES ###########################
""" 
Para simplificar calculos y evitarnos hacer mucha alebra simbolica, opte por pedir la ecuacion con la y' ya 
despejada (y tambien porque aun con sympy, no tengo ni la menor idea de como hacer despeje de variables
de forma simbolicaxd)


AVISO: Esto funciona con
"""

def resolver_euler(ecuacion_str, x0, y0, h, x_final):
    """
    Resuelve EDO usando Euler.
    este funciona como f(x,y) y no cmo f(t,y) pq usa eval() y esa funciona solo con x,y gg
    """
    try:
        #  Convertir datos que vienen de C# (strings) a numeros
        x = float(x0)
        y = float(y0)
        hh = float(h)
        meta = float(x_final)
        
        resultados = []
        i = 0
        
        #  Ciclo principal 
        while x < meta + 1e-15: #por si es un numero extragno (muchisimos decimales), mejor prevenir que lamentar 
            
            funcion = eval(ecuacion_str) 

            # Formula de Euler: w_i+1 = w_actual + h * f(x,y)
            y_siguiente = y + hh * funcion
            
            # Guardamos: [Iteracion, X actual, Y actual, Y calculada]
            resultados.append([i, x, y, y_siguiente])
            
            # Actualizamos variables para la siguiente vuelta
            y = y_siguiente
            x += hh
            i += 1
            
        return resultados

    except Exception as e:
        return f"Error en la formula: {str(e)}"

########################################### TAYLOR DE ORDEN SUPERIOR ##################################
# La verdad es que aca si abuse de sympy, la biblioteca hizo casi todo (derivo y evaluo) gg
def resolver_taylor_comparativo(ecuacion_str, t0, w0, h, t_final):
    """
    Calcula Taylor de Orden 2, 3 y 4 simultaneamente.
    Usa sympy para derivadas simbolicas.
    """
    try:
        # 1. Definir variables simbolicas
        t, y = sp.symbols('t y')
        
        # 2. Parsear la ecuacion del usuario (f)
        # y' = f(t,y)
        f = sp.sympify(ecuacion_str)

        # 3. Calcular Derivadas Totales (Regla de la cadena)
        # y'' = f' = df/dt + df/dy * y'
        # y''' = f'' ...
        
        # Derivada 1 (f) -> Ya la tenemos, es f
        d1 = f 
        
        # Derivada 2 (f') -> df/dt + df/dy * f
        d2 = sp.diff(d1, t) + sp.diff(d1, y) * d1
        
        # Derivada 3 (f'') -> d(d2)/dt + d(d2)/dy * f
        d3 = sp.diff(d2, t) + sp.diff(d2, y) * d1
        
        # Derivada 4 (f''') 
        d4 = sp.diff(d3, t) + sp.diff(d3, y) * d1

        # 4. Crear funciones Python rapidas (lambdify)
        # Esto convierte la expresion simbolica en una funcion normal de python
        # para evaluarla rapido en el bucle.
        F1 = sp.lambdify((t, y), d1, 'math')
        F2 = sp.lambdify((t, y), d2, 'math')
        F3 = sp.lambdify((t, y), d3, 'math')
        F4 = sp.lambdify((t, y), d4, 'math')
        
        # 5. Inicializar variables numericas
        ti = float(t0)
        paso = float(h)
        meta = float(t_final)
        
        # Mantenemos 3 simulaciones independientes
        w2 = float(w0) # Para Orden 2
        w3 = float(w0) # Para Orden 3
        w4 = float(w0) # Para Orden 4
        
        resultados = []
        iteracion = 0
        
        # Guardar estado inicial
        resultados.append([iteracion, ti, w2, w3, w4])
        
        # 6. Bucle de resolucion
        while ti < meta - (paso/1000.0): # Tolerancia flotante
            
            # --- TLO (Termino Local de Orden) ---
            # Taylor formula: w_next = w + h * (f + h/2*f' + ...)
            
            # Calculos para Orden 2 (usa w2)
            val_f = F1(ti, w2)
            val_f_prime = F2(ti, w2)
            T2 = val_f + (paso/2)*val_f_prime
            w2_sig = w2 + paso * T2
            
            # Calculos para Orden 3 (usa w3)
            # Reevaluamos derivadas con w3 porque las trayectorias divergen
            v3_f = F1(ti, w3)
            v3_fp = F2(ti, w3)
            v3_fpp = F3(ti, w3)
            T3 = v3_f + (paso/2)*v3_fp + (paso**2/6)*v3_fpp
            w3_sig = w3 + paso * T3
            
            # Calculos para Orden 4 (usa w4)
            v4_f = F1(ti, w4)
            v4_fp = F2(ti, w4)
            v4_fpp = F3(ti, w4)
            v4_fppp = F4(ti, w4)
            T4 = v4_f + (paso/2)*v4_fp + (paso**2/6)*v4_fpp + (paso**3/24)*v4_fppp
            w4_sig = w4 + paso * T4
            
            # Actualizar tiempos y valores
            ti += paso
            w2 = w2_sig
            w3 = w3_sig
            w4 = w4_sig
            iteracion += 1
            
            resultados.append([iteracion, ti, w2, w3, w4])
            
        return resultados

    except Exception as e:
        return f"Error Taylor: {str(e)}"
    
######################################## RUNGEKUTTA DE ORDEN 2,3,4 ################################
#Este fue probabemente el metodo ams facil de todo el programa, salio como en 15 minutos pq
# ya teniamos las formulasxd
def resolver_rk_general(ecuacion_str, t0, w0, h, t_final, metodo_tipo):
    """
    Resuelve EDO usando RK2, RK3 o RK4.
    metodo_tipo: 2, 3 o 4 (int) indicando el orden.
    Retorna: [iter, t, w, [k1, k2, k3, k4]]
    """
    try:
        t = float(t0)
        w = float(w0)
        paso = float(h)
        meta = float(t_final)
        
        resultados = [] # Lista principal
        i = 0
        
        # Guardamos la fila inicial (iteracion 0). Las K son 0 porque no se han calculado.
        # Formato: [i, t, w, [k1, k2, k3, k4]], efectivamente, estoy abusando de las listas, otra vez
        resultados.append([i, t, w, [0.0, 0.0, 0.0, 0.0]]) 
        
        while t < meta:
            
            # Funcion auxiliar para evaluar f(t, y) rapido sin repetir codigo
            def f(t_val, y_val):
                # Contexto local para eval
                local_vars = {"t": t_val, "y": y_val}
                # eval usa globals() para tomar funciones de math (sin, cos, etc),
                # estas 3 lineas de codigo las caque de chat pq por alguna razon, el evaluarlas asi nadamas como en Euler daba error, no tengo idea porque pero bueno
                return eval(ecuacion_str, globals(), local_vars)

            # Inicializamos lista de Ks
            ks = [0.0, 0.0, 0.0, 0.0] 
            w_sig = 0.0

            if metodo_tipo == 2:
                # --- RK2  ---
                # k1 = h * f(t, w)
                # k2 = h * f(t + h/2, w + k1/2)
                # w_sig = w + k2
                
                k1 = paso * f(t, w)
                k2 = paso * f(t + paso/2, w + k1/2)
                
                w_sig = w + k2
                ks = [k1, k2, 0.0, 0.0]

            elif metodo_tipo == 3:
                # --- RK3 o huen ---
                # k1 = h * f(t, w)
                # k2 = h * f(t + h/2, w + k1/2)
                # k3 = h * f(t + h, w - k1 + 2*k2)
                # w_sig = w + (k1 + 4*k2 + k3) / 6
                
                k1 = paso * f(t, w)
                k2 = paso * f(t + paso/2, w + k1/2)
                k3 = paso * f(t + paso, w - k1 + 2*k2)
                
                w_sig = w + (k1 + 4*k2 + k3) / 6.0
                ks = [k1, k2, k3, 0.0]

            elif metodo_tipo == 4:
                # --- RK4  ---
                # k1 = h * f(t, w)
                # k2 = h * f(t + h/2, w + k1/2)
                # k3 = h * f(t + h/2, w + k2/2)
                # k4 = h * f(t + h, w + k3)
                # w_sig = w + (k1 + 2*k2 + 2*k3 + k4) / 6
                
                k1 = paso * f(t, w)
                k2 = paso * f(t + paso/2, w + k1/2)
                k3 = paso * f(t + paso/2, w + k2/2)
                k4 = paso * f(t + paso, w + k3)
                
                w_sig = w + (k1 + 2*k2 + 2*k3 + k4) / 6.0
                ks = [k1, k2, k3, k4]
            
            # Avanzamos
            i += 1
            t += paso
            w = w_sig
            
            # Guardamos la fila completa con las Ks que generaron este nuevo W
            resultados.append([i, t, w, ks])

        return resultados

    except Exception as e:
        return f"Error RK: {str(e)}"
    
######################################### RK FELBERG ################################################
"""
Este fue posiblemente (junto a factorizacion de matrices) el metodo que mas tiempo y trabajo me costo,
aparentemente era sencillo (o eso pense) pero me lleve MUCHO, MUCHO en este metodo, creo que en git
solo aparece una pequena diferencia de horas entre push y push pero es pq esas diferencias fue el tiempo que
tarde en hacer la conexion en python bridge. Para hacer cada metodo lo hacia en notebooks y los probaba ahi.

Comente todo lo mejor que pude pero hay algunas partes pequenas que salieron de pura prueba y error,
solo dios y yo sabiamos como funcionaban esas partes, y ahora solo dios lo sabe
"""

def resolver_rkf(ecuacion_str, t0, w0, h_input, t_final, tol_input, factor_input):
    """
    Implementa Runge-Kutta-Fehlberg con paso adaptativo.
    Retorna filas con estado de aceptacion y calculo de nuevo h.
    """
    try:
        t = float(t0)
        w = float(w0)
        h = float(h_input)
        meta = float(t_final)
        tol = float(tol_input)
        factor = float(factor_input)
        
        resultados = []
        i = 0
        
        # Agregamos fila inicial
        # [i, h, t, k1..k6, w4, w5, R, Aceptado?, ParteFormula, q, qh]
        resultados.append([i, h, t, 0,0,0,0,0,0, w, w, 0, "Inicio", 0, 0, 0])
        
        # Funcion auxiliar para evaluar f(t,y)
        def f(t_val, y_val):
            return eval(ecuacion_str, globals(), {"t": t_val, "y": y_val})

        # Loop principal (con proteccion de iteraciones infinitas)
        max_iter = 5000
        while t < meta and i < max_iter:
            
            # --- 1. Calcular Coeficientes K ---
            k1 = h * f(t, w)
            
            k2 = h * f(t + h/4, w + k1/4)
            
            k3 = h * f(t + 3*h/8, w + 3*k1/32 + 9*k2/32)
            
            k4 = h * f(t + 12*h/13, w + 1932*k1/2197 - 7200*k2/2197 + 7296*k3/2197)
            
            k5 = h * f(t + h, w + 439*k1/216 - 8*k2 + 3680*k3/513 - 845*k4/4104)
            
            k6 = h * f(t + h/2, w - 8*k1/27 + 2*k2 - 3544*k3/2565 + 1859*k4/4104 - 11*k5/40)

            # ---  Calcular Aproximaciones ---
            # Orden 4 (wi)
            w4 = w + 25*k1/216 + 1408*k3/2565 + 2197*k4/4104 - k5/5
            
            # Orden 5 (Wi_Mejor)
            w5 = w + 16*k1/135 + 6656*k3/12825 + 28561*k4/56430 - 9*k5/50 + 2*k6/55

            # --- 3. Calcular Error R ---
            # Formula : R = 1/h * |wi+1_MEJOR - wi+1|
            diff = abs(w5 - w4)
            if h == 0: R = 0 # Evitar error div/0
            else: R = (1.0 / h) * diff
            
            # Evitar R=0 exacto para no dividir entre cero luego 
            """
            ESA SOLA LINEA ME DEJO LOCO AMIGO, SALIO A PURA PRUEBA Y ERROR KJADKLADSDSAKJ
            """
            if R < 1e-15: R = 1e-15 

            # --- 4. Calcular Factores de Ajuste (q) ---
            # Formula: q = factor * (tol / R)^(1/4)
            parte_formula = (tol / R)**0.25
            q = factor * parte_formula
            
            # Nuevo h propuesto
            qh = q * h
            
            # --- 5. Decision: Aceptar o Rechazar ---
            aceptado = ""
            
            if R <= tol:
                # CASO: EXITO
                aceptado = "Si"
                
                # Guardamos la fila del calculo exitoso
                i += 1
                resultados.append([
                    i, h, t + h, 
                    k1, k2, k3, k4, k5, k6, 
                    w4, w5, 
                    R, aceptado, parte_formula, q, qh
                ])
                
                # Actualizamos variables para el SIGUIENTE paso
                w = w5     # Nos quedamos con la aproximacion mas precisa
                t = t + h  # Avanzamos t
                
                # Para la siguiente iteracion, usamos el q*h calculado como nuevo h
                if t + qh > meta:
                    h = meta - t
                else:
                    h = qh #Lo que dijo el maestro gg
                
            else:
                # CASO: FALLO (El error es muy grande)
                aceptado = "No (Repetir)"
                
                # Guardamos la fila para mostrar que falló (pero no incrementamos i ni t)
                resultados.append([
                    i+1, h, t + h, # Mostramos t+h tentativo
                    k1, k2, k3, k4, k5, k6, 
                    w4, w5, 
                    R, aceptado, parte_formula, q, qh
                ])
                
                # RECHAZAMOS h. 
                # No actualizamos ni w ni t.
                # Simplemente cambiamos h por el nuevo qh (que sera mas pequeño) y repetimos.
                h = qh

        return resultados

    except Exception as e:
        return f"Error RKF: {str(e)}"
    

################################################ ADAMS BACHFORT  GG ##########################################
def resolver_adams_bashforth(ecuacion_str, t0, w0, h, t_final, pasos_int):
    """
    Resuelve EDO usando Adams-Bashforth (Explicito).
    Requiere arrancar con RK4.
    pasos_int: Numero de pasos hacia atras (2, 3, 4, 5).
    (Investigue eso de los pasos y lo puse en el programa pq no encontraba la libreta y solo tenia foto
    de las formulas de la clase)
    """
    try:
        t = float(t0)
        w = float(w0)
        paso = float(h)
        meta = float(t_final)
        orden = int(pasos_int)
        
        resultados = [] # [i, t, w, metodo_usado]
        funciones = [] # Historial de f(t, w) necesario para Adams
        
        # Funcion auxiliar f(t,y)
        def f(t_val, y_val):
            return eval(ecuacion_str, globals(), {"t": t_val, "y": y_val})

        i = 0
        resultados.append([i, t, w, "Inicio"])
        funciones.append(f(t, w)) # Guardamos f0

        # ---  ARRANQUE  ---
        # Necesitamos generar 'orden - 1' puntos extra para tener suficiente historia.
        
        for _ in range(orden - 1):
            if t >= meta: break 

            # Logica RK4 (Si, podria haber hecho a funcion simple y madnarla a llamar pero a este punto prefiero copiar y
            # pegar codigo para saber donde fue el error al debbugear, gracias a los throw Exceptions)
            k1 = paso * f(t, w)
            k2 = paso * f(t + paso/2, w + k1/2)
            k3 = paso * f(t + paso/2, w + k2/2)
            k4 = paso * f(t + paso, w + k3)
            
            w = w + (k1 + 2*k2 + 2*k3 + k4) / 6.0
            t += paso
            i += 1
            
            resultados.append([i, t, w, "Arranque (RK4)"])
            funciones.append(f(t, w)) # Guardamos la funcion de este nuevo punto

        # --- FASE 2: ADAMS-BASHFORTH ---
        # Ahora que tenemos la lista 'funciomes' llena con los puntos necesarios...
        
        max_iter = 10000
        while t < meta and i < max_iter:
            
            w_sig = 0
            
            # Accedemos a las funciones guardadas desde el final hacia atras
            # p[-1] es fi, p[-2] es fi-1, etc.
            p = funciones
                     
            if orden == 4:
                # w_i+1 = w_i + h/24 * (55fi - 59fi-1 + 37fi-2 - 9fi-3)
                w_sig = w + (paso/24.0) * (55*p[-1] - 59*p[-2] + 37*p[-3] - 9*p[-4])
                
            elif orden == 5:
                # w_i+1 = w_i + h/720 * (1901fi - 2774fi-1 + 2616fi-2 - 1274fi-3 + 251fi-4)
                w_sig = w + (paso/720.0) * (1901*p[-1] - 2774*p[-2] + 2616*p[-3] - 1274*p[-4] + 251*p[-5])

            # Actualizamos variables
            w = w_sig
            t += paso
            i += 1
            
            resultados.append([i, t, w, f"Adams (Orden {orden})"])
            
            # Guardamos la nueva funcion para el futuro
            funciones.append(f(t, w))
            

        return resultados

    except Exception as e:
        return f"Error Adams: {str(e)}"

    ###################################### COSO DE MINIMOS CUADRADOS #############################################

def resolver_minimos_cuadrados(puntos_x, puntos_y, tipo, grado_poly=1):
    """
    Resuelve minimos cuadrados, evalua con Sympy y grafica con Matplotlib.
    Retorna: [EcuacionStr, ListaCoeficientes, ListaYEvaluada, ImagenBase64]
    Aunque el codigo se vea aca todo verboso, realmente ha sido de los metodos mas facilesxd
    es posible que sea pq lo vimos en PPCD y casi que hice la misma implementacionxd, la unica
    diferencia con la notebook de PPCD es q aca integramos nosotros el metodo de las ecuaciones,
    de ahi en fuera, la mayor parte lo vimos en PPCD
    """
    try:
        #print(tipo)
        """
        NO TIENEN NI FOKIN IDEA DE LO QUE ME COSTO ESTE CODIGO, FUNCIONABA EN NOTEBOOKS Y TODO EPRO CASUALMENTE
        CADA QUE ELEGIA EXPONENCIAL AQUI, daba pivote cercano a 0, pense que eran los numeros y me puse a hacer pruebas a mano
        en la libreta, no encontraba nada, fui a c# y movi de todo para DESPUES DE TRES 3 HORAS DE MRD encontrara que el error
        estaba en el combobox, porque c# enviaba la formula del exponencial pero en python lo tenia como Exponencial 1 o algo asi
        entonces se saltaba los pasos de los elifs y metia una matriz 2x2 en una de tamano m+2 x m+1 entonces daba 0 el pivote al 
        momento de resolver, NOTAR ESE ERROR ME COSTO HORAS DE VIDA, por eso deje ahi comentado el print pq fue gracioso que
        despues de estar a punto de sacarme los ojos se me ocurriera imprimir el tipo que se estaba pasando y me diera esoxdddddd
        """


        # -- PREPARACIÓN DE DATOS ---
        X_proc = []
        Y_proc = []
        m = grado_poly #poly por monopoly (me gusta mucho el monopoly imperio JHKLDSAHKLSAD)

        # Listas originales float para graficar los puntos dispersos
        x_orig = [float(x) for x in puntos_x]
        y_orig = [float(y) for y in puntos_y]

        if tipo == "Polinomial":
            X_proc = x_orig
            Y_proc = y_orig
            m = grado_poly
            
        elif tipo == "y = ae^bx": # y = be^(ax) -> ln(y) = ln(b) + ax
            for i in range(len(x_orig)):
                if y_orig[i] <= 0: return "Error: Y debe ser > 0 para Ln(y)"
                X_proc.append(x_orig[i])
                Y_proc.append(math.log(y_orig[i]))
            m = 1 

        elif tipo == "y = ax^b": # y = bx^a -> ln(y) = ln(b) + a*ln(x)
            for i in range(len(x_orig)):
                if x_orig[i] <= 0 or y_orig[i] <= 0: return "Error: X,Y > 0 para Logaritmos"
                X_proc.append(math.log(x_orig[i]))
                Y_proc.append(math.log(y_orig[i]))
            m = 1

        n_puntos = len(X_proc)
        
        # ---  ARMADO DE MATRIZ Y SOLUCIÓN GAUSS  ---
        matriz = [[0.0] * (m + 2) for _ in range(m + 1)]

        for i in range(m + 1):
            for j in range(m + 1):
                matriz[i][j] = sum(val**(i+j) for val in X_proc)
            matriz[i][m + 1] = sum(Y_proc[k] * (X_proc[k]**i) for k in range(n_puntos))

        # Usamos el metodo que hice arriba 
        res_gauss = resolver_gauss_general(matriz, "Total")
        if isinstance(res_gauss, str): return res_gauss # Retornar error si falla (si amigos, if isintance esta cada 50 lineas kmadask)
        
        coefs = res_gauss[1] # [a0, a1, a2...]

        # ---  CREACION DE FUNCION SIMBOLICA ---
        x_sym = sp.symbols('x')
        expr_sym = 0
        
        if tipo == "Polinomial":
            # a0 + a1*x + a2*x^2 ...
            for i, c in enumerate(coefs):
                expr_sym += c * (x_sym**i)
                
        elif tipo == "y = ae^bx":
            # coefs[0] = ln(b), coefs[1] = a
            # y = e^ln(b) * e^(ax) -> b * exp(ax)
            b = math.exp(coefs[0])
            a = coefs[1]
            expr_sym = b * sp.exp(a * x_sym)

        elif tipo == "y = ax^b":
            # coefs[0] = ln(b), coefs[1] = a
            # y = e^ln(b) * x^a -> b * x^a
            b = math.exp(coefs[0])
            a = coefs[1]
            expr_sym = b * (x_sym**a)


        f_eval = sp.lambdify(x_sym, expr_sym, "numpy")

        # --  EVALUACION EN PUNTOS ORIGINALES ----
        y_calculadas = []
        for val_x in x_orig:
            # Evaluamos usando sympy subs para precisión o la lambdify =========================================================================
            try:
                val = float(expr_sym.subs(x_sym, val_x))
                y_calculadas.append(val)
            except:
                y_calculadas.append(0.0)

        # --- 5. GRAFICACION CON MATPLOTLIB ---
        plt.figure(figsize=(6, 4.5)) # Tamaño de figura
        
        # A) Puntos originales
        plt.scatter(x_orig, y_orig, color='red', label='Datos', zorder=5)

        # B) Curva de ajuste (suavizada)
        try:
            # Crear un rango denso de X para que la curva se vea bonita
            gap = (max(x_orig) - min(x_orig)) * 0.1
            if gap == 0: gap = 1
            x_range = np.linspace(min(x_orig) - gap, max(x_orig) + gap, 200)
            
            # Evaluar la función en el rango
            y_range = f_eval(x_range)
            
            # Si resulta una constante (ej: y=5), numpy devuelve un float, convertir a array (aca ya use arrayas pq namas era para la grafica)
            if np.isscalar(y_range): 
                y_range = np.full_like(x_range, y_range)

            plt.plot(x_range, y_range, color='blue', label=f'Ajuste {tipo}')
        except Exception as plot_err:
            plt.text(min(x_orig), min(y_orig), "Error graficando curva")

        plt.title(f"Funcion con puntos calculados")
        plt.xlabel("X")
        plt.ylabel("Y")
        plt.grid(True, linestyle='--', alpha=0.6)
        plt.legend()
        plt.tight_layout()

        # Guardar en Buffer BytesIO (si, toda esta parte es un copy-paste de lo utilizado arriba)
        buf = io.BytesIO()
        plt.savefig(buf, format='png', dpi=100)
        buf.seek(0)
        plt.close() # Limpiar memoria de matplotlib

        # Convertir a Base64 string para enviar a C#
        img_b64 = base64.b64encode(buf.getvalue()).decode('utf-8')

        # ---  RETORNO ---
        # Convertimos la expresion sympy a string bonito
        ecuacion_str = str(expr_sym).replace("**", "^")
        
        return [ecuacion_str, coefs, y_calculadas, img_b64]

    except Exception as e:
        return f"Error Minimos Cuadrados: {str(e)}"

#############################################################3 SISTEMAS EDOs CON RK4 ########################################
"""
OKEY, este programa estuvo realmente raro, por alguna razon, funcionaxdddd, medio revise en internet como se realizaba (lo intente
hacer como vimos en clase pero nomas no me quedo). Segun lo que encontre, es una funcion vectorial, la cual acepta t (tiempo) y
un vector (u1,u2,u3,u4), ya con base a eso, realiza aproximaciones.

Honestamente, este, el de factorizaciones de matrices y el rkfelberg, fueron los que mas me constaron, es chistoso ya que
este es MUCHISIMO mas facil o al menos su codigo es mas sencillo que en los otros, pero eso de meter las funciones como u1 * 5-u2 o
cosas asi, me confundio mucho. De ahi en fuera, creo que todo esta bienxd
"""
def resolver_rk4_sistemas(ecuaciones_str, valores_iniciales, t0, tf, h):
    """
    Resuelve sistema de EDOs usando RK4.
   
    """
    try:
        #  Definir variables simbolicas 
        t = sp.symbols('t')
        u1, u2, u3, u4 = sp.symbols('u1 u2 u3 u4')
        
        #Convertir strings a funciones 
        funciones = []
        # Argumentos para todas las funciones: f(t, u1, u2, u3, u4)
        args_sym = [t, u1, u2, u3, u4]
        
        for ec_str in ecuaciones_str:
            expr = sp.sympify(ec_str)
            # Creamos una funcion rapida compatible (esta linea si me la saque de chat, perdonamigos)
            f_lambda = sp.lambdify(args_sym, expr, modules=['numpy', 'math'])
            funciones.append(f_lambda)

        # 3. Inicializacion
        t_actual = float(t0)
        u_actual = np.array(valores_iniciales, dtype=float)
        tf = float(tf)
        h = float(h)
        
        # Estructura de resultados: Primera fila (Valores iniciales)
        # Formato de fila: [t, u1, u2, ...]
        resultados = []
        fila_inicial = [t_actual] + u_actual.tolist()
        resultados.append(fila_inicial)

        #    Metodo RK4
        pasos = int((tf - t0) / h)
        
        # Funcion auxiliar para evaluar el vector de derivadas en (ti, ui)
        def evaluar_F(ti, ui):
            # Preparamos los argumentos. Rellenamos con 0 si faltan variables 
            vals = list(ui)
            while len(vals) < 4: vals.append(0.0)
            
            derivadas = []
            for f in funciones:
                # f(t, u1, u2, u3, u4)
                d = f(ti, vals[0], vals[1], vals[2], vals[3])
                derivadas.append(d)
            return np.array(derivadas, dtype=float)

        for _ in range(pasos):
            k1 = evaluar_F(t_actual, u_actual)
            k2 = evaluar_F(t_actual + 0.5*h, u_actual + 0.5*h*k1)
            k3 = evaluar_F(t_actual + 0.5*h, u_actual + 0.5*h*k2)
            k4 = evaluar_F(t_actual + h, u_actual + h*k3)

            # Formula RK4
            u_siguiente = u_actual + (h / 6.0) * (k1 + 2*k2 + 2*k3 + k4)
            t_actual += h
            
            # Guardar resultados
            fila = [t_actual] + u_siguiente.tolist()
            resultados.append(fila)
            
            u_actual = u_siguiente

        return resultados

    except Exception as e:
        return f"Error RK4: {str(e)}"