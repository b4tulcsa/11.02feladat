## 11.02.-ei feladat


### Fibonacci
```C#
int fibo(int hanyadik)
{
    int elozo = 0;
    int mostani = 1;
    int osszeadott = 0;

    for (int i = 1; i < hanyadik; i++)
    {
        osszeadott = elozo + mostani;
        elozo = mostani;
        mostani = osszeadott;
    }
    if (hanyadik == 0)
    {
        return elozo;
    }
    else
    {
        return mostani;
    }
    
}

Console.WriteLine(fibo(int.Parse(Console.ReadLine())));
```
### Abs-Max
```C#
int abs_max(int egy, int keto)
{
    return Math.Max(Math.Abs(egy), Math.Abs(keto));
}

Console.WriteLine(abs_max(12, -15));
```
