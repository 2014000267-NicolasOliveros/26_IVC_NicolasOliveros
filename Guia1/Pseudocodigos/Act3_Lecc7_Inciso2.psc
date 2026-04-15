Algoritmo Act3_Lecc7_Inciso2
    Definir ang1, ang2, ang3 Como Entero
	
    Escribir "Ingrese ángulo 1:"
    Leer ang1
    Escribir "Ingrese ángulo 2:"
    Leer ang2
    Escribir "Ingrese ángulo 3:"
    Leer ang3
	
    Si ang1 = 60 Y ang2 = 60 Y ang3 = 60 Entonces
        Escribir "Equilátero"
    Sino
        Si ang1 = ang2 O ang1 = ang3 O ang2 = ang3 Entonces
            Escribir "Isósceles"
        Sino
            Escribir "Escaleno"
        FinSi
    FinSi
FinAlgoritmo