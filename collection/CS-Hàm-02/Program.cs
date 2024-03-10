using System.Text.RegularExpressions;

void ChuanHoaChuoi(List<string> str) {
    for(int i = 0; i < str.Count(); i++) {
        str[i].Trim();
        str[i] = Regex.Replace(str[i], @"\s+", " ");
        string[] hoTen = str[i].Split(" ");
    }
}
List<string> hoTen = new List<string> {"nguyen van A", "Tran van C "};
ChuanHoaChuoi(hoTen);
