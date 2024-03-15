// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы
int[] array = new int[]{12, 16, 8, 23, 30, 28, 20};
int lastIndex = array.Length - 1;

void PrintArrayElements(int[] array, int i)
{

  if(i < 0)
  {
    return;
  } 

  Console.Write($"{array[i]} ");
  PrintArrayElements(array, i - 1);
}

PrintArrayElements(array, lastIndex);