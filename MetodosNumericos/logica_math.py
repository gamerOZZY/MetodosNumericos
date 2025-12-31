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