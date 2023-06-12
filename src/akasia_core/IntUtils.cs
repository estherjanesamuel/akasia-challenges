namespace akasia_core;

public class IntUtils
{

    public int perkalianSederhana(int j, int k)
    {
        int hasil = 0;
        while (j > 0)
        {
            /*
                There is a small mistake here 
                The variable name total is used instead of hasil.
                
                "total += k;"
            */
            hasil += k;
            j--;
        }
        return hasil;
    }
}