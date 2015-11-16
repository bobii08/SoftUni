using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int positionInWord = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    char currentChar = word[positionInWord];
                    matrix[rows, cols] = currentChar;
                    positionInWord++;
                    if (positionInWord == word.Length)
                    {
                        positionInWord = 0;
                    }
                }
            }

            List<string> listOfWords = new List<string>();
            listOfWords.Add("");

            // check in the right direction
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char firstLetter = matrix[row, col];
                    string currentWord = firstLetter.ToString();
                    int currentNumberOfLettersInSequence = 1;
                    if (matrix.GetLength(0) == 1)
                    {
                        Console.WriteLine(matrix[0, 0]);
                        return;
                    }
                    if (col + 1 < matrix.GetLength(1))
                    {
                        char nextLetter = matrix[row, col + 1];
                        while (firstLetter < nextLetter)
                        {
                            currentWord = currentWord + nextLetter;
                            currentNumberOfLettersInSequence++;
                            if (currentNumberOfLettersInSequence > listOfWords[0].Length)
                            {
                                listOfWords.Clear();
                                listOfWords.Add(currentWord);
                            }
                            else if (currentNumberOfLettersInSequence == listOfWords[0].Length)
                            {
                                listOfWords.Add(currentWord);
                            }

                            col++;
                            if (col == matrix.GetLength(1) - 1)
                            {
                                break;
                            }

                            firstLetter = nextLetter;
                            nextLetter = matrix[row, col + 1];
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    char firstLetter = matrix[row, col];
                    string currentWord = firstLetter.ToString();
                    int currentNumberOfLettersInSequence = 1;
                    if (col - 1 >= 0)
                    {
                        char nextLetter = matrix[row, col - 1];
                        while (firstLetter < nextLetter)
                        {
                            currentWord = currentWord + nextLetter;
                            currentNumberOfLettersInSequence++;
                            if (currentNumberOfLettersInSequence > listOfWords[0].Length)
                            {
                                listOfWords.Clear();
                                listOfWords.Add(currentWord);
                            }
                            else if (currentNumberOfLettersInSequence == listOfWords[0].Length)
                            {
                                listOfWords.Add(currentWord);
                            }

                            col--;
                            if (col == 0)
                            {
                                break;
                            }

                            firstLetter = nextLetter;
                            nextLetter = matrix[row, col - 1];
                        }
                    }
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    char firstLetter = matrix[row, col];
                    string currentWord = firstLetter.ToString();
                    int currentNumberOfLettersInSequence = 1;
                    if (row + 1 < matrix.GetLength(0))
                    {
                        char nextLetter = matrix[row + 1, col];
                        while (firstLetter < nextLetter)
                        {
                            currentNumberOfLettersInSequence++;
                            currentWord = currentWord + nextLetter;
                            if (currentNumberOfLettersInSequence > listOfWords[0].Length)
                            {
                                listOfWords.Clear();
                                listOfWords.Add(currentWord);
                            }
                            else if (currentNumberOfLettersInSequence == listOfWords[0].Length)
                            {
                                listOfWords.Add(currentWord);
                            }

                            row++;
                            if (row == matrix.GetLength(0) - 1)
                            {
                                break;
                            }

                            firstLetter = nextLetter;
                            nextLetter = matrix[row + 1, col];
                        }
                    }
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    char firstLetter = matrix[row, col];
                    string currentWord = firstLetter.ToString();
                    int currentNumberOfLettersInSequence = 1;
                    if (row - 1 >= 0)
                    {
                        char nextLetter = matrix[row - 1, col];
                        while (firstLetter < nextLetter)
                        {
                            currentNumberOfLettersInSequence++;
                            currentWord = currentWord + nextLetter;
                            if (currentNumberOfLettersInSequence > listOfWords[0].Length)
                            {
                                listOfWords.Clear();
                                listOfWords.Add(currentWord);
                            }
                            else if (currentNumberOfLettersInSequence == listOfWords[0].Length)
                            {
                                listOfWords.Add(currentWord);
                            }

                            row--;
                            if (row == 0)
                            {
                                break;
                            }

                            firstLetter = nextLetter;
                            nextLetter = matrix[row - 1, col];
                        }
                    }
                }
            }

            listOfWords.Sort();
            Console.WriteLine(listOfWords[0]);
        }
    }
}
