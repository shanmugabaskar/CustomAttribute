// See https://aka.ms/new-console-template for more information
using CustomAttribute;
using System.Reflection;

Rectangle r = new Rectangle(4.5, 7.5);
r.Display();
Type type = typeof(Rectangle);

//iterating through the attributes of the Rectangle class
foreach (Object attributes in type.GetCustomAttributes(false))
{
    DeBugInfo dbi = (DeBugInfo)attributes;

    if (null != dbi)
    {
        Console.WriteLine("Bug no: {0}", dbi.BugNo);
        Console.WriteLine("Developer: {0}", dbi.Developer);
        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
        Console.WriteLine("Remarks: {0}", dbi.Message);
    }
}

//iterating through the method attributes
foreach (MethodInfo m in type.GetMethods())
{

    foreach (Attribute a in m.GetCustomAttributes(true))
    {
        DeBugInfo dbi = (DeBugInfo)a;

        if (null != dbi)
        {
            Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
            Console.WriteLine("Developer: {0}", dbi.Developer);
            Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
            Console.WriteLine("Remarks: {0}", dbi.Message);
        }
    }
}
Console.ReadLine();
      
