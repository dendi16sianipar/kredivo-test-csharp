using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Masukkan nilai array (dipisahkan dengan spasi):");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Masukkan nilai target:");
        int target = int.Parse(Console.ReadLine());

        JatisSolution sol = new JatisSolution();
        int[] result = sol.solution(nums, target);

        Console.WriteLine("Output: [{0}, {1}]", result[0], result[1]);
    }
}

class JatisSolution {
    public int[] solution(int[] nums, int target) {
        for (int i=0; i<nums.Length; i++) {
            for (int j=i; j<nums.Length; j++) {
                int complement = target - nums[i];
                if (nums[j] == complement)
                    return new int[] {i, j};
            }
        }
        throw new ArgumentException("No Data");
    }
}
