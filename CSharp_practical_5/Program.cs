class ExceptionHandling
{
    static void Main(string[] args)
    {
        try
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(array[i]);
            }
        }catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("This is Finally Block");
        }

        Console.ReadKey();
    }
}