Algoritmo Act1_Lecc7_Inciso1
    Definir n1, n2, n3, n4, n5, promedio Como Real
	
    Escribir "Ingrese 5 notas:"
    Leer n1, n2, n3, n4, n5
	
    promedio <- (n1 + n2 + n3 + n4 + n5) / 5
	
    Si promedio >= 60 Entonces
        Escribir "Aprueba"
    Sino
        Escribir "Reprueba"
    FinSi
FinAlgoritmo