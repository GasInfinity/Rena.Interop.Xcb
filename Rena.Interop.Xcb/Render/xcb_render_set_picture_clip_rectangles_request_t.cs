namespace Rena.Interop.Xcb;

public partial struct xcb_render_set_picture_clip_rectangles_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_render_picture_t")]
    public uint picture;

    [NativeTypeName("int16_t")]
    public short clip_x_origin;

    [NativeTypeName("int16_t")]
    public short clip_y_origin;
}
