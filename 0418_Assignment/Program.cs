namespace _0418_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStructure.List<string> list = new DataStructure.List<string>();
            for(int i = 0; i < 10; i++)
            {
                list.Add($"{i}번째 리스트 원소");
            }
            for(int i = 0;i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            string[] str = new string[10];
            list.CopyTo(str);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine(list.Contains(str[0]));
        }
    }
}