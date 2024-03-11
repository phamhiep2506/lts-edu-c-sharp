using System.Collections;

List<int[]> ds = new List<int[]>();

int[] arr0 = { 1, 2, 3, 4};
int[] arr1 = { 5, 6, 7, 8};
int[] arr2 = { 9, 10, 11, 12};

ds.Add(arr0);
ds.Add(arr1);
ds.Add(arr2);

List<double> giaTriTrungBinh = new List<double>();

for (int i = 0; i < ds.Count; i++)
{
    int tong = 0;

    for (int j = 0; j < ds[i].Length; j++)
    {
        tong += ds[i][j];
    }
    giaTriTrungBinh.Add((double)tong / ds[i].Length);
}

// print gia tri trung binh
foreach (int giaTri in giaTriTrungBinh)
{
    Console.WriteLine(giaTri);
}
