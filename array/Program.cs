using System;

namespace array {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            int[] ages = {45, 41, 25, 23, 20, 19, 18};

            int sum = 0;
            for(int i = 0; i < ages.Length; i++ ) {
                sum = sum + ages[i];
            }
            sum = 0;
            foreach(int age in ages) {
                sum = sum + age;
            }
            Console.WriteLine($"sum is {sum}");

        }
    }
}
