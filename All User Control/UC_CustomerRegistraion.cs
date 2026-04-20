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
    public partial class UC_CustomerRegistraion : UserControl
    {
        public UC_CustomerRegistraion()
        {
            InitializeComponent();
        }

        private void UC_CustomerRegistraion_Load(object sender, EventArgs e)
        {

        }
        bool isChecked = false;
        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                // الحالة الأولى: عند تفعيل الزر (مثل صورة 2)
                btnAlloteRoom.ColorBackground = Color.FromArgb(0, 118, 221); // اللون الأزرق
                btnAlloteRoom.ForeColor = Color.White;                // نص أبيض
                isChecked = true; // تغيير الحالة لمضغوط
            }
            else
            {
                // الحالة الثانية: عند إلغاء التفعيل (العودة للوضع الطبيعي)
                btnAlloteRoom.ColorBackground = Color.Black; // أو أي لون تريده
                btnAlloteRoom.ForeColor = Color.White;
                isChecked = false; // العودة للحالة العادية
            }
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
