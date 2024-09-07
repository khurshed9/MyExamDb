

using exam.n1.Service;

QueryService queryService = new QueryService();
var query =  queryService.Query1();
foreach (var item in query)
{
    Console.WriteLine(item.UserId + " " + item.FirstName + " " + item.LastName);
}