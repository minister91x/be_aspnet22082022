using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IEmployee
    {
        string GenerateID();
        void NhapNhanVien();
        Employee FindByID(string ID);
        void UpdateNhanVien(string ID);
        List<Employee> FindByName(string keyword);
        bool DeleteById(string ID);
        int SoLuongNhanVien();
    }
}
