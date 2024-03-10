List<string> ds = new List<string> { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanh" };

List<string> SearchDS(int n) {
    List<string> result = new List<string> {};

    result = ds.FindAll(x => x.Length > n);

    return result;
}

List<string> dsSearch = new List<string> {};

dsSearch = SearchDS(16);
foreach(string d in dsSearch) {
    Console.WriteLine(d);
}
