# kredivo-test-csharp

Code program
``` c
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
```

Penjelasan

- looping pertama, nilai i mulai dari 0 dan nilai j dimulai dari 0 hingga 3.
- looping kedua, nilai i tetap 0, namun nilai j dimulai dari 1 hingga 3.
- looping ketiga, nilai i tetap 0, dan nilai j tetap 2 (karena looping sebelumnya telah mencapai indeks ke-2 pada array nums).
- looping ketiga ini, isi dari nilai complement dihitung sebagai 10 - 4 = 6, dan kemudian dicek apakah nilai nums[j] (yaitu nums[2] yang bernilai 6) sama dengan nilai complement tersebut. Karena sama, maka i dan j yang memenuhi kondisi tersebut adalah 0 dan 2 sehingga hasilnya adalah [0, 2].
