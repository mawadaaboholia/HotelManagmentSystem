using Guna.UI2.WinForms.Suite;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentSystem.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {

        }
        bool isChecked = false;
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                // الحالة الأولى: عند تفعيل الزر (مثل صورة 2)
                btnAddRoom.ColorBackground = Color.FromArgb(0, 118, 221); // اللون الأزرق
                btnAddRoom.ForeColor = Color.White;                // نص أبيض
                isChecked = true; // تغيير الحالة لمضغوط
            }
            else
            {
                // الحالة الثانية: عند إلغاء التفعيل (العودة للوضع الطبيعي)
                btnAddRoom.ColorBackground = Color.Black; // أو أي لون تريده
                btnAddRoom.ForeColor = Color.White;
                isChecked = false; // العودة للحالة العادية
            } 
        }

    }
}
