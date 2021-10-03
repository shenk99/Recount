using System;
using System.Collections.Generic;

public class voter
{
    public string name = "";
    public int numvotes;

    public static bool operator ==(voter ImpliedObject, string f)
    {
        return ImpliedObject.name == f;
    }
    public static bool operator <(voter ImpliedObject, voter f)
    {
        return (ImpliedObject.numvotes < f.numvotes);
    }
    public static bool operator >(voter ImpliedObject, voter f)
    {
        return (ImpliedObject.numvotes > f.numvotes);
    }

}

public static class GlobalMembers
{
    public static bool myfunction(voter i, voter j)
    {
        return (i < j);
    }

    internal static void Main()
    {
        List<voter> voters = new List<voter>();
        string name;

        while (name = Console.ReadLine())
        {
            if (name == "***")
            {
                break;
            }
            _Vector_iterator<_Vector_val<_Simple_types<voter>>> it = find(voters.GetEnumerator(), voters.end(), name);
            if (it != voters.end())
            {
                it.numvotes += 1;
            }
            else
            {
                voter a = new voter();
                a.name = name;
                a.numvotes = 1;
                voters.Add(a);
            }
        }
        voters.Sort((a, b) => -1 * a.CompareTo(b));

        if (voters[0].numvotes == voters[1].numvotes)
        {
            Console.Write("Runoff!");
            Console.Write("\n");
        }
        else
        {
            _Vector_iterator<_Vector_val<_Simple_types<voter>>> tt = max_element(voters.GetEnumerator(), voters.end());
            Console.Write(tt.name);
            Console.Write("\n");
        }
    }
}
