namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_mode_info_iterator_t
{
    public xcb_randr_mode_info_t* data;

    public int rem;

    public int index;
}
