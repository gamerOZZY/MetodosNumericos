## Proyecto Semestral: Métodos Numéricos

---

Este proyecto representa el trabajo semestral de la asignatura **Métodos Numéricos** de la universidad. Su objetivo principal es implementar y evaluar una variedad de algoritmos que permiten la solución de problemas matemáticos mediante aproximaciones sucesivas, un enfoque fundamental en ingeniería y ciencias.

---

### Tecnologías y Lenguaje Principal

Todos los métodos numéricos presentados en este repositorio están siendo desarrollados e implementados en **C#** y **Python**. 

[Image of C# programming language logo]


| Lenguaje | Enfoque |
| :---: | :---: |
| **C#** | Creacion del front mediante forms |
| **Python** | Logica e implementacion de todos los metodos numericos. Es el cerebro del programa |
| **Markdown/HTML/CSS** | Estructuración y presentación del `README` en GitHub. |

---

###  Fundamentos y Métodos Implementados

A lo largo de este proyecto, se han codificado e implementado diversos métodos numéricos. La implementación cubre tanto métodos para la solución de **ecuaciones no lineales** como para la **integración numérica** y **sistemas de ecuaciones**.

#### 1. Solución de Ecuaciones No Lineales

Estos métodos buscan encontrar las raíces (o ceros) de una función $f(x)=0$.

* **Método de Bisección:** Un método cerrado simple y robusto que reduce el intervalo de búsqueda a la mitad en cada iteración.
* **Método de Newton-Raphson:** Uno de los métodos más eficientes (con convergencia cuadrática), que requiere el cálculo de la primera derivada de la función.
* **Método de la Secante:** Una alternativa al método de Newton-Raphson que evita la necesidad de calcular la derivada, aproximándola con una pendiente.

#### 2. Sistemas de Ecuaciones Lineales

Se utilizan para resolver sistemas de la forma $A\mathbf{x} = \mathbf{b}$, donde $A$ es la matriz de coeficientes.

* **Método de Gauss-Seidel:** Un método iterativo de descomposición que actualiza las variables tan pronto como están disponibles. Es muy útil para matrices grandes y dispersas.

#### 3. Integración Numérica

Estos algoritmos se usan para calcular el valor de una integral definida $\int_a^b f(x) dx$ de forma aproximada.

* **Regla del Trapecio (Compuesta):** Aproxima el área bajo la curva usando una serie de trapecios.
* **Regla de Simpson 1/3 (Compuesta):** Utiliza un polinomio de segundo grado para aproximar la función, ofreciendo una mayor precisión.

---

#### 4. Entre muchos otros metodos

Aqui solo menciono algunos de los metodos mas comunes, sin embargo, el programa contiene muchos otros metdos bastante utiles como:
* **Polinomios interpolantes:** Se utilizan diversos metodos
* **Derivaciones e integraciones compuestas:** Mas metodos (con funcion proporcionada y con solo puntos proporcionados) para derivar e integrar
* **Solucion de ecuaciones diferenciales:** adsasdsd
* **Etc**

###  Créditos y Contacto

Este proyecto fue desarrollado por **Ramirez Cortes Axel Osiris** y **Reynoso Pablo Edgar** como parte del programa de estudios en **ESCOM / Licenciatura en Ciencia de Datos**, por parte de la materia de **Metodos numericos**.

---
