Algoritmo Act3_Lecc11_inc2
	Definir extremoA, extremoB, limiteInferior, limiteSuperior, totalAcumulado, contador Como Entero
    totalAcumulado <- 0
    
    Escribir "Introduce el primer valor del intervalo:"
    Leer extremoA
    Escribir "Introduce el segundo valor del intervalo:"
    Leer extremoB
    
	
    Si extremoA < extremoB Entonces
        limiteInferior <- extremoA
        limiteSuperior <- extremoB
    Sino
        limiteInferior <- extremoB
        limiteSuperior <- extremoA
    Fin Si
    
	
    Para contador <- limiteInferior Hasta limiteSuperior Hacer
        totalAcumulado <- totalAcumulado + contador
    Fin Para
    
    Escribir "El resultado de acumular los valores desde ", limiteInferior, " hasta ", limiteSuperior, " da un total de: ", totalAcumulado
	
FinAlgoritmo
