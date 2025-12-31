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
