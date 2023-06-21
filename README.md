# csharp-get-answer
C#问答程序
using System;
引入了System命名空间，该命名空间包含了许多基本的类和类型，Console: 提供与控制台窗口进行交互的方法和属性，例如读取输入、输出文本等。
String: 表示字符串的类，提供了处理和操作字符串的方法和属性。
DateTime: 表示日期和时间的类，用于处理日期和时间相关的操作，例如获取当前日期时间、格式化日期时间等。
Math: 提供了常用的数学运算方法，例如求绝对值、取最大值、最小值、幂运算、三角函数等。
Random: 用于生成伪随机数的类，可以用于模拟随机事件或生成随机数据。
Array: 提供了对数组进行操作的方法和属性，例如创建、排序、搜索等。
List<T>: 泛型集合类，用于存储和操作元素的动态列表。
Dictionary<TKey, TValue>: 泛型键值对集合类，用于存储和操作具有唯一键和对应值的元素。
File: 提供了对文件进行读写操作的静态方法，例如创建、删除、读取、写入文件等。
Directory: 提供了对文件夹进行操作的静态方法，例如创建、删除、移动文件夹等。
Path: 提供了有关文件和文件夹路径的操作，例如获取文件名、扩展名、合并路径等。
Convert: 提供了类型转换相关的静态方法，例如将字符串转换为数字、日期等。
class Program
{
定义了一个名为Program的类。
    static string GetAnswer(string question)
    {
定义了一个名为GetAnswer的静态方法，接受一个字符串参数question，并返回一个字符串作为回答。
        switch (question)
        {
            case "你好":
                return "你好";
            case "你的名字是什么":
                return "黄文定";
            case "你的生日是什么时候":
                return "2009年7月18日";
            case "你是中国人吗":
                return "我是中国人";
            case "台湾是中国的吗":
                return "台湾是中国的";
            case "你爱我吗":
                return "这是一个由我决定的选项，我需要认真，但是我还是爱着你";
            case "你喜欢去哪里":
                return "中国大陆和中国台湾";
            case "你有朋友吗":
                return "没有";
            case "你的心情怎么样":
                return "自卑，孤独";
            default:
                return "抱歉，我黄文定无法回答你的问题。";
        }
    }
使用switch语句根据question的值进行匹配，并返回相应的回答。如果无法匹配任何问题，返回默认的回答。
    static void Main()
    {
        while (true)
        {
            Console.Write("请输入你的问题（输入'退出'结束程序）: ");
            string userQuestion = Console.ReadLine();

            if (userQuestion == "退出")
            {
                break;
            }

            string response = GetAnswer(userQuestion);
            Console.WriteLine(response);
        }
    }
}
在Main方法中，使用一个无限循环来获取用户的输入问题，并调用GetAnswer方法获取回答。如果用户输入"退出"，则跳出循环，结束程序的执行。最后将回答输出到控制台。
