﻿//using System;

//public class HaloGeneric
//{
//    public void SapaUser<T>(T user)
//    {
//        Console.WriteLine($"Halo user {user}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        HaloGeneric halo = new HaloGeneric();
//        halo.SapaUser("Wildan");
//    }
//}

using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");

    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> nimData = new DataGeneric<string>("103022300095");

        nimData.PrintData();
    }
}