using System;

namespace DastFood.Classes
{
    static class Horof
    {
        private static string[/*20*/] AlphaNumeric1;
        private static string[/*10*/] AlphaNumeric2;
        private static string[/*10*/] AlphaNumeric3;

        private static void Alphaset()
        {
            if (AlphaNumeric1 == null)
            {
                AlphaNumeric1 = new string[20];
                AlphaNumeric2 = new string[10];
                AlphaNumeric3 = new string[10];
            }


            AlphaNumeric1[0] = "صفر";
            AlphaNumeric1[1] = "یک";
            AlphaNumeric1[2] = "دو";
            AlphaNumeric1[3] = "سه";
            AlphaNumeric1[4] = "چهار";
            AlphaNumeric1[5] = "پنج";
            AlphaNumeric1[6] = "شش";
            AlphaNumeric1[7] = "هفت";
            AlphaNumeric1[8] = "هشت";
            AlphaNumeric1[9] = "نه";
            AlphaNumeric1[10] = "ده";
            AlphaNumeric1[11] = "یازده";
            AlphaNumeric1[12] = "دوازده";
            AlphaNumeric1[13] = "سیزده";
            AlphaNumeric1[14] = "چهارده";
            AlphaNumeric1[15] = "پانزده";
            AlphaNumeric1[16] = "شانزده";
            AlphaNumeric1[17] = "هفده";
            AlphaNumeric1[18] = "هجده";
            AlphaNumeric1[19] = "نوزده";

            AlphaNumeric2[1] = "ده";
            AlphaNumeric2[2] = "بیست";
            AlphaNumeric2[3] = "سی";
            AlphaNumeric2[4] = "چهل";
            AlphaNumeric2[5] = "پنجاه";
            AlphaNumeric2[6] = "شست";
            AlphaNumeric2[7] = "هفتاد";
            AlphaNumeric2[8] = "هشتاد";
            AlphaNumeric2[9] = "نود";

            AlphaNumeric3[1] = "یکصد";
            AlphaNumeric3[2] = "دویست";
            AlphaNumeric3[3] = "سیصد";
            AlphaNumeric3[4] = "چهارصد";
            AlphaNumeric3[5] = "پانصد";
            AlphaNumeric3[6] = "ششصد";
            AlphaNumeric3[7] = "هفتصد";
            AlphaNumeric3[8] = "هشتصد";
            AlphaNumeric3[9] = "نهصد";
        }

        public static string toHorof(string Number)
        {
            string Num = Number.Substring(0,Number.Contains(".") ? Number.IndexOf('.') : Number.Length);
            if (Number.StartsWith("-"))
                return "منفی " + toHorof2(Num.Replace("-", ""));
            else
                return toHorof2(Num);
        }
        public static string toHorof2(string Number)
        {
            if (Number == "") return "";
            Alphaset();

            long No;
            string N;

            No = long.Parse(Number);
            N = No.ToString();

            switch (N.Length)
            {
                case 1:
                case 2:
                case 3:
                    if (No < 20)
                        return AlphaNumeric1[No];
                    else if (No < 100)
                    {
                        if (No % 10 == 0)
                            return AlphaNumeric2[No / 10];
                        else
                            return AlphaNumeric2[No / 10] + " و " + toHorof((No % 10).ToString());
                    }
                    else if (No < 1000)
                    {
                        if (No % 100 == 0)
                            return AlphaNumeric3[No / 100];
                        else
                            return AlphaNumeric3[No / 100] + " و " + toHorof((No % 100).ToString());
                    }
                    break;
                case 4:
                case 5:
                case 6:
                    if (N.EndsWith("000"))
                        return toHorof(N.Substring(0, N.Length - 3)) + " هزار ";
                    else
                        return toHorof(N.Substring(0, N.Length - 3)) + " هزار " + " و" + toHorof(N.Substring(N.Length - 3, 3));
                case 7:
                case 8:
                case 9:
                    if (N.EndsWith("000000"))
                        return toHorof(N.Substring(0, N.Length - 6)) + " میلیون ";
                    else
                        return toHorof(N.Substring(0, N.Length - 6)) + " میلیون " + " و" + toHorof(N.Substring(N.Length - 6, 6));
                default:
                    if (N.EndsWith("000000000"))
                        return toHorof(N.Substring(0, N.Length - 9)) + " میلیارد ";
                    else
                        return toHorof(N.Substring(0, N.Length - 9)) + " میلیارد " + " و" + toHorof(N.Substring(N.Length - 9, 9));
            }
            throw new ArgumentException();
        }
    }
}
