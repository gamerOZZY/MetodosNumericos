## P O R F A V O R
##COMENTAR HASTA EL MAS MINIMO DETALLE DE LAS FUNCIONES, somos 3 y aunque el codigo sea basura, tenemos que
##entender claramente que es lo que hacexd
from urllib.request import parse_http_list
import sympy as sp
import numpy as np
import matplotlib
matplotlib.use('Agg')
import matplotlib.pyplot as plt
import io

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

        # Construir el polinomio P(x) simbólicamente
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

        # --- 1. Recalcular Coeficientes (Diferencias Divididas) ---
        F = [[0] * n for _ in range(n)]
        for i in range(n): F[i][0] = lista_y[i]

        for j in range(1, n):
            for i in range(j, n):
                numerador = F[i][j-1] - F[i-1][j-1]
                denominador = lista_x[i] - lista_x[i-j]
                if denominador == 0: return None
                F[i][j] = numerador / denominador
        
        b = [F[i][i] for i in range(n)] # Coeficientes

        # --- 2. Crear función para evaluar el polinomio ---
        # Esta función "lambda" evalúa P(x) usando los coeficientes b
        def P(x_val):
            resultado = b[0]
            factor = 1
            for i in range(1, n):
                factor = factor * (x_val - lista_x[i-1])
                resultado = resultado + b[i] * factor
            return resultado

        # --- 3. Configurar la Gráfica con Matplotlib ---
        plt.figure(figsize=(6, 4)) # Tamaño de la imagen
        plt.style.use('seaborn-v0_8-whitegrid') # Estilo bonito (opcional)

        # Generar dominio X suave para la curva (desde el minX hasta maxX un poco extendido)
        x_min, x_max = min(lista_x), max(lista_x)
        padding = (x_max - x_min) * 0.1
        x_suave = np.linspace(x_min - padding, x_max + padding, 200)
        y_suave = [P(val) for val in x_suave]

        # Dibujar Curve e Puntos
        plt.plot(x_suave, y_suave, 'b-', label='Polinomio Interpolante', linewidth=2)
        plt.scatter(lista_x, lista_y, color='red', s=50, label='Datos Originales', zorder=5)
        
        # Marcar el punto de interés
        y_interes = P(x_interes)
        plt.scatter([x_interes], [y_interes], color='green', s=100, marker='*', label='Punto Interes', zorder=10)

        plt.title("Interpolacion de Newton")
        plt.xlabel("X")
        plt.ylabel("Y")
        plt.legend()
        plt.grid(True)

        ##Toda esta parte (la de guardar en la memoria) fue sacada de internet ya que no se sabia como se debia realizar
        ## y opte por investigar, de una forma simple, la grafica la pasamos a bytes, la mandamos al buffer,
        #la mandamos a c y c la vuelve a armar.

        # --- 4. Guardar en Memoria (La parte mágica) ---
        buf = io.BytesIO() # Crear un buffer en RAM
        plt.savefig(buf, format='png', dpi=100) # Guardar la gráfica en el buffer
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
            # Derivada centrada básica (reutilizando el concepto de 3 puntos)
            D[i][0] = (f(x_val + h) - f(x_val - h)) / (2 * h)
            h = h / 2 # Preparamos h para la siguiente fila (mitad del paso)

        # 2. Llenar el resto de columnas (Extrapolación)
        # Fórmula: D[i,j] = (4^j * D[i, j-1] - D[i-1, j-1]) / (4^j - 1)
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
        # Llamamos a la función corregida de arriba
        F = obtener_tabla_diferencias(lista_x, lista_y)
        
        # Validación: Si F es un string, es que hubo error en la tabla AUNQUE no creo que pase pero aja, ahi esta por si las dudas
        if isinstance(F, str): return F 

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

        # ---  ATRÁS (Usando diagonal inferior) ---
        elif tipo == 'atras':
            # Los coeficientes están en la última fila llena de cada columna
            # F[n-1][0] (no se usa para el polinomio, es y), F[n-1][1]... 
            # Corrección logica Atras: Usamos la ultima fila disponible para ese orden
            # El coef b0 está en F[n-1][0]
            # El coef b1 está en F[n-1][1]
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

        # Paso 2: Llenar la matriz triangular usando la fórmula recursiva
        # Fórmula: Q[i,j] = [ (x - xi-j)*Q[i,j-1] - (x - xi)*Q[i-1,j-1] ] / (xi - xi-j)
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
            # Calculamos el término Li(x)
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
            if abs(y_i) < 1e-9: continue # Saltar términos cero
            
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

        # Función interna para evaluar Lagrange en cualquier punto v
        def P_Lagrange(v):
            res = 0.0
            for i in range(n):
                term = 1.0
                for j in range(n):
                    if i != j:
                        term *= (v - lista_x[j]) / (lista_x[i] - lista_x[j])
                res += lista_y[i] * term
            return res

        # Configurar gráfica
        plt.figure(figsize=(5, 3.5))
        x_min, x_max = min(lista_x), max(lista_x)
        pad = (x_max - x_min) * 0.1 if n > 1 else 1.0
        
        # Generamos 100 puntos para que la curva se vea suave
        x_suave = np.linspace(x_min - pad, x_max + pad, 100)
        y_suave = [P_Lagrange(val) for val in x_suave]

        plt.plot(x_suave, y_suave, 'purple', label='Lagrange', linewidth=1.5) # Color morado para variar
        plt.scatter(lista_x, lista_y, color='red', zorder=5)
        
        # Punto de interés
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
        
        # Ahora sí podemos usar slicing de Python [1:-1]
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
        
        # --- 1. DIBUJAR LA CURVA SUAVE (LA FUNCIÓN REAL) ---
        # Creamos una 'x' simbólica y convertimos el texto a función GRACIAS SYMPY TEAMO
        x_sym = sp.symbols('x')
        expr = sp.sympify(func_str)
        f_real = sp.lambdify(x_sym, expr, modules=['numpy', 'math'])
        
        # Genero 200 puntos entre el inicio y el fin para que se vea curva
        x_min, x_max = min(lista_x), max(lista_x)
        pad = (x_max - x_min) * 0.05 # Un poquito de margen extra
        
        x_suave = np.linspace(x_min, x_max, 200)
        y_suave = [f_real(val) for val in x_suave]
        
        # Dibujamos la función real en AZUL OSCURO
        plt.plot(x_suave, y_suave, 'b-', linewidth=2, label=f'f(x) Real')

        # --- 2. SOMBREAR EL ÁREA (LA APROXIMACIÓN) ---
        # Usamos fill_between con los puntos ORIGINALES. 
        # Esto conectará los puntos con lineas rectas (Trapecios),
        # permitiendo ver visualmente la diferencia con la curva real.
        plt.fill_between(lista_x, lista_y, color='skyblue', alpha=0.4, label='Aprox. Numerica')
        
        # --- 3. DIBUJAR LOS PUNTOS Y DETALLES ---
        plt.scatter(lista_x, lista_y, color='red', zorder=5, s=30)
        
        # Líneas verticales para los intervalos
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
        puntos_corte.add(c) # Agregamos el punto medio también
        return S_izq + S_der + error # Devolvemos valor refinado
    else:
        # Rechazamos y dividimos más (tolerancia se divide por 2)
        return adaptive_core(f, a, c, tol/2.0, puntos_corte) + \
               adaptive_core(f, c, b, tol/2.0, puntos_corte)

# --- FUNCIÓN PRINCIPAL ADAPTATIVA ---
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
        
        # 2. Sombrear Área
        # Evaluamos Y en los puntos de corte para el relleno
        y_cortes = [f(val) for val in lista_x_cortes]
        plt.fill_between(lista_x_cortes, y_cortes, color='lime', alpha=0.2, label='area')
        
        # 3. DIBUJAR LAS LINEAS ADAPTATIVAS (La parte visual importante)
        # Dibujamos líneas verticales rojas donde el algoritmo hizo cortes
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

        # 3. MOSTRAR LOS PUNTOS DE GAUSS (La parte didáctica)
        # Calculamos dónde caen los puntos en el intervalo real
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
            
            # Suma de los nuevos puntos (los que están en medio de los anteriores)
            # Puntos: a+h, a+3h, a+5h, etc
            suma_nuevos = sum(f(a + k*h) for k in range(1, 2**i, 2))
            
            # Formula recursiva del Trapecio: T_nuevo = 0.5 * T_anterior + h * suma_nuevos
            R[i][0] = 0.5 * R[i-1][0] + h * suma_nuevos
            
        # --- PASO 2: Extrapolación de Richardson (Columnas 1..k) ---
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
        
        # 5. Aplicar formula: ÁreaBase / 4 * SumaAlturas
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