string[] massivArray = new string[] {"tray", "fra", "ra", "2f2", "f4pi", "white", "red", "write", "line", "no", "yes", "false", ""};
string strList = string.Empty;
for (int i = 0; i < massivArray.Length; i++)
{
    if (Convert.ToString(massivArray[i]).Length < 4 &&
                          massivArray[i] != string.Empty)
    {
        if (strList.Length == 0)
        {
            strList += Convert.ToString(massivArray[i]);
        }
        else
        {
            if (i < massivArray.Length)
            {
                strList += "\n";
            }
            strList += Convert.ToString(massivArray[i]);
        }
    }
}
string[] arrayList = new string[strList.Length];
arrayList = strList.Split("\n");


for (int i = 0; i < arrayList.Length; i++)
{
    Console.WriteLine(arrayList[i]);
}
