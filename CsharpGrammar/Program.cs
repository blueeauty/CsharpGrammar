/************************************************
*
* FileName:	Program.cs
* Description:  Csharp Grammar from Version 1.0 to Version 13
*
* Version:
* Author: 	Administrator
* CreateTime:	2024/12/26 14:13
************************************************/
#define A
#undef B
#define Debug
//#define Retail
#if Debug && Retail
#error A Build can't be both debug and retail
#endif

class C
{
#if A
    void f() { }
#else
#endif
#if B
    void I() { }
#else
#endif
}

class Program
{
    @class Cla =new @class();
    static void Main(string[] args)
    {
        var aaa = 1_3_23_1;
        string str = @"666
            777
            888";
        Console.WriteLine(str);
        @class.@void(true);
        
    }

}

#region 词法和句法分析(Lexical grammar and Syntactic grammar)
class @class
{
    public static void @void(bool @bool)
    {
        char c = '\u0066';
        if (@bool)
        {
            System.Console.WriteLine(c.ToString());
        }
    }
}
#endregion


#region Csharp1.0
/// <summary>
/// C# 1.0 特性
/// </summary>
#region Classes
class Person {
    public required string Name { get; set; }
    public int Id { get; set; }
}

class Student : Person 
{
    Person Person=new Person() { Name="Father"};
    /// <summary>构造函数</summary>
    Student()
    {

    }
    /// <summary>
    /// 带参构造
    /// </summary>
    /// <param name="person">The person.</param>
    Student(Person person)=>Person=person;

}



#endregion

#endregion

#region Csharp1.2

#endregion

#region Csharp2.0

#endregion

#region Csharp3.0

#endregion

#region Csharp4.0

#endregion

#region Csharp5.0

#endregion

#region Csharp6.0

#endregion

#region Csharp7.0

#endregion

#region Csharp7.1

#endregion

#region Csharp7.2

#endregion

#region Csharp7.3

#endregion

#region Csharp8.0

#endregion

#region Csharp9

#endregion

#region Csharp10

#endregion

#region Csharp11

#endregion

#region Csharp12

#endregion

#region Csharp13

#endregion