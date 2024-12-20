namespace _1
{
    public class Mas1Op
    {
        public static int Summa(int[,] mas1 )
        {
            int summa2 = 0;
            foreach (int element in mas1)
        {
            if(element % 3 == 0)
        {
            summa2 += element;
        }
            }
        return summa2;
        }
    }
}