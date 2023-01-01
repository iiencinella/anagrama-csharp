# Problema del anagrama

Si tomamos una palabra, le cambiamos el ordes de sus letras y formamos otra palabra, a esta palabra la llamaremos anagrama. Esta definición también la podemos aplicar a un conjunto de palabras.
Se emplea frecuentemente en acertijos, juegos de mesa y como seudónimo.
A ver es facil poder distinguir si una palabra es anagrama o no. Sin embargo, mientras más larga sea la palabra, más difícil es poder detectar si estamos frente a un anagrama o no.
La dificultad radica en que por cada palabra de `n` cantidad de letras, habrá `n!` (factorial de n) combinaciones posibles.

Ejemplo de un anagrama:
![Ejemplo de anagrama](/assets/images/Alan_Smithee_name.jpg)

Hay muchas formas de resolver anagramas o generar palabras que sean anagramas.

Comparto algunas formas que pensé para determinar si 2 palabras son anagramas o no:

1. Recorremos la primer palabra caracter por caracter, luego buscamos si esta letra existe en la otra palabra y la eliminamos. Si terminamos de recorrer todas las letras de la primer palabra y no nos quedan letras por verificar en la segunda, entonces las dos palabras son anagramas.
2. Ordenamos las letras de las dos palabras alfabeticamente y las comparamos, si en ambos casos tenemos el mismo valor (que cada letra en la misma posisición de las dos palabras es la misma), entonces ambas palabras son anagramas.
3. [Esta solución es un poco rebuscada]. Convierto cada letra de ambas palabras en su valor numérico ASCII, sumo el valor de cada letra de ambas palabras y comparo la suma. Si el resultado de la suma en ambas palabras es la misma, entonces ambas palabras son anagramas.

`De a poco iré agregando más ideas de como determinar si dos palabras son anagramas o no`