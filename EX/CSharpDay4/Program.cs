// See https://aka.ms/new-console-template for more information


using CSharpDay5.Day5;
//LINQandNumbers lq =  new LINQandNumbers();

//lq.Display();
//Console.WriteLine("Ascending");
//lq.ascendingOrder();
//Console.WriteLine("under500");
//lq.under500Desc();
//Console.WriteLine("Even Numbers");
//lq.evenNumber();
//Console.WriteLine("Min Max Average");
//lq.minmaxavg();

//LINQandStrings str = new LINQandStrings();
//str.displayList();
//Console.WriteLine("----Starts with b----");
//str.startwithb();
//Console.WriteLine("----Contain berry----");
//str.containberry();
//Console.WriteLine("----Starts with A-M----");
//str.startswithAM();
//Console.WriteLine("----Count of Starting with N-Z----");
//str.countstartswithNZ();
//Console.WriteLine("----Longest string----");
//str.longString();

Person ob = new Person();
ob.getPersons();
ob.displayAll();
Console.WriteLine("----Male under 25----");
ob.MaleUnder25();
Console.WriteLine("----Descending disctinct hometown----");
ob.distinctHometown();
Console.WriteLine("----Sort hometown and then by name----");
ob.sortHometown();
Console.WriteLine("----Average age of men and women----");
ob.avgAge();
Console.WriteLine("----Grouping hometown and its count----");
ob.groupHometown();