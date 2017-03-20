// Decompiled with JetBrains decompiler
// Type: ah1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

public class ah1
{
  public static bool a = false;
  public static long b = 600000000;
  public static long c = 864000000000;
  private static Random d = new Random((int) DateTime.UtcNow.Ticks);
  private static long e = 1000;
  private static readonly DateTime f = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

  static ah1()
  {
    ah1.a = System.Type.GetType("Mono.Runtime") != null;
  }

  public static bool i(string A_0)
  {
    if (A_0.Length < 150)
      return Regex.IsMatch(A_0, "^[_a-zA-Z0-9\\@][_a-zA-Z0-9\\-\\(\\)\\#\\@]+$");
    return false;
  }

  public static bool h(string A_0)
  {
    return Regex.IsMatch(A_0, "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,9}$", RegexOptions.IgnoreCase);
  }

  public static bool g(string A_0)
  {
    if (A_0.Length >= 3 && A_0.Length <= 16)
      return Regex.IsMatch(A_0, "^[a-zA-Z0-9][_a-zA-Z0-9\\-]+[a-zA-Z0-9]$");
    return false;
  }

  public static bool f(string A_0)
  {
    if (A_0.Length >= 3 && A_0.Length <= 30)
      return Regex.IsMatch(A_0, "^[a-zA-Z0-9](?!.*[ ]{2})[ _a-zA-Z0-9\\-]+[a-zA-Z0-9]$");
    return false;
  }

  public static bool e(string A_0)
  {
    if (A_0.Length >= 3 && A_0.Length <= 30)
      return Regex.IsMatch(A_0, "^[a-zA-Z0-9](?!.*[ ]{2})[ _a-zA-Z0-9\\-]+[a-zA-Z0-9]$");
    return false;
  }

  public static bool d(string A_0)
  {
    if (A_0.Length >= 2 && A_0.Length <= 5)
      return Regex.IsMatch(A_0, "^[a-zA-Z0-9]+$");
    return false;
  }

  [SpecialName]
  public static long c()
  {
    return Convert.ToInt64((DateTime.UtcNow - ah1.f).TotalMilliseconds * (double) ah1.e);
  }

  public static DateTime a(GameTimeStamp A_0, DateTime A_1, DateTime A_2, int A_3)
  {
    TimeSpan timeSpan = TimeSpan.FromMinutes((double) A_3);
    DateTime dateTime1 = A_0.i();
    DateTime dateTime2 = dateTime1 + timeSpan;
    DateTime dateTime3 = new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day, A_1.Hour, A_1.Minute, 0, 0, dateTime1.Kind);
    if (dateTime3 - dateTime1 < timeSpan)
      dateTime3 = dateTime3.AddDays(1.0);
    return dateTime3;
  }

  public static DateTime b(GameTimeStamp A_0, TimeSpan A_1)
  {
    A_1 += TimeSpan.FromHours(4.0);
    DateTime dateTime1 = A_0.i();
    DateTime dateTime2 = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, A_1.Hours, A_1.Minutes, 0, 0, dateTime1.Kind);
    if (dateTime2 < dateTime1)
      dateTime2 = dateTime2.AddDays(1.0);
    return dateTime2;
  }

  public static DateTime a(GameTimeStamp A_0, TimeSpan A_1)
  {
    DateTime dateTime = ah1.b(A_0, A_1) - TimeSpan.FromHours(4.0);
    if (dateTime < A_0.i())
      dateTime = dateTime.AddDays(1.0);
    return dateTime;
  }

  public static DateTime a(GameTimeStamp A_0, aie A_1, h5 A_2)
  {
    DateTime dateTime1 = A_0.i();
    // ISSUE: reference to a compiler-generated method
    DateTime dateTime2 = A_2.d();
    int num1 = 1;
    // ISSUE: reference to a compiler-generated method
    foreach (int key in A_2.f().Keys)
    {
      if (num1 < key)
        num1 = key;
    }
    // ISSUE: reference to a compiler-generated method
    int totalDays = (int) (dateTime1 - A_2.d()).TotalDays;
    int key1;
    int num2;
    // ISSUE: reference to a compiler-generated method
    if (A_2.d() + TimeSpan.FromDays(1.0) > dateTime1)
    {
      // ISSUE: reference to a compiler-generated method
      if (A_2.f().Count == 0)
      {
        // ISSUE: reference to a compiler-generated method
        return A_2.d();
      }
      // ISSUE: reference to a compiler-generated method
      key1 = A_2.f().Keys.First<int>();
      num2 = 1;
    }
    else
    {
      key1 = totalDays % num1 + 1;
      num2 = totalDays;
    }
    List<TimeSpan> timeSpanList;
    // ISSUE: reference to a compiler-generated method
    if (A_2.f().TryGetValue(key1, out timeSpanList))
    {
      foreach (TimeSpan timeSpan in timeSpanList)
      {
        // ISSUE: reference to a compiler-generated method
        if (A_2.e())
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          timeSpan -= TimeSpan.FromHours((double) A_1.ap().f());
        }
        DateTime dateTime3 = dateTime2 + timeSpan + TimeSpan.FromDays((double) (num2 - 1));
        if (dateTime1 < dateTime3)
          return dateTime3;
      }
    }
    for (int index = 0; index < 500; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      if (A_2.f().TryGetValue(key1, out timeSpanList))
      {
        foreach (TimeSpan timeSpan in timeSpanList)
        {
          // ISSUE: reference to a compiler-generated method
          if (A_2.e())
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            timeSpan -= TimeSpan.FromHours((double) A_1.ap().f());
          }
          DateTime dateTime3 = dateTime2 + timeSpan + TimeSpan.FromDays((double) num2);
          if (dateTime1 < dateTime3)
            return dateTime3;
        }
      }
      ++key1;
      if (key1 > num1)
        key1 = 1;
      ++num2;
    }
    return DateTime.MaxValue;
  }

  public static DateTime a(GameTimeStamp A_0, g8 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    DateTime e8 = A_1.ar().e8;
    long num = A_0.i().Ticks - e8.Ticks;
    // ISSUE: reference to a compiler-generated method
    TimeSpan e9 = A_1.ar().e9;
    TimeSpan timeSpan = TimeSpan.FromTicks(e9.Ticks * (num / e9.Ticks));
    // ISSUE: reference to a compiler-generated method
    return e8 + timeSpan + e9 - A_1.ar().fa;
  }

  public static List<System.Type> b<a>()
  {
    return ah1.a<a>(Assembly.GetAssembly(typeof (a)));
  }

  public static List<System.Type> a<a>(Assembly A_0)
  {
    return ((IEnumerable<System.Type>) A_0_1.GetTypes()).Where<System.Type>((Func<System.Type, bool>) (A_0_2 => A_0_2.IsSubclassOf(typeof (a)))).ToList<System.Type>();
  }

  public static void a(System.Type A_0, List<System.Type> A_1)
  {
    if (A_0.BaseType == null)
      return;
    A_1.Add(A_0);
    ah1.a(A_0.BaseType, A_1);
  }

  public static Dictionary<System.Type, List<ahz>> b(System.Type A_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    ah1.a a = new ah1.a();
    // ISSUE: reference to a compiler-generated field
    a.a = A_0_1;
    Dictionary<System.Type, List<ahz>> dictionary = new Dictionary<System.Type, List<ahz>>();
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    foreach (System.Type type1 in ((IEnumerable<System.Type>) Assembly.GetAssembly(a.a).GetTypes()).Where<System.Type>(new Func<System.Type, bool>(a.b)).ToList<System.Type>())
    {
      List<System.Type> A_1 = new List<System.Type>();
      ah1.a(type1, A_1);
      A_1.Reverse();
      List<ahz> ahzList = new List<ahz>();
      foreach (System.Type type2 in A_1)
      {
        List<FieldInfo> source = new List<FieldInfo>();
        foreach (FieldInfo field in type2.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public))
        {
          object[] customAttributes = field.GetCustomAttributes(true);
          if (customAttributes.Length <= 0 || !customAttributes[0].GetType().Equals(typeof (acg)))
            source.Add(field);
        }
        foreach (FieldInfo A_0 in source.OrderBy<FieldInfo, int>((Func<FieldInfo, int>) (A_0_2 => A_0_2.MetadataToken)).ToList<FieldInfo>())
        {
          ahz ahz = new ahz(A_0);
          ahzList.Add(ahz);
        }
      }
      dictionary.Add(type1, ahzList);
    }
    return dictionary;
  }

  public static ulong c(string A_0)
  {
    ulong num = 3074457345618258791;
    for (int index = 0; index < A_0.Length; ++index)
      num = (num + (ulong) A_0[index]) * 3074457345618258799UL;
    return num;
  }

  public static string b(DateTime A_0)
  {
    return A_0.ToString("HH:mm") + " (UTC)";
  }

  public static string a(DateTime A_0)
  {
    CultureInfo currentCulture = CultureInfo.CurrentCulture;
    return A_0.ToString("m", (IFormatProvider) currentCulture) + ", " + A_0.ToString("HH:mm") + " (UTC)";
  }

  public static byte[] b(string A_0)
  {
    byte[] bytes = Encoding.UTF8.GetBytes(A_0);
    MemoryStream memoryStream = new MemoryStream();
    using (GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Compress, true))
      gzipStream.Write(bytes, 0, bytes.Length);
    memoryStream.Position = 0L;
    byte[] buffer = new byte[memoryStream.Length];
    memoryStream.Read(buffer, 0, buffer.Length);
    byte[] numArray = new byte[buffer.Length + 4];
    Buffer.BlockCopy((Array) buffer, 0, (Array) numArray, 4, buffer.Length);
    Buffer.BlockCopy((Array) BitConverter.GetBytes(bytes.Length), 0, (Array) numArray, 0, 4);
    return numArray;
  }

  public static string a(byte[] A_0)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      int int32 = BitConverter.ToInt32(A_0, 0);
      memoryStream.Write(A_0, 4, A_0.Length - 4);
      byte[] numArray = new byte[int32];
      memoryStream.Position = 0L;
      using (GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Decompress))
        gzipStream.Read(numArray, 0, numArray.Length);
      return Encoding.UTF8.GetString(numArray);
    }
  }

  public static string a(int A_0)
  {
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < A_0; ++index)
    {
      char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * ah1.d.NextDouble() + 65.0)));
      stringBuilder.Append(ch);
    }
    return stringBuilder.ToString();
  }

  public static int a(string A_0, string A_1)
  {
    if (string.IsNullOrEmpty(A_0) || string.IsNullOrEmpty(A_1))
      return 0;
    int length = A_1.Length;
    int num1 = 0;
    int num2 = 0;
    while ((num1 = A_0.IndexOf(A_1, num1 + length)) > 0)
      ++num2;
    return num2;
  }

  public static byte[] a(BitArray A_0)
  {
    byte[] numArray = new byte[(A_0.Length - 1) / 8 + 1];
    A_0.CopyTo((Array) numArray, 0);
    return numArray;
  }

  public static System.Type a(string A_0)
  {
    return System.Type.GetType(A_0);
  }

  public static bool a()
  {
    return true;
  }

  public static Queue<a> a<a>(Queue<a> A_0, a A_1)
  {
    if (A_0.Count == 0)
      return A_0;
    if (A_0.Peek().Equals((object) A_1))
    {
      A_0.Dequeue();
      return A_0;
    }
    if (!A_0.Contains(A_1))
      return A_0;
    a[] array = A_0.ToArray();
    int num = Array.IndexOf<a>(array, A_1);
    Queue<a> aQueue = new Queue<a>();
    for (int index = 0; index < num; ++index)
      aQueue.Enqueue(array[index]);
    for (int index = num + 1; index < array.Length; ++index)
      aQueue.Enqueue(array[index]);
    return aQueue;
  }
}
