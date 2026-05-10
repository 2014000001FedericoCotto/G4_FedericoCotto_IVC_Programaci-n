Algoritmo Act1_Lecc11_Inc1
	Definir capacidadTotal, autosIngresados, cajonesLibres Como Entero
    capacidadTotal <- 200
    autosIngresados <- 0
    
    Repetir
        cajonesLibres <- capacidadTotal - autosIngresados
        
        Si cajonesLibres > 0 Entonces
            Escribir "Cajones disponibles: ", cajonesLibres
            Escribir "Presione una tecla para ingresar un auto:"
            Leer entrada 
            autosIngresados <- autosIngresados + 1
        Fin Si
        
    Hasta Que autosIngresados >= capacidadTotal
    
    Escribir "Ya no hay cajones libres. Estacionamiento lleno."
	
	
FinAlgoritmo

