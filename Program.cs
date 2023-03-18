using System.Media;

namespace EstudianteSorpresa {

    class Program {

        public static void Main (string[]args) {


            // Lista de estudiantes y Diccionario
            List<string> list_estudiantes = new List<string>{                
                "Adrian Francisco Carlos",
                "Arisneudy Junior Santana Pozo",
                "Ashley Classe Ripol",
                "Brahiam Isai Montero Santillan",
                "Bryant Lerbours Reynoso",
                "César Junior Pérez Castillo",
                "Claudio Argenis Ferreira Guaba",
                "Crismel Mariñez Carrasco",
                "Crystal De Los Angeles Guzman Matos",
                "Frank Junior Jesus Peña",
                "George Luis Canela Sosa",
                "Gregory Acosta Peña",
                "Hanler Vargas Fernandez",
                "Hector Gabriel Medina Garcia",
                "Heidy Maria Javier Cordero",
                "Igor Ubiera Corniel",
                "Isaac Alexander Polonio Lorenzo",
                "Jamil Antonio Williams Ortiz",
                "Johan Dariel Hernandez Suarez",
                "Jommy Domínguez Sánchez",
                "Jorge Jeffer Rosendo Felix",
                "Laura Teodocia Cantalicio Calderón",
                "Mark Roberandy Abreu Gomez",
                "Oliver Polanco Sanchez",
                "Osiris Omarlin Matos Moreta",
                "Rachely Esther Pérez Del Villar",
                "Yahinniel Alejandro Torres Vasquez"
                };
            List<string> present_estudiante = new List<string>(list_estudiantes);
            List<string> ejer_estudiante = new List<string>(present_estudiante);
            
            // Variables
            bool bucle = true;
            bool b_maestro = true;

            //Audios
            SoundPlayer inicio = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\Inicio-p.wav")!; // Inicio
            SoundPlayer m_principal = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\MenuPrincipal.wav")!; // Menu Principal
            SoundPlayer elegir_est = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\est_sorpresa.wav")!; //Sonido al momento de elegir al estudiante
            SoundPlayer m_maestro = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\m_maestro.wav")!; //Sonido del modo maestro
            SoundPlayer saliendo = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\saliendo.wav")!; //Sonido al salir del sistema
            SoundPlayer error = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\error.wav")!; //Sonido cuando ocure un error
            SoundPlayer s_modo = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\s_modo.wav"); //Sonido al salir de un modo
            SoundPlayer i_modo = new ("C:\\Users\\Arisn\\Escritorio\\EstudianteSorpresa\\Audios\\i_modo.wav"); //Sonido al ingresar a un modo

            inicio.Play ();
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(@"
                             ________            __                    __ __                     __                                                                                           
                            |        \          |  \                  |  \  \                   |  \                                                                                          
                            | ▓▓▓▓▓▓▓▓ _______ _| ▓▓_   __    __  ____| ▓▓\▓▓ ______  _______  _| ▓▓_    ______        _______  ______   ______   ______   ______   ______   _______  ______  
                            | ▓▓__    /       \   ▓▓ \ |  \  |  \/      ▓▓  \|      \|       \|   ▓▓ \  /      \      /       \/      \ /      \ /      \ /      \ /      \ /       \|      \ 
                            | ▓▓  \  |  ▓▓▓▓▓▓▓\▓▓▓▓▓▓ | ▓▓  | ▓▓  ▓▓▓▓▓▓▓ ▓▓ \▓▓▓▓▓▓\ ▓▓▓▓▓▓▓\\▓▓▓▓▓▓ |  ▓▓▓▓▓▓\    |  ▓▓▓▓▓▓▓  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓▓ \▓▓▓▓▓▓\
                            | ▓▓▓▓▓   \▓▓    \  | ▓▓ __| ▓▓  | ▓▓ ▓▓  | ▓▓ ▓▓/      ▓▓ ▓▓  | ▓▓ | ▓▓ __| ▓▓    ▓▓     \▓▓    \| ▓▓  | ▓▓ ▓▓   \▓▓ ▓▓  | ▓▓ ▓▓   \▓▓ ▓▓    ▓▓\▓▓    \ /      ▓▓
                            | ▓▓_____ _\▓▓▓▓▓▓\ | ▓▓|  \ ▓▓__/ ▓▓ ▓▓__| ▓▓ ▓▓  ▓▓▓▓▓▓▓ ▓▓  | ▓▓ | ▓▓|  \ ▓▓▓▓▓▓▓▓     _\▓▓▓▓▓▓\ ▓▓__/ ▓▓ ▓▓     | ▓▓__/ ▓▓ ▓▓     | ▓▓▓▓▓▓▓▓_\▓▓▓▓▓▓\  ▓▓▓▓▓▓▓
                            | ▓▓     \       ▓▓  \▓▓  ▓▓\▓▓    ▓▓\▓▓    ▓▓ ▓▓\▓▓    ▓▓ ▓▓  | ▓▓  \▓▓  ▓▓\▓▓     \    |       ▓▓\▓▓    ▓▓ ▓▓     | ▓▓    ▓▓ ▓▓      \▓▓     \       ▓▓\▓▓    ▓▓
                             \▓▓▓▓▓▓▓▓\▓▓▓▓▓▓▓    \▓▓▓▓  \▓▓▓▓▓▓  \▓▓▓▓▓▓▓\▓▓ \▓▓▓▓▓▓▓\▓▓   \▓▓   \▓▓▓▓  \▓▓▓▓▓▓▓     \▓▓▓▓▓▓▓  \▓▓▓▓▓▓ \▓▓     | ▓▓▓▓▓▓▓ \▓▓       \▓▓▓▓▓▓▓\▓▓▓▓▓▓▓  \▓▓▓▓▓▓▓
                                                                                                                                                | ▓▓                                          
                                                                                                                                                | ▓▓                                          
                                                                                                                                                 \▓▓                                          
                            ");

            //Barra de carga
            for (int i = 0; i < 162; i++) {

                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep (80);
                Console.Write ("▀");
            }

            Thread.Sleep(1600);
            Console.ResetColor();
            inicio.Stop();
            Console.Clear();
            m_principal.Play ();

            do {

                // Menu Principal
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear ();
                Console.WriteLine(@" 

                                    ░▒█▀▄▀█░█▀▀░█▀▀▄░█░▒█░░░▒█▀▀█░█▀▀▄░░▀░░█▀▀▄░█▀▄░░▀░░▄▀▀▄░█▀▀▄░█░
                                    ░▒█▒█▒█░█▀▀░█░▒█░█░▒█░░░▒█▄▄█░█▄▄▀░░█▀░█░▒█░█░░░░█▀░█▄▄█░█▄▄█░█░
                                    ░▒█░░▒█░▀▀▀░▀░░▀░░▀▀▀░░░▒█░░░░▀░▀▀░▀▀▀░▀░░▀░▀▀▀░▀▀▀░█░░░░▀░░▀░▀▀       
                                 ");
                Console.ResetColor();
                Console.WriteLine("\n[1] Estudiante a Presentar");
                Console.WriteLine("[2] Estudiante a dar Ejercicio");
                Console.WriteLine("[3] Salir");
                Console.WriteLine("\n[0] Maestro\n");
                Console.Write("Ingrese una opcion: ");
                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion) {
                    
                    // Muestra los estudiantes que tienen que presentar en clase
                    case (1):

                        m_principal.Stop ();
                        // Mostrar datos que no se repitan de la lista
                        present_estudiante = present_estudiante.Distinct().ToList();
                        //Si no hay ningun indice en la lista, procede a mostrar el mensaje siguiente
                        if (present_estudiante.Count == 0) {
                            
                            Console.Clear ();
                            Console.WriteLine("Ya han presentado todos los estudiantes....");

                            Thread.Sleep(1000);
                            Console.Write("\nPresione una tecla....");
                            Console.ReadKey();

                            // Devuelve al principio del bucle
                            continue;
                        }

                        Console.Clear ();
                        Random e = new ();
                        // Va a leer desde el indice 0 hasta el ultimo indice de la lista
                        int index = e.Next (0, present_estudiante.Count);
                        // Se asigna el nombre del estudiante a la variable creada estudiante
                        string estudiante = present_estudiante[index];
                        // Remueve el indice elegido para que no pueda volver a repetirse
                        present_estudiante.RemoveAt (index);
                        // Agrega el nombre del estudiante a la segunda lista, para que puede ser elegido en la otra lista
                        ejer_estudiante.Add (estudiante);
                        
                        elegir_est.Play();
                        Thread.Sleep(7000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine (@"   
                                            ░▒█▀▀▀░█▀▀░▀█▀░█░▒█░█▀▄░░▀░░█▀▀▄░█▀▀▄░▀█▀░█▀▀░░░█▀▀░█▀▀░█░░█▀▀░█▀▄░█▀▄░░▀░░▄▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄
                                            ░▒█▀▀▀░▀▀▄░░█░░█░▒█░█░█░░█▀░█▄▄█░█░▒█░░█░░█▀▀░░░▀▀▄░█▀▀░█░░█▀▀░█░░░█░░░░█▀░█░░█░█░▒█░█▄▄█░█░█░█░░█
                                            ░▒█▄▄▄░▀▀▀░░▀░░░▀▀▀░▀▀░░▀▀▀░▀░░▀░▀░░▀░░▀░░▀▀▀░░░▀▀▀░▀▀▀░▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░░▀▀░░▀░░▀░▀░░▀░▀▀░░░▀▀░
                                            ");
                        Console.ResetColor();
                        Console.WriteLine($"\nEl estudiante [{estudiante}] debe presentar en clase.");

                        Thread.Sleep(1000);
                        Console.Write("\nPresione una tecla....");
                        Console.ReadKey();
                        elegir_est.Stop();
                        Thread.Sleep(200);

                        break;


                    // Muestra los estudiantes que tienen que dar un ejercicio a un estudiante x en clase
                    case (2):

                        m_principal.Stop ();
                        // Mostrar datos que no se repitan de la lista
                        ejer_estudiante = ejer_estudiante.Distinct().ToList();
                        //Si no hay ningun indice en la lista, procede a mostrar el mensaje siguiente
                        if (ejer_estudiante.Count == 0) {
                            
                            Console.Clear ();
                            Console.WriteLine("Ya han dado ejercicios todos los estudiantes....");

                            Thread.Sleep(1000);
                            Console.Write("\nPresione una tecla....");
                            Console.ReadKey();

                            // Devuelve al principio del bucle
                            continue;
                        }

                        Console.Clear();
                        Random e2 = new ();
                        // Va a tomar un indice aleatorio desde el indice 0 hasta el ultimo indice de la lista y lo va a guardar en la variable index2
                        int index2 = e2.Next(0, ejer_estudiante.Count);
                        // Se asigna el nombre del estudiante por medio del indice ramdom obtenido a la variable estudiantes
                        string estudiantes = ejer_estudiante[index2];
                        // Remueve el indice de la lista para no repetir el nombre nuevamente
                        ejer_estudiante.RemoveAt(index2);
                        // Agrega de nuevo al estudiante a la lista de los que presentan, para que pueda presentar en algun momento
                        present_estudiante.Add(estudiantes);

                        elegir_est.Play();
                        Thread.Sleep(7000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine (@"   
                                            ░▒█▀▀▀░█▀▀░▀█▀░█░▒█░█▀▄░░▀░░█▀▀▄░█▀▀▄░▀█▀░█▀▀░░░█▀▀░█▀▀░█░░█▀▀░█▀▄░█▀▄░░▀░░▄▀▀▄░█▀▀▄░█▀▀▄░█▀▄░▄▀▀▄
                                            ░▒█▀▀▀░▀▀▄░░█░░█░▒█░█░█░░█▀░█▄▄█░█░▒█░░█░░█▀▀░░░▀▀▄░█▀▀░█░░█▀▀░█░░░█░░░░█▀░█░░█░█░▒█░█▄▄█░█░█░█░░█
                                            ░▒█▄▄▄░▀▀▀░░▀░░░▀▀▀░▀▀░░▀▀▀░▀░░▀░▀░░▀░░▀░░▀▀▀░░░▀▀▀░▀▀▀░▀▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░░▀▀░░▀░░▀░▀░░▀░▀▀░░░▀▀░
                                            ");
                        Console.ResetColor();
                        Console.WriteLine($"El estudiante [{estudiantes}] debe dar un ejercicio.");

                        Thread.Sleep(1000);
                        Console.Write("\nPresione una tecla....");
                        Console.ReadKey();
                        elegir_est.Stop();
                        Thread.Sleep(200);

                        break;


                    // Salir del programa  
                    case (3):
                        saliendo.Play();
                        m_principal.Stop ();
                        saliendo.Play();
                        Console.Clear ();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine (@"   
                                                $$$$$$\             $$\ $$\                           $$\           
                                                $$  __$$\           $$ |\__|                          $$ |          
                                                $$ /  \__| $$$$$$\  $$ |$$\  $$$$$$\  $$$$$$$\   $$$$$$$ | $$$$$$\  
                                                \$$$$$$\   \____$$\ $$ |$$ |$$  __$$\ $$  __$$\ $$  __$$ |$$  __$$\ 
                                                \____$$\  $$$$$$$ |$$ |$$ |$$$$$$$$ |$$ |   $$|$$/   $$ |$$ /  $$ |
                                                $$\   $$ |$$  __$$ |$$ |$$ |$$   ____|$$|  $$ |$|    $$ |$$ |  $$ |
                                                \$$$$$$  |\$$$$$$$ |$$ |$$ |\$$$$$$$\ $$|  $$ | \$$$$$$$ |\$$$$$$  |
                                                \______/  \_______|\__|\__| \_______|\__|  \__|  \_______| \______/ 
                                                                    
                                            ");
                        
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.ResetColor();
                        bucle = false;

                        break;
                    

                    // Entrar al modo maestro
                    case (0):
                        Console.Clear();
                        m_principal.Stop ();
                        i_modo.Play();
                        Thread.Sleep(2000);
                        i_modo.Stop();
                        Thread.Sleep(1000);
                        m_maestro.Play ();

                        do {
                            //Menu principal - Modo maestro
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(@"
                                
                                ░█▀▄▀█░█▀▀░█▀▀▄░█░▒█░░░█▀▄▀█░█▀▀▄░█▀▀░█▀▀░▀█▀░█▀▀▄░▄▀▀▄
                                ░█░▀░█░█▀▀░█░▒█░█░▒█░░░█░▀░█░█▄▄█░█▀▀░▀▀▄░░█░░█▄▄▀░█░░█
                                ░▀░░▒▀░▀▀▀░▀░░▀░░▀▀▀░░░▀░░▒▀░▀░░▀░▀▀▀░▀▀▀░░▀░░▀░▀▀░░▀▀░
                            ");
                            Console.ResetColor();
                            Console.WriteLine("[1] Agregar estudiante a la lista");
                            Console.WriteLine("[2] Borrar estudiante de la lista");
                            Console.WriteLine("[3] Ver lista de los estudiante");
                            Console.WriteLine("[4] Salir \n");
                            Console.Write("Ingrese una opcion: ");

                            int opcion2 = int.Parse(Console.ReadLine()!);

                            switch (opcion2) {

                                case 1:

                                    m_maestro.Stop ();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine (@"
                                                        ╔═══╗╔═══╗╔════╗╔╗ ╔╗╔═══╗╔╗   ╔══╗╔════╗╔═══╗╔═══╗╔══╗╔═══╗╔═╗ ╔╗    ╔═══╗╔═══╗    ╔╗   ╔══╗╔═══╗╔════╗╔═══╗
                                                        ║╔═╗║║╔═╗║║╔╗╔╗║║║ ║║║╔═╗║║║   ╚╣╠╝╚══╗ ║║╔═╗║║╔═╗║╚╣╠╝║╔═╗║║║╚╗║║    ╚╗╔╗║║╔══╝    ║║   ╚╣╠╝║╔═╗║║╔╗╔╗║║╔═╗║
                                                        ║║ ║║║║ ╚╝╚╝║║╚╝║║ ║║║║ ║║║║    ║║   ╔╝╔╝║║ ║║║║ ╚╝ ║║ ║║ ║║║╔╗╚╝║     ║║║║║╚══╗    ║║    ║║ ║╚══╗╚╝║║╚╝║║ ║║
                                                        ║╚═╝║║║ ╔╗  ║║  ║║ ║║║╚═╝║║║ ╔╗ ║║  ╔╝╔╝ ║╚═╝║║║ ╔╗ ║║ ║║ ║║║║╚╗║║     ║║║║║╔══╝    ║║ ╔╗ ║║ ╚══╗║  ║║  ║╚═╝║
                                                        ║╔═╗║║╚═╝║ ╔╝╚╗ ║╚═╝║║╔═╗║║╚═╝║╔╣╠╗╔╝ ╚═╗║╔═╗║║╚═╝║╔╣╠╗║╚═╝║║║ ║║║    ╔╝╚╝║║╚══╗    ║╚═╝║╔╣╠╗║╚═╝║ ╔╝╚╗ ║╔═╗║
                                                        ╚╝ ╚╝╚═══╝ ╚══╝ ╚═══╝╚╝ ╚╝╚═══╝╚══╝╚════╝╚╝ ╚╝╚═══╝╚══╝╚═══╝╚╝ ╚═╝    ╚═══╝╚═══╝    ╚═══╝╚══╝╚═══╝ ╚══╝ ╚╝ ╚╝
                                                        ");
                                    Console.ResetColor();
                                    Console.Write ("Cantidad a introducir: ");
                                    int n = int.Parse (Console.ReadLine()!);

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine (@"
                                                        ╔═══╗╔═══╗╔════╗╔╗ ╔╗╔═══╗╔╗   ╔══╗╔════╗╔═══╗╔═══╗╔══╗╔═══╗╔═╗ ╔╗    ╔═══╗╔═══╗    ╔╗   ╔══╗╔═══╗╔════╗╔═══╗
                                                        ║╔═╗║║╔═╗║║╔╗╔╗║║║ ║║║╔═╗║║║   ╚╣╠╝╚══╗ ║║╔═╗║║╔═╗║╚╣╠╝║╔═╗║║║╚╗║║    ╚╗╔╗║║╔══╝    ║║   ╚╣╠╝║╔═╗║║╔╗╔╗║║╔═╗║
                                                        ║║ ║║║║ ╚╝╚╝║║╚╝║║ ║║║║ ║║║║    ║║   ╔╝╔╝║║ ║║║║ ╚╝ ║║ ║║ ║║║╔╗╚╝║     ║║║║║╚══╗    ║║    ║║ ║╚══╗╚╝║║╚╝║║ ║║
                                                        ║╚═╝║║║ ╔╗  ║║  ║║ ║║║╚═╝║║║ ╔╗ ║║  ╔╝╔╝ ║╚═╝║║║ ╔╗ ║║ ║║ ║║║║╚╗║║     ║║║║║╔══╝    ║║ ╔╗ ║║ ╚══╗║  ║║  ║╚═╝║
                                                        ║╔═╗║║╚═╝║ ╔╝╚╗ ║╚═╝║║╔═╗║║╚═╝║╔╣╠╗╔╝ ╚═╗║╔═╗║║╚═╝║╔╣╠╗║╚═╝║║║ ║║║    ╔╝╚╝║║╚══╗    ║╚═╝║╔╣╠╗║╚═╝║ ╔╝╚╗ ║╔═╗║
                                                        ╚╝ ╚╝╚═══╝ ╚══╝ ╚═══╝╚╝ ╚╝╚═══╝╚══╝╚════╝╚╝ ╚╝╚═══╝╚══╝╚═══╝╚╝ ╚═╝    ╚═══╝╚═══╝    ╚═══╝╚══╝╚═══╝ ╚══╝ ╚╝ ╚╝
                                                        ");
                                    Console.ResetColor();

                                    
                                    for (int i = 0; i < n; i++) {

                                        Console.Write ("Ingrese el nombre del estudiante: ");
                                        string es_nombre = Console.ReadLine ()!;
                                        list_estudiantes.Insert(0, es_nombre);
                                    }
                                    
                                    Thread.Sleep(1000);
                                    Console.Write("\nPresione una tecla....");
                                    Console.ReadKey();
                                    break;

                                case 2:

                                    Console.Clear();
                                    m_maestro.Stop ();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine (@"
                                                        ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
                                                        ██░▄▄▀█▀▄▄▀█░▄▄▀█░▄▄▀█░▄▄▀█░▄▄▀████░▄▄▄█░▄▄█▄░▄█░██░█░▄▀██▄██░▄▄▀█░▄▄▀█▄░▄█░▄▄
                                                        ██░▄▄▀█░██░█░▀▀▄█░▀▀▄█░▀▀░█░▀▀▄████░▄▄▄█▄▄▀██░██░██░█░█░██░▄█░▀▀░█░██░██░██░▄▄
                                                        ██░▀▀░██▄▄██▄█▄▄█▄█▄▄█▄██▄█▄█▄▄████░▀▀▀█▄▄▄██▄███▄▄▄█▄▄██▄▄▄█▄██▄█▄██▄██▄██▄▄▄
                                                        ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                                                        ");
                                    Console.ResetColor();
                                    Console.Write ("Ingrese el nombre del estudiante: ");
                                    string name = Console.ReadLine ()!;
                                    
                                    Console.Clear ();
                                    for (int i = 0; i < list_estudiantes.Count; i++) {

                                        // El metodo StartsWith sirve para buscar algun nombre por su inicial o por el primer nombre
                                        if (list_estudiantes[i] == name || list_estudiantes[i].StartsWith(name)) {
                                            
                                            Console.WriteLine ($"El estudiante [{list_estudiantes[i]}] ha sido eliminado con exito....");
                                            list_estudiantes.RemoveAt (i);

                                            Thread.Sleep(1000);
                                            Console.Write("\nPresione una tecla....");
                                            Console.ReadKey();
                                        }

                                    }

                                    break;

                                case 3:

                                    m_maestro.Stop ();
                                    Console.Clear ();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(@"

                                                        ░▒█░░░░░▀░░█▀▀░▀█▀░█▀▀▄░░░▒█▀▀▀░█▀▀░▀█▀░█░▒█░█▀▄░░▀░░█▀▀▄░█▀▀▄░▀█▀░█▀▀░█▀▀
                                                        ░▒█░░░░░█▀░▀▀▄░░█░░█▄▄█░░░▒█▀▀▀░▀▀▄░░█░░█░▒█░█░█░░█▀░█▄▄█░█░▒█░░█░░█▀▀░▀▀▄
                                                        ░▒█▄▄█░▀▀▀░▀▀▀░░▀░░▀░░▀░░░▒█▄▄▄░▀▀▀░░▀░░░▀▀▀░▀▀░░▀▀▀░▀░░▀░▀░░▀░░▀░░▀▀▀░▀▀▀
                                                    ");
                                    Console.ResetColor();
                                    
                                    //Recorrer lista de alumnos
                                    for (int i = 0; i < list_estudiantes.Count; i++) {

                                        Console.WriteLine ($"{i}) {list_estudiantes[i]}");
                                    }

                                    Thread.Sleep(1000);
                                    Console.Write("\nPresione una tecla....");
                                    Console.ReadKey();
                                    
                                    break;

                                case 4: 

                                    m_maestro.Stop ();
                                    Console.Clear ();
                                    s_modo.Play();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine (@"   
                                                            $$$$$$\            $$\ $$\                           $$\           
                                                            $$  __$$\           $$ |\__|                          $$ |          
                                                            $$ /  \__| $$$$$$\  $$ |$$\  $$$$$$\  $$$$$$$\   $$$$$$$ | $$$$$$\  
                                                            \$$$$$$\   \____$$\ $$ |$$ |$$  __$$\ $$  __$$\ $$  __$$ |$$  __$$\ 
                                                            \____$$\  $$$$$$$ |$$ |$$ |$$$$$$$$ |$$ |  $$ |$$ /   $$ |$$ /  $$ |
                                                            $$\   $$ |$$  __$$ |$$ |$$ |$$   ____|$$ |  $$ |$|    $$ |$$ |  $$ |
                                                            \$$$$$$  |\$$$$$$$ |$$ |$$ |\$$$$$$$\ $$ |  $$ |\$$$$$$$ |\$$$$$$  |
                                                            \______/  \_______|\__|\__| \_______|\__|  \__| \_______| \______/ 
                                                                                
                                                        ");
                                    
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.ResetColor();
                                    b_maestro = false;

                                    break;

                                default:
                                    m_maestro.Stop ();
                                    Console.Clear();
                                    error.Play();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(@"

                                                        ░▒█▀▀▀░█▀▀▄░█▀▀▄░▄▀▀▄░█▀▀▄░█
                                                        ░▒█▀▀▀░█▄▄▀░█▄▄▀░█░░█░█▄▄▀░▀
                                                        ░▒█▄▄▄░▀░▀▀░▀░▀▀░░▀▀░░▀░▀▀░▄
                                                     ");
                                    
                                    Thread.Sleep(2000);
                                    Console.ResetColor();
                                    Console.Write("\nPresione una tecla....");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (b_maestro == true);

                        break;

                    default:

                        m_principal.Stop ();
                        Console.Clear();
                        error.Play();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"

                                            ░▒█▀▀▀░█▀▀▄░█▀▀▄░▄▀▀▄░█▀▀▄░█
                                            ░▒█▀▀▀░█▄▄▀░█▄▄▀░█░░█░█▄▄▀░▀
                                            ░▒█▄▄▄░▀░▀▀░▀░▀▀░░▀▀░░▀░▀▀░▄
                                            ");
                        
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        Console.Write("\nPresione una tecla....");
                        Console.ReadKey();
                        break;
                }

            } while (bucle == true);
        }
    }
}