Console.WriteLine("MENU");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Técnico IT");
Console.WriteLine("4. Visitante");
Console.WriteLine("Seleccionar una opción: ");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        {
            Console.WriteLine("Ingresar Hora : ");
            int hora = int.Parse(Console.ReadLine());
            if (hora >= 0 && hora <= 23)
            {
                Console.WriteLine("Ingresar dia: ");
                int dia = int.Parse(Console.ReadLine());
                if (dia >= 1 && dia <=7)
                {
                    Console.WriteLine("Carnet vigente: (S/N) ");
                    string carne = Console.ReadLine();
                    if (carne == "S")
                    {
                        Console.WriteLine("Autorización escrita: (S/N) ");
                        string autorizacion = Console.ReadLine();
                        if (carne == "S")
                        {
                            Console.WriteLine("Trae USB: (S/N) ");
                            string traeUSB = Console.ReadLine();
                            if (traeUSB == "S")
                            {
                                Console.WriteLine("Está acompañado: (S/N) ");
                                string acompañado = Console.ReadLine();
                                if (acompañado == "S")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No esta acompañado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No trae USB");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Autorizacion invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Carne invalido");
                    }
                }
                else
                {
                    Console.WriteLine("Dia invalida");
                }
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("Ingresar Hora : ");
            int hora = int.Parse(Console.ReadLine());
            if (hora >= 0 && hora <= 23)
            {
                Console.WriteLine("Ingresar dia: ");
                int dia = int.Parse(Console.ReadLine());
                if (dia >= 1 && dia <= 7)
                {
                    Console.WriteLine("Carnet vigente: (S/N) ");
                    string carne = Console.ReadLine();
                    if (carne == "S")
                    {
                        Console.WriteLine("Autorización escrita: (S/N) ");
                        string autorizacion = Console.ReadLine();
                        if (carne == "S")
                        {
                            Console.WriteLine("Trae USB: (S/N) ");
                            string traeUSB = Console.ReadLine();
                            if (traeUSB == "S")
                            {
                                Console.WriteLine("Está acompañado: (S/N) ");
                                string acompañado = Console.ReadLine();
                                if (acompañado == "S")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No esta acompañado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No trae USB");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Autorizacion invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Carne invalido");
                    }
                }
                else
                {
                    Console.WriteLine("Dia invalida");
                }
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("Ingresar Hora : ");
            int hora = int.Parse(Console.ReadLine());
            if (hora >= 0 && hora <= 23)
            {
                Console.WriteLine("Ingresar dia: ");
                int dia = int.Parse(Console.ReadLine());
                if (dia >= 1 && dia <= 7)
                {
                    Console.WriteLine("Carnet vigente: (S/N) ");
                    string carne = Console.ReadLine();
                    if (carne == "S")
                    {
                        Console.WriteLine("Autorización escrita: (S/N) ");
                        string autorizacion = Console.ReadLine();
                        if (carne == "S")
                        {
                            Console.WriteLine("Trae USB: (S/N) ");
                            string traeUSB = Console.ReadLine();
                            if (traeUSB == "S")
                            {
                                Console.WriteLine("Está acompañado: (S/N) ");
                                string acompañado = Console.ReadLine();
                                if (acompañado == "S")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No esta acompañado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No trae USB");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Autorizacion invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Carne invalido");
                    }
                }
                else
                {
                    Console.WriteLine("Dia invalida");
                }
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }
            break;
        }
    case 4:
        {
            Console.WriteLine("Ingresar Hora : ");
            int hora = int.Parse(Console.ReadLine());
            if (hora >= 0 && hora <= 23)
            {
                Console.WriteLine("Ingresar dia: ");
                int dia = int.Parse(Console.ReadLine());
                if (dia >= 1 && dia <= 7)
                {
                    Console.WriteLine("Carnet vigente: (S/N) ");
                    string carne = Console.ReadLine();
                    if (carne == "S")
                    {
                        Console.WriteLine("Autorización escrita: (S/N) ");
                        string autorizacion = Console.ReadLine();
                        if (carne == "S")
                        {
                            Console.WriteLine("Trae USB: (S/N) ");
                            string traeUSB = Console.ReadLine();
                            if (traeUSB == "S")
                            {
                                Console.WriteLine("Está acompañado: (S/N) ");
                                string acompañado = Console.ReadLine();
                                if (acompañado == "S")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No esta acompañado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No trae USB");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Autorizacion invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Carne invalido");
                    }
                }
                else
                {
                    Console.WriteLine("Dia invalida");
                }
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }
            break;
        }
    default:
        {
            Console.WriteLine("Opción no válida");
        }
        break;
}
