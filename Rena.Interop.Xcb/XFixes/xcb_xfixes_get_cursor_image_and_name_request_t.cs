namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_get_cursor_image_and_name_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;
}
