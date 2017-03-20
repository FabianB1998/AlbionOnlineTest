// Decompiled with JetBrains decompiler
// Type: kr
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;

public static class kr
{
  public static string a = "EN-US";
  public static string b = kr.a;
  public static string c = kr.b;
  public static Dictionary<string, string> d = new Dictionary<string, string>();
  public static bool e = false;
  public static List<string> f = new List<string>();
  public static List<string> g = new List<string>() { "EN-US", "DE-DE", "FR-FR", "RU-RU", "PL-PL", "ES-ES", "PT-BR" };

  public static List<string> a(string A_0, string A_1, bool A_2)
  {
    Stopwatch stopwatch = Stopwatch.StartNew();
    kr.c = kr.g[0];
    if (kr.g.Contains(A_1_1))
      kr.c = A_1_1;
    bool flag = kr.c != kr.a && global::a.k;
    kr.d.Clear();
    kr.f.Clear();
    List<string> stringList = new List<string>();
    using (XmlReader xmlReader1 = XmlReader.Create((TextReader) new StringReader(A_0_1)))
    {
      while (xmlReader1.ReadToFollowing("tu"))
      {
        xmlReader1.MoveToAttribute("tuid");
        string key = xmlReader1.Value.Trim();
        xmlReader1.MoveToElement();
        string str1 = "";
        XmlReader xmlReader2 = xmlReader1.ReadSubtree();
        while (xmlReader2.ReadToFollowing("tuv"))
        {
          xmlReader1.MoveToAttribute("xml:lang");
          string str2 = xmlReader1.Value;
          if (flag && str2 == kr.a)
          {
            if (xmlReader1.ReadToFollowing("seg"))
              str1 = xmlReader1.ReadString().Trim();
          }
          else if (str2 == kr.c)
          {
            if (xmlReader1.ReadToFollowing("seg"))
            {
              string str3 = xmlReader1.ReadString().Trim();
              if (key.Length != 0)
              {
                try
                {
                  if (str3.Length > 0)
                  {
                    kr.d.Add(key, str3);
                    break;
                  }
                  if (flag)
                  {
                    kr.d.Add(key, str1);
                    break;
                  }
                  kr.d.Add(key, string.Empty);
                  break;
                }
                catch (ArgumentException ex)
                {
                  ab0.a("Localization Tag '" + key + "' has duplicate entries!");
                  if (A_2)
                  {
                    stringList.Add(key);
                    break;
                  }
                  break;
                }
              }
            }
            else
              break;
          }
        }
        if (flag && !kr.d.ContainsKey(key) && !string.IsNullOrEmpty(str1))
          kr.d.Add(key, str1);
      }
      kr.e = true;
    }
    if (A_2)
    {
      kr.f = new List<string>((IEnumerable<string>) kr.d.Keys);
      kr.f.Sort((Comparison<string>) ((A_0_2, A_1_2) => A_0_2.CompareTo(A_1_2)));
    }
    stopwatch.Stop();
    return stringList;
  }

  public static bool c(string A_0)
  {
    string str;
    return !string.IsNullOrEmpty(A_0) && kr.d.TryGetValue(A_0, out str);
  }

  public static string b(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return string.Empty;
    string str;
    if (!kr.d.TryGetValue(A_0, out str))
      return A_0;
    if (str.Length != 0)
      return str;
    ab0.a("Localization Tag '" + A_0 + "' is empty!");
    return "LOCA: NT!";
  }

  public static string a(string A_0, params object[] A_1)
  {
    if (string.IsNullOrEmpty(A_0))
      return string.Empty;
    string format;
    if (!kr.d.TryGetValue(A_0, out format))
      return A_0;
    if (format.Length == 0)
    {
      ab0.a("Localization Tag '" + A_0 + "' is empty!");
      return "LOCA: NT!";
    }
    try
    {
      format = string.Format(format, A_1);
      return format;
    }
    catch (Exception ex)
    {
    }
    ab0.a("Localization Tag '" + A_0 + "' has invalid parameters: " + format);
    return "LOCA: PE!";
  }

  public static string a(Enum A_0)
  {
    return kr.b("@" + A_0.GetType().Name.ToUpper() + "_" + A_0.ToString().ToUpper());
  }

  public static string a(string A_0)
  {
    if (!string.IsNullOrEmpty(A_0) && A_0.StartsWith("@"))
      return kr.b(A_0);
    return A_0;
  }
}
