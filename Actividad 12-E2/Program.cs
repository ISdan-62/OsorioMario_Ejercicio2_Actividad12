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
                if (dia >= 1 && dia <= 7)
                {
                    Console.WriteLine("Carnet vigente: (S/N) ");
                    string carne = Console.ReadLine();
                    Console.WriteLine("Autorización escrita: (S/N) ");
                    string autorizacion = Console.ReadLine();
                    Console.WriteLine("Trae USB: (S/N) ");
                    string traeUSB = Console.ReadLine();
                    if (traeUSB=="S")
                    {
                        Console.WriteLine("Está acompañado: (S/N) ");
                        string acompañado = Console.ReadLine();
                        if (acompañado=="S")
                        {
                            Console.WriteLine("Uso del USb concedido");
                        }
                        else
                        {
                            Console.WriteLine("Uso del USb denegado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No trae USB");
                    }
                    string acceso;
                    string nivel;
                    if (hora >= 7 && hora <= 18)
                    {
                        if (autorizacion == "S")
                        {
                            acceso = "Consedido";
                            nivel = "Permirtido al estudiante";
                        }
                        else if (autorizacion=="N" && carne=="S")
                        {
                            acceso = "Consedido condicionalmente";
                            nivel = "Permirtido condicionalmente al estudiante";
                        }
                        else
                        {
                            acceso = "Denegado";
                            nivel = "Denegado al estudiante";
                        }
                        Console.WriteLine("RESULTADO");
                        Console.WriteLine($"El acceso es:  {acceso}");
                        Console.WriteLine($"Nivel de permiso es:   {nivel}");
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
                    Console.WriteLine("Autorización escrita: (S/N) ");
                    string autorizacion = Console.ReadLine();
                    Console.WriteLine("Trae USB: (S/N) ");
                    string traeUSB = Console.ReadLine();
                    if (traeUSB == "S")
                    {
                        Console.WriteLine("Está acompañado: (S/N) ");
                        string acompañado = Console.ReadLine();
                        if (acompañado == "S")
                        {
                            Console.WriteLine("Uso del USb concedido");
                        }
                        else
                        {
                            Console.WriteLine("Uso del USb denegado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No trae USB");
                    }
                    string acceso;
                    string nivel;
                    if (hora >= 7 && hora <= 18)
                    {
                        if (carne == "S")
                        {
                            acceso = "Consedido";
                            nivel = "Permirtido al docente";
                        }
                        else if (carne == "N" && autorizacion == "S")
                        {
                            acceso = "Consedido condicionalmente";
                            nivel = "Permirtido condicionalmente al docente";
                        }
                        else
                        {
                            acceso = "Denegado";
                            nivel = "Denegado al docente";
                        }
                        Console.WriteLine("RESULTADO");
                        Console.WriteLine($"El acceso es:  {acceso}");
                        Console.WriteLine($"Nivel de permiso es:   {nivel}");
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
                    Console.WriteLine("Autorización escrita: (S/N) ");
                    string autorizacion = Console.ReadLine();
                    Console.WriteLine("Trae USB: (S/N) ");
                    string traeUSB = Console.ReadLine();
                    if (traeUSB == "S")
                    {
                        Console.WriteLine("Está acompañado: (S/N) ");
                        string acompañado = Console.ReadLine();
                        if (acompañado == "S")
                        {
                            Console.WriteLine("Uso del USb concedido");
                        }
                        else
                        {
                            Console.WriteLine("Uso del USb denegado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No trae USB");
                    }
                    string acceso;
                    string nivel;
                    if (hora <=6 && hora >= 19)
                    {
                        if (autorizacion == "S")
                        {
                            acceso = "Consedido";
                            nivel = "Permirtido al tecnico";
                        }
                        else
                        {
                            acceso = "Denegado";
                            nivel = "Denegado al tecnico";
                        }
                        Console.WriteLine("RESULTADO");
                        Console.WriteLine($"El acceso es:  {acceso}");
                        Console.WriteLine($"Nivel de permiso es:   {nivel}");
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
                    Console.WriteLine("Autorización escrita: (S/N) ");
                    string autorizacion = Console.ReadLine();
                    Console.WriteLine("Trae USB: (S/N) ");
                    string traeUSB = Console.ReadLine();
                    Console.WriteLine("Está acompañado: (S/N) ");
                    string acompañado = Console.ReadLine();
                    if (traeUSB == "S")
                    {
                        if (acompañado == "S")
                        {
                            Console.WriteLine("Uso del USb concedido");
                        }
                        else
                        {
                            Console.WriteLine("Uso del USb denegado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No trae USB");
                    }
                    string acceso;
                    string nivel;
                    if (autorizacion=="S")
                    {
                        if (acompañado == "S")
                        {
                            acceso = "Consedido";
                            nivel = "Permirtido al visitante";
                        }
                        else
                        {
                            acceso = "Denegado";
                            nivel = "Denegado al visitante";
                        }
                        Console.WriteLine("RESULTADO");
                        Console.WriteLine($"El acceso es:  {acceso}");
                        Console.WriteLine($"Nivel de permiso es:   {nivel}");
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
            }
            break;  
        }
    default:
        {
            Console.WriteLine("Opción no válida");
        }
        break;
}
