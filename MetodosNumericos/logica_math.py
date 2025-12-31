import sympy as sp
import numpy as np
#SYMPY NOS AHORRO AGNOS DE VIDA GGGGGGGGGGG

def evaluar_y(func_str, x_val):
    """Convierte texto a funcion y evalua en x."""
    try:
        x = sp.symbols('x')
        expr = sp.sympify(func_str)
        # Usamos numpy para evaluacion rapida y segura
        f = sp.lambdify(x, expr, modules=['numpy', 'math'])
        return float(f(x_val))
    except Exception as e:
        return f"Error: {str(e)}"

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