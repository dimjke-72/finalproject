int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

