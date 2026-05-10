Algoritmo Act2_Lecc11_Inc1
	Definir n, i Como Entero
    Definir fac Como Real 
    
    Escribir "Ingrese un numero:"
    Leer n
    
    Si n < 0 Entonces
        Escribir "Factorial no definido por No. negativos"
    Sino
        fac <- 1
        i <- 1
        
        Si n > 0 Entonces
            Repetir
                fac <- fac * i
                i <- i + 1
            Hasta Que i > n
        Fin Si
        
        Escribir "El factorial de ", n, " es: ", fac
    Fin Si
	
	
FinAlgoritmo
