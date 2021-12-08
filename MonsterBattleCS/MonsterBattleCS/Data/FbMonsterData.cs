// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Data
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct FbMonsterData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static FbMonsterData GetRootAsFbMonsterData(ByteBuffer _bb) { return GetRootAsFbMonsterData(_bb, new FbMonsterData()); }
  public static FbMonsterData GetRootAsFbMonsterData(ByteBuffer _bb, FbMonsterData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FbMonsterData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Label { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLabelBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetLabelBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetLabelArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public short Hp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public short Ap { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public short Dp { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public Data.Hand Hand { get { int o = __p.__offset(14); return o != 0 ? (Data.Hand)__p.bb.GetSbyte(o + __p.bb_pos) : Data.Hand.stone; } }

  public static Offset<Data.FbMonsterData> CreateFbMonsterData(FlatBufferBuilder builder,
      StringOffset labelOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      short hp = 0,
      short ap = 0,
      short dp = 0,
      Data.Hand hand = Data.Hand.stone) {
    builder.StartTable(6);
    FbMonsterData.AddName(builder, nameOffset);
    FbMonsterData.AddLabel(builder, labelOffset);
    FbMonsterData.AddDp(builder, dp);
    FbMonsterData.AddAp(builder, ap);
    FbMonsterData.AddHp(builder, hp);
    FbMonsterData.AddHand(builder, hand);
    return FbMonsterData.EndFbMonsterData(builder);
  }

  public static void StartFbMonsterData(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddLabel(FlatBufferBuilder builder, StringOffset labelOffset) { builder.AddOffset(0, labelOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddHp(FlatBufferBuilder builder, short hp) { builder.AddShort(2, hp, 0); }
  public static void AddAp(FlatBufferBuilder builder, short ap) { builder.AddShort(3, ap, 0); }
  public static void AddDp(FlatBufferBuilder builder, short dp) { builder.AddShort(4, dp, 0); }
  public static void AddHand(FlatBufferBuilder builder, Data.Hand hand) { builder.AddSbyte(5, (sbyte)hand, 0); }
  public static Offset<Data.FbMonsterData> EndFbMonsterData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Data.FbMonsterData>(o);
  }
};


}
