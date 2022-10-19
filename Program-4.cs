using System;
using System.Collections;

namespace InterfaceEg
{
    #region Interfaces - Multiple Inheritance
    //interface IBulkOperations
    //{
    //    void DeleteAll();
    //}

    //interface IOperations
    //{
    //    void GetAll();
    //    void GetById();
    //    void Create();
    //    void Update();
    //    void Delete();
    //}

    //class Employees : IOperations,IBulkOperations
    //{
    //    public void Create()
    //    {
    //        Console.WriteLine("Create Employee");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("Delete Employee");
    //    }

    //    public void DeleteAll()
    //    {
    //        Console.WriteLine("Delete All Operations");
    //    }

    //    public void GetAll()
    //    {
    //        //EF To Read Employees
    //        //Data Reader To Read Employees
    //        //Data Set Read Employees
    //        //XML File
    //        //Json data
    //        Console.WriteLine("Get All Employees");
    //    }

    //    public void GetById()
    //    {
    //        Console.WriteLine("Get Employee By Id");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Update Employee");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Bulk Operations
    //        IBulkOperations bulkOperations = new Employees();
    //        bulkOperations.DeleteAll();


    //        //Operatation
    //        IOperations operations;
    //        operations = new Employees();

    //        operations.GetAll();
    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region Partial Classes
    //partial class A
    //{
    //    public void Show()
    //    {
    //        Console.WriteLine("Show");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //A a = new A();

    //        //a.Show();
    //        //a.Display();

    //        Console.ReadLine();
    //    }
    //} 
    #endregion

    #region Collection Classes
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Stack S = new Stack(3);
    //        //S.Push(2);
    //        //S.Push(8);
    //        //S.Push(8);

    //        //while (S.Count != 0)
    //        //{
    //        //    Console.WriteLine(S.Pop().ToString());
    //        //}

    //        //int sum = 0;
    //        //while(S.Count!=0)
    //        //{
    //        //    sum = sum + int.Parse(S.Pop().ToString());
    //        //}
    //        //Console.WriteLine("Sum is " + sum);


    //        //Queue Q = new Queue();
    //        //Q.Enqueue("raju");
    //        //Q.Enqueue("naik");
    //        //Q.Enqueue("vadithya");

    //        //while (Q.Count != 0)
    //        //{
    //        //    Console.WriteLine(Q.Dequeue());
    //        //}           

    //        //string name=null;

    //        //while(Q.Count!=0)
    //        //{
    //        //    name = name + " " + Q.Dequeue();
    //        //}
    //        //Console.WriteLine(name);

    //        Console.ReadLine();
    //    }
    //} 
    #endregion
}
