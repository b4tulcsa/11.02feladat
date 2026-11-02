// jelszoerosseg

char[] karakterek = { '-', '_', '.' };
void jelszo_erosseg(string jelszo)
{
    int erosseg = 1;
    if (jelszo.Length >= 5)
    {
        erosseg++;
    }
    if (jelszo.Length >= 8)
    {
        erosseg += 2;
    }
    foreach (char betu in jelszo)
    {
        if (karakterek.Contains(betu))
        {
            erosseg += 2;
        }
    }
    if (jelszo.Contains("123") || jelszo.Contains("jelszo"))
    {
        erosseg = 0;
    }
    Console.WriteLine($"Input: {jelszo}");
    Console.WriteLine($"Return: {erosseg}");
}

jelszo_erosseg("hazi_macska_4_life");
Console.WriteLine();
jelszo_erosseg("ez1feltorhetetlenjelszo");

Console.WriteLine();

// Magánhangzó eltávolítás
string maganhangzo_torol(string szoveg)
{
    szoveg.Replace("a", "");
    szoveg.Replace("á", "");
    szoveg.Replace("e", "");
    szoveg.Replace("é", "");
}
