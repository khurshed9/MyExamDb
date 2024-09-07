using Dapper;
using exam.n1.Mapping;
using Npgsql;

namespace exam.n1.Service;

public class QueryService
{
    public IEnumerable<Query1> Query1()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query1>(QueryCommmands.Query1);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query2> Query2()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query2>(QueryCommmands.Query2);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query3> Query3()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query3>(QueryCommmands.Query3);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }   
    }

    public IEnumerable<Query4> Query4()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query4>(QueryCommmands.Query4);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query5> Query5()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query5>(QueryCommmands.Query5);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query6> Query6()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query6>(QueryCommmands.Query6);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query7> Query7()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query7>(QueryCommmands.Query7);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query8> Query8()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query8>(QueryCommmands.Query8);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query9> Query9()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query9>(QueryCommmands.Query9);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query10> Query10()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query10>(QueryCommmands.Query10);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query11> Query11()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query11>(QueryCommmands.Query11);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query12> Query12()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query12>(QueryCommmands.Query12);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query16> Query16()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query16>(QueryCommmands.Query16);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public IEnumerable<Query14> Query14()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                connection.Open();
                return connection.Query<Query14>(QueryCommmands.Query14);
            }
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}

file class QueryCommmands
{
    public const string Query1 = @"select u.userid, u.firstname, u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth, o.orderid, o.userid, o.orderdate, Sum(o.totalamount) , o.status from users u
                                   join orders o on u.userid = o.userid
                                   group by u.userid, u.firstname, u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth, o.orderid, o.userid, o.orderdate
                                    order by u.userid";

    public const string Query2 =
        @"select p.productid, p.productname, p.description, p.price, p.stockquantity, p.category, p.createdat, r.reviewid, r.productid, r.rating, r.comment, r.createdat from products p
          join reviews r on p.productid = r.productid
          order by r.createdat";

    public const string Query3 = @"select status, Count(*) as amount from supporttickets
                                   group by status";

    public const string Query4 = @"select u.userid, u.firstname, u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth, o.orderid, Count(o.userid) from users u
                                  join orders o on u.userid = o.userid
                                   group by u.userid, u.firstname, u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth, o.orderid
                                   having Count(o.userid) > 5";
    
    public const string Query5 = @"select o.orderid,p.productname,  Sum(o.totalamount) from orders o
                                   join orderitems oi on o.orderid = oi.orderid
                                      join products p on p.productid = oi.productid
                                         group by o.orderid,p.productname
                                             order by o.orderid";

    public const string Query6 = @"select r.reviewid, p.productname, r.userid, r.rating, r.comment, r.createdat from reviews r
                                   join products p on p.productid = r.productid";

    public const string Query7 = @"select o.orderid, o.orderdate from orders o
                                   where (Extract(Month from current_date) - Extract(Month from o.orderdate)) = 0 ";

    public const string Query8 = @"select p.productid, p.category, AVG(p.price) from products p
                                    group by p.productid, p.category
                                    order by p.productid";

    public const string Query9 =
        @"select u.userid, u.firstname, u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth , r.rating from users u
        join reviews r on u.userid = r.userid
        where r.rating > 4
       order by u.userid";

    public const string Query10 =
        @"select u.userid, u.firstname,u.lastname, u.email, u.phonenumber, u.address, u.dateofbirth, s.status from users u
                                   join supporttickets s on u.userid = s.userid
                                   where status = 'Closed'";

    public const string Query11 =
        @"select p.productid, p.productname, p.description, p.price, p.stockquantity, p.category, p.createdat, Count(r.productid) as amount from products p
          join reviews r on p.productid = r.productid
           group by p.productid, p.productname, p.description, p.price, p.stockquantity, p.category, p.createdat
          order by Count(r.productid) desc
           limit 5";

    public const string Query12 = @"select u.userid, u.firstname, u.lastname, Sum(o.totalamount) from users u
                                    join orders o on u.userid = o.userid
                                    group by u.userid, u.firstname, u.lastname
                                    order by u.userid";

    public const string Query14 =
        @"select s.ticketid, s.userid, s.issuetype, s.description, s.status, s.createdat,s.resolvedat from supporttickets s
         where s.status  IN('Open','In Progress') ";

    public const string Query16 = @"select p.productid, p.productname, p.description, p.price, p.category, p.createdat, Sum(p.stockquantity) from products p
                                     group by p.productid, p.productname, p.description, p.price, p.category, p.createdat
                                        Having Sum(p.stockquantity) > 100";
}