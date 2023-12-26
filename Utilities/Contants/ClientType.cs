namespace Utilities.Contants
{
    public enum ClientType
        {
            ALL = -1,
            AGENT = 1, // đại lý Adavigo
            TIER_1_AGENT = 2, // đại lý của Adavigo b2b
            TIER_2_AGENT = 3,
            TIER_3_AGENT = 4,
            CUSTOMER = 5, // khách lẻ của adavigo

        }
    public enum ClientProfileType
    {
        BOOKER = 0, //Sale booking, chỉ có trong trường hợp book hộ
        CONTACT_CLIENT =1, // Thông tin thành viên chính , sử dụng để liên hệ
        GUEST_ADULT=2, // Thông tin thành viên trong đoàn là người lớn
        GUEST_CHILD=2, // Thông tin thành viên trong đoàn là người lớn
        GUEST_INFANT=2, // Thông tin thành viên trong đoàn là trẻ sơ sinh
    }
}
