[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
 
# ¿String es un tipo por valor o un tipo por referencia?
string en C# es un tipo por referencia. Sin embargo, se comporta como inmutable: cada vez que se modifica una cadena, se crea una nueva instancia.

# ¿Qué secuencias de escape tiene el tipo string?
Algunas secuencias de escape comunes en string son:

\n: salto de línea

\t: tabulación

\\: barra invertida

\": comillas dobles

\': comillas simples

\r: retorno de carro

\b: retroceso

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

@: crea una cadena literal donde se ignoran las secuencias de escape.
Ejemplo: @"C:\Users\Juan"

$: permite la interpolación de cadenas, insertando variables directamente.
Ejemplo: $"Hola {nombre}"

Se pueden combinar: $@"Hola {nombre}"