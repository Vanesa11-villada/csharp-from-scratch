namespace itm.csharp.basic
{
    /*Solicita al usuario un número y determina si es positivo, negativo o cero*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Es cero");
        }
    }

    /*Solicita al usuario dos números y muestra el mayor de ellos.*/
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {num1 + num2}\nResta: {num1 - num2}\nMultiplicación: {num1 * num2}\nDivisión: {num1 / num2}");
        }
    }

    /*Solicita al usuario un número y muestra el cuadrado de ese número*/
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");
        }
    }

    /*Solicita al usuario el radio de un círculo y muestra su área*/
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * radio * radio;
            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
        }
    }

    /*Solicita al usuario un número entre 1 y 7 y muestra el día de la semana*/
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                // ... otros días
                default: Console.WriteLine("Número no válido"); break;
            }
        }
    }

    /*Solicita al usuario su salario mensual y, si este excede los 1000, muestra el impuesto a pagar (10% del salario).*/
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 1000 ? 0.1 * salario : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
        }
    }

    /*Solicita al usuario dos números y realiza una división entre ellos*/
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Número a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {n / divisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación!");
            }
        }
    }

    /*Calcula y muestra la suma de números impares entre 1 y 100*/
    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de números impares entre 1 y 100 es: {suma}");
        }
    }


    /*Solicita al usuario los valores para dos fracciones y muestra la suma de esas fracciones.*/
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fracción:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la primera fracción:");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fracción:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la segunda fracción:");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Sumar(fraccion2);

                Console.WriteLine($"La suma de {fraccion1} y {fraccion2} es: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }


    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        // Puedes agregar más métodos para otras operaciones si es necesario

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }


    /*Solicita al usuario una palabra y muestra esa palabra en orden inverso.*/
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            string invertida = new string(palabra.Reverse().ToArray());
            Console.WriteLine($"La palabra invertida es: {invertida}");
        }
    }

    /*Solicita al usuario tres números y muestra el promedio de esos números.*/
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine($"El promedio de los tres números es: {promedio}");
        }
    }

    /* Solicita al usuario cinco números y muestra el número más grande de esos cinco*/
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el número {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El número más grande de la lista es: {numeros.Max()}");
        }
    }

    /*Solicita al usuario una palabra y determina si es un palíndromo (se lee igual de izquierda a derecha que de derecha a izquierda).*/
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();

            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                Console.WriteLine($"La palabra {palabra} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"La palabra {palabra} no es un palíndromo.");
            }
        }
    }

    /* Solicita al usuario un número y determina si es par o impar.*/
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
    /*Solicita al usuario un número y verifica si está en el rango de 0 a 10.*/
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                Console.WriteLine($"El número {numero} está en el rango de 0 a 10.");
            }
            else
            {
                Console.WriteLine($"El número {numero} está fuera del rango de 0 a 10.");
            }
        }
    }

}