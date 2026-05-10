Algoritmo Act2_Lecc15_Inc1
	Definir n1, n2, men, may, i Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer n1
    Escribir "Ingrese el segundo número:"
    Leer n2
    
	
    Si n1 < n2 Entonces
        men <- n1
        may <- n2
    Sino
        men <- n2
        may <- n1
    Fin Si
    
    Escribir "Múltiplos de 4 de ", men, " a ", may, ":"
    
    Para i <- men Hasta may Hacer
        
        Si i % 4 = 0 Entonces
            Escribir i
        Fin Si
    Fin Para

	
FinAlgoritmo
