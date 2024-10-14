namespace DOAN_DTO
{
    public class NHANVIENDTO
    {
        public int MANV { get; set; }         // Mã nhân viên
        public string TENNV { get; set; }     // Tên nhân viên
        public string QUYEN { get; set; }     // Quyền (Admin, Nhân viên)
        public string USERNAME { get; set; }  // Tài khoản đăng nhập
        public string PASSWORD { get; set; }  // Mật khẩu
    }
}