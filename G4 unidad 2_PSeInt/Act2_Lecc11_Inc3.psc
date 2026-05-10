Algoritmo Act2_Lecc11_Inc3
	Definir opcio, totalboletos Como Entero
    Definir totaldinero Como Real
    
    totalboletos <- 0
    totaldinero <- 0
    opcio = 1
    
    Escribir "--- Sistema de Ventas: Rueda de la Fortuna ---"
    
    Mientras opcio <> 0 Hacer
       
        Escribir "1- Adulto (Q15)"
        Escribir "2- Niño (Q10)"
        Escribir "0- Cerrar caja y ver totales"
        Leer opcio
        
        Segun opcio Hacer
            1:
                totalboletos <- totalboletos + 1
                totaldinero <- totaldinero + 15
                Escribir "Boleto de adulto registrado."
            2:
                totalboletos <- totalboletos + 1
                totaldinero <- totaldinero + 10
                Escribir "Boleto de niño registrado."
            0:
                Escribir "Cerrando sistema..."
            De Otro Modo:
                Escribir "Opción no válida."
        Fin Segun
        
        Escribir "Numero de boletos:", totalboletos,"     Total: Q", totalDinero
        Escribir "--------------------------------------------"
    Fin Mientras
    
    Escribir "REPORTE FINAL:"
    Escribir "Total de boletos vendidos: ", totalBoletos
    Escribir "Total de dinero cobrado: ", totalDinero
	
	
FinAlgoritmo
