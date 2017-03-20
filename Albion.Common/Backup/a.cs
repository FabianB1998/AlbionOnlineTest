// Decompiled with JetBrains decompiler
// Type: a
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

public class a
{
  public static string a = "";
  public static bool b = false;
  public static bool c = false;
  public static string d = "";
  public static bool e = false;
  public static bool f = false;
  public static bool g = false;
  public static bool h = false;
  public static bool i = true;
  public static bool j = false;
  public static bool k = true;
  public static bool l = true;
  public static int m = -1;
  public static bool n = false;
  public static bool o = true;
  public static bool p = false;
  public static bool q = false;
  public static bool r = false;
  public static string Macro0;
  public static string Macro1;
  public static string Macro2;
  public static string Macro3;
  public static string Macro4;
  public static string Macro5;
  public static string Macro6;
  public static string Macro7;
  public static string Macro8;
  public static string Macro9;

  public static void a()
  {
    try
    {
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      if (folderPath.Length <= 0)
        return;
      string str1 = Path.Combine(folderPath, "Albion");
      if (!Directory.Exists(str1))
        Directory.CreateDirectory(str1);
      string path = Path.Combine(str1, "settings.xml");
      if (!File.Exists(path))
        return;
      StreamReader streamReader;
      try
      {
        streamReader = new StreamReader(path);
      }
      catch (Exception ex)
      {
        ab0.a("Error loading settings!");
        return;
      }
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(streamReader.ReadToEnd());
      if (xmlDocument.DocumentElement.Name != "settings")
        throw new AlbionException("invalid file format for settings");
      XmlNodeList elementsByTagName = xmlDocument.DocumentElement.GetElementsByTagName("setting");
      System.Type type = typeof (global::a);
      FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);
      foreach (XmlElement A_0 in elementsByTagName)
      {
        string str2 = aim.h(A_0, "name");
        string s = aim.h(A_0, "value");
        foreach (FieldInfo fieldInfo in fields)
        {
          try
          {
            if (fieldInfo.Name == str2)
            {
              if (fieldInfo.FieldType == typeof (string))
                fieldInfo.SetValue((object) type, (object) s);
              else if (fieldInfo.FieldType == typeof (bool))
              {
                bool flag = bool.Parse(s);
                fieldInfo.SetValue((object) type, (object) flag);
              }
              else if (fieldInfo.FieldType == typeof (int))
              {
                int num = int.Parse(s);
                fieldInfo.SetValue((object) type, (object) num);
              }
            }
          }
          catch (Exception ex)
          {
            ab0.a("error parsing settings value");
          }
        }
      }
    }
    catch (Exception ex)
    {
      ab0.a(ex.ToString() + " " + ex.Message + " " + ex.StackTrace.ToString());
    }
  }
}
