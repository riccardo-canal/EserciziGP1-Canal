using Enum__Struct_e_Cast;

internal class Program
{
    private static void Main(string[] args)
    {
        // Header
        Console.WriteLine("======================");
        Console.WriteLine("Exercises on Enum, Struct and Cast");
        Console.WriteLine("======================");

        // Esercizio 1: Creare un enum per rappresentare i giorni della settimana e iterare sui valori.
        Console.WriteLine("\nExercise 1\n");
        EnumStructCastFunctions.IterateWeekDays();

        // Esercizio 2: Dichiarare un enum per rappresentare i livelli di priorità di un task.
        Console.WriteLine("\nExercise 2\n");
        EnumStructCastFunctions.ShowTaskPriority();

        // Esercizio 3: Usare un enum per selezionare un'opzione in uno switch-case.
        Console.WriteLine("\nExercise 3\n");
        EnumStructCastFunctions.SwitchCaseEnum();

        // Esercizio 4: Dichiarare una struct per rappresentare un punto 2D e calcolare la distanza tra due punti.
        Console.WriteLine("\nExercise 4\n");
        EnumStructCastFunctions.CalculateDistance();

        // Esercizio 5: Creare una struct per rappresentare un rettangolo e calcolarne l'area.
        Console.WriteLine("\nExercise 5\n");
        EnumStructCastFunctions.CalculateRectangleArea();

        // Esercizio 6: Utilizzare un enum per rappresentare i tipi di un veicolo in un programma.
        Console.WriteLine("\nExercise 6\n");
        EnumStructCastFunctions.VehicleTypeExample();

        // Esercizio 7: Dichiarare una struct con un costruttore e un metodo.
        Console.WriteLine("\nExercise 7\n");
        EnumStructCastFunctions.CalculateCircleArea();

        // Esercizio 8: Scrivere un programma che converte un valore int in un enum usando il casting.
        Console.WriteLine("\nExercise 8\n");
        EnumStructCastFunctions.ConvertIntToEnum();

        // Esercizio 9: Dichiarare un enum con valori personalizzati e verificarne l'uso.
        Console.WriteLine("\nExercise 9\n");
        EnumStructCastFunctions.CustomEnumValues();

        // Esercizio 10: Creare una struct per rappresentare un colore in formato RGB.
        Console.WriteLine("\nExercise 10\n");
        EnumStructCastFunctions.DisplayColorExample();

        // Esercizio 11: Utilizzare un enum in una funzione per selezionare un'opzione.
        Console.WriteLine("\nExercise 11\n");
        EnumStructCastFunctions.SelectOperationExample();

        // Esercizio 12: Dichiarare una struct con proprietà readonly.
        Console.WriteLine("\nExercise 12\n");
        EnumStructCastFunctions.ReadOnlyStructExample();

        // Esercizio 13: Creare un enum per rappresentare i mesi dell'anno.
        Console.WriteLine("\nExercise 13\n");
        EnumStructCastFunctions.DisplayMonth();

        // Esercizio 14: Dichiarare una struct per rappresentare una persona con nome e età.
        Console.WriteLine("\nExercise 14\n");
        EnumStructCastFunctions.CreatePerson();

        // Esercizio 15: Scrivere un programma che utilizza il casting esplicito tra tipi numerici.
        Console.WriteLine("\nExercise 15\n");
        EnumStructCastFunctions.ExplicitCastingExample();

        // Esercizio 16: Dichiarare un enum per rappresentare i tipi di errore di un'app.
        Console.WriteLine("\nExercise 16\n");
        EnumStructCastFunctions.AppErrorExample();

        // Esercizio 17: Creare una struct per rappresentare una posizione 3D e calcolarne la distanza.
        Console.WriteLine("\nExercise 17\n");
        EnumStructCastFunctions.Calculate3DDistance();

        // Esercizio 18: Utilizzare un enum per definire i tipi di permesso di un'app.
        Console.WriteLine("\nExercise 18\n");
        EnumStructCastFunctions.PermissionExample();

        // Esercizio 19: Dichiarare una struct per rappresentare una data personalizzata.
        Console.WriteLine("\nExercise 19\n");
        EnumStructCastFunctions.DisplayCustomDate();

        // Esercizio 20: Creare una struct per rappresentare una carta da gioco (valore e seme).
        Console.WriteLine("\nExercise 20\n");
        EnumStructCastFunctions.DisplayPlayingCard();

        // Esercizio 21: Utilizzare un enum in un'istruzione condizionale.
        Console.WriteLine("\nExercise 21\n");
        EnumStructCastFunctions.ConditionalEnum();

        // Esercizio 22: Dichiarare una struct che contiene un array come proprietà.
        Console.WriteLine("\nExercise 22\n");
        EnumStructCastFunctions.ContainerExample();

        // Esercizio 23: Scrivere un programma che converte un valore double in float usando il casting esplicito.
        Console.WriteLine("\nExercise 23\n");
        EnumStructCastFunctions.DoubleToFloatCasting();

        // Esercizio 24: Utilizzare un enum per rappresentare i tipi di file supportati da un'app.
        Console.WriteLine("\nExercise 24\n");
        EnumStructCastFunctions.FileTypeExample();

        // Esercizio 25: Creare una struct per rappresentare un vettore e calcolare il prodotto scalare.
        Console.WriteLine("\nExercise 25\n");
        EnumStructCastFunctions.VectorDotProduct();
    }
}
