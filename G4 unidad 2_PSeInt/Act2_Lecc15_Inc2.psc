Algoritmo Act2_Lecc15_Inc2
	Definir q, a, b, i como Entero
	Escribir "===CLASIFICACION DE BILLETES==="
	a = 0 
	b = 0 
	Para i = 1 Hasta 10 Hacer
		Escribir "Ingrese la denominación del billete ", i
		Leer q
		Si q == 100 Entonces
			a = a + 1
			b = b + 100
		Fin Si
	Fin Para
	
	Escribir "Cantidad de billetes de Q100: ", a
	Escribir "billetes de Q100: ", b
FinAlgoritmo
