Console.Clear();
string [] massiv = ["1234", "1567", "-2", "computer science"];
string [] array = new string[massiv.Length]; 
int j = 0;
for (int i = 0; i < massiv.Length; i++){
    if (massiv[i].Length <= 3){
        array[j] = massiv[i];
        j++;
    } 
}
Console.WriteLine ($"Начальный массив: {string.Join(" ", massiv)}");
Console.WriteLine ($"Конечный массив: {string.Join(" ", array)}");