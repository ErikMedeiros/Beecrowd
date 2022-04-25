using System; 

class URI {

    static void Main(string[] args) { 

        double [,] table = new double [5, 1] { {4.00}, {4.50}, {5.00}, {2.00}, {1.50} };
        string [] nums = Console.ReadLine().Split(' ');
        int cod, uni;

        cod = int.Parse(nums[0]) - 1;
        uni = int.Parse(nums[1]);

        Console.WriteLine($"Total: R$ {table[cod, 0] * uni:0.00}");

    }

}