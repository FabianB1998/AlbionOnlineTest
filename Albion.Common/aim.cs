// Decompiled with JetBrains decompiler
// Type: aim
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Xml;

public class aim
{
  public static bool i(XmlElement A_0, string A_1)
  {
    return A_0.HasAttribute(A_1);
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, string A_3)
  {
    A_1.Attributes.Append(A_0.CreateAttribute(A_2)).InnerText = A_3;
  }

  public static string h(XmlElement A_0, string A_1)
  {
    return aim.a(A_0, A_1, string.Empty);
  }

  public static string a(XmlElement A_0, string A_1, string A_2)
  {
    if (A_0.HasAttribute(A_1))
      return A_0.Attributes[A_1].InnerText;
    return A_2;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, int A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static int b(XmlElement A_0, string A_1, int A_2)
  {
    if (A_0.HasAttribute(A_1))
      return aim.a(A_0.Attributes[A_1].InnerText, A_2);
    return A_2;
  }

  public static void a<a>(XmlDocument A_0, XmlElement A_1, string A_2, a A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.ToString());
  }

  public static a a<a>(XmlElement A_0, string A_1, a A_2)
  {
    try
    {
      System.Type enumType = typeof (a);
      if (ah1.a)
        enumType.GetCustomAttributes(typeof (ObfuscationAttribute), false);
      return (a) Enum.Parse(enumType, aim.a(A_0, A_1, A_2.ToString()), true);
    }
    catch (Exception ex)
    {
      return A_2;
    }
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, long A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static long a(XmlElement A_0, string A_1, long A_2)
  {
    try
    {
      if (A_0.HasAttribute(A_1))
        return long.Parse(A_0.Attributes[A_1].InnerText, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      return A_2;
    }
    catch (Exception ex)
    {
      throw new Exception("Error in '" + A_0.OwnerDocument.DocumentElement.Name + "' attribute could not be parsed as long : '" + A_0.Name + "' | '" + A_1 + "'|", ex);
    }
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, float A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static float a(XmlElement A_0, string A_1, float A_2)
  {
    if (A_0.HasAttribute(A_1))
      return aim.a(A_0.Attributes[A_1].InnerText, A_2);
    return A_2;
  }

  public static ahy a(XmlElement A_0, string A_1, ahy A_2)
  {
    float result;
    if (A_0.HasAttribute(A_1) && float.TryParse(A_0.Attributes[A_1].InnerText, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
      return ahy.l((double) result);
    return A_2;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, bool A_3)
  {
    aim.a(A_0, A_1, A_2, A_3 ? "true" : "false");
  }

  public static bool a(XmlElement A_0, string A_1, bool A_2)
  {
    if (A_0.HasAttribute(A_1))
      return aim.a(A_0.Attributes[A_1].InnerText);
    return A_2;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, float A_3, float A_4)
  {
    aim.a(A_0, A_1, A_2, string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1}", new object[2]
    {
      (object) A_3,
      (object) A_4
    }));
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, ahk A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aim.a(A_0, A_1, A_2, string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1}", new object[2]
    {
      (object) A_3.g(),
      (object) A_3.h()
    }));
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, params ahk[] A_3)
  {
    if (A_3.Length == 0)
      return;
    string[] strArray = new string[A_3.Length];
    for (int index = 0; index < A_3.Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      strArray[index] = string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1}", new object[2]
      {
        (object) A_3[index].g(),
        (object) A_3[index].h()
      });
    }
    aim.a(A_0, A_1, A_2, string.Join(";", strArray));
  }

  public static ahk a(XmlElement A_0, string A_1, ahk A_2)
  {
    if (A_0.HasAttribute(A_1))
      return aim.a(A_0.Attributes[A_1].InnerText, A_2);
    return A_2;
  }

  public static ahk[] g(XmlElement A_0, string A_1)
  {
    if (!A_0.HasAttribute(A_1))
      return new ahk[0];
    string[] strArray = A_0.Attributes[A_1].InnerText.Split(new char[1]
    {
      ';'
    }, StringSplitOptions.RemoveEmptyEntries);
    ahk[] ahkArray = new ahk[strArray.Length];
    for (int index = 0; index < ahkArray.Length; ++index)
      ahkArray[index] = aim.a(strArray[index].Trim(), ahk.d());
    return ahkArray;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, float A_3, float A_4, float A_5)
  {
    aim.a(A_0, A_1, A_2, string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1} {2}", (object) A_3, (object) A_4, (object) A_5));
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, acf A_3)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aim.a(A_0, A_1, A_2, string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1} {2}", (object) A_3.k(), (object) A_3.l(), (object) A_3.m()));
  }

  public static acf a(XmlElement A_0, string A_1, acf A_2)
  {
    if (A_0.HasAttribute(A_1))
      return aim.a(A_0.Attributes[A_1].InnerText, A_2);
    return A_2;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, int A_3, int A_4)
  {
    aim.a(A_0, A_1, A_2, string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1}", new object[2]
    {
      (object) A_3,
      (object) A_4
    }));
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, int[] A_3)
  {
    if (A_3.Length == 0)
      return;
    string[] strArray = new string[A_3.Length / 2];
    int index1 = 0;
    int index2 = 0;
    while (index1 < strArray.Length)
    {
      strArray[index1] = string.Format((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, "{0} {1}", new object[2]
      {
        (object) A_3[index2],
        (object) A_3[index2 + 1]
      });
      ++index1;
      index2 += 2;
    }
    aim.a(A_0, A_1, A_2, string.Join(";", strArray));
  }

  public static void a(XmlElement A_0, string A_1, ref int A_2, ref int A_3)
  {
    if (!A_0.HasAttribute(A_1))
      return;
    aim.a(A_0.Attributes[A_1].InnerText, ref A_2, ref A_3);
  }

  public static int[] f(XmlElement A_0, string A_1)
  {
    if (!A_0.HasAttribute(A_1))
      return new int[0];
    string[] strArray = A_0.Attributes[A_1].InnerText.Split(new char[1]
    {
      ';'
    }, StringSplitOptions.RemoveEmptyEntries);
    int[] numArray = new int[strArray.Length * 2];
    int index1 = 0;
    int index2 = 0;
    while (index1 < strArray.Length)
    {
      aim.a(strArray[index1].Trim(), ref numArray[index2], ref numArray[index2 + 1]);
      ++index1;
      index2 += 2;
    }
    return numArray;
  }

  public static int a(XmlElement A_0, string A_1, int A_2)
  {
    if (!A_0.HasAttribute(A_1))
      return A_2;
    string[] strArray = A_0.Attributes[A_1].InnerText.Split(new string[1]
    {
      ", "
    }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 4)
      return A_2;
    return (int) byte.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat) | (int) byte.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat) << 8 | (int) byte.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat) << 16 | (int) byte.Parse(strArray[3], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat) << 24;
  }

  public static void c(XmlDocument A_0, XmlElement A_1, string A_2, kx A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.m().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static kx c(XmlElement A_0, string A_1, kx A_2)
  {
    if (A_0.HasAttribute(A_1))
      return kx.f(double.Parse(A_0.Attributes[A_1].InnerText, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
    return A_2;
  }

  public static void b(XmlDocument A_0, XmlElement A_1, string A_2, kx A_3)
  {
    aim.a(A_0, A_1, A_2, A_3.j().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static kx b(XmlElement A_0, string A_1, kx A_2)
  {
    if (A_0.HasAttribute(A_1))
      return kx.g(long.Parse(A_0.Attributes[A_1].InnerText, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
    return A_2;
  }

  public static void a(XmlDocument A_0, XmlElement A_1, string A_2, kx A_3)
  {
    // ISSUE: reference to a compiler-generated method
    aim.a(A_0, A_1, A_2, A_3.i().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static kx a(XmlElement A_0, string A_1, kx A_2)
  {
    if (A_0.HasAttribute(A_1))
      return kx.f(long.Parse(A_0.Attributes[A_1].InnerText, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
    return A_2;
  }

  public static DateTime a(XmlElement A_0, string A_1, DateTime A_2)
  {
    if (A_0.HasAttribute(A_1))
      return DateTime.Parse(A_0.Attributes[A_1].InnerText, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, DateTimeStyles.AssumeUniversal).ToUniversalTime();
    return A_2;
  }

  public static TimeSpan a(XmlElement A_0, string A_1, TimeSpan A_2)
  {
    if (A_0.HasAttribute(A_1))
      return TimeSpan.Parse(A_0.Attributes[A_1].InnerText);
    return A_2;
  }

  public static a a<a>(string A_0, bool A_1)
  {
    A_0 = A_0.Trim();
    if (string.IsNullOrEmpty(A_0))
      throw new ArgumentNullException("String is null or empty.");
    System.Type enumType = typeof (a);
    if (!enumType.IsEnum)
      throw new ArgumentException("Type provided must be an enum.", "T");
    if (ah1.a)
      enumType.GetCustomAttributes(typeof (ObfuscationAttribute), false);
    return (a) Enum.Parse(enumType, A_0, A_1);
  }

  public static a a<a>(string A_0, a A_1, bool A_2)
  {
    try
    {
      return aim.a<a>(A_0, A_2);
    }
    catch (Exception ex)
    {
      ab0.a(ex);
      return A_1;
    }
  }

  public static void a(XmlElement A_0, string A_1, int A_2, out int A_3, out int A_4)
  {
    string s = aim.a(A_0, A_1, (string) null);
    if (string.IsNullOrEmpty(s))
      A_3 = A_4 = A_2;
    else if (s.Contains("-"))
    {
      string[] strArray = s.Split(new char[1]{ '-' }, StringSplitOptions.RemoveEmptyEntries);
      A_3 = int.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
      A_4 = int.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    }
    else
      A_3 = A_4 = int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
  }

  public static XmlElement e(XmlElement A_0, string A_1)
  {
    XmlNodeList elementsByTagName = A_0.GetElementsByTagName(A_1);
    if (elementsByTagName != null && elementsByTagName.Count > 0)
      return elementsByTagName[0] as XmlElement;
    return (XmlElement) null;
  }

  public static void a(XmlElement A_0, string A_1, ref int[] A_2)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        int num1 = aim.b(A_0_1, "tier", -1);
        if (num1 > 0 && num1 <= 8)
        {
          int num2 = aim.b(A_0_1, A_1, int.MinValue);
          A_2[num1 - 1] = num2;
        }
      }
    }
    int num = 0;
    while (num < 8)
      ++num;
  }

  public static void a(XmlElement A_0, string A_1, ref float[] A_2)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        int num1 = aim.b(A_0_1, "tier", -1);
        if (num1 > 0 && num1 <= 8)
        {
          float num2 = aim.a(A_0_1, A_1, float.MinValue);
          A_2[num1 - 1] = num2;
        }
      }
    }
    int num = 0;
    while (num < 8)
      ++num;
  }

  public static void c(XmlElement A_0, string A_1, ref kx[] A_2)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        int num = aim.b(A_0_1, "tier", -1);
        if (num > 0 && num <= 8)
        {
          kx kx = aim.c(A_0_1, A_1, kx.j);
          A_2[num - 1] = kx;
        }
      }
    }
    int num1 = 0;
    while (num1 < 8)
      ++num1;
  }

  public static void b(XmlElement A_0, string A_1, ref kx[] A_2)
  {
    aim.a(A_0, A_1, ref A_2, kx.j);
  }

  public static void a(XmlElement A_0, string A_1, ref kx[] A_2, kx A_3)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        int num = aim.b(A_0_1, "tier", -1);
        if (num > 0 && num <= 8)
        {
          kx kx = aim.c(A_0_1, A_1, A_3);
          A_2[num - 1] = kx;
        }
      }
    }
    int num1 = 0;
    while (num1 < 8)
      ++num1;
  }

  public static void a(XmlElement A_0, string A_1, ref kx[] A_2)
  {
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement A_0_1 = obj as XmlElement;
      if (A_0_1 != null)
      {
        int index = aim.b(A_0_1, "tier", -1);
        if (index >= 0 && index <= 8)
        {
          kx kx = aim.b(A_0_1, A_1, kx.j);
          A_2[index] = kx;
        }
      }
    }
    int num = 0;
    while (num < 8)
      ++num;
  }

  public static string[] a(System.Type A_0)
  {
    List<string> stringList = new List<string>();
    foreach (ail customAttribute in A_0.GetCustomAttributes(typeof (ail), true))
    {
      if (customAttribute != null && !string.IsNullOrEmpty(customAttribute.a))
        stringList.Add(customAttribute.a);
    }
    return stringList.ToArray();
  }

  public static List<XmlElement> d(XmlElement A_0, string A_1)
  {
    List<XmlElement> xmlElementList = (List<XmlElement>) null;
    foreach (object obj in (XmlNode) A_0)
    {
      XmlElement xmlElement = obj as XmlElement;
      if (xmlElement != null && xmlElement.Name == A_1)
      {
        if (xmlElementList == null)
          xmlElementList = new List<XmlElement>();
        xmlElementList.Add(xmlElement);
      }
    }
    return xmlElementList;
  }

  public static XmlElement c(XmlElement A_0, string A_1)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, A_1);
    if (xmlElementList != null && xmlElementList.Count > 0)
      return xmlElementList[0];
    return (XmlElement) null;
  }

  public static void b(XmlElement A_0, string A_1)
  {
    XmlElement xmlElement = aim.c(A_0, A_1);
    if (xmlElement == null)
      return;
    A_0.RemoveChild((XmlNode) xmlElement);
  }

  public static void a(XmlElement A_0, string A_1)
  {
    List<XmlElement> xmlElementList = aim.d(A_0, A_1);
    if (xmlElementList == null)
      return;
    for (int index = 0; index < xmlElementList.Count; ++index)
      A_0.RemoveChild((XmlNode) xmlElementList[index]);
  }

  public static bool a(string A_0)
  {
    if (!(A_0 == "true") && !(A_0 == "True") && (!(A_0 == "TRUE") && !(A_0 == "yes")))
      return A_0 == "1";
    return true;
  }

  public static int a(string A_0, int A_1)
  {
    int result;
    if (int.TryParse(A_0, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
      return result;
    return A_1;
  }

  public static float a(string A_0, float A_1)
  {
    float result;
    if (float.TryParse(A_0, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
      return result;
    return A_1;
  }

  public static ahk a(string A_0, ahk A_1)
  {
    string[] strArray = A_0.Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 2)
      return A_1;
    return new ahk(float.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static acf a(string A_0, acf A_1)
  {
    string[] strArray = A_0.Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 3)
      return A_1;
    return new acf(float.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  public static void a(string A_0, ref int A_1, ref int A_2)
  {
    string[] strArray = A_0.Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    A_1 = int.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    A_2 = int.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
  }
}
