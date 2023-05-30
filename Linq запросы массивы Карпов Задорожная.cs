using System;
using System.Linq;
class SimpQuery {
    static void Main() {
        int[] nums = { 1, -2, 3, 0, -4, 5 };
        var posNums = from n in nums
            where n > 0
            select n;
        var noZeroNums = from n in nums
            where n != 0
            select n;
        var evenNums = from n in nums
            where n % 2==0
            select n;
        int sum = 0,mult = 1,count = 0;
        foreach (int i in posNums) sum += i;
        foreach (int i in noZeroNums) mult *= i;
        foreach (int i in evenNums) count+= 1;
        Console.WriteLine(sum);
        Console.WriteLine(mult);
        Console.WriteLine(count);

        sum = 0;
        mult = 1;
        count = 0;

        nums=(from num in nums
            where num % 2 == 0
            select num).ToArray();
        
        var posNums1 = from n in nums
            where n > 0
            select n;
        var noZeroNums1 = from n in nums
            where n != 0
            select n;
        var evenNums1 = from n in nums
            where n % 2==0
            select n;
        
        foreach (int i in posNums1) sum += i;
        foreach (int i in noZeroNums1) mult *= i;
        foreach (int i in evenNums1) count+= 1;
        Console.WriteLine(sum);
        Console.WriteLine(mult);
        Console.WriteLine(count);

    }
}