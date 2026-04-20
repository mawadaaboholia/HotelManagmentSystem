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
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
        }
        bool isChecked = false;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                // الحالة الأولى: عند تفعيل الزر (مثل صورة 2)
                btnRegister.ColorBackground = Color.FromArgb(0, 118, 221); // اللون الأزرق
                btnRegister.ForeColor = Color.White;                // نص أبيض
                isChecked = true; // تغيير الحالة لمضغوط
            }
            else
            {
                // الحالة الثانية: عند إلغاء التفعيل (العودة للوضع الطبيعي)
                btnRegister.ColorBackground = Color.Black; // أو أي لون تريده
                btnRegister.ForeColor = Color.White;
                isChecked = false; // العودة للحالة العادية
            }
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                // الحالة الأولى: عند تفعيل الزر (مثل صورة 2)
                btnRegister.ColorBackground = Color.FromArgb(0, 118, 221); // اللون الأزرق
                btnRegister.ForeColor = Color.White;                // نص أبيض
                isChecked = true; // تغيير الحالة لمضغوط
            }
            else
            {
                // الحالة الثانية: عند إلغاء التفعيل (العودة للوضع الطبيعي)
                btnRegister.ColorBackground = Color.Black; // أو أي لون تريده
                btnRegister.ForeColor = Color.White;
                isChecked = false; // العودة للحالة العادية
            }
        }
    }
}
