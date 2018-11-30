using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return MenuDAO.instance;
            }

            private set
            {
                instance = value;
            }
        }
        private MenuDAO() { }
        
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.nameFood, bi.Count, f.Price, (f.Price*bi.Count) AS totalPrice FROM dbo.Bill AS b, dbo.BillInfo AS bi, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.sttBill = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu; 

        }
    }
}
