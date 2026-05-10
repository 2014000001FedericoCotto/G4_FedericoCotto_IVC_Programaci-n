Algoritmo Act3_Lecc11_inc1
	Definir num, j, totalDivisores, totalPrimos Como Entero
    Definir acumuladorPrimos Como Entero
    
    totalPrimos <- 0
    acumuladorPrimos <- 0
    
    Para num <- 2 Hasta 100 Hacer
        totalDivisores <- 0
		
        Para j <- 1 Hasta num Hacer
            Si num % j = 0 Entonces
                totalDivisores <- totalDivisores + 1
            Fin Si
        Fin Para
        
        
        Si totalDivisores = 2 Entonces
            totalPrimos <- totalPrimos + 1
            acumuladorPrimos <- acumuladorPrimos + num
        Fin Si
    Fin Para
    
    Escribir "Total de números primos hallados: ", totalPrimos
    Escribir "La sumatoria de los primos es: ", acumuladorPrimos
	
	
FinAlgoritmo
