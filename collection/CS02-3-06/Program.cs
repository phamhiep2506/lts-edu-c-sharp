int RandomInt() {
    Random rnd = new Random();
    return rnd.Next(1, 100);
}

Console.WriteLine(RandomInt());
