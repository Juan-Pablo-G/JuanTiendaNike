using System.Text.RegularExpressions;

namespace Program
{
    class VariablesGlobales
    {
        private static int fila_num = 0;
        private static int col_num = 27;
        private static int textBoxLeft;
        private static int textBoxTop;
        private static string idiomaCliente;
        private static string nombreCliente;
        private static string apellidoCliente;
        private static string numCliente;
        private static string direccionCliente;
        private static string edadCliente;
        private static string sexoCliente;
        private static string tallaCliente;
        private static string correoCliente;
        private static string pagoCliente;
        static void Main(string[] args)
        {
            Idioma();
            Console.Clear();
            MostrarAnimacion();
            NombreYApellido();
            Numero();
            Direccion();
            Edad();
            Sexo();
            Talla();
            Correo();
            Pago();
            Console.Clear();
            TiempoEspera();
            Console.Clear();
            MuestraDatos();
            ExitApp();
        }
        public static void MostrarAnimacion()
        {
            Console.Title = "Proyecto TUI / By: Juan Pablo Giraldo";
            int width = 112, height = 30;
            Console.SetWindowSize(width, height);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            string marco_horizontal = "═══════════════════════════";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(14, fila_num);
            Console.WriteLine("╔" + marco_horizontal + marco_horizontal + marco_horizontal + "══╗");

            string autor = "APP By: Juan Pablo Giraldo, Version TUI: 1.0";
            Console.ForegroundColor = ConsoleColor.Black;

            string msj1, msj2, msj3, msj4, msj5, msj6, msj7, msj8, msj9, msj10, msj11, msj12;
            int retardo = 700;
            Thread.Sleep(retardo);
            msj1 = "███╗  ██╗██╗██╗  ██╗███████╗";
            msj2 = "████╗ ██║██║██║ ██╔╝██╔════╝";
            msj3 = "██╔██╗██║██║█████═╝ █████╗  ";
            msj4 = "██║╚████║██║██╔═██╗ ██╔══╝  ";
            msj5 = "██║ ╚███║██║██║ ╚██╗███████╗";
            msj6 = "╚═╝  ╚══╝╚═╝╚═╝  ╚═╝╚══════╝";
            msj7 = "                 ██";
            msj8 = " ██           ███  ";
            msj9 = "██          ███    ";
            msj10 = "███     █████     ";
            msj11 = " █████████        ";
            msj12 = "  █████           ";
            fila_num = fila_num + 1;
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj1);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj2);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj3);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj4);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj5);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(44, fila_num);
            Console.WriteLine(msj6);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj7);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj8);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj9);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj10);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj11);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 4);
            Console.SetCursorPosition(48, fila_num);
            Console.WriteLine(msj12);
            int textBoxLeft, textBoxTop;

            Console.SetCursorPosition(col_num + 8, fila_num + 1);
            Console.WriteLine(autor.ToUpper());
            Console.ForegroundColor = ConsoleColor.Black;
            fila_num = fila_num + 1;
            Console.SetCursorPosition(29, fila_num + 1);
            Console.WriteLine("╚" + marco_horizontal + marco_horizontal + "╝");

        }
        public static void Box(int left, int top, int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(left, top);
            Console.Write("╔" + new string('═', width - 2) + "╗");

            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("║" + new string(' ', width - 2) + "║");
            }

            Console.SetCursorPosition(left, top + height - 1);
            Console.Write("╚" + new string('═', width - 2) + "╝");
        }
        public static void Idioma()
        {
            bool idiomaValido = false;
            int width = 112, height = 30;
            Console.SetWindowSize(width, height);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Box(24, 9, 66, 13);
            Console.SetCursorPosition(34, 12);
            Console.WriteLine("SELLECCIONE EL IDIOMA        SELECT THE LANGUAGE");
            Console.SetCursorPosition(43, 14);
            Console.WriteLine("ESPAÑOL= 1       ENGLISH = 2");
            Box(44, 15 + 1, 25, 3);
            textBoxLeft = 46;
            textBoxTop = 17;
            Console.SetCursorPosition(textBoxLeft, textBoxTop);
            string idioma = Console.ReadLine();
            while (!idiomaValido)
            {
                if (idioma == "1" || idioma == "2")
                {
                    idiomaValido = true;
                }
                else
                {
                    Box(24, 9, 66, 13);
                    Console.SetCursorPosition(34, 12);
                    Console.WriteLine("SELLECCIONE EL IDIOMA        SELECT THE LANGUAGE");
                    Console.SetCursorPosition(43, 14);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ESPAÑOL= 1       ENGLISH = 2");
                    Box(44, 15 + 1, 25, 3);
                    textBoxLeft = 46;
                    textBoxTop = 17;
                    Console.SetCursorPosition(textBoxLeft, textBoxTop);
                    idioma = Console.ReadLine();
                }
                idiomaCliente = idioma;
            }
        }
        public static void NombreYApellido()
        {
            fila_num = fila_num + 2;
            string mensaje1, mensaje2;
            if (idiomaCliente == "1")
            {
                bool nombreValido = false;
                mensaje1 = "Ingrese Su Nombre";
                Console.SetCursorPosition(3, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje1);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string nombreClienteIngresado = Console.ReadLine();
                Console.SetCursorPosition(3, fila_num);
                Console.WriteLine("                     ");

                while (!nombreValido)
                {
                    if (NombreValido(nombreClienteIngresado))
                    {
                        nombreValido = true;
                    }
                    else
                    {
                        mensaje1 = "Ingrese Nombre Valido";
                        Console.SetCursorPosition(2, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje1);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        nombreClienteIngresado = Console.ReadLine();
                        Console.SetCursorPosition(2, fila_num);
                        Console.WriteLine("                             ");
                    }
                }

                fila_num = fila_num;
                bool apellidoValido = false;
                mensaje2 = "Ingrese Su Apellido";
                Console.SetCursorPosition(46, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje2);
                Box(43, fila_num + 1, 25, 3);
                textBoxLeft = 45;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string apellidoClienteIngresado = Console.ReadLine();
                Console.SetCursorPosition(46, fila_num);
                Console.WriteLine("                     ");

                while (!apellidoValido)
                {
                    if (NombreValido(apellidoClienteIngresado))
                    {
                        apellidoValido = true;
                    }
                    else
                    {
                        mensaje2 = "Ingrese Apellido Valido";
                        Console.SetCursorPosition(44, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje2);
                        Box(43, fila_num + 1, 25, 3);
                        textBoxLeft = 45;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        apellidoClienteIngresado = Console.ReadLine();
                        Console.SetCursorPosition(44, fila_num);
                        Console.WriteLine("                           ");
                    }
                }
                nombreCliente = nombreClienteIngresado;
                apellidoCliente = apellidoClienteIngresado;
            }
            else
            {
                bool nombreValido = false;
                mensaje1 = "Enter your first name";
                Console.SetCursorPosition(2, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje1);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string nombreClienteIngresado = Console.ReadLine();
                Console.SetCursorPosition(2, fila_num);
                Console.WriteLine("                       ");

                while (!nombreValido)
                {
                    if (NombreValido(nombreClienteIngresado))
                    {
                        nombreValido = true;
                    }
                    else
                    {
                        mensaje1 = "Enter a valid name";
                        Console.SetCursorPosition(2, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje1);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        nombreClienteIngresado = Console.ReadLine();
                        Console.SetCursorPosition(2, fila_num);
                        Console.WriteLine("                             ");
                    }
                }

                fila_num = fila_num;
                bool apellidoValido = false;
                mensaje2 = "Enter your last name";
                Console.SetCursorPosition(46, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje2);
                Box(43, fila_num + 1, 25, 3);
                textBoxLeft = 45;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string apellidoClienteIngresado = Console.ReadLine();
                Console.SetCursorPosition(46, fila_num);
                Console.WriteLine("                     ");

                while (!apellidoValido)
                {
                    if (NombreValido(apellidoClienteIngresado))
                    {
                        apellidoValido = true;
                    }
                    else
                    {
                        mensaje2 = "Enter a valid last name";
                        Console.SetCursorPosition(44, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje2);
                        Box(43, fila_num + 1, 25, 3);
                        textBoxLeft = 45;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        apellidoClienteIngresado = Console.ReadLine();
                        Console.SetCursorPosition(44, fila_num);
                        Console.WriteLine("                           ");
                    }
                }
                nombreCliente = nombreClienteIngresado;
                apellidoCliente = apellidoClienteIngresado;
            }
        }
        public static void Numero()
        {
            fila_num = fila_num;
            if (idiomaCliente == "1")
            {
                long num;
                bool numValido = false;
                string mensaje3 = "Ingrese Su Numero";
                Console.SetCursorPosition(91, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje3);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string numIngresado = Console.ReadLine();
                Console.SetCursorPosition(91, fila_num);
                Console.WriteLine("                        ");

                while (!numValido)
                {
                    if (long.TryParse(numIngresado, out num) && num >= 3000000000 && num <= 3999999999)
                    {
                        int primerosTresDigitos = (int)(num / 10000000);

                        if (primerosTresDigitos >= 300 && primerosTresDigitos <= 320)
                        {
                            numValido = true;
                        }
                    }

                    if (!numValido)
                    {
                        mensaje3 = "Ingrese Numero Valido";
                        Console.SetCursorPosition(89, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje3);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        numIngresado = Console.ReadLine();
                        Console.SetCursorPosition(89, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                numCliente = numIngresado;
            }
            else
            {
                long num;
                bool numValido = false;
                string mensaje3 = "Enter your phone number";
                Console.SetCursorPosition(88, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje3);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string numIngresado = Console.ReadLine();
                Console.SetCursorPosition(88, fila_num);
                Console.WriteLine("                           ");

                while (!numValido)
                {
                    if (long.TryParse(numIngresado, out num) && num >= 3000000000 && num <= 3999999999)
                    {
                        int primerosTresDigitos = (int)(num / 10000000);

                        if (primerosTresDigitos >= 300 && primerosTresDigitos <= 320)
                        {
                            numValido = true;
                        }
                    }

                    if (!numValido)
                    {
                        mensaje3 = "Enter a valid number";
                        Console.SetCursorPosition(89, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje3);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        numIngresado = Console.ReadLine();
                        Console.SetCursorPosition(89, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                numCliente = numIngresado;
            }
        }
        public static void Direccion()
        {
            fila_num = fila_num + 5;
            if (idiomaCliente == "1")
            {
                bool dirValida = false;
                string mensaje4 = "Ingrese Su Direccion";
                Console.SetCursorPosition(2, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje4);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string direccion = Console.ReadLine();
                Console.SetCursorPosition(2, fila_num);
                Console.WriteLine("                        ");

                while (!dirValida)
                {
                    if (DireccionValida(direccion))
                    {
                        dirValida = true;
                    }
                    else
                    {
                        mensaje4 = "Direccion Valida(cr-cll)";
                        Console.SetCursorPosition(1, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje4);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        direccion = Console.ReadLine();
                        Console.SetCursorPosition(1, fila_num);
                        Console.WriteLine("                        ");
                    }
                }
                direccionCliente = direccion;
            }
            else
            {
                bool dirValida = false;
                string mensaje4 = "Enter your address";
                Console.SetCursorPosition(2, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje4);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string direccion = Console.ReadLine();
                Console.SetCursorPosition(2, fila_num);
                Console.WriteLine("                        ");

                while (!dirValida)
                {
                    if (DireccionValida(direccion))
                    {
                        dirValida = true;
                    }
                    else
                    {
                        mensaje4 = "Valid address(st|ave)";
                        Console.SetCursorPosition(1, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje4);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        direccion = Console.ReadLine();
                        Console.SetCursorPosition(1, fila_num);
                        Console.WriteLine("                         ");
                    }
                }
                direccionCliente = direccion;
            }
        }
        public static void Edad()
        {
            fila_num = fila_num;
            if (idiomaCliente == "1")
            {
                bool edadValida = false;
                string mensaje5 = "Ingrese Su Edad";
                Console.SetCursorPosition(48, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje5);
                Box(43, fila_num + 1, 25, 3);
                textBoxLeft = 46;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string edad = Console.ReadLine();
                Console.SetCursorPosition(48, fila_num);
                Console.WriteLine("                          ");

                while (!edadValida)
                {
                    if (EdadValida(edad))
                    {
                        edadValida = true;
                    }
                    else
                    {
                        mensaje5 = "Ingrese Edad Valida(0-110)";
                        Console.SetCursorPosition(43, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje5);
                        Box(43, fila_num + 1, 25, 3);
                        textBoxLeft = 45;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        edad = Console.ReadLine();
                        Console.SetCursorPosition(43, fila_num);
                        Console.WriteLine("                           ");
                    }
                }
                edadCliente = edad;
            }
            else
            {
                bool edadValida = false;
                string mensaje5 = "Enter your age";
                Console.SetCursorPosition(48, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje5);
                Box(43, fila_num + 1, 25, 3);
                textBoxLeft = 46;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string edad = Console.ReadLine();
                Console.SetCursorPosition(48, fila_num);
                Console.WriteLine("                          ");

                while (!edadValida)
                {
                    if (EdadValida(edad))
                    {
                        edadValida = true;
                    }
                    else
                    {
                        mensaje5 = "Enter a valid age(0-110)";
                        Console.SetCursorPosition(43, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje5);
                        Box(43, fila_num + 1, 25, 3);
                        textBoxLeft = 45;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        edad = Console.ReadLine();
                        Console.SetCursorPosition(43, fila_num);
                        Console.WriteLine("                           ");
                    }
                }
                edadCliente = edad;
            }

        }
        public static void Sexo()
        {
            fila_num = fila_num;
            if (idiomaCliente == "1")
            {
                bool genero = false;
                string mensaje6 = "Ingrese Su Sexo";
                Console.SetCursorPosition(92, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje6);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string sexo = Console.ReadLine();
                Console.SetCursorPosition(92, fila_num);
                Console.WriteLine("                      ");

                while (!genero)
                {
                    if (GeneroValido(sexo))
                    {
                        genero = true;
                    }
                    else
                    {
                        mensaje6 = "Sexo Valido(M|F|m|f)";
                        Console.SetCursorPosition(90, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje6);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        sexo = Console.ReadLine();
                        Console.SetCursorPosition(90, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                sexoCliente = sexo;
            }
            else
            {
                bool genero = false;
                string mensaje6 = "Enter your gender";
                Console.SetCursorPosition(92, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje6);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string sexo = Console.ReadLine();
                Console.SetCursorPosition(92, fila_num);
                Console.WriteLine("                      ");

                while (!genero)
                {
                    if (GeneroValido(sexo))
                    {
                        genero = true;
                    }
                    else
                    {
                        mensaje6 = "Valid gender(M|F|m|f)";
                        Console.SetCursorPosition(90, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje6);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        sexo = Console.ReadLine();
                        Console.SetCursorPosition(90, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                sexoCliente = sexo;
            }

        }
        public static void Talla()
        {
            fila_num = fila_num + 5;
            if (idiomaCliente == "1")
            {
                bool tallaValida = false;
                string mensaje7 = "Ingrese Su Talla";
                Console.SetCursorPosition(3, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje7);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string talla = Console.ReadLine();
                Console.SetCursorPosition(3, fila_num);
                Console.WriteLine("                        ");

                while (!tallaValida)
                {
                    if (TallaValida(talla))
                    {
                        tallaValida = true;
                    }
                    else
                    {
                        mensaje7 = "Talla Valida(30-50)";
                        Console.SetCursorPosition(3, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje7);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        talla = Console.ReadLine();
                        Console.SetCursorPosition(3, fila_num);
                        Console.WriteLine("                        ");
                    }
                }
                tallaCliente = talla;
            }
            else
            {
                bool tallaValida = false;
                string mensaje7 = "Enter your shoe size";
                Console.SetCursorPosition(3, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje7);
                Box(fila_num - fila_num, fila_num + 1, 25, 3);
                textBoxLeft = fila_num - fila_num;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                string talla = Console.ReadLine();
                Console.SetCursorPosition(3, fila_num);
                Console.WriteLine("                        ");

                while (!tallaValida)
                {
                    if (TallaValida(talla))
                    {
                        tallaValida = true;
                    }
                    else
                    {
                        mensaje7 = "Valid shoe size(30-50)";
                        Console.SetCursorPosition(3, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje7);
                        Box(fila_num - fila_num, fila_num + 1, 25, 3);
                        textBoxLeft = fila_num - fila_num;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft + 2, textBoxTop);
                        talla = Console.ReadLine();
                        Console.SetCursorPosition(3, fila_num);
                        Console.WriteLine("                        ");
                    }
                }
                tallaCliente = talla;
            }
        }
        public static void Correo()
        {
            fila_num = fila_num;
            if (idiomaCliente == "1")
            {
                bool correoValido = false;
                string mensaje8 = "Ingrese Su Correo Electronico";
                Console.SetCursorPosition(41, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje8);
                Box(38, fila_num + 1, 34, 3);
                textBoxLeft = 39;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string correo = Console.ReadLine();
                Console.SetCursorPosition(41, fila_num);
                Console.WriteLine("                                ");

                while (!correoValido)
                {
                    if (EmailValido(correo))
                    {
                        correoValido = true;
                    }
                    else
                    {
                        mensaje8 = " Correo Valido(gmail-hotmail)";
                        Console.SetCursorPosition(41, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje8);
                        Box(38, fila_num + 1, 34, 3);
                        textBoxLeft = 39;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        correo = Console.ReadLine();
                        Console.SetCursorPosition(41, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                correoCliente = correo;
            }
            else
            {
                bool correoValido = false;
                string mensaje8 = "Enter your email address";
                Console.SetCursorPosition(43, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje8);
                Box(38, fila_num + 1, 34, 3);
                textBoxLeft = 39;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string correo = Console.ReadLine();
                Console.SetCursorPosition(43, fila_num);
                Console.WriteLine("                                ");

                while (!correoValido)
                {
                    if (EmailValido(correo))
                    {
                        correoValido = true;
                    }
                    else
                    {
                        mensaje8 = " Valid email(gmail-hotmail)";
                        Console.SetCursorPosition(41, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje8);
                        Box(38, fila_num + 1, 34, 3);
                        textBoxLeft = 39;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        correo = Console.ReadLine();
                        Console.SetCursorPosition(41, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                correoCliente = correo;
            }
        }
        public static void Pago()
        {
            fila_num = fila_num;
            if (idiomaCliente == "1")
            {
                bool pagoValido = false;
                string mensaje9 = "Ingrese Metodo De Pago";
                Console.SetCursorPosition(89, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje9);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string pago = Console.ReadLine();
                Console.SetCursorPosition(89, fila_num);
                Console.WriteLine("                        ");

                while (!pagoValido)
                {
                    if (PagoValido(pago))
                    {
                        pagoValido = true;
                    }
                    else
                    {
                        mensaje9 = "Pago(Tarjeta|Efectivo)";
                        Console.SetCursorPosition(89, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje9);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        pago = Console.ReadLine();
                        Console.SetCursorPosition(89, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                pagoCliente = pago;
            }
            else
            {
                bool pagoValido = false;
                string mensaje9 = "Enter payment method";
                Console.SetCursorPosition(89, fila_num);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mensaje9);
                Box(87, fila_num + 1, 25, 3);
                textBoxLeft = 89;
                textBoxTop = fila_num + 2;
                Console.SetCursorPosition(textBoxLeft, textBoxTop);
                string pago = Console.ReadLine();
                Console.SetCursorPosition(89, fila_num);
                Console.WriteLine("                        ");

                while (!pagoValido)
                {
                    if (PagoValido(pago))
                    {
                        pagoValido = true;
                    }
                    else
                    {
                        mensaje9 = "Payment method(Card|Cash)";
                        Console.SetCursorPosition(87, fila_num);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(mensaje9);
                        Box(87, fila_num + 1, 25, 3);
                        textBoxLeft = 89;
                        textBoxTop = fila_num + 2;
                        Console.SetCursorPosition(textBoxLeft, textBoxTop);
                        pago = Console.ReadLine();
                        Console.SetCursorPosition(87, fila_num);
                        Console.WriteLine("                             ");
                    }
                }
                pagoCliente = pago;
            }

        }
        public static void MuestraDatos()
        {
            string msj1, msj2;
            int retardo = 700;
            Thread.Sleep(retardo);
            fila_num = (fila_num - fila_num) + 1;
            msj1 = "█▀▄ ▄▀█ ▀█▀ ▄▀█   █▄▄ ▄▀█ █▀ █▀▀";
            msj2 = "█▄▀ █▀█  █  █▀█   █▄█ █▀█ ▄█ ██▄";
            Console.SetCursorPosition(0, fila_num);
            Console.WriteLine(msj1);
            fila_num = fila_num + 1;
            Thread.Sleep(retardo / 3);
            Console.SetCursorPosition(0, fila_num);
            Console.WriteLine(msj2);

            fila_num = fila_num + 3;
            Console.SetCursorPosition(0, fila_num);
            string tabla_horizontal = "────────────────────────────────────";
            Console.WriteLine("┌ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┐");

            fila_num = fila_num + 1;
            if (idiomaCliente == "1")
            {
                Console.SetCursorPosition(3, fila_num);
                string texto1 = "│ Nombre: " + nombreCliente;
                Console.WriteLine(texto1);

                Console.SetCursorPosition(36, fila_num);
                string texto2 = "│ Apellido: " + apellidoCliente;
                Console.WriteLine(texto2);

                Console.SetCursorPosition(80, fila_num);
                string texto3 = "│ Contacto: " + numCliente;
                Console.WriteLine(texto3);

                Console.WriteLine("├ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┤");

                fila_num = fila_num + 2;
                Console.SetCursorPosition(3, fila_num);
                string texto4 = "│ Direccion: " + direccionCliente;
                Console.WriteLine(texto4);

                Console.SetCursorPosition(36, fila_num);
                string texto5 = "│ Edad: " + edadCliente;
                Console.WriteLine(texto5);

                Console.SetCursorPosition(80, fila_num);
                string texto6 = "│ Sexo: " + sexoCliente;
                Console.WriteLine(texto6);

                Console.WriteLine("├ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┤");

                fila_num = fila_num + 2;
                Console.SetCursorPosition(3, fila_num);
                string texto7 = "│ Talla: " + tallaCliente;
                Console.WriteLine(texto7);

                Console.SetCursorPosition(36, fila_num);
                string texto8 = "│ Correo: " + correoCliente;
                Console.WriteLine(texto8);

                Console.SetCursorPosition(80, fila_num);
                string texto9 = "│ Metodo Pago: " + pagoCliente;
                Console.WriteLine(texto9);

                Console.WriteLine("└ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┘");
            }
            else
            {
                Console.SetCursorPosition(3, fila_num);
                string texto1 = "│ Name: " + nombreCliente;
                Console.WriteLine(texto1);

                Console.SetCursorPosition(36, fila_num);
                string texto2 = "│ Last Name: " + apellidoCliente;
                Console.WriteLine(texto2);

                Console.SetCursorPosition(80, fila_num);
                string texto3 = "│ Contact: " + numCliente;
                Console.WriteLine(texto3);

                Console.WriteLine("├ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┤");

                fila_num = fila_num + 2;
                Console.SetCursorPosition(3, fila_num);
                string texto4 = "│ Address: " + direccionCliente;
                Console.WriteLine(texto4);

                Console.SetCursorPosition(36, fila_num);
                string texto5 = "│ Age: " + edadCliente;
                Console.WriteLine(texto5);

                Console.SetCursorPosition(80, fila_num);
                string texto6 = "│ Gender: " + sexoCliente;
                Console.WriteLine(texto6);

                Console.WriteLine("├ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┤");

                fila_num = fila_num + 2;
                Console.SetCursorPosition(3, fila_num);
                string texto7 = "│ Shoe Size: " + tallaCliente;
                Console.WriteLine(texto7);

                Console.SetCursorPosition(36, fila_num);
                string texto8 = "│ Email: " + correoCliente;
                Console.WriteLine(texto8);

                Console.SetCursorPosition(80, fila_num);
                string texto9 = "│ Payment Method: " + pagoCliente;
                Console.WriteLine(texto9);

                Console.WriteLine("└ " + tabla_horizontal + tabla_horizontal + tabla_horizontal + " ┘");
            }
        }
        static bool NombreValido(string nombre)
        {
            foreach (char caracter in nombre)
            {
                if (!char.IsLetter(caracter))
                {
                    return false;
                }
            }
            return true;
        }
        static bool DireccionValida(string input)
        {
            if (idiomaCliente == "1")
            {
                Regex validar = new Regex(@"^(cll|cr|calle|carrera|Calle|Carrera)\s*\d+(\s*#\s*(\d+|\d+\s*[aA]))+\s*(-\s*\d+)?$", RegexOptions.IgnoreCase);
                return validar.IsMatch(input);
            }
            else
            {
                Regex validar = new Regex(@"^(st|ave)\s*\d+(\s*#\s*(\d+|\d+\s*[aA]))*\s*(-\s*\d+)?$", RegexOptions.IgnoreCase);
                return validar.IsMatch(input);
            }

        }
        static bool EdadValida(string input)
        {
            if (uint.TryParse(input, out uint años))
            {
                return años >= 0 && años <= 110;
            }

            return false;
        }
        static bool GeneroValido(string genero)
        {
            if (idiomaCliente == "1")
            {
                string[] palabrasPermitidas = { "m", "M", "masculino", "Masculino", "f", "F", "femenino", "Femenino" };
                foreach (string palabraPermitida in palabrasPermitidas)
                {
                    if (genero == palabraPermitida)
                    {
                        return true;
                    }
                }
            }
            else
            {
                string[] palabrasPermitidas = { "m", "M", "masculine", "Masculine", "f", "F", "feminine", "Feminine" };
                foreach (string palabraPermitida in palabrasPermitidas)
                {
                    if (genero == palabraPermitida)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool TallaValida(string input)
        {
            if (uint.TryParse(input, out uint tallaZapato))
            {
                return tallaZapato >= 30 && tallaZapato <= 50;
            }

            return false;
        }
        public static bool EmailValido(string email)
        {
            int long_email = email.Length;
            int posicion_arroba = 0;

            for (int pos_car = 0; pos_car < long_email; pos_car++)
            {
                string caracter = email.Substring(pos_car, 1);

                if (caracter == "@")
                {
                    posicion_arroba = pos_car;
                }
            }

            if (posicion_arroba == 0)
            {
                return false;
            }
            else
            {
                string parte_izquierda = email.Substring(0, posicion_arroba);
                string nombre_email = parte_izquierda;

                string primer_caracter = nombre_email.Substring(0, 1);

                char car = Convert.ToChar(primer_caracter.ToLower());

                if (!(car >= 'a' && car <= 'z'))
                {
                    return false;
                }
                else
                {
                    string parte_derecha = email.Substring(posicion_arroba + 1, (long_email - posicion_arroba) - 1);

                    string[] partes_derecha = parte_derecha.Split('.');
                    if (partes_derecha.Length < 2)
                    {
                        return false;
                    }

                    string empresa_correo = partes_derecha[0];

                    switch (empresa_correo.ToLower())
                    {
                        case "gmail":
                            return true;
                        case "hotmail":
                            return true;
                        default:
                            return false;
                    }
                }
            }
        }
        static bool PagoValido(string metodoPago)
        {
            if (idiomaCliente == "1")
            {
                string[] palabrasPermitidas = { "efectivo", "Efectivo", "tarjeta", "Tarjeta" };

                foreach (string palabraPermitida in palabrasPermitidas)
                {
                    if (metodoPago == palabraPermitida)
                    {
                        return true;
                    }
                }
            }
            else
            {
                string[] palabrasPermitidas = { "cash", "Cash", "card", "Card" };

                foreach (string palabraPermitida in palabrasPermitidas)
                {
                    if (metodoPago == palabraPermitida)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void TiempoEspera()
        {
            if (idiomaCliente == "1")
            {
                Console.SetCursorPosition(52, 17);
                Console.Write("CARGANDO");
            }
            else
            {
                Console.SetCursorPosition(52, 17);
                Console.Write("LOADING");
            }
            string msj1, msj2, msj3, msj4, msj5, msj6, msj7, msj8, msj9, msj10;
            int retardo = 700;
            Thread.Sleep(retardo);
            msj1 = "████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
            msj2 = "████████▒▒▒▒▒▒▒▒▒▒▒▒";
            msj3 = "████████████▒▒▒▒▒▒▒▒";
            msj4 = "████████████████▒▒▒▒";
            msj5 = "████████████████████";
            Console.SetCursorPosition(46, 15);
            Console.WriteLine(msj1);
            Thread.Sleep(retardo);
            Console.SetCursorPosition(46, 15);
            Console.WriteLine(msj2);
            Thread.Sleep(retardo);
            Console.SetCursorPosition(46, 15);
            Console.WriteLine(msj3);
            Thread.Sleep(retardo);
            Console.SetCursorPosition(46, 15);
            Console.WriteLine(msj4);
            Thread.Sleep(retardo);
            Console.SetCursorPosition(46, 15);
            Console.WriteLine(msj5);
            Thread.Sleep(retardo);
        }
        public static void ExitApp()
        {
            if (idiomaCliente == "1")
            {
                string msj1, msj2;
                int retardo = 700;
                Thread.Sleep(retardo);
                msj1 = "█▀▀ █▀█ ▄▀█ █▀▀ █ ▄▀█ █▀   █▀█ █▀█ █▀█   █ █ ▀█▀ █ █   █ ▀█ ▄▀█ █▀█   █▄ █ █ █ █▀▀ █▀ ▀█▀ █▀█ ▄▀█   ▄▀█ █▀█ █▀█";
                msj2 = "█▄█ █▀▄ █▀█ █▄▄ █ █▀█ ▄█   █▀▀ █▄█ █▀▄   █▄█  █  █ █▄▄ █ █▄ █▀█ █▀▄   █ ▀█ █▄█ ██▄ ▄█  █  █▀▄ █▀█   █▀█ █▀▀ █▀▀";
                fila_num = fila_num + 10;
                Console.SetCursorPosition(0, fila_num);
                Console.WriteLine(msj1);
                fila_num = fila_num + 1;
                Thread.Sleep(retardo / 3);
                Console.SetCursorPosition(0, fila_num);
                Console.WriteLine(msj2);

                Console.SetCursorPosition(34, 23);
                Console.Write("Presiona cualquier tecla para salir . . . ");
                Console.ReadKey(true);
            }
            else
            {
                string msj1, msj2;
                int retardo = 700;
                Thread.Sleep(retardo);
                msj1 = "▀█▀ █ █ ▄▀█ █▄ █ █▄▀   █▄█ █▀█ █ █   █▀▀ █▀█ █▀█   █ █ █▀ █ █▄ █ █▀▀   █▀█ █ █ █▀█   ▄▀█ █▀█ █▀█";
                msj2 = " █  █▀█ █▀█ █ ▀█ █ █    █  █▄█ █▄█   █▀  █▄█ █▀▄   █▄█ ▄█ █ █ ▀█ █▄█   █▄█ █▄█ █▀▄   █▀█ █▀▀ █▀▀";
                fila_num = fila_num + 10;
                Console.SetCursorPosition(3, fila_num);
                Console.WriteLine(msj1);
                fila_num = fila_num + 1;
                Thread.Sleep(retardo / 3);
                Console.SetCursorPosition(3, fila_num);
                Console.WriteLine(msj2);

                Console.SetCursorPosition(20, 23);
                Console.Write("Press any key to exit . . . ");
                Console.ReadKey(true);
            }
        }
    }
}