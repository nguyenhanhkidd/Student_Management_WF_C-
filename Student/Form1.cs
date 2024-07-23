using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //khởi tạo lsv khi form_load thành công
        private void Form1_Load(object sender, EventArgs e)
        {
            //đổi chế độ view để hiện thị dữ liệu trên lsv
            lsvStudent.View = View.Details;
            lsvStudent.GridLines = true;
            lsvStudent.FullRowSelect = true;

            //tạo ra các cột cho listView
            lsvStudent.Columns.Add("ID", 50);
            lsvStudent.Columns.Add("Name", 150);
            lsvStudent.Columns.Add("Phone", 100);
            lsvStudent.Columns.Add("Gender", 80);
            lsvStudent.Columns.Add("Course", 80);
            lsvStudent.Columns.Add("Description", 200);

            //Tạo ra một đối tượng có kiểu ListViewItem
            ListViewItem std_1 = new ListViewItem();
            std_1.Text = "BH01345";
            std_1.SubItems.Add("Nguyen An");
            std_1.SubItems.Add("012399999");
            std_1.SubItems.Add("Male");
            std_1.SubItems.Add("SE07202");
            std_1.SubItems.Add("BTEC HN");

            //Đẩy đối tượng ListViewItem vừa tạo được vào trong ListView
            lsvStudent.Items.Add(std_1);
        }
        //Đẩy dữ liệu từ form vào lsv
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //khởi tạo các biến để lấy giá trị trong form
            string ID = tbID.Text;
            string Name = tbName.Text;
            string Phone = tbPhone.Text;
            string Gender = null;

            //Lấy thông tin trong radioBtn
            if (rbM.Checked)
            {
                Gender = "Male";

            }
            else if (rbF.Checked)
            {
                Gender = "Female";
            }

            //Lấy thông tin trong cbb
            string Course = null;
            if (cbCourse.SelectedIndex == 0)
            {
                Course = "SE07201";
            }
            else if (cbCourse.SelectedIndex == 1)
            {
                Course = "SE07202";
            }
            else if (cbCourse.SelectedIndex == 2)
            {
                Course = "SE07203";
            }
            string Description = tbDescription.Text;

            //Đẩy dữ liệu đã lấy được trên form vào đối tượng ListViewItem
            //Khai báo đối tượng mới
            ListViewItem item = new ListViewItem();

            //gán giá trị đã lấy được trong form vào đối tượng item
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone);
            item.SubItems.Add(Gender);
            item.SubItems.Add(Course);
            item.SubItems.Add(Description);

            //đẩy item vào lsvStudent
            lsvStudent.Items.Add(item);

            ClearForm();
        }
        private void lsvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvStudent.SelectedItems.Count > 0)
            {
                //MessageBox.Show(lsvStudent.SelectedItems.Count.ToString());

                ListViewItem seleted_Item = lsvStudent.SelectedItems[0];

                string ID = seleted_Item.SubItems[0].Text;
                //kiểm tra lại
                string Name = seleted_Item.SubItems[1].Text;
                string Phone = seleted_Item.SubItems[2].Text;
                string Gender = seleted_Item.SubItems[3].Text;
                string Course = seleted_Item.SubItems[4].Text;
                string Description = seleted_Item.SubItems[5].Text;

                //Đẩy dữ liệu từ lsvStudent lên form
                tbID.Text = ID;
                tbName.Text = Name;
                tbPhone.Text = Phone;

                if (Gender == "Male")
                {
                    rbM.Checked = true;
                }
                else if (Gender == "Female")
                {
                    rbF.Checked = true;
                }

                if (Course == "SE07201")
                {
                    cbCourse.SelectedIndex = 0;
                }
                else if (Course == "SE07202")
                {
                    cbCourse.SelectedIndex = 1;
                }
                else if (Course == "SE07203")
                {
                    cbCourse.SelectedIndex = 2;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvStudent.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvStudent.SelectedItems[0];
                item.SubItems.Clear();

                //khởi tạo các biến để lấy giá trị trong form sau khi đẩy dữ liệu từ bảng lên form
                string ID = tbID.Text;
                string Name = tbName.Text;
                string Phone = tbPhone.Text;

                string gender = null;
                if (rbM.Checked)
                {
                    gender = "Male";
                }
                else if (rbF.Checked)
                {
                    gender = "Female";
                }

                string Course = null;
                if (cbCourse.SelectedIndex == 0)
                {
                    Course = "SE07201";
                }
                else if (cbCourse.SelectedIndex == 1)
                {
                    Course = "SE07202";
                }
                else if (cbCourse.SelectedIndex == 2)
                {
                    Course = "SE07203";
                }

                string Description = tbDescription.Text;


                //nhận các giá trị mới thay đổi trên form

                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(gender);
                item.SubItems.Add(Course);
                item.SubItems.Add(Description);

                //xóa dữ liệu cũ trên form
                tbID.Text = null;
                tbName.Text = null;
                tbPhone.Text = null;
                rbF.Checked = false;
                rbM.Checked = false;
                cbCourse.SelectedIndex = -1;
                tbDescription.Text = null;
            }        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvStudent.SelectedItems.Count > 0)
            {
                lsvStudent.Items.Remove(lsvStudent.SelectedItems[0]);
            }
        }
        private void ClearForm()
        {
            tbID.Text = null;
            tbName.Text = null;
            tbPhone.Text = null;
            rbF.Checked = false;
            rbM.Checked = false;
            cbCourse.SelectedIndex = -1;
            tbDescription.Text = null;
        }
    }
    }

