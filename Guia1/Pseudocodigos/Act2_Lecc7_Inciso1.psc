Algoritmo Act2_Lecc7_Inciso1
    Definir opcion Como Entero
	
    Escribir "1. Información"
    Escribir "2. Soporte"
    Escribir "3. Ventas"
    Escribir "4. Operador"
    Leer opcion
	
    Si opcion = 1 Entonces
        Escribir "Información"
    Sino
        Si opcion = 2 Entonces
            Escribir "Soporte"
        Sino
            Si opcion = 3 Entonces
                Escribir "Ventas"
            Sino
                Si opcion = 4 Entonces
                    Escribir "Operador"
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
        FinSi
    FinSi
FinAlgoritmo