/************************************************
*
* FileName:	Program.cs
* Description:  Csharp Grammar from Version 1.0 to Version 13
*
* Version:
* Author: 	Administrator
* CreateTime:	2024/12/26 14:13
************************************************/

#region Csharp1.0
public class class2
{

    public class MyClass { }

    #region class 类
    //引用对象但不创建实例。堆内存上不分配地址
    MyClass myClass;
    //使用new运算符显示创建实例托管堆上分配地址
    static MyClass _myClass = new MyClass();
    //my 与 _myClass指向同一个地址，所以后续更改都会跟随改变。
    MyClass my = _myClass;

    //引用类型默认null,值类型默认0

    //可以使用初始化器要求调用方提供初始值
    private int _capacity;
    public class2(int capacity) => capacity = _capacity;

    //对属性使用  required 修饰符  允许调用者 使用初始值设定项来设置属性的初始值    
    public class Person
    {
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
    }
    Person P1 = new Person() { FirstName = "123", LastName = "321" };


    //类完全支持继承 这为面向对象的基本特点，sealed修饰除外
    //继承并替代类虚方法，可以实现多个接口。除构造函数外
    //通过派生来完成
    public class Person2 : Person
    { }
    Person2 person2 = new Person2() { FirstName = "123", LastName = "321" };

    // abstract 抽象类包含抽象方法，抽象方法包含签名定义但不包含实现。抽象类不能实例化，
    public abstract class Person3
    {
        public int Getint()
        {
            return 10;
        }
        public abstract void GetString();
    }
    //抽象方法由派生类实现
    public class Person4 : Person3
    {
        public override void GetString()
        {
            throw new NotImplementedException();
        }

    }
    #endregion

    #region 结构体

    // struct 为值类型 结构体的变量包含类型的实例
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x; Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString() => $"{X} {Y}";

    }

    //readonly 来修饰表示结构类型不可变，所有数据成员都是只读（构造函数除外）
    public readonly struct Coords2
    {
        public Coords2(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; init; }
        public double Y { get; init; }

        public override string ToString() => $"({X}, {Y})";
    }


    //readonly 实例成员 可以修饰方法 属性 字段/静态字段 索引器 

    //struct 的变量直接包含struct的数据
    //结构体不能继承，但能继承接口

    #endregion

    #region 接口-定义多种类型的行

    #endregion


}

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