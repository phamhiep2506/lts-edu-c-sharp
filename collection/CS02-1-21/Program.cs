using System.Text.RegularExpressions;

string hoTen = "   NgUyen VaN   An    ";

hoTen = hoTen.Trim();

hoTen = Regex.Replace(hoTen, @"\s+", " ");

string[] hoTenSplit = hoTen.Split(" ");

Console.WriteLine($"{hoTenSplit[2]}{hoTenSplit[0].ToCharArray()[0]}{hoTenSplit[1].ToCharArray()[0]}@hvitclan.vn");
