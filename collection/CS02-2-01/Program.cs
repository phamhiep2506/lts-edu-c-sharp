List<int> listNumber = new List<int>() {1,2,3,4,5,-1,-2,-5,7,8,9};

for(int i = 0; i < listNumber.Count(); i++) {
    if(listNumber[i] < 0) {
        listNumber[i] = 0;
    }
}

foreach(int n in listNumber) {
    Console.WriteLine(n);
}
