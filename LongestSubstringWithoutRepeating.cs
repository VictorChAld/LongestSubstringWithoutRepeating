using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LongestSubstringWithoutRepeating
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        char[] arr = s.ToCharArray();
        string cadena = "";
        string maxcadena = "";

        for (int i = 0; i < arr.Length; i++)
        {            
            if (!cadena.Contains(arr[i].ToString()))
            {
                cadena = cadena + arr[i].ToString();                
            }
            else
            {
                cadena = cadena + arr[i].ToString();
                //Si se corta la secuencia porque hay un caracter repetido, debo decidir cuál es más largo, el que se corta o el que se va a formar
                int index = cadena.IndexOf(arr[i].ToString());
                cadena = cadena.Substring(index + 1, (cadena.Length) - (index + 1));
            }
        }
        maxcadena = (cadena.Length > maxcadena.Length) ? cadena : maxcadena; //con esto me aseguro que mientras avanza la cadena, se convierta en la máxima

        return maxcadena.Length;
    }
}
