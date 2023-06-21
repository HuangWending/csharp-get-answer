using System;

class Program
{
    static string GetAnswer(string question)
    {
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
