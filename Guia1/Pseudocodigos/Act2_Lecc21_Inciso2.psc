Algoritmo Act2_Lecc21_Inciso2
    Definir opcion Como Entero
	
    Escribir "1. Ventas"
    Escribir "2. Recepción"
    Escribir "3. Dirección"
    Escribir "4. Compras"
    Leer opcion
	
    Si opcion = 1 Entonces
        Escribir "Bienvenido a Ventas"
        Escribir "Encargado: Juan Perez"
        Escribir "Correo: ventas@empresa.com"
    Sino
        Si opcion = 2 Entonces
            Escribir "Bienvenido a Recepción"
            Escribir "Encargado: Maria Lopez"
            Escribir "Correo: recepcion@empresa.com"
        Sino
            Si opcion = 3 Entonces
                Escribir "Bienvenido a Dirección"
                Escribir "Encargado: Carlos Ruiz"
                Escribir "Correo: direccion@empresa.com"
            Sino
                Si opcion = 4 Entonces
                    Escribir "Bienvenido a Compras"
                    Escribir "Encargado: Ana Torres"
                    Escribir "Correo: compras@empresa.com"
                Sino
                    Escribir "Opción inválida"
                FinSi
            FinSi
        FinSi
    FinSi
FinAlgoritmo