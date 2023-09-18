public class ModuloFirst
{
    public static int[] modulof(int[] t_in)
    {
        int first = t_in[0];
        int[] output = new int[t_in.Length];
        for (int i = 0; i < t_in.Length; i++)
        {
            output[i] = t_in[i] % first;
        }
        return output;
    }
}
