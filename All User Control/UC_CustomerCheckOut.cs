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
    public partial class UC_CustomerCheckOut : UserControl
    {
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        bool isChecked = false;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                // الحالة الأولى: عند تفعيل الزر (مثل صورة 2)
                btnCheckOut.ColorBackground = Color.FromArgb(0, 118, 221); // اللون الأزرق
                btnCheckOut.ForeColor = Color.White;                // نص أبيض
                isChecked = true; // تغيير الحالة لمضغوط
            }
            else
            {
                // الحالة الثانية: عند إلغاء التفعيل (العودة للوضع الطبيعي)
                btnCheckOut.ColorBackground = Color.Black; // أو أي لون تريده
                btnCheckOut.ForeColor = Color.White;
                isChecked = false; // العودة للحالة العادية
            }
        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
