// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace rlbot.flat
{

using global::System;
using global::FlatBuffers;

public struct Vector3Partial : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Vector3Partial GetRootAsVector3Partial(ByteBuffer _bb) { return GetRootAsVector3Partial(_bb, new Vector3Partial()); }
  public static Vector3Partial GetRootAsVector3Partial(ByteBuffer _bb, Vector3Partial obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vector3Partial __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Float? X { get { int o = __p.__offset(4); return o != 0 ? (Float?)(new Float()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Float? Y { get { int o = __p.__offset(6); return o != 0 ? (Float?)(new Float()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Float? Z { get { int o = __p.__offset(8); return o != 0 ? (Float?)(new Float()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartVector3Partial(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddX(FlatBufferBuilder builder, Offset<Float> xOffset) { builder.AddStruct(0, xOffset.Value, 0); }
  public static void AddY(FlatBufferBuilder builder, Offset<Float> yOffset) { builder.AddStruct(1, yOffset.Value, 0); }
  public static void AddZ(FlatBufferBuilder builder, Offset<Float> zOffset) { builder.AddStruct(2, zOffset.Value, 0); }
  public static Offset<Vector3Partial> EndVector3Partial(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Vector3Partial>(o);
  }
};


}
