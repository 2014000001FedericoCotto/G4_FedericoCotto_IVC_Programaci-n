Algoritmo Act1_Lecc9_Inc1
	Definir peso, total Como Real
    
    total = 0
    
    Mientras total < 1 Hacer
        Escribir "Ingrese el peso de la manzana en kg:"
        Leer peso
        total = total + peso
        Escribir "Peso acumulado: ", total, " kg"
    FinMientras
    
    Escribir "Ya tienes 1 kilogramo o mas de manzanas"
FinAlgoritmo
