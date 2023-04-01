namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_set_gc_clip_region_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_gcontext_t")]
    public uint gc;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint region;

    [NativeTypeName("int16_t")]
    public short x_origin;

    [NativeTypeName("int16_t")]
    public short y_origin;
}
