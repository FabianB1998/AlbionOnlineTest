// Decompiled with JetBrains decompiler
// Type: aab
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.ResourceDistribution;
using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class aab
{
  public static int a(GameTimeStamp A_0, string A_1)
  {
    return BitConverter.ToInt32(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(A_1 + (object) A_0.i().Date.Ticks)), 0);
  }

  public static ResourceNodeTypes b(string A_0)
  {
    try
    {
      return aim.a<ResourceNodeTypes>(A_0, true);
    }
    catch (Exception ex)
    {
      return ResourceNodeTypes.Invalid;
    }
  }

  public static void a(Dictionary<string, HashSet<aaf>> A_0, string A_1)
  {
    if (A_0 == null)
      return;
    StreamWriter text = File.CreateText(A_1);
    List<string> stringList = new List<string>((IEnumerable<string>) A_0.Keys);
    stringList.Sort();
    foreach (string index in stringList)
    {
      List<aaf> aafList = new List<aaf>((IEnumerable<aaf>) A_0[index]);
      aafList.Sort(new Comparison<aaf>(aab.a));
      foreach (aaf aaf in aafList)
        text.WriteLine("{0} , {1} , {2} , {3}", (object) index, (object) aaf.a, (object) aaf.b, (object) aaf.c);
    }
    text.Close();
  }

  public static void a(Dictionary<aae, HashSet<aaf>> A_0, string A_1)
  {
    if (A_0 == null)
      return;
    StreamWriter text = File.CreateText(A_1);
    List<aae> aaeList = new List<aae>((IEnumerable<aae>) A_0.Keys);
    aaeList.Sort(new Comparison<aae>(aab.a));
    foreach (aae index in aaeList)
    {
      List<aaf> aafList = new List<aaf>((IEnumerable<aaf>) A_0[index]);
      aafList.Sort(new Comparison<aaf>(aab.a));
      foreach (aaf aaf in aafList)
        text.WriteLine("{0} , {1} , {2} , {3}", (object) (index.b + "_" + (object) index.a), (object) aaf.a, (object) aaf.b, (object) aaf.c);
    }
    text.Close();
  }

  public static void a(g8 A_0, ka.ClusterNameInformation A_1, it.PvpRules A_2, string A_3, out int A_4, out int A_5)
  {
    A_3 = A_3.ToUpper();
    A_4 = 9;
    A_5 = 1;
    // ISSUE: reference to a compiler-generated method
    df df = A_0.bf().hz(new de(A_1, A_2));
    if (df == null)
    {
      A_4 = A_5 = 0;
    }
    else
    {
      foreach (dh key in df.c.Keys)
      {
        if (key.b.ToUpper() == A_3)
        {
          A_4 = Math.Min(A_4, key.c);
          A_5 = Math.Max(A_5, key.c);
        }
      }
      if (A_4 <= A_5)
        return;
      A_4 = A_5 = 0;
    }
  }

  public static Dictionary<string, Dictionary<int, dg>> a(dk A_0, ka.ClusterNameInformation A_1, it.PvpRules A_2)
  {
    if (A_0 == null)
      return (Dictionary<string, Dictionary<int, dg>>) null;
    df df = A_0.hz(new de(A_1, A_2));
    if (df == null)
      return (Dictionary<string, Dictionary<int, dg>>) null;
    Dictionary<string, Dictionary<int, dg>> dictionary1 = new Dictionary<string, Dictionary<int, dg>>();
    foreach (KeyValuePair<dh, dg> keyValuePair in df.c)
    {
      Dictionary<int, dg> dictionary2;
      if (!dictionary1.TryGetValue(keyValuePair.Key.b, out dictionary2))
      {
        dictionary2 = new Dictionary<int, dg>();
        dictionary1.Add(keyValuePair.Key.b, dictionary2);
      }
      dg dg;
      if (!dictionary2.TryGetValue(keyValuePair.Key.c, out dg))
      {
        dg = new dg(0, 0);
        dictionary2.Add(keyValuePair.Key.c, dg);
      }
      dg = dictionary2[keyValuePair.Key.c];
      dg.a += keyValuePair.Value.a;
      dg.b += keyValuePair.Value.b;
      dictionary2[keyValuePair.Key.c] = dg;
    }
    return dictionary1;
  }

  public static Dictionary<string, HashSet<aaf>> a(dk A_0, dj A_1, ka.ClusterNameInformation A_2, it.PvpRules A_3, int A_4, Dictionary<aae, HashSet<aaf>> A_5)
  {
    Dictionary<string, HashSet<aaf>> A_3_1 = new Dictionary<string, HashSet<aaf>>();
    if (!aab.a(A_0, A_1, A_2, A_3, A_5))
      return (Dictionary<string, HashSet<aaf>>) null;
    k3 k3 = new k3(A_4);
    de A_0_1 = new de(A_2, A_3);
    df df = A_0.hz(A_0_1);
    if (df == null)
      return (Dictionary<string, HashSet<aaf>>) null;
    dd A_0_2 = new dd(A_2);
    dl dl = A_1.hz(A_0_2);
    if (dl == null)
      return (Dictionary<string, HashSet<aaf>>) null;
    Dictionary<aae, List<aaf>> dictionary = new Dictionary<aae, List<aaf>>((IEqualityComparer<aae>) new aac());
    foreach (KeyValuePair<dh, dg> keyValuePair in df.c)
    {
      k3 A_4_1 = new k3(A_4);
      int A_0_3 = keyValuePair.Value.a + k3.Next(keyValuePair.Value.b);
      aae key1 = new aae(keyValuePair.Key.a, keyValuePair.Key.b);
      List<aaf> A_2_1;
      if (!dictionary.TryGetValue(key1, out A_2_1))
      {
        A_2_1 = new List<aaf>((IEnumerable<aaf>) A_5[key1]);
        A_2_1.Sort(new Comparison<aaf>(aab.a));
        dictionary.Add(key1, A_2_1);
      }
      dm key2 = new dm(keyValuePair.Key.b, keyValuePair.Key.c);
      dn dn;
      if (dl.b.TryGetValue(key2, out dn) && dn.a.Count > 0)
        aab.a(A_0_3, dn.a, A_2_1, A_3_1, A_4_1);
    }
    foreach (KeyValuePair<dh, dg> keyValuePair in df.c)
    {
      k3 A_4_1 = new k3(A_4);
      aae key1 = new aae(keyValuePair.Key.a, keyValuePair.Key.b);
      List<aaf> A_2_1;
      if (!dictionary.TryGetValue(key1, out A_2_1))
      {
        HashSet<aaf> aafSet;
        if (!A_5.TryGetValue(key1, out aafSet))
          return (Dictionary<string, HashSet<aaf>>) null;
        A_2_1 = new List<aaf>((IEnumerable<aaf>) aafSet);
        A_2_1.Sort(new Comparison<aaf>(aab.a));
        dictionary.Add(key1, A_2_1);
      }
      dm key2 = new dm(keyValuePair.Key.b, keyValuePair.Key.c);
      dn dn;
      if (dl.b.TryGetValue(key2, out dn) && A_2_1.Count > 0 && dn.b.Count > 0)
        aab.a(A_2_1.Count, dn.b, A_2_1, A_3_1, A_4_1);
    }
    return A_3_1;
  }

  private static void a(int A_0, List<@do> A_1, List<aaf> A_2, Dictionary<string, HashSet<aaf>> A_3, k3 A_4)
  {
    int[] numArray = new int[A_1.Count];
    for (int index1 = 0; index1 < A_0; ++index1)
    {
      int index2 = 0;
      long num1 = 0;
      int index3 = 0;
      for (int count = A_1.Count; index3 < count; ++index3)
      {
        long num2 = index1 == 0 ? 0L : (long) numArray[index3] * @do.d() / (long) index1;
        // ISSUE: reference to a compiler-generated method
        long num3 = A_1[index3].e() - num2;
        if (num3 > num1)
        {
          index2 = index3;
          num1 = num3;
        }
      }
      int index4 = A_4.Next(A_2.Count);
      aaf aaf = A_2[index4];
      HashSet<aaf> aafSet;
      if (!A_3.TryGetValue(A_1[index2].b, out aafSet))
      {
        aafSet = new HashSet<aaf>((IEqualityComparer<aaf>) new aad());
        A_3.Add(A_1[index2].b, aafSet);
      }
      if (aafSet.Add(aaf))
        ++numArray[index2];
      else
        ab0.a("Duplicate Position found ?");
      A_2[index4] = A_2[A_2.Count - 1];
      A_2.RemoveAt(A_2.Count - 1);
    }
  }

  public static bool a(dk A_0, dj A_1, ka.ClusterNameInformation A_2, it.PvpRules A_3, Dictionary<aae, HashSet<aaf>> A_4, out List<string> A_5)
  {
    A_5 = new List<string>();
    if (A_4.Count == 0)
    {
      de A_0_1 = new de(A_2, A_3);
      if (A_0.hz(A_0_1) != null)
        A_5.Add("Cluster has no Resource-Nodes but is using Preset: " + A_0_1.ToString());
      return false;
    }
    bool flag = false;
    if (A_0 == null || A_1 == null)
    {
      A_5.Add("Necessary ResourceDistribution GameData isn't available");
      return false;
    }
    de A_0_2 = new de(A_2, A_3);
    df df = A_0.hz(A_0_2);
    if (df == null)
    {
      A_5.Add("Seems like there is no Distribution Data available for " + (object) A_2);
      return false;
    }
    dd A_0_3 = new dd(A_2);
    if (A_1.hz(A_0_3) == null)
    {
      A_5.Add("Seems like there is no PrefabMapping-Data available for " + (object) A_2);
      return false;
    }
    HashSet<acf> acfSet1 = new HashSet<acf>();
    HashSet<acf> acfSet2 = new HashSet<acf>();
    foreach (KeyValuePair<aae, HashSet<aaf>> keyValuePair in A_4)
    {
      foreach (aaf aaf in keyValuePair.Value)
      {
        if (!acfSet1.Add(aaf.a))
          acfSet2.Add(aaf.a);
      }
    }
    if (acfSet2.Count > 0)
    {
      string str = "Duplicate Positions found in Nodes:" + Environment.NewLine;
      foreach (acf acf in acfSet2)
        str = str + acf.ToString() + Environment.NewLine;
      A_5.Add(str);
      flag = true;
    }
    foreach (KeyValuePair<ResourceNodeTypes, Dictionary<string, int>> keyValuePair1 in df.b)
    {
      foreach (KeyValuePair<string, int> keyValuePair2 in keyValuePair1.Value)
      {
        aae key = new aae(keyValuePair1.Key, keyValuePair2.Key);
        HashSet<aaf> aafSet;
        if (A_4.TryGetValue(key, out aafSet))
        {
          if (aafSet.Count < keyValuePair2.Value)
          {
            A_5.Add(string.Format("In Preset {0}: There are only {1} nodes available for {2} {3} ({4} needed)", (object) A_2, (object) aafSet.Count.ToString(), (object) key.a.ToString(), (object) key.b, (object) keyValuePair2.Value));
            flag = true;
          }
        }
        else
        {
          A_5.Add(string.Format("In Preset {0}: There are no nodes available for {1} {2} ({3} needed)", (object) A_2, (object) key.a.ToString(), (object) key.b, (object) keyValuePair2.Value));
          flag = true;
        }
      }
    }
    return !flag;
  }

  public static bool a(dk A_0, dj A_1, ka.ClusterNameInformation A_2, it.PvpRules A_3, Dictionary<aae, HashSet<aaf>> A_4)
  {
    List<string> A_5;
    bool flag = aab.a(A_0, A_1, A_2, A_3, A_4, out A_5);
    int index = 0;
    for (int count = A_5.Count; index < count; ++index)
      aab.a(A_5[index]);
    return flag;
  }

  private static int a(aae A_0, aae A_1)
  {
    int num = A_1.b.CompareTo(A_0.b);
    if (num == 0)
      num = A_1.a.CompareTo((object) A_0.a);
    return num;
  }

  private static int a(aaf A_0, aaf A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    int num = A_1.a.k().CompareTo(A_0.a.k());
    if (num == 0)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      num = A_1.a.m().CompareTo(A_0.a.m());
    }
    return num;
  }

  private static void a(string A_0)
  {
  }
}
