using System.Text.RegularExpressions;

List<string> ChuanHoaChuoi(List<string> str) {
    List<string> result = new List<string>();

    for(int i = 0; i < str.Count(); i++) {
        str[i] = str[i].Trim();
        str[i] = Regex.Replace(str[i], @"\s+", " ");
        string[] hoTen = str[i].Split(" ");
        string ht = "";
        for(int j = 0; j <= hoTen.Length - 1; j++) {
            hoTen[j] = hoTen[j].Substring(0, 1).ToUpper() + hoTen[j].Substring(1).ToLower();
            ht = ht + hoTen[j] + " ";
        }
        result.Add(ht.Trim());
    }

    return result;

}

List<string> hoTen = new List<string> {"          nguyen            van A", "Tran van C "};

List<string> ht = new List<string>();
ht = ChuanHoaChuoi(hoTen);
foreach(string h in ht) {
    Console.WriteLine(h);
}
