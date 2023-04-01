namespace Rena.Interop.Xcb;

public partial struct xcb_xfixes_subtract_region_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint source1;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint source2;

    [NativeTypeName("xcb_xfixes_region_t")]
    public uint destination;
}
