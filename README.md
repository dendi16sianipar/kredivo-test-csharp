# kredivo-test-csharp

Penjelasan:

looping pertama, nilai i mulai dari 0 dan nilai j dimulai dari 0 hingga 3.
looping kedua, nilai i tetap 0, namun nilai j dimulai dari 1 hingga 3.
looping ketiga, nilai i tetap 0, dan nilai j tetap 2 (karena looping sebelumnya telah mencapai indeks ke-2 pada array nums).
looping ketiga ini, isi dari nilai complement dihitung sebagai 10 - 4 = 6, dan kemudian dicek apakah nilai nums[j] (yaitu nums[2] yang bernilai 6) sama dengan nilai complement tersebut. Karena sama, maka i dan j yang memenuhi kondisi tersebut adalah 0 dan 2 sehingga hasilnya adalah [0, 2].
