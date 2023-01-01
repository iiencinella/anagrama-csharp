string? wordOne;
string? wordTwo;
int option = 0;

do
{
  Console.Clear();
  PrintMessage();
  Console.WriteLine("Ingrese la primer palabra (es para evaluar si es palabra anagram)");
  wordOne = Console.ReadLine();
} while(wordOne?.Trim().Length == 0);

do
{
  Console.Clear();
  PrintMessage();
  Console.WriteLine("Ingrese la segunda palabra");
  wordTwo = Console.ReadLine();
} while(wordTwo?.Trim().Length == 0);

Console.Clear();
PrintMessage();
Console.WriteLine("Escriba el número del algoritmo a usar:");
Console.WriteLine("1. Removiendo de la segunda palabra las letras existentes en la primera");
Console.WriteLine("2. Ordenando ambas cadenas y comparando");
Console.WriteLine("3. Obteniendo el valor ASCII de cada caracter de cada palabra, sumarlos y comparar resultados");
int.TryParse(Console.ReadLine(), out option);

//First validation. Option menu correct
if(option > 0)
{
  //Second validation. Lenghts words
  if(wordOne?.Length != wordTwo?.Length)
  {
    Console.WriteLine("Las palabras no son anagrama");
    Thread.Sleep(1000);
    return;
  }

  //Third validation. Empty values
  if(wordOne?.Trim() == "" && wordTwo?.Trim() == "")
  {
    Console.WriteLine("Las palabras no son anagrama");
    Thread.Sleep(1000);
    return;
  }

  if(ProccessToEvaluating(option, ref wordOne, ref wordTwo))
  {
    Console.WriteLine("Las palabras {0} y {1} son anagramas", wordOne, wordTwo);
  }
  else
  {
    Console.WriteLine("Las palabras {0} y {1} no son anagrama", wordOne, wordTwo);
  }
  Thread.Sleep(1000);
}
else
{
  Console.WriteLine("Se acabó el programa");
  Thread.Sleep(500);
}

static void PrintMessage()
{
  Console.WriteLine("Bienvenido!!!");
  Console.WriteLine("Esto es un ejercicio para determinar si dos palabras son anagrama.");
}

static bool ProccessToEvaluating(int? option, ref string? wordOne, ref string? wordTwo)
{
  bool response = false;

  switch (option)
  {
    case 1:
      response = AnagramRemoveArray(wordOne, wordTwo);
      break;
    case 2:
      response = AnagramSort(wordOne, wordTwo);
      break;
    case 3:
      response = (AnagramNumeric(wordOne, wordTwo));
      break;
  }

  return response;
}

static bool AnagramRemoveArray(string? word1, string? word2)
{
  for (int i = 0; i < word1?.Length; i++)
  {
    int pos = word2.IndexOf(word1[i]);
    if (pos > -1) word2 = word2.Remove(pos, 1);
    else break;
  }
  
  return word2 == "";
}

static bool AnagramSort(string? word1, string? word2)
{
  word1 = String.Concat(word1.OrderBy(ch => ch));
  word2 = String.Concat(word2.OrderBy(ch => ch));

  return word1 == word2;
}

static bool AnagramNumeric(string? word1, string? word2)
{
  int addWord1 = 0;
  int addWord2 = 0;

  foreach (var character in word1)
  {
    addWord1 += (int)character;
  }

  foreach (var character in word2)
  {
    addWord2 += (int)character;
  }

  return addWord1 == addWord2;
}