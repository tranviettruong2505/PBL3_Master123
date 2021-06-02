using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_BookShopManagement.DAL;
using PBL3_BookShopManagement.BLL;
using PBL3_BookShopManagement.DTO;

namespace PBL3_BookShopManagement.GUI.UserControls
{
    public partial class UC_ManageUser : UserControl
    {
        public UC_ManageUser()
        {
            InitializeComponent();

            SetCBB(cbbRole, false);
            SetCBB(cbbShow, true);

            Show(null, 0);

            //Hàm tạo watermark 
            txtSearchName.ForeColor = Color.LightGray;
            txtSearchName.Text = "Enter Name Staff";
            txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);

            cbbShow.SelectedIndex = 0;
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "")
            {
                txtSearchName.Text = "Enter Name Staff";
                txtSearchName.ForeColor = Color.Gray;
            }
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "Enter Name Staff")
            {
                txtSearchName.Text = "";
                txtSearchName.ForeColor = Color.Black;
            }
        }

        public void SetCBB(ComboBox cbb, bool All)
        {
            if(cbb != null)
            {
                cbb.Items.Clear();
            }
            if (All)
            {
                cbb.Items.Add(new CBBItem { Text = "All", Value = 0 });
            }
            cbb.Items.AddRange(BLL_Staff.Instance.getListCBBPosition().ToArray());
        }

        public void Show(string name, int idPos)
        {
            dataGridView1.DataSource = BLL_Staff.Instance.GetListStaffView_BLL(name, idPos);
            dataGridView1.Columns[0].HeaderText = "ID Staff";
            dataGridView1.Columns[1].HeaderText = "Name Staff";
            dataGridView1.Columns[2].HeaderText = "Gender";
            dataGridView1.Columns[3].HeaderText = "Date of Birth";
            dataGridView1.Columns[4].HeaderText = "Address";
            dataGridView1.Columns[5].HeaderText = "Phone number";
            dataGridView1.Columns[6].HeaderText = "Mail";
            dataGridView1.Columns[7].HeaderText = "ID User";
            dataGridView1.Columns[8].HeaderText = "User name";
            dataGridView1.Columns[9].HeaderText = "Password";
            dataGridView1.Columns[10].HeaderText = "Position";
        }

        private Staff GetStaff()
        {
            Staff staff = new Staff();
            if(txtIDStaff.Text != "")
            {
                staff.ID_Staff = Convert.ToInt32(txtIDStaff.Text.ToString());
            }
            staff.Name_Staff = txtName.Text;
            staff.DateOfBirth = Convert.ToDateTime(dateBirth.Value);
            staff.Address = txtAddress.Text;
            if (rbtnMale.Checked == true)
            {
                staff.Gender = true;
            }
            else
            {
                staff.Gender = false;
            }
            staff.Mail = txtMail.Text;
            staff.SDT = txtSDT.Text;
            return staff;
        }

        private Account GetAccount()
        {
            Account account = new Account();
            if (txtIDUser.Text != "")
            {
                account.ID_User = Convert.ToInt32(txtIDUser.Text.ToString());
            }
            
            account.UserName = txtUserName.Text;
            account.Password = txtPass.Text;
            if (cbbRole.SelectedIndex != -1)
            {
                account.ID_Position = ((CBBItem)(cbbRole.SelectedItem)).Value;
            }
            return account;
        }

        public void ResetGUI()
        {
            txtIDStaff.Text = "";
            txtName.Text = "";
            dateBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtMail.Text = "";
            txtSDT.Text = "";
            CBBItem item = new CBBItem();
            txtIDUser.Text = "";
            cbbRole.SelectedIndex = -1;
            txtUserName.Text = "";
            txtPass.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Show(null, ((CBBItem)(cbbShow.SelectedItem)).Value);
        }

        private void SetDetail(Staff staff, Account account)
        {
            txtIDStaff.Text = staff.ID_Staff.ToString();
            txtName.Text = staff.Name_Staff;
            dateBirth.Value = staff.DateOfBirth;
            txtAddress.Text = staff.Address;
            if(staff.Gender == true)
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            txtMail.Text = staff.Mail;
            txtSDT.Text = staff.SDT;
            CBBItem item = new CBBItem();
            foreach(CBBItem i in cbbRole.Items)
            {
                if (i.Value == account.ID_Position) item = i;
            }
            txtMail.Text = staff.Mail;
            txtSDT.Text = staff.SDT;
            txtIDUser.Text = staff.ID_User.ToString();
            cbbRole.SelectedIndex = cbbRole.Items.IndexOf(item);
            txtUserName.Text = account.UserName;
            txtPass.Text = account.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                int ID_User = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_User"].Value);
                int ID_Staff = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Staff"].Value);
                Account account = BLL_Staff.Instance.GetAccountbyID(ID_User);
                Staff staff = BLL_Staff.Instance.GetStaffbyID(ID_Staff);
                SetDetail(staff, account);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetGUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == null) || (txtAddress.Text == null) || ((rbtnMale.Checked == false) && (rbtnFemale.Checked == false)) ||
                (txtUserName.Text == null) || (txtPass.Text == null) || (txtMail.Text == null) || (txtSDT.Text == null) || 
                (cbbRole.SelectedIndex == -1))
            {
                MessageBox.Show("Enter complete information");
            }
            else
            {
                //int idStaff = 0;
                //if(txtIDStaff.Text != "")
                //{
                //    idStaff = Convert.ToInt32(txtIDStaff.Text.ToString());
                //}
                BLL_Staff.Instance.ExecuteStaff(GetStaff(), GetAccount());
                dataGridView1.DataSource = BLL_Staff.Instance.GetListStaffView_BLL(null, ((CBBItem)(cbbShow.SelectedItem)).Value);
                ResetGUI();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                List<string> listDel = new List<string>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    listDel.Add(i.Cells["ID_Staff"].Value.ToString());
                }
                BLL_Staff.Instance.DelStaff_BLL(listDel);
                dataGridView1.DataSource = BLL_Staff.Instance.GetListStaffView_BLL(null, ((CBBItem)(cbbShow.SelectedItem)).Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchName.Text == "Enter Name Staff")
            {
                Show(null, ((CBBItem)(cbbShow.SelectedItem)).Value);
            }
            else
            {
                Show(txtSearchName.Text, ((CBBItem)(cbbShow.SelectedItem)).Value);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex != -1)
            {
                List<StaffView> list = new List<StaffView>();
                if(txtSearchName.Text == "Enter Name Staff")
                {
                    list = BLL_Staff.Instance.GetListStaffView_BLL(null, ((CBBItem)(cbbShow.SelectedItem)).Value);
                }
                else
                {
                    list = BLL_Staff.Instance.GetListStaffView_BLL(txtSearchName.Text, ((CBBItem)(cbbShow.SelectedItem)).Value);
                }
                string sortBy = cbbSort.SelectedItem.ToString();
                switch (sortBy)
                {
                    case "ID Staff":
                        dataGridView1.DataSource = list.OrderBy(o => o.ID_Staff).ToList();
                        break;
                    case "Name Staff":
                        dataGridView1.DataSource = list.OrderBy(o => o.Name_Staff).ToList();
                        break;
                }
            }
            else
            {
                MessageBox.Show("select attribute to sort");
            }
        }
    }
}
//Staff staff = new Staff();
//staff.ID_Staff = 1;
//staff.Name_Staff = "NVB";
//staff.DateOfBirth = DateTime.Now;
//staff.Address = "Quang Tri";
//staff.Gender = true;
//staff.ID_User = 1;

//Account account = new Account();
//account.ID_User = 1;
//account.UserName = "seller";
//account.Password = "seller";
//account.ID_Position = 2;
