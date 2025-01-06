
/************************************************
*
* FileName:	Program.cs
* Description:  Csharp Grammar from Version 1.0 to Version 13
*
* Version:
* Author: 	Administrator
* CreateTime:	2024/12/26 14:13
************************************************/
#pragma warning disable CS0168  //Disabling "variable declared but never used"
//#pragma warning disable //All warnings are suppressed here
//#pragma checksum "file.cs" "{GUID}" "hash"
#define A
#undef B
#define Debug
//#define Retail
#if Debug && Retail
#error A Build can't be both debug and retail
#endif
#line 133

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

//静态导入
using static System.Math;
using static System.Runtime.InteropServices.JavaScript.JSType;
//the next line will be treated as line 133
//int asdfg = 111;
class A 
{
    public static int X;
    internal static int Y;
    private static int Z;
    //Finalizer
    ~A()
    {
        //Cleanup code
        Console.WriteLine("Finalize instance of A");
    }
}

class B
{
    object Ref;
    public B(object o)
    {
        Ref = o;
    }
    ~B()
    {
        Console.WriteLine("Finalize instance of B");
    }
}

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

//namespace asd{

//}
class Program
{
    @class Cla = new @class();
    static void Main(string[] args)
    {
        var aaa = 0x1_2;
        int asd;
        int bbb=new int();
        int ccc=default(int);
#nullable disable
        string str = null;
        Console.WriteLine(str is null);
        @class.@void(true);
        B b = new B(new A());
        b = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
        //if (true)
        //{
        //    int sss = 0;
        //}
        //int sss = 1;
    }

    //static int Main()
    //{
    //    var aaa = 0x1_2;
    //    int asd;
    //    #nullable disable
    //    string str = null;
    //    Console.WriteLine(false);
    //    @class.@void(true);
    //    return 1;
    //}
}



//class Program;


public class class2

{

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
    //接口包含非抽象class和struct必须实现的功能定义，接口可以定义为静态方法
    //支持实例方法、属性、事件、索引器：静态构造函数、字段、常量或运算符
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    #endregion
    #region 属性
    //属性为字段的延伸，提高数据的安全性
    public string? _FirstName;
    public string? FirstName { get { return _FirstName; } set { _FirstName = value; } }

    //可以设置属性为只 读/写属性外还可以对get/set访问器设置不同的可访问性
    public string? FirstName2 { get; private set; }



    #endregion
    #region 委托  
    //。net中的后期绑定机制
    //例如虽然都是排序但是最终调用的方法不同

    //声明类型   实际声明的是类
    public delegate int Comparison<in T>(T letf, T rigth);
    //创建实例 变量
    //public Comparison<T> comparator;
    //调用
    //int result = comparator(letf, rigth);

    #endregion
    #region 事件
    //事件基于委托且是多播委托
    public class FileFoundArgs : EventArgs
    {
        public string FoundFile { get; }

        public FileFoundArgs(string fileName) => FoundFile = fileName;
    }

    public class FileSearcher
    {
        public event EventHandler<FileFoundArgs>? FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                RaiseFileFound(file);
            }

        }
        private void RaiseFileFound(string file) =>
      FileFound?.Invoke(this, new FileFoundArgs(file));
    }
    #endregion

    #region 特性
    static int i = 42;
    Type type = i.GetType();
    //输出 .System.Int32

    Assembly info = typeof(int).Assembly;
    //输出 .System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e；
    #endregion
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

class Derived : @class
{
    public static new void @void(bool @bool)
    {

    }
}
#endregion



#region Csharp1.0  (Visual Studio 2002, .Net Framework 1.0)
/// <summary>
/// C# 1.0 特性
/// </summary>
#region Classes
class Person
{
    public required string Name { get; set; }
    public int Id { get; set; }
}

class Student : Person
{
    Person Person = new Person() { Name = "Father" };
    /// <summary>构造函数</summary>
    Student()
    {

    }
    /// <summary>
    /// 带参构造
    /// </summary>
    /// <param name="person">The person.</param>
    Student(Person person) => Person = person;

}



#endregion

#endregion



#region Csharp2.0 (Visual Studio 2005, .Net Framework 2.0)
public class Csharp2
{
    #region 泛型
    private List<int> list = new List<int>();
    #endregion

    #region partial 分布类型 可定义类，结构或者接口的其他部分，各个部分必须具有相同的访问类型
    public partial class Employee
    {
        public string Name { get; set; }
    }
    #endregion

    #region 匿名方法
    Func<int, int, int> sum = delegate (int a, int b) { return a + b; };

    Func<int, int, int> sum2 = (a, b) => a + b;
    //使用delegate可以省略参数类型，如果这样做，可将匿名方法转化为具有任何参数的委托类型
    Action greet = delegate { Console.WriteLine("Hello, World!"); };
    Action<int, double> gteet2 = delegate { Console.WriteLine("Hello, World!"); };

    //lambda唯一不支持的匿名方法的唯一功能，弃元 参数
    Func<int, int, int> sum3 = delegate (int _, int _) { return 42; };

    //还可以使用static静态匿名方法不可以从封闭范围捕获局部变量
    Func<int, int, int> sum4 = static delegate (int a, int b) { return a + b; };

    /// <summary>
    /// 从方法组转化
    /// </summary>
    static void StaticFunction() { }
    Action a = () => StaticFunction();
    #endregion

    #region 可以为Null的值类型 System.Nullable<T>
    int? ttt = null;


    private void Test()
    {
        //is检查 既检查null又检查值
        if (ttt is int valuettt) { Console.WriteLine(valuettt); };

        if (ttt.HasValue) { Console.WriteLine(ttt.Value); };

        //从可空转化为值类型
        int? abc = 42;
        int cba = abc ?? -1;
    }


    #endregion

    #region 迭代器foreach等

    #endregion

    #region 属性访问和设置权限分享，即可以分别设置getter 和 setter 的可访问性
    public int MyProperty { get; private set; }
    #endregion

    #region 协变和逆变 支持委托、接口
    //参数列表或返回值的数据类型可以是相应数据类型的派生类，即 is a 关系。
    public class Person { };
    public class Student : Person { };

    //协变
    static public Person NewPerson()
    {
        return new Person();
    }

    static public Student NewStudent()
    {
        return new Student();
    }

    delegate Person Create();

    Create create = NewPerson;
    //协变
    Create create2 = NewStudent;


    // 逆变
    public void ProcessPerson(Person p) { }
    public void ProcessStudent(Student s) { }

    public delegate void Process(Person p);

    public void tes()
    {
        Process process = ProcessPerson;
        // 逆变 但是不支持非泛型参数
        // Process process2 = ProcessStudent;
    }



    #endregion

}
#endregion

#region Csharp3.0 (Visual Studio 2008, .Net Framework 3.0)
public class Csharp3
{
    #region 自动属性
    public int MyCsharp3 { get; set; }
    #endregion
    public void Test()
    {
        #region 匿名类型 var

        var v = new { Amount = 108, Message = "Hello" };
        #endregion

        #region 对象和集合初始化器

        Person tom = new Person() { Id = 0, Name = "Tom" };
        List<string> names = new List<string> { "Tom", "Jack", "Lucy" };
        #endregion

        #region 扩展方法（不是派生）
        string originalString = "hello";
        string modifiedString = originalString.ToUpperWithSuffix("!");
        #endregion

        #region Lambda 表达式  （参数1，参数2）=>{表达式主体}

        #endregion  

        #region 表达式树 【无】

        #endregion
    }

    #region 分布方法 Partial
    partial class MyPartialClass
    {
        // Declaring definition
        partial void OnSomethingHappened(string s);
    }

    // This part can be in a separate file.
    partial class MyPartialClass
    {
        // Comment out this method and the program
        // will still compile.
        partial void OnSomethingHappened(string s) =>
            Console.WriteLine($"Something happened: {s}");
    }

    #endregion
}


public static class StringExtensions
{
    // 定义一个扩展方法，用于将字符串转换为大写并添加一个后缀
    public static string ToUpperWithSuffix(this string str, string suffix)
    {
        if (str == null) throw new ArgumentNullException(nameof(str));
        return str.ToUpper() + suffix;
    }
}


#endregion

#region Csharp4.0 (Visual Studio 2010, .Net Framework 4)

public class cs4
{
    #region Dynamic运行时才会进行判断，var根据上下文推断数据类型
    static object GetPerson()
    {
        return new Person { Name = "Leo" };
    }
    private void dy()
    {
        object objPerson = GetPerson();
        var objName = objPerson.GetType().GetProperty("Name").GetValue(objPerson);
        Console.WriteLine(objName);

        dynamic dynPerson = GetPerson();
        var dynName = dynPerson.Name;
        Console.WriteLine(dynName);
    }


    #endregion

    #region 可选参数
    public int addnum(int y, int x = 1)
    {
        return x + y;
    }
    #endregion

    #region 泛型中的协变和逆变（原理同C#2.0委托、接口的协变和逆变）

    #endregion

    #region 嵌入互操作类型(引用某个dll，如果它的属性嵌入式互操作类型为true的话，那么该程序集中的很多东西你都用不了。)

    #endregion
}
#endregion

#region Csharp5.0 (Visual Studio 2012, .Net Framework 4.5)
public class cs5
{
    #region 异步编程 
    #region 使用委托实现
    //先使用委托来实现异步编程
    delegate void AsyncFoo(string i);

    public void main()
    {
        string i = "参数";
        Console.WriteLine("调用异步方法前");
        PostAsync(i);
        Console.WriteLine("调用异步方法后");
    }
    private static void PostAsync(object i)
    {
        AsyncFoo caller = Myfunc;
        //BeginInvoke调用时立刻返回，不阻塞线程,实际调用的方法在另一个线程异步执行    
        //返回IAsyncResult 可以用于查询异步调用的状态

        //caller对象被作为AsyncState传递给BeginInvoke方法，并在回调方法FooCallBack中通过ar.AsyncState访问到。
        caller.BeginInvoke(i.ToString(), FooCallBack, caller);
    }

    private static void Myfunc(string i)
    {
        Console.WriteLine("通过委托来实现异步编程的");

    }

    //回调
    private static void FooCallBack(IAsyncResult ar)
    {
        var caller = (AsyncFoo)ar.AsyncState;
        //结束释放资源
        caller.EndInvoke(ar);


    }
    #endregion

    #region 使用Task实现
    public void maa()
    {
        Console.WriteLine("主线程，线程ID：" + Thread.CurrentThread.ManagedThreadId);
        //Task方式一
        Task task1 = new Task(() => TaskFunc1());
        task1.Start();

        //Task方式二
        var result = Task.Run<string>(() => { return TaskFunc2(); });
        Console.WriteLine(result.Result);
    }
    private static void TaskFunc1()
    {
        Console.WriteLine("Task方式一开启的线程ID：" + Thread.CurrentThread.ManagedThreadId);
    }

    private static string TaskFunc2()
    {
        return "Task方式二开启的线程ID：" + Thread.CurrentThread.ManagedThreadId;
    }


    #endregion

    #region 使用await async
    public void mmaind()
    {
        Console.WriteLine("主线程，线程ID：" + Thread.CurrentThread.ManagedThreadId);
        var result1 = AsyncFunc1();
        Console.WriteLine(result1.Result);


    }
    private static async Task<string> AsyncFunc1()
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("await/async线程ID: {0}", Thread.CurrentThread.ManagedThreadId);
            return "这是返回值";
        });

    }
    #endregion
    #endregion

    #region 调用方信息特性 
    public void DoProcessing()
    {
        TraceMessage("Something happened.");
    }

    public void TraceMessage(string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
    {
        Trace.WriteLine("message: " + message);
        Trace.WriteLine("member name: " + memberName);
        Trace.WriteLine("source file path: " + sourceFilePath);
        Trace.WriteLine("source line number: " + sourceLineNumber);
    }
    #endregion

}

#endregion

#region Csharp6.0 (Visual Studio 2015, .Net Framework 4.6)
public class Cs6
{
    #region 静态导入 直接使用方法；
    double d1 = Pow(1, 2);
    #endregion

    #region 异常筛选器  Catch/Finally 块中的 Await
    //当level=10的时候才进行异常处理
    public async void cs6Main()
    {
        int level = 0;

        try
        {
            d1 = 0.1;
        }
        catch (Exception ex) when (level == 10)
        {

            ex.Message.ToString();

            try
            {
                await LogErrorAsync(ex);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    static async Task LogErrorAsync(Exception ex)
    {
        // Simulate logging the error
        await Task.Delay(500);
        Console.WriteLine($"Logged error: {ex.Message}");
    }
    #endregion

    #region 自动属性的初始化
    public string Name { get; set; } = "no name";
    #endregion

    #region Expression bodied 成员。表达式主体成员
    //原 public override string ToString() { return $"{Name}".Trim(); }
    //优化后
    public override string ToString() => $"{Name}".Trim();
    //Cs6 cs6 = new Cs6();
    //cs6.ToString();
    #endregion

    #region Null条件操作符  
    //x ? y ；x为空不执行，不为空执行右边   x ?? y 为空执行左边，不为右边
    #endregion

    #region 字符拼接
    public void _str()
    {
        string str = "123";
        str = $"0{str}4";

    }
    #endregion

    #region nameof 用于返回方法、属性、变量的名称
    string name = nameof(System.String.Format);
    #endregion

    #region 字典初始化
    Dictionary<int, string> moreNumbers = new Dictionary<int, string>
{
{19, "nineteen" },
{23, "twenty-three" },
{42, "forty-two" }
};
    #endregion
}
#endregion

#region Csharp7.0 (Visual Studio 2017, .Net Framework 4.7)
public class CS70
{
    #region 可以在out后面直接声明变量
    static string str = "1";
    bool b = int.TryParse(str, out int t1);
    #endregion

    #region 数据类型转换的语法糖
    public void cs7m()
    {
        object obj = "3";
        int sum = 0;
        //之前
        if (obj is int) sum += (int)obj;
        //现在
        if (obj is int val) sum += val;


    }
    #endregion

    #region Tuples 元祖改进
    (int one, int two) tuple = (1, 2);
    public void tup()
    {
        var tuple2 = (one: 1, two: 2);


    }
    #endregion

    //可以从一个类的构造函数中提取相应的数据，比如：var (Name, Age) = new Person(Name, Age);

    //本地函数。在函数中定义子函数，子函数体放在 return 后面。这个相关于C++中的inline，用于提高效率，一般非性能场合不推荐使用，因为它不仅影响了程序的阅读性，而且也不利于代码管理。

    //二进制0b
    static int b1 = 0b000_0001;

    #region ref 局部变量 引用传递,修改引用的值会影响原值，但是不能引用null

    public void main()
    {
        ref int num = ref GetDataRef(new int[] { 1, 2, 3 }, 0);

    }
    ref int GetDataRef(int[] data, int index)
    {
        return ref data[index];

    }

    #endregion

    //泛型支持async

    //public string Name{ get => name; set => name = value ?? "noname";}
}
#endregion

#region Csharp7.1

public class Cs71<T>
{
    //应用程序的入口点可以含有 async 修饰符  asyncMain

    //default  数据类型的推断默认值
    int i = default;
    string s = default;

    //推断元组元素名称
    // var person = (name: "Alice", age: 30);

    //泛型类型参数的模式匹配
    public void PrintTypeWithSwitch(T item)
    {
        switch (item)
        {
            case string str:
                Console.WriteLine($"It's a string: {str}");
                break;
            case int num:
                Console.WriteLine($"It's an int: {num}");
                break;
            default:
                Console.WriteLine($"It's something else.");
                break;
        }
    }
}



#endregion

#region Csharp7.2
//private protected 访问修饰符允许访问同一程序集中的派生类
#endregion

#region Csharp7.3

#endregion

#region Csharp8.0 (Visual Studio 2019 .Net Framework 4.8)
#region Readonly 成员  readonly修饰的函数无法修改类内的成员
public struct Vector2
{
    public float x, y;
    public readonly float GetLengthIllegal()
    {
        var tmp = MathF.Sqrt(12);
        //x = tmp;    // Compiler error, cannot write x
        // y = tmp;    // Compiler error, cannot write y 
        return tmp;
    }
}

#endregion

#region 默认接口成员
public interface IMyInterface
{
    void MyMethod()
    {
        Console.WriteLine("123");
    }
}
#endregion

#region 模式匹配【无】
public class cs8
{
    #region Switch表达式
    public void main()
    {
        Console.WriteLine(Classify(13));  // output: Too high
        Console.WriteLine(Classify(double.NaN));  // output: Unknown
        Console.WriteLine(Classify(2.4));  // output: Acceptable

        static string Classify(double measurement) => measurement switch
        {
            < -4.0 => "Too low",
            > 10.0 => "Too high",
            double.NaN => "Unknown",
            _ => "Acceptable",
        };


    }
    #endregion




}
#endregion

#region Using声明 对实现IDisposable接口的自动释放
public class usin
{

    //static void Main()
    //{
    //    using (StreamReader reader = new StreamReader("example.txt"))
    //    {

    //        string content = reader.ReadToEnd();
    //        Console.WriteLine(content);
    //    } // 在这里，reader.Dispose() 会被自动调用
    //}
}
#endregion

#region 本地函数 只能是包含他的外部方法访问，不能访问外部方法的实例成员

public class cs82
{
    public void adc()
    {
        static void bac()
        {


        }


    }

}

#endregion

#region 可处置的 ref 结构 可以在方法中使用 ref 结构 直接传递引用指向地址
struct MyStruct
{
    public int Value;
}
class Program2
{
    static void ModifyStruct(ref MyStruct myStruct)
    {
        myStruct.Value = 100;
    }

    //static void Main()
    //{
    //    MyStruct myStruct = new MyStruct();
    //    myStruct.Value = 50;

    //    Console.WriteLine("Before: " + myStruct.Value); // 输出: Before: 50

    //    ModifyStruct(ref myStruct);

    //    Console.WriteLine("After: " + myStruct.Value); // 输出: After: 100
    //}
}
#endregion

#region 可控引用类型  后加？这样不加的都不是null了

#endregion

#region 异步流  基于IAsyncEnumerable<T> 消费异步流使用await foreach

//生产，例如读取传感器数据
public class AsyncStreamExample
{
    public static async IAsyncEnumerable<int> RangeAsync(int start, int count, int delay)
    {
        for (int i = start; i < start + count; i++)
        {
            await Task.Delay(delay); // 模拟异步操作，如I/O等待
            // 产生下一个元素,逐步返回
            yield return i;
        }
    }

    //static async Task Main()
    //{
    //    await foreach (var number in AsyncStreamExample.RangeAsync(0, 10, 500))
    //    {
    //        Console.WriteLine(number);
    //    }
    //}
}



#endregion

#region 范围运算符.. 索引和范围
//int[] numbers = [0, 10, 20, 30, 40, 50];
//int start = 1;
//int amountToTake = 3;
//int[] subset = numbers[start..(start + amountToTake)];
//Display(subset);  // output: 10 20 30

//  ^代表倒数
//int margin = 1;
//int[] inner = numbers[margin..^margin];
//Display(inner);  // output: 10 20 30 40
#endregion

#region Null 合并赋值 ??= 左侧为null时将右边值给左边

#endregion

#region 非托管构造类型，为了指定使用哪个where进行约束
public class AGenericClass<T> where T : IComparable<T> { }
public struct Coords<T> where T : unmanaged { }
#endregion

#region 嵌套表达式中的 Stackalloc ; 表达式在堆栈上分配内存块.方法结束自动释放

#endregion

#region 内插逐字字符串的增强功能  $@或@$

#endregion
#endregion

#region Csharp9 (Visual Studio 2019, .Net 5.0)
public class Cs9
{
    #region 记录 record引用和 值 record struct ；不可变，只读,需要可变属性使用init，可在初始化时设置。可重写ToString、Equals、GetHashCode
    public record Person(string FirstName, string LastName, int Age);
    public string FirstName { get; init; }
    //public static void Main()
    //{
    //    Person person1 = new Person("John", "Doe", 30);
    //    Person person2 = new Person("John", "Doe", 30);

    //    Console.WriteLine(person1 == person2); // 输出: True
    //    Console.WriteLine(person1.GetHashCode() == person2.GetHashCode()); // 输出: True
    //    Console.WriteLine(person1); // 输出: Person { FirstName = John, LastName = Doe, Age = 30 }
    //}


    #endregion

    #region 关键字init 可初始化属性；相比get set必须调用构造函数来初始化，private set可在构造后修改但只能在类中；
    class Person_InitExampleAutoProperty
    {
        public int YearOfBirth { get; init; }
    }
    #endregion

    #region 顶级语句 没有main，Program 方法的程序
    //编译器将使用入口点方法为应用程序生成 Program 类
    //一个项目只能有一个顶级文件，但可以有任意数量的其他源代码文件
    //顶级语句隐式位于全局命名空间中
    //使用using必须先出现；
    //顶级语句的文件还可以包含命名空间和类型定义，但它们必须位于顶级语句之后
    //引用 args 变量来访问输入的任何命令行参数
    //异步使用await
    //退出使用return
    #endregion
}

#endregion



#region Csharp10

#endregion

#region Csharp11

#endregion

#region Csharp12

#endregion

#region Csharp13

#endregion