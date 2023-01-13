string[] CreateArray(string[] array){
    int count = 0;

    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new String[count];
    count = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            newArray[count] = array[i];
            count++;
        }  
    }

    return newArray;
}

void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

string[] array = {"hello", "2", "world", ":-)"};
PrintArray(CreateArray(array));