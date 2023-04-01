namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_delete_device_property_request_t
{
    [NativeTypeName("uint8_t")]
    public byte major_opcode;

    [NativeTypeName("uint8_t")]
    public byte minor_opcode;

    [NativeTypeName("uint16_t")]
    public ushort length;

    [NativeTypeName("xcb_atom_t")]
    public uint property;

    [NativeTypeName("uint8_t")]
    public byte device_id;

    [NativeTypeName("uint8_t[3]")]
    public fixed byte pad0[3];
}
