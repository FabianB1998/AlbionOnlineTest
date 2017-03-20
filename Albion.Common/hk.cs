// Decompiled with JetBrains decompiler
// Type: hk
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class hk
{
  private static readonly hk a = new hk() { g = ConstraintSpace.Local, f = ConstraintType.Parent, h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>() { { ConstrainableAttributes.Translation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Rotation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Scaling, ConstraintTransformationUpdates.None } } };
  private static readonly hk b = new hk() { g = ConstraintSpace.World, f = ConstraintType.AttributeMask, h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>() { { ConstrainableAttributes.Translation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Rotation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Scaling, ConstraintTransformationUpdates.None } } };
  private static readonly hk c = new hk() { g = ConstraintSpace.World, f = ConstraintType.AttributeMask, h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>() { { ConstrainableAttributes.Translation, ConstraintTransformationUpdates.Initial }, { ConstrainableAttributes.Rotation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Scaling, ConstraintTransformationUpdates.None } } };
  private static readonly hk d = new hk() { g = ConstraintSpace.World, f = ConstraintType.AttributeMask, h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>() { { ConstrainableAttributes.Translation, ConstraintTransformationUpdates.Initial }, { ConstrainableAttributes.Rotation, ConstraintTransformationUpdates.Initial }, { ConstrainableAttributes.Scaling, ConstraintTransformationUpdates.None } } };
  private static readonly hk e = new hk() { g = ConstraintSpace.Local, f = ConstraintType.AttributeMask, h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>() { { ConstrainableAttributes.Translation, ConstraintTransformationUpdates.Continuous }, { ConstrainableAttributes.Rotation, ConstraintTransformationUpdates.None }, { ConstrainableAttributes.Scaling, ConstraintTransformationUpdates.None } } };
  public ConstraintType f;
  public ConstraintSpace g;
  public Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates> h;

  [SpecialName]
  public static hk e()
  {
    return hk.b;
  }

  [SpecialName]
  public static hk d()
  {
    return hk.a;
  }

  [SpecialName]
  public static hk c()
  {
    return hk.c;
  }

  [SpecialName]
  public static hk b()
  {
    return hk.d;
  }

  [SpecialName]
  public static hk a()
  {
    return hk.e;
  }

  public static hk a(XmlElement A_0, hk A_1)
  {
    hk hk = new hk();
    string str = aim.a(A_0, "constraintpreset", "");
    if (string.IsNullOrEmpty(str))
      return A_1;
    switch (str)
    {
      case "default":
        return hk.d();
      case "inworld":
        return hk.c();
      case "inWorldWithRotate":
        return hk.b();
      case "pointconstraint":
        return hk.a();
      default:
        switch (aim.a(A_0, "constrainttype", "parent"))
        {
          case "parent":
            hk.f = ConstraintType.Parent;
            break;
          case "attributemask":
            hk.f = ConstraintType.AttributeMask;
            break;
          default:
            hk.f = ConstraintType.Parent;
            break;
        }
        switch (aim.a(A_0, "constraintspace", "local"))
        {
          case "world":
            hk.g = ConstraintSpace.World;
            break;
          case "local":
            hk.g = ConstraintSpace.Local;
            break;
          default:
            hk.g = ConstraintSpace.Local;
            break;
        }
        hk.h = new Dictionary<ConstrainableAttributes, ConstraintTransformationUpdates>();
        foreach (ConstrainableAttributes key in Enum.GetValues(typeof (ConstrainableAttributes)))
        {
          string A_1_1;
          switch (key)
          {
            case ConstrainableAttributes.Translation:
              A_1_1 = "constraintupdatetranslate";
              break;
            case ConstrainableAttributes.Rotation:
              A_1_1 = "constraintupdaterotate";
              break;
            case ConstrainableAttributes.Scaling:
              A_1_1 = "constraintupdatescale";
              break;
            default:
              A_1_1 = "";
              break;
          }
          if (!string.IsNullOrEmpty(A_1_1))
          {
            switch (aim.a(A_0, A_1_1, "none"))
            {
              case "none":
                hk.h.Add(key, ConstraintTransformationUpdates.None);
                continue;
              case "initial":
                hk.h.Add(key, ConstraintTransformationUpdates.Initial);
                continue;
              case "continuous":
                hk.h.Add(key, ConstraintTransformationUpdates.Continuous);
                continue;
              default:
                hk.h.Add(key, ConstraintTransformationUpdates.None);
                continue;
            }
          }
        }
        return hk;
    }
  }

  public override string ToString()
  {
    string str = "" + "ConstraintSettings: " + Environment.NewLine + "      Type:" + this.f.ToString() + Environment.NewLine + "     Space:" + this.g.ToString() + Environment.NewLine + " UpdateMask:" + Environment.NewLine;
    foreach (ConstrainableAttributes key in this.h.Keys)
      str = str + "      " + key.ToString() + "  :" + this.h[key].ToString() + Environment.NewLine;
    return str;
  }
}
