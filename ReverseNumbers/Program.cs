// https://youtu.be/F8ytNWMI_a0?si=NspUME6dT7uyHqQV&t=235

int counter = 1;

Console.WriteLine("Bitte eine ganze Zahl eingeben");
int zahl = Convert.ToInt32(Console.ReadLine());
zahl = zahl - (zahl % 9);       // muss durch 9 teilbar sein
int noOfGroups = zahl / 3;      // Anzahl der 3er Gruppen
int noOfRows = zahl / 9;        // Anzahl der Zeilen
int[,] matrix = new int[noOfGroups, 3];

// Zahlen in Array aus 3er Arrays schreiben
for (int i = 0; i < noOfGroups; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = counter;
        counter++;
    }
}

// Zeilenweise Ausgabe der 3er Gruppen
for (int i = 0; i < noOfGroups; i += 3) //Zeilen
{
    PrintRow(i, matrix);
}

static void PrintRow(int i, int[,] matrix)
{
    PrintGroup(i + 2, matrix);
    PrintGroup(i + 1, matrix);
    PrintGroup(i + 0, matrix);
    Console.WriteLine();
}
static void PrintGroup(int gr, int[,] matrix)
{
    Console.Write(matrix[gr, 0] + " ");
    Console.Write(matrix[gr, 1] + " ");
    Console.Write(matrix[gr, 2] + "\t");
}
