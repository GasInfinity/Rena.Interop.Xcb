namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_group_info_iterator_t
{
    public xcb_input_group_info_t* data;

    public int rem;

    public int index;
}