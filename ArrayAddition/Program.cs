using System;

namespace ArrayAddition
{
    class Program
    {
        /// <summary>
        /// Additionne deux tableaux à 2 dimensions
        /// </summary>
        /// <param name="array1">Premier tableau 2D</param>
        /// <param name="array2">Deuxième tableau 2D</param>
        /// <returns>Nouveau tableau 2D contenant la somme des valeurs correspondantes, ou null si les dimensions ne correspondent pas</returns>
        static int[,]? AddArrays2D(int[,] array1, int[,] array2)
        {
            // Vérifier que les tableaux ne sont pas null
            if (array1 == null || array2 == null)
                return null;

            // Obtenir les dimensions des tableaux
            int rows1 = array1.GetLength(0);
            int cols1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int cols2 = array2.GetLength(1);

            // Vérifier que les dimensions sont identiques
            if (rows1 != rows2 || cols1 != cols2)
                return null;

            // Créer le tableau résultat
            int[,] result = new int[rows1, cols1];

            // Additionner les valeurs correspondantes
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Affiche un tableau 2D de manière formatée
        /// </summary>
        /// <param name="array">Le tableau à afficher</param>
        static void PrintArray2D(int[,]? array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("[");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < cols - 1)
                        Console.Write(" ");
                }
                Console.WriteLine("]");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Addition de tableaux 2D ===");
            Console.WriteLine();

            // Exemple d'utilisation selon l'image fournie
            int[,] tableau1 = { { 1, 2 }, { 3, 4 } };
            int[,] tableau2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Tableau 1:");
            PrintArray2D(tableau1);
            Console.WriteLine();

            Console.WriteLine("Tableau 2:");
            PrintArray2D(tableau2);
            Console.WriteLine();

            Console.WriteLine("Résultat de l'addition:");
            int[,]? resultat = AddArrays2D(tableau1, tableau2);
            PrintArray2D(resultat);
            Console.WriteLine();

            // Test avec des tableaux de dimensions différentes
            Console.WriteLine("=== Test avec des dimensions différentes ===");
            int[,] tableau3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] tableau4 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Tableau 3 (2x3):");
            PrintArray2D(tableau3);
            Console.WriteLine();

            Console.WriteLine("Tableau 4 (2x2):");
            PrintArray2D(tableau4);
            Console.WriteLine();

            Console.WriteLine("Résultat de l'addition (doit être null):");
            int[,]? resultatDifferent = AddArrays2D(tableau3, tableau4);
            PrintArray2D(resultatDifferent);
            Console.WriteLine();

            // Test supplémentaire avec des tableaux 3x3
            Console.WriteLine("=== Test avec des tableaux 3x3 ===");
            int[,] tableau5 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] tableau6 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            Console.WriteLine("Tableau 5:");
            PrintArray2D(tableau5);
            Console.WriteLine();

            Console.WriteLine("Tableau 6:");
            PrintArray2D(tableau6);
            Console.WriteLine();

            Console.WriteLine("Résultat de l'addition:");
            int[,]? resultat3x3 = AddArrays2D(tableau5, tableau6);
            PrintArray2D(resultat3x3);
        }
    }
}
