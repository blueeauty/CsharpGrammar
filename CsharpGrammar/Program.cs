/************************************************
*
* FileName:	Program.cs
* Description:  Csharp Grammar from Version 1.0 to Version 13
*
* Version:
* Author: 	Administrator
* CreateTime:	2024/12/26 14:13
************************************************/
class Program
{
    public static Person Person=new  Person() { Name = "Father", Id=11 };
    public static void ChangePerson(Person person)
    {
        person.Name = "sadafafd";
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Person.Name);
        ChangePerson(Person);
        Console.WriteLine(Person.Name);
    }

}

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