# Addition de Tableaux 2D

Ce projet implémente une fonction en C# qui permet d'additionner deux tableaux à 2 dimensions.

## Fonctionnalités

La fonction `AddArrays2D` prend en paramètre deux tableaux à 2 dimensions et retourne :
- Un nouveau tableau 2D contenant la somme des valeurs correspondantes si les dimensions sont identiques
- `null` si les tableaux n'ont pas la même taille

## Spécifications

- Vérification que les dimensions des deux tableaux sont identiques
- Addition élément par élément des tableaux
- Gestion des cas d'erreur (tableaux null ou dimensions différentes)

## Exemple d'utilisation

```csharp
int[,] tableau1 = { { 1, 2 }, { 3, 4 } };
int[,] tableau2 = { { 1, 2 }, { 3, 4 } };

int[,]? resultat = AddArrays2D(tableau1, tableau2);
// Résultat: { { 2, 4 }, { 6, 8 } }
```

## Compilation et exécution

```bash
cd ArrayAddition
dotnet build
dotnet run
```

## Résultat attendu

```
=== Addition de tableaux 2D ===

Tableau 1:
[1 2]
[3 4]

Tableau 2:
[1 2]
[3 4]

Résultat de l'addition:
[2 4]
[6 8]
```

Le programme inclut également des tests pour :
- L'addition de tableaux avec des dimensions différentes (retourne null)
- L'addition de tableaux 3x3 pour valider le fonctionnement avec d'autres tailles