namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Variables
            DateOnly dateConverted;
            string? nameInput;  // Permitir que sea nulo
            string? birthdayInput;  // Permitir que sea nulo

            // Introducción
            Console.WriteLine("¡Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            nameInput = nameInput ?? "Desconocido"; // Asignar valor predeterminado si es nulo
            Console.WriteLine($"Un gusto conocerte {nameInput}");

            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            birthdayInput = birthdayInput ?? "01/01/1900"; // Asignar valor predeterminado si es nulo

            // Intentamos parsear la fecha
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid == false)
            {
                Console.WriteLine($"La fecha de nacimiento es inválida, usted nos envió este dato erróneo: {birthdayInput}");
                return; // Salimos si la fecha es inválida
            }

            // Crear el objeto Person si la fecha es válida
            var person = new Person
            {
                Name = nameInput,  // No será nulo debido a la asignación anterior
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            // Mostrar los resultados
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"¡Tu edad es {person.Age} años!");

            Console.ReadLine(); // Pausar para que el usuario vea los resultados
        }
    }

    public class Person
    {
        public required string Name { get; set; }  // Requiere un valor en la creación
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }

}
