// See https://aka.ms/new-console-template for more information
// programa que puedo ejecutar
using System;
using System.IO;

namespace MyApplication
{
  class Day1
  {
    static void Main(string[] args)
    {
      var path = @"C:\dev\CSharp-advent-of-code-2023\test\input.txt";
      var lines = ReadFile(path);
      var fileLenght = lines.Length;

      var first = 0;
      var last = 0;
      var counter = 0;
      for (int i= 0; i< fileLenght; i++){
        first= Day1.FirstNumberOfWord(lines[i]);
        last= Day1.LastNumberOfWord(lines[i]);
        counter += first*10 + last;
      }
      Console.WriteLine(counter);
    }
    static int FirstNumberOfWord(string aWord)
    {
      int lenght = aWord.Length;
      for (int i= 0; i< lenght; i++){
        if(char.IsDigit(aWord[i])){
          int firstNumber = aWord[i] - '0';
          return firstNumber;
        }
      }
      return -1;
    }
    static int LastNumberOfWord(string aWord)
    {
      int lenght = aWord.Length;
      for (int i= lenght-1; i>= 0; i--){
        if(char.IsDigit(aWord[i])){
          int lastNumber = aWord[i] - '0';
          return lastNumber;
        }
      }
      return -1;
    }
    static string[] ReadFile(string path){
      var content = File.ReadAllLines(path);
      return content;
    }
  }
}