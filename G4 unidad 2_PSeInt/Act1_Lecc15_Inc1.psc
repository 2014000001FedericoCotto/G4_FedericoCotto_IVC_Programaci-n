Algoritmo Act1_Lecc15_Inc1
	Definir no1, no2, men, may, i Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer no1
    Escribir "Ingrese el segundo número:"
    Leer no2
    
	Si n1 < n2 Entonces
        men <- n1
        may <- n2
    Sino
        men <- n2
        may <- n1
    Fin Si
    Escribir "Multiplos de 4 de", men, " a ", ma, ":"
    Para i <- men Hasta may Hacer
        Si i % 4 = 0 Entonces
            Escribir i
        Fin Si
    Fin Para
	
FinAlgoritmo
