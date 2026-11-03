// jelszoerosseg

using System.Globalization;

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

char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'u', 'ú', 'ü', 'ű', 'o', 'ó', 'ö', 'ő', 'A', 'Á', 'E', 'É', 'I', 'Í', 'U', 'Ú', 'Ü', 'Ű', 'O', 'Ó', 'Ö', 'Ő' };
void maganhangzo_torol(string szoveg)
{
    foreach (char betu in szoveg)
    {
        if (maganhangzok.Contains(betu))
        {
            Console.Write("");
        }
        else
        {
            Console.Write(betu);
        }
    }
}
maganhangzo_torol("abAgrwéÁccc");


// Elmozdulás

int vert = 0;
int hor = 0;
string mozdulasv = "";
string mozdulash = "";
void elmozdulas(string mozgas)
{
    foreach (char betu in mozgas)
    {
        if (betu == 'J')
        {
            hor -= 1;
        }
        else if (betu == 'B')
        {
            hor += 1;
        }
        else if (betu == 'F')
        {
            vert += 1;
        }
        else if (betu == 'L')
        {
            vert -= 1;
        }
    }

    if (vert > 0)
    {
        mozdulasv = "Fel";
    }
    else
    {
        mozdulasv = "Le";
    }
    if (hor > 0)
    {
        mozdulash = "Bal";
    }
    else
    {
        mozdulash = "Jobb";
    }

    Console.WriteLine($"Mozdulunk {mozdulash}ra {Math.Abs(hor)}-ot és {mozdulasv}fele {Math.Abs(vert)}at");
}

elmozdulas("JJFBFFFFFFBBBL");