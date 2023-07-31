using System;
using System.Collections;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=5E6sMxzNMqQ&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=11
//ctrl+shift+space --- check details 

static class MainClass
{
    static void Main()
    {
        System.Collections.Generic.
        int[] ints = new int[] { 25, 34, 32 };
        ArrayList myPartyAges = new ArrayList();    // none generic
        myPartyAges.Add(25);
        myPartyAges.Add(34);
        myPartyAges.Add("Billy");
        myPartyAges.Add(32);
        myPartyAges.Add(99);
        List<int> myPartyAges2 = new List<int>();   //generic list
        myPartyAges2.Add(25);
        myPartyAges2.Add(34);
        myPartyAges2.Add("Billy");
        myPartyAges2.Add(32);
        myPartyAges2.Add(99);
        //foreach(int age in myPartyAges)
        //    Console.WriteLine(age);
    }
}