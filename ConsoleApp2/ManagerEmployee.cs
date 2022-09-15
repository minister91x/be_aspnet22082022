using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ManagerEmployee: IEmployee
    {
        private List<Employee> ListEmployee = null;

        public ManagerEmployee()
        {
            ListEmployee = new List<Employee>();
        }

        /**
         * Hàm tạo ID tăng dần cho nhân viên
         */
        public string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }
        public int SoLuongNhanVien()
        {
            int Count = 0;
            if (ListEmployee != null)
            {
                Count = ListEmployee.Count;
            }
            return Count;
        }
        public void NhapNhanVien()
        {
            // Khởi tạo một nhân viên mới
            Employee sv = new Employee();
            sv.ID = GenerateID();
            Console.Write("Nhap ten nhan vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());
            ListEmployee.Add(sv);
        }

        public Employee FindByID(string ID)
        {
            Employee searchResult = null;
            if (ListEmployee != null && ListEmployee.Count > 0)
            {
                foreach (Employee sv in ListEmployee)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }


            return searchResult;
            
           // return ListEmployee.FindAll(s => s.ID == ID).FirstOrDefault();
        }

        public void UpdateNhanVien(string ID)
        {
            // Tìm kiếm nhân viên trong danh sách ListEmployeee
            Employee sv = FindByID(ID);
            // Nếu nhân viên tồn tại thì cập nhập thông tin nhân viên
            if (sv != null)
            {
                Console.Write("Nhap ten Nhan vien muon cap nhat: ");
                string name = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật tên
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

            }
            else
            {
                Console.WriteLine("Nhan vien co ID = {0} khong ton tai.", ID);

            }
        }

        public List<Employee> FindByName(string keyword)
        {
            List<Employee> searchResult = new List<Employee>();
            if (ListEmployee != null && ListEmployee.Count > 0)
            {
                foreach (Employee sv in ListEmployee)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }

        /**
         * Hàm xóa theo ID
         */
        public bool DeleteById(string ID)
        {
            bool IsDeleted = false;
            // tìm kiếm nhân viên theo ID
            Employee sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListEmployee.Remove(sv);
            }
            return IsDeleted;
        }

        public int DeleteNhanVien(string ids)
        {
            throw new NotImplementedException();
        }

        public int SoLuongNhanVien111()
        {
            throw new NotImplementedException();
        }

        private int CheckIsNumber()
        {
            return 1;
        }
    }
}
