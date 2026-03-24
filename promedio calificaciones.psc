Algoritmo sin_titulo
	Escribir "==PROMEDIO DE CALIFICACIONES=="
	Definir materia Como Caracter
	Definir n1, n2, n3, n4, n5 Como Entero
	Definir prom Como Real
	Escribir "Dime que materia se va a evaluar: "
	Leer materia
	Escribir "Dame la 1ra Nota: "
	Leer n1
	Escribir "Dame la 2da Nota: "
	Leer n2
	Escribir "Dame la 3ra Nota: "
	Leer n3
	Escribir "Dame la 4ta Nota: "
	Leer n4
	Escribir "Dame la 5ta Nota: "
	Leer n5
	prom = (n1+n2+n3+n4+n5)/5
	Si prom < 70 Entonces
		Escribir "El estudiante ha perdido ",materia " Con ",prom
	SiNo
		Escribir "El estudiante ha aprobado ",materia " Con ",prom
	FinSi
FinAlgoritmo
