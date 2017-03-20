// Decompiled with JetBrains decompiler
// Type: acj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Photon;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class acj
{
  public const byte a = 252;
  public const byte b = 253;
  public const byte c = 254;
  public const byte d = 255;

  public static Dictionary<byte, object> b(i0 A_0)
  {
    return acj.a((object) A_0);
  }

  public static Dictionary<byte, object> b(jf A_0)
  {
    return acj.a((object) A_0);
  }

  public static Dictionary<byte, object> b(jk A_0)
  {
    return acj.a((object) A_0);
  }

  private static Dictionary<byte, object> a(object A_0)
  {
    Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
    List<ahz> ahzList;
    iz.a.TryGetValue(A_0.GetType(), out ahzList);
    byte num = 0;
    foreach (ahz ahz in ahzList)
      dictionary.Add(num++, ahz.a(A_0));
    return dictionary;
  }

  public static byte[] a(object A_0, PropertyInfo A_1)
  {
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    MemoryStream memoryStream = new MemoryStream();
    try
    {
      binaryFormatter.Serialize((Stream) memoryStream, A_1.GetValue(A_0, (object[]) null));
    }
    catch (SerializationException ex)
    {
      Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
      throw;
    }
    finally
    {
      memoryStream.Close();
    }
    return memoryStream.ToArray();
  }

  public static object a(MemoryStream A_0)
  {
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    try
    {
      return binaryFormatter.Deserialize((Stream) A_0);
    }
    catch (SerializationException ex)
    {
      Console.WriteLine("Failed to Deserialize. Reason: " + ex.Message);
      throw;
    }
    finally
    {
      A_0.Close();
    }
  }

  protected static string a(string A_0, object A_1)
  {
    if (A_1 == null)
      return "null";
    if (A_1.GetType().IsArray)
    {
      if (A_1.GetType().GetElementType() == typeof (float))
      {
        string str = "(";
        bool flag = true;
        foreach (float num in A_1 as float[])
        {
          if (!flag)
            str += ", ";
          else
            flag = false;
          str += num.ToString("0.000", (IFormatProvider) CultureInfo.InvariantCulture);
        }
        return str + ")";
      }
      if (A_1.GetType().GetElementType() == typeof (int))
      {
        string str = "(";
        bool flag = true;
        foreach (int num in A_1 as int[])
        {
          if (!flag)
            str += ", ";
          else
            flag = false;
          str += num.ToString();
        }
        return str + ")";
      }
      if (A_1.GetType().GetElementType() == typeof (short))
      {
        string str = "(";
        bool flag = true;
        foreach (short num in A_1 as short[])
        {
          if (!flag)
            str += ", ";
          else
            flag = false;
          str += num.ToString();
        }
        return str + ")";
      }
      if (A_1.GetType().GetElementType() == typeof (byte))
      {
        string str = "(";
        bool flag = true;
        foreach (byte num in A_1 as byte[])
        {
          if (!flag)
            str += ", ";
          else
            flag = false;
          str += num.ToString();
        }
        return str + ")";
      }
      if (A_1.GetType().GetElementType() == typeof (long))
      {
        string str = "(";
        bool flag = true;
        foreach (long num in A_1 as long[])
        {
          if (!flag)
            str += ", ";
          else
            flag = false;
          str += num.ToString();
        }
        return str + ")";
      }
      string str1 = "(";
      bool flag1 = true;
      object[] objArray = A_1 as object[];
      if (objArray == null)
        return "unsupported POD array type: " + A_1.GetType().GetElementType().ToString();
      foreach (object obj in objArray)
      {
        if (!flag1)
          str1 += ", ";
        else
          flag1 = false;
        str1 = A_1.GetType().GetElementType() != typeof (float) ? str1 + obj.ToString() : str1 + ((float) obj).ToString("0.000", (IFormatProvider) CultureInfo.InvariantCulture);
      }
      return str1 + ")";
    }
    if (A_1.GetType() == typeof (long) && A_0.ToLower().Contains("time"))
      return new ahy((long) A_1).y();
    return A_1.ToString();
  }

  public static string a(jf A_0)
  {
    if (A_0 == null)
      return "null";
    // ISSUE: reference to a compiler-generated method
    string str = "Operation: " + (object) (OperationCodes) ((ach[]) A_0.GetType().GetCustomAttributes(typeof (ach), false))[0].b();
    List<ahz> ahzList;
    iz.a.TryGetValue(A_0.GetType(), out ahzList);
    foreach (ahz ahz in ahzList)
      str = str + " " + ahz.d() + ": " + acj.a(ahz.d(), ahz.a((object) A_0));
    return str;
  }

  public static string a(jk A_0)
  {
    if (A_0 == null)
      return "null";
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string str = "Response: " + (object) (OperationCodes) ((ach[]) A_0.GetType().GetCustomAttributes(typeof (ach), false))[0].b() + " ReturnCode: " + ack.a(A_0.a5w());
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(A_0.a5x()))
    {
      // ISSUE: reference to a compiler-generated method
      str = str + " DebugMessage: " + A_0.a5x();
    }
    List<ahz> ahzList;
    iz.a.TryGetValue(A_0.GetType(), out ahzList);
    foreach (ahz ahz in ahzList)
      str = str + " " + ahz.d() + ": " + acj.a(ahz.d(), ahz.a((object) A_0));
    return str;
  }

  public static string a(i0 A_0)
  {
    if (A_0 == null)
      return "null";
    // ISSUE: reference to a compiler-generated method
    string str = "Event: " + (object) (ahj) ((aci[]) A_0.GetType().GetCustomAttributes(typeof (aci), false))[0].b();
    List<ahz> ahzList;
    iz.a.TryGetValue(A_0.GetType(), out ahzList);
    foreach (ahz ahz in ahzList)
      str = str + " " + ahz.d() + ": " + acj.a(ahz.d(), ahz.a((object) A_0));
    return str;
  }
}
