// Decompiled with JetBrains decompiler
// Type: ab0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

public class ab0
{
  public static bool a = false;
  public static bool b = true;

  static ab0()
  {
    ab0.a();
  }

  private static void a(string A_0, object A_1, ab0.Level A_2)
  {
  }

  public static void a()
  {
    // ISSUE: reference to a compiler-generated method
    ab0.a(new ab0.a(ab0.a));
  }

  [Conditional("UNITY_EDITOR")]
  [Conditional("DEBUG")]
  public static void a(bool A_0)
  {
    if (A_0)
      return;
    StackTrace stackTrace = new StackTrace(true);
    // ISSUE: reference to a compiler-generated method
    ab0.b()("ASSERTion failed! Stacktrace: " + stackTrace.ToString(), (object) null, ab0.Level.Error);
    try
    {
      throw new AlbionException("ASSERTion failed! Stacktrace: " + stackTrace.ToString());
    }
    catch (AlbionException ex)
    {
    }
  }

  [Conditional("UNITY_EDITOR")]
  [Conditional("DEBUG")]
  public static void c(bool A_0, string A_1)
  {
    if (A_0)
      return;
    StackTrace stackTrace = new StackTrace(true);
    // ISSUE: reference to a compiler-generated method
    ab0.b()("ASSERTion failed! Message: " + A_1 + " Stacktrace: " + stackTrace.ToString(), (object) null, ab0.Level.Error);
    try
    {
      throw new AlbionException("ASSERTion failed! Message: " + A_1 + " Stacktrace: " + stackTrace.ToString());
    }
    catch (AlbionException ex)
    {
    }
  }

  [Conditional("DEBUG")]
  [Conditional("UNITY_EDITOR")]
  public static void a(bool A_0, params string[] A_1)
  {
    string str = string.Concat(A_1);
    if (A_0)
      return;
    StackTrace stackTrace = new StackTrace(true);
    // ISSUE: reference to a compiler-generated method
    ab0.b()("ASSERTion failed! Message: " + str + " Stacktrace: " + stackTrace.ToString(), (object) null, ab0.Level.Error);
    try
    {
      throw new AlbionException("ASSERTion failed! Message: " + str + " Stacktrace: " + stackTrace.ToString());
    }
    catch (AlbionException ex)
    {
    }
  }

  [Conditional("DEBUG")]
  [Conditional("UNITY_EDITOR")]
  public static void b(bool A_0, string A_1)
  {
    int num = A_0 ? 1 : 0;
  }

  [Conditional("UNITY_EDITOR")]
  [Conditional("ALBIONSERVER")]
  public static void e(string A_0)
  {
    if (ab0.a)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, (object) null, ab0.Level.Info);
  }

  [Conditional("UNITY_EDITOR")]
  [Conditional("ALBIONSERVER")]
  public static void b(object A_0)
  {
    if (ab0.a)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0.ToString(), (object) null, ab0.Level.Info);
  }

  [Conditional("ALBIONSERVER")]
  [Conditional("UNITY_EDITOR")]
  public static void d(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, (object) null, ab0.Level.Info);
  }

  [Conditional("UNITY_EDITOR")]
  [Conditional("ALBIONSERVER")]
  public static void c(string A_0, object A_1)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, A_1, ab0.Level.Info);
  }

  [Conditional("ALBIONSERVER")]
  [Conditional("UNITY_EDITOR")]
  public static void c(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, (object) null, ab0.Level.Warning);
  }

  [Conditional("ALBIONSERVER")]
  [Conditional("UNITY_EDITOR")]
  public static void b(string A_0, object A_1)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, A_1, ab0.Level.Warning);
  }

  [Conditional("ALBIONSERVER")]
  [Conditional("UNITY_EDITOR")]
  public static void b(string A_0, params object[] A_1)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(string.Format(A_0, A_1), (object) null, ab0.Level.Warning);
  }

  [Conditional("ALBIONSERVER")]
  [Conditional("UNITY_EDITOR")]
  public static void b(object A_0, string A_1, params object[] A_2)
  {
    // ISSUE: reference to a compiler-generated method
    ab0.b()(string.Format(A_1, A_2), A_0, ab0.Level.Warning);
  }

  public static void b(string A_0)
  {
    if (!ab0.b)
      return;
    StackTrace stackTrace = new StackTrace(true);
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0 + " Stacktrace: " + stackTrace.ToString(), (object) null, ab0.Level.Error);
  }

  public static void a(string A_0)
  {
    if (!ab0.b)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, (object) null, ab0.Level.Error);
  }

  public static void a(string A_0, object A_1)
  {
    if (!ab0.b)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0, A_1, ab0.Level.Error);
  }

  public static void a(string A_0, params object[] A_1)
  {
    if (!ab0.b)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(string.Format(A_0, A_1), (object) null, ab0.Level.Error);
  }

  public static void a(object A_0, string A_1, params object[] A_2)
  {
    if (!ab0.b)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(string.Format(A_1, A_2), A_0, ab0.Level.Error);
  }

  public static void a(bool A_0, string A_1)
  {
    if (!ab0.b || A_0)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_1, (object) null, ab0.Level.Error);
  }

  public static void a(Exception A_0)
  {
    if (!ab0.b)
      return;
    // ISSUE: reference to a compiler-generated method
    ab0.b()(A_0.ToString(), (object) null, ab0.Level.Error);
  }

  public static Dictionary<string, object> a(object A_0)
  {
    List<Dictionary<string, object>> dictionaryList = new List<Dictionary<string, object>>(A_0.GetType().GetProperties().Length);
    foreach (PropertyInfo property in A_0.GetType().GetProperties())
    {
      object obj = property.GetValue(A_0, (object[]) null);
      dictionaryList.Add(new Dictionary<string, object>()
      {
        {
          "PropertyName",
          (object) property.Name
        },
        {
          "PropertyValue",
          obj != null ? (object) obj.ToString() : (object) "null"
        }
      });
    }
    return new Dictionary<string, object>() { { "Object2Dictionary", (object) dictionaryList } };
  }

  public delegate void a(string A_0, object A_1, ab0.Level A_2);

  public enum Level
  {
    Info,
    Warning,
    Error,
  }
}
