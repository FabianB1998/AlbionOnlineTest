// Decompiled with JetBrains decompiler
// Type: Albion.Common.GameData.FightingObjectCastEventMsgTypes
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

namespace Albion.Common.GameData
{
  public enum FightingObjectCastEventMsgTypes
  {
    None,
    OnCastStart,
    OnCastFinished,
    OnCastCanceled,
    OnCastInterrupted,
    OnChannelingStart,
    OnChannelingInterrupted,
    OnChannelingEnd,
    OnChannelingHit,
    OnSpellHit,
    OnSpellAdded,
    OnSpellRemoved,
    WhileCasting,
    WhileChanneling,
    WhileCastingAndChanneling,
    SpellEffectAreaInit,
    NumOfEntries,
  }
}
