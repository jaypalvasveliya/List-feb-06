// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> carname = new List<string>();

carname.Add("enova");
carname.Add("creta");
carname.Add("kai");
carname.Add("vartus");
carname.Add("mahesh");





//addrange methed
foreach (string car in carname)
{
    Console.WriteLine(car);
}
Console.WriteLine("--------------------");


foreach (string car in carname)
{
    Console.WriteLine(car);
}
















//addrange methed
foreach (string car in carname)
{
    Console.WriteLine(car);
}
Console.WriteLine("--------------------");
carname.AddRange(carname);

foreach (string car in carname)
{
    Console.WriteLine(car);
}



Console.WriteLine("***************");


carname.Sort();
foreach (string car in carname)
{
    Console.WriteLine(car);
}

foreach (string car in carname)
{
    Console.WriteLine(car);
}





Console.WriteLine("*****count*****");
Console.WriteLine(carname.Count);




Console.WriteLine("***capacity***");
Console.WriteLine(carname.Capacity);

//Console.WriteLine(carname.);
Console.ReadLine();



//insert 
List<int> numbar = new List<int>();


numbar.Add(13);
numbar.Add(14);
numbar.Add(15);
numbar.Add(16);
numbar.Add(17);


foreach (int numbar12 in numbar)
{
    Console.WriteLine(numbar12);
}
Console.WriteLine("*****************");
//numbar.Insert(2,24);
//numbar.InsertRange(3,numbar);
//numbar.RemoveAt(3); 
//numbar.RemoveRange(1,1);
//Console.WriteLine(numbar.Contains(15));
//Exists with lemda expresands
//numbar.Reverse();   
//Console.WriteLine(numbar.IndexOf(15,1));
//Console.WriteLine(numbar.LastIndexOf(17));
//numbar.Clear();    



foreach (int numbar2 in numbar)
{
    Console.WriteLine(numbar2);
}



Console.WriteLine(numbar);
Console.ReadLine();















